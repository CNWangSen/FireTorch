using System.Collections.Generic;

public class Ability
{
    public Card owner;
    public List<int> amounts = new List<int>{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14};
    //public List<Card> RememberedCards = new List<Card>();
    //public TargetingOptions m_opt = TargetingOptions.NoTarget;
//---------------Aura----------------------
    public List<Ability> AuraAffecting = new List<Ability>();
    public virtual bool AuraActive()
    {
        return false;
    }
    public virtual bool AuraBuffThis(Card c)
    {
        return false;
    }
    public virtual string AuraBuffName(Card c)
    {
        return this.GetType().Name+"Buff";
    }

    public Ability(){}
    public void AttachTo(Card owner)
    {
        this.owner = owner;
        owner.abilityList.Add(this);
        this.Init();
        this.RegisterEventEffect();
    }

    public virtual void Init(){
        //this.owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
    }
//---------------Trigger----------------------
    public virtual void RegisterEventEffect(){}
    public virtual void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
    }




    public virtual void Battlecry(Card target = null){}
    public virtual void Deathrattle(){}

    public bool IsPerment = true;
    public int DurationTurn = 1;
    //public Dictionary<GameTag, int> Property = new Dictionary<GameTag, int>();

    public virtual bool IsDying()
    {
        if(owner.GetTag(GameTag.Health) <= 0 || owner.GetTag(GameTag.IsDying)==1)
        {
            return true;
        }
        return false;
    }
//--------------------------------------------------------------------------------------------Aura

//--------------------------------------------------------------------------------------------Conditions
    public List<Card> FindAllChar()
    {
        return owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Merge(owner.myPlayer.hero).Merge(owner.myPlayer.otherPlayer.hero);
    }
    public List<Card> FindAllMin()
    {
        return owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board);
    }
    public List<Card> FindAdj(Card who=null)
    {
        if(who==null)
        {
            who=owner;
        }
        List<Card> res = new List<Card>();
        if(who.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
        {
            int pos = who.myPlayer.board.IndexOf(who);
            
            foreach(Card c in who.myPlayer.board)
            {
                int diff =who.myPlayer.board.IndexOf(c) - pos;
                if(diff ==1 || diff==-1)
                {
                    res.Add(c);
                }
            }            
        }
        else if(who.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave && who.GetTag(GameTag.CardType) == (int) CardType.Minion){
            int pos = who.GetTag(GameTag.ZoneIndex);
            foreach(Card c in who.myPlayer.board)
            {
                int diff =who.myPlayer.board.IndexOf(c) - pos;
                if(diff ==0 || diff==-1)
                {
                    res.Add(c);
                }
            }
        }
        else{

        }
        return res;
    }
    public List<Card> FindRace(List<Card> rawlist,RaceType rc)
    {
        List<Card> resList = new List<Card>();
        foreach(Card c in rawlist)
        {
            if(c.raceType.Contains(rc) || c.raceType.Contains(RaceType.All))
            {
                resList.Add(c);
            }
        }
        return resList;
    }
    
    public List<Card> FindType(List<Card> rawlist,CardType ty)
    {
        List<Card> resList = new List<Card>();
        foreach(Card c in rawlist)
        {
            if(c.cardType==ty)
            {
                resList.Add(c);
            }
        }
        return resList;
    }
    public bool CondHoldAnotherRace(RaceType race)
    {
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.raceType.Contains(race) && c!=owner)
            {
                return true;
            }
        }
        return false;
    }
    public bool CondCtrlAnotherRace(RaceType race)
    {
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.raceType.Contains(race) && c!=owner)
            {
                return true;
            }
        }
        return false;
    }
    public bool CondMyTurn()
    {
        return owner.myPlayer.myGame.PlayersInGame[owner.myPlayer.myGame.GetTag(GameTag.NowPlayingIndex)]==owner.myPlayer;
    }
    public bool CondHasHero()
    {
        return owner.myPlayer.hero.Count>0;
    }
    public bool CondInPlay()
    {
        ZoneType z = (ZoneType)owner.GetTag(GameTag.ZoneType);
        bool inP=false;
        switch(owner.cardType)
        {
            case(CardType.Minion):
                if(z==ZoneType.Board)
                    inP=true;
                break;
            case(CardType.Weapon):
                if(z==ZoneType.Weapon)
                    inP=true;
                break;
            case(CardType.Hero):
                if(z==ZoneType.Hero)
                    inP=true;
                break;
            //case(CardType)
            default:
                break;
        }
        return inP;
    }
    public bool CondDeckUni()
    {
        return true;
    }
    public int CntCombo()
    {
        return 1;
    }
//--------------------------------------------------------------------------------------------Task
    public void TaskSetGolden()
    {
        owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
    }
    public void TaskInitAbility(string abiname)
    {
        new EffectGiveAbility(owner.myPlayer,owner,owner,abiname,createVfx:false).Resolve();
    }
    public void TaskRandomDiscard()
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c!=owner)
            {
                Pool.Add(c);
            }
        }
        Card ToDiscard = Pool.Choice(owner.myPlayer.randomGen);
        if(ToDiscard!=null)
        {
            new EffectMove(owner.myPlayer,ToDiscard,ZoneType.Hand,ZoneType.Grave).Resolve();
        }
    }
    public void TaskSetHpTargets(List<Card> Targets,int amount,int hpDef=-1)
    {
        List<int> dmgs=new List<int>();
        foreach(Card c in Targets)
        {
            dmgs.Add(-c.GetTag(GameTag.Health)+amount);
        }
        new EffectChange(owner.myPlayer,owner,targets:Targets,hpChanges:dmgs,hpDef:hpDef).Resolve();
    }
    public void TaskSetAtkTargets(List<Card> Targets,int amount)
    {
        List<int> dmgs=new List<int>();
        foreach(Card c in Targets)
        {
            dmgs.Add(-c.GetTag(GameTag.Attack)+amount);
        }
        new EffectChange(owner.myPlayer,owner,targets:Targets,atkChanges:dmgs).Resolve();
    }
    public void TaskBuffTargets(List<Card> Targets, int atk=0,int hp=0,int mana=0)
    {
        List<int> atks = new List<int>();
        List<int> hps = new List<int>();
        List<int> manas= new List<int>();
        foreach(Card c in Targets)
        {
            atks.Add(atk);
            hps.Add(hp);
            manas.Add(mana);
        }
        new EffectChange(owner.myPlayer,owner,targets:Targets,atkChanges:atks,hpChanges:hps,manaChanges:manas).Resolve();
    }
    public void TaskDamageTargets(List<Card> Targets,int amount)
    {
        List<int> dmgs=new List<int>();
        foreach(Card c in Targets)
        {
            dmgs.Add(amount);
        }
        new EffectDamage(owner.myPlayer,owner,targets:Targets,amounts:dmgs).Resolve();
    }
    public void TaskDestroyTargets(List<Card> Targets)
    {
        new EffectDestroy(owner.myPlayer,owner,targets:Targets).Resolve();
    }
    public void TaskBuffRandomTarget(List<Card> Targets,int atk=0,int hp=0, int arm=0)
    {
        Card ToBuff=Targets.Choice(owner.myPlayer.randomGen);
        if(ToBuff!=null)
        {
            new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:atk,hpChange:hp,armChange:arm).Resolve();
        }
    }
    public void TaskDamageRandomEnemy(int amount=0,List<Card> Pool = null)
    {
        if(Pool==null)
        {
            Pool = new List<Card>();
            foreach(Card c in owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero))
            {
                if(c.GetTag(GameTag.Health)>0)
                {
                    Pool.Add(c);
                }
            }
        }
        Card Target = Pool.Choice(owner.myPlayer.randomGen);
        if(Target!=null)
        {
            new EffectDamage(owner.myPlayer,owner,Target,amount).Resolve();
        }
    }
    public void TaskDamageRandomDistributeTargets(List<Card> Targets,int amount,int single=1)
    {
        if(owner.cardType==CardType.Spell)
        {
            amount+=owner.GetTag(GameTag.SpellDamage);
        }
        while(true)
        {
            List<Card> Alive = new List<Card>();
            foreach(Card c in Targets)
            {
                if(c.GetTag(GameTag.Health)>0)
                {
                    Alive.Add(c);
                }
            }
            Card ToDamage = Alive.Choice(owner.myPlayer.randomGen);
            if(ToDamage!=null && amount>0)
            {
                new EffectDamage(owner.myPlayer,owner,ToDamage,single,dmgbuffen:false).Resolve();
                amount-=1;
            }
            else{
                break;
            }
        }
    }
    public void TaskDestroyRandomEnemyMinion(int amount=0)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.board)
        {
            if(c.GetTag(GameTag.Health)>0)
            {
                Pool.Add(c);
            }
        }
        Card Target = Pool.Choice(owner.myPlayer.randomGen);
        if(Target!=null)
        {
            new EffectDestroy(owner.myPlayer,owner,Target).Resolve();
        }
    }
    public void TaskDamageRandomEnemyMinion(int amount=0)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.board)
        {
            if(c.GetTag(GameTag.Health)>0)
            {
                Pool.Add(c);
            }
        }
        Card Target = Pool.Choice(owner.myPlayer.randomGen);
        if(Target!=null)
        {
            new EffectDamage(owner.myPlayer,owner,Target,amount).Resolve();
        }
    }
    public void TaskHealMyHero(int amount=0,bool tofull=false)
    {
        if(owner.myPlayer.hero.Count>0)
        {
            if(tofull)
            {
                amount = owner.myPlayer.hero[0].GetTag(GameTag.Damage);
            }
            else{

            }
            new EffectHeal(owner.myPlayer,owner,owner.myPlayer.hero[0],amount).Resolve();
        }
    }
    public void TaskHealEnemyHero(int amount=0,bool tofull=false)
    {
        if(owner.myPlayer.otherPlayer.hero.Count>0)
        {
            if(tofull)
            {
                amount = owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Damage);
            }
            else{

            }
            new EffectHeal(owner.myPlayer,owner,owner.myPlayer.otherPlayer.hero[0],amount).Resolve();
        }
    }
    public void TaskDamageEnemyHero(int amount=0)
    {
        if(owner.myPlayer.otherPlayer.hero.Count>0)
        {
            new EffectDamage(owner.myPlayer,owner,owner.myPlayer.otherPlayer.hero[0],amount).Resolve();
        }
    }
    public void TaskDamageMyHero(int amount=0)
    {
        if(owner.myPlayer.hero.Count>0)
        {
            new EffectDamage(owner.myPlayer,owner,owner.myPlayer.hero[0],amount).Resolve();
        }
    }

    public Card TaskDraw(Card ToDraw = null, bool ToEn=false)
    {
        Player WhoDraw = owner.myPlayer;
        if(ToEn)
        {
            WhoDraw=owner.myPlayer.otherPlayer;
        }
        if(ToDraw==null)
        {
            ToDraw = WhoDraw.deck.Choice(owner.myPlayer.randomGen);
        }
        if(ToDraw!=null)
        {
            new EffectDraw(WhoDraw,cardIndex:WhoDraw.deck.IndexOf(ToDraw)).Resolve();
        }
        else{
            new EffectDraw(WhoDraw).Resolve();
        }
        return ToDraw;
    }
    public Card TaskDrawType(CardType ctype)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==ctype && c.GetTag(GameTag.ZoneType)==(int)ZoneType.Deck)
            {
                Pool.Add(c);
            }
        }
        Card ToDraw = Pool.Choice(owner.myPlayer.randomGen);
        if(ToDraw!=null)
        {
            new EffectDraw(owner.myPlayer,cardIndex:owner.myPlayer.deck.IndexOf(ToDraw)).Resolve();
        }
        return ToDraw;      
    }
    public Card TaskDrawKey(string abiname)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.HasAbility(abiname) && c.GetTag(GameTag.ZoneType)==(int)ZoneType.Deck)
            {
                Pool.Add(c);
            }
        }
        Card ToDraw = Pool.Choice(owner.myPlayer.randomGen);
        if(ToDraw!=null)
        {
            new EffectDraw(owner.myPlayer,cardIndex:owner.myPlayer.deck.IndexOf(ToDraw)).Resolve();
        }
        return ToDraw;      
    }
    public Card TaskDrawRace(RaceType race)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.raceType.Contains(race))
            {
                Pool.Add(c);
            }
        }
        Card ToDraw = Pool.Choice(owner.myPlayer.randomGen);
        if(ToDraw!=null)
        {
            new EffectDraw(owner.myPlayer,cardIndex:owner.myPlayer.deck.IndexOf(ToDraw)).Resolve();
        }
        return ToDraw; 
    }
    public Card TaskDrawSchool(SpellSchoolType sch)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.spellType.Contains(sch))
            {
                Pool.Add(c);
            }
        }
        Card ToDraw = Pool.Choice(owner.myPlayer.randomGen);
        if(ToDraw!=null)
        {
            new EffectDraw(owner.myPlayer,cardIndex:owner.myPlayer.deck.IndexOf(ToDraw)).Resolve();
        }
        return ToDraw; 
    }
    public void TaskBuffMyWeapon(int mana=0, int atk=0, int hp=0, int hpdef=-1)
    {
        if(owner.myPlayer.weapon.Count>0)
        {
            new EffectChange(owner.myPlayer,owner,owner.myPlayer.weapon[0],manaChange:mana,atkChange:atk,hpChange:hp).Resolve();
        }
    }

    public void TaskBuffMyHero(int mana=0, int atk=0, int hp=0, int arm=0, int hpdef=-1)
    {
        if(owner.myPlayer.hero.Count>0)
        {
            new EffectChange(owner.myPlayer,owner,owner.myPlayer.hero[0],manaChange:mana,atkChange:atk,hpChange:hp,armChange:arm).Resolve();
        }        
    }


    public Card TaskCreate(CardDbf db, ZoneType zone, bool ToEn=false, bool randpos=false, int pos=-1)
    {
        if(db==null)
        {
            return null;
        }
        Player p = owner.myPlayer;
        if(ToEn)
        {
            p=owner.myPlayer.otherPlayer;
        }
        if(randpos)
        {
            pos=p.deck.IndexOf(p.deck.Choice(p.randomGen));
        }
        Card CreatedCard=new Card(db,p);
        if(owner.myPlayer.myGame.m_Mode==GameMode.BattleGround)
        {
            CreatedCard.SetTag(GameTag.AttacksLeftThisTurn, CreatedCard.GetTag(GameTag.AttacksForOneTurn));
            if(owner.cardType==CardType.Minion)
            {
                if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
                {
                    pos = owner.GetTag(GameTag.ZoneIndex)+1;
                }
                else{
                    pos = owner.GetTag(GameTag.ZoneIndex);
                }
                
            }
        }
        new EffectCreate(p,CreatedCard,zone,targetIndex:pos).Resolve();
        if(Game.NowGame.m_Mode==GameMode.BattleGround && owner.myPlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            if(HSViewer.Instance!=null)
                HSViewer.Instance.PreLoad(db);
        }
        return CreatedCard;
    }
    public Card TaskMove(Card CardToMove, ZoneType zone, bool ToEn=false, bool randpos=false)
    {
        Player p = owner.myPlayer;
        int pos = -1;
        if(ToEn)
        {
            p=owner.myPlayer.otherPlayer;
        }
        if(randpos)
        {
            pos=p.deck.IndexOf(p.deck.Choice(p.randomGen));
        }
        new EffectMove(p,CardToMove,(ZoneType)CardToMove.GetTag(GameTag.ZoneType),zone,targetIndex:pos).Resolve();
        return CardToMove;
    }

    public CardDbf TaskMakeDbf(CardType type=CardType.Minion, int mana=0, int atk=0, int hp=0, RaceType race= RaceType.None)
    {
        if(owner.cardDbf.RelatedDbf.Count!=0)
        {
            return owner.cardDbf.RelatedDbf[0];
        }
        else
        {
            CardDbf db = new CardDbf();
            if(race!= RaceType.None)
            {

                db.RaceType.Add(race);
            }
            db.ManaCost = mana;
            db.Attack = atk;
            db.MaxHealth = hp;
            db.CardType= type;
            switch(db.CardType)
            {
                case(CardType.Minion):
                    db.DbfId=1301;
                    db.m_noteMiniGuid="Sheep";
                    break;
                case(CardType.Weapon):
                    db.DbfId=1324;
                    db.m_noteMiniGuid="HeavyAxe";
                    break;
                default:
                    break;
            }
            return db;
        }
    }
//--------------------------------------------------------------------------------------------TODO:CallBack Impl
    public virtual int AfterGetTag(GameTag tg)
    {
        return 0;
    }

    public virtual void OnCombatStart()
    {
        
    }
   
    public virtual void BeforeMakeDamage(Card target = null, int amount = 0)
    {
    }
    public virtual void MakeDamage(Card target = null, int amount = 0)
    {
    }
    public virtual void AfterMakeDamage(Card target = null, int amount = 0)
    {
    }
    public virtual void OverKill(Card target = null, int amount = 0)
    { 
    }


    public virtual int BeforeTakeDamage(Card source = null, int amount = 0)
    {
        return amount;
    }
    public virtual void TakeDamage(Card source = null, int amount = 0)
    {
    }
    public virtual void AfterTakeDamage(Card source = null, int amount = 0)
    { 
    }



    public virtual void MakeHeal(Card target = null, int amount = 0)
    {
    }
    public virtual int BeforeTakeHeal(Card source = null, int amount = 0)
    {
        return amount;
    }
    public virtual void TakeHeal(Card source = null, int amount = 0)
    { }

    public virtual void BeforeAttack(Card target = null)
    { }
    public virtual void AfterAttack(Card target = null)
    { }

    public virtual void BeforeAttacked(Card source = null)
    { }
    public virtual void AfterAttacked(Card source = null)
    { }

    public virtual void Trade()
    {
        
    }


 

    /*
    public virtual void WhenEnterBoard()
    {
    }
    public virtual void WhenLeaveBoard()
    {
    }
    public virtual void WhenEnterHand()
    { }
    public virtual void WhenLeaveHand()
    { }

    public virtual void WhenHandToBoard()
    {
        WhenEnterBoard();
    }
    public virtual void WhenHandToGrave() { }

    public virtual void WhenHandToDeck() { }



    public virtual void WhenBoardToGrave()
    {
        WhenLeaveBoard();
    }
    public virtual void WhenBoardToHand()
    {
        WhenLeaveBoard();
        WhenEnterHand();
    }
    public virtual void WhenBoardToDeck()
    {
        WhenLeaveBoard();
    }



    public virtual void WhenDeckToBoard()
    {
        WhenEnterBoard();
    }
    public virtual void WhenDeckToHand()
    {
        WhenEnterHand();
    }
    public virtual void WhenDeckToGrave() { }


    public virtual void WhenGraveToBoard()
    {
        WhenEnterBoard();
    }
    public virtual void WhenGraveToHand()
    {
        WhenEnterHand();
    }
    public virtual void WhenGraveToDeck() { }
    */
}
