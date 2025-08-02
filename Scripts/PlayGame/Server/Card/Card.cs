using System.Collections.Generic;
/*
public static class IDFactory
{

    private static int Count;
    public static int GetUniqueID()
    {
        Count++;
        return Count;
    }

    public static void ResetIDs()
    {
        Count = 0;
    }
}
*/
public class Card
{
    //public static AllCard
    public Player myPlayer;
    public CardDbf cardDbf;
    public List<Ability> abilityList = new List<Ability>();
    //public List<Ability> stateList = new List<Ability>();

    public List<Card> attachmentList = new List<Card>();
    public Card attachedTo;

    public List<ClassType> classes;
    public List<RaceType> raceType;
    public List<SpellSchoolType> spellType;
    public CardType cardType;

    public Card hateCard = null;

    //public Dictionary<GameTag, int> Property = new Dictionary<GameTag, int>();
    public int[] PropertyArr = new int[100];

    public int GetTag(GameTag tg)
    {
        return new EffectGetTag(this,tg).Resolve(c:0);
    }
    public void ChangeTag(GameTag tg, int cvalue)
    {
        this.SetTag(tg,this.GetTag(tg)+cvalue);
    }
    public void SetTag(GameTag tg, int value)
    {
        this.PropertyArr[(int)tg]=value;
        /*
        int tagV;        
        if (this.Property.TryGetValue(tg, out tagV))
        {
            this.Property[tg] = value;
        }
        else 
        {
            this.Property.Add(tg,value);
        }
        */
    }

    public Card(CardDbf dbf, Player player, int assid = -1)
    {
        this.myPlayer = player;
        this.cardDbf = dbf;

        this.classes = dbf.Classes;
        this.cardType = dbf.CardType;
        this.raceType = dbf.RaceType;
        this.spellType = dbf.SpellType;
        if(dbf.PremiumType!=PremiumType.Mythic)
        {
            this.SetTag(GameTag.PremiumType, (int)PremiumType.Normal);
        }
        else{
            this.SetTag(GameTag.PremiumType, (int)PremiumType.Mythic);
        }
        
        this.SetTag(GameTag.ZoneType, (int)ZoneType.Aside);

        this.SetTag(GameTag.Mana,dbf.ManaCost);
        this.SetTag(GameTag.Attack,dbf.Attack);
        this.SetTag(GameTag.Health,dbf.MaxHealth);
        this.SetTag(GameTag.Armor,dbf.Armor);
        this.SetTag(GameTag.ManaDef, dbf.ManaCost);
        this.SetTag(GameTag.AttackDef,dbf.Attack);
        this.SetTag(GameTag.HealthDef, dbf.MaxHealth);
        this.SetTag(GameTag.ArmorDef, 0);
        this.SetTag(GameTag.Damage,0);
        this.SetTag(GameTag.AttacksForOneTurn,1);

        this.SetTag(GameTag.ManaMod, 0);
        this.SetTag(GameTag.AttackMod, 0);
        this.SetTag(GameTag.HealthMod, 0);
        this.SetTag(GameTag.ArmorMod, 0);
        
        this.SetTag(GameTag.AttackableTargets, (int)TargetingOptions.OpposingCharactersTauntFirst);

        this.SetTag(GameTag.IsInjured,0);
        this.SetTag(GameTag.IsCanceled,0);

        this.SetTag(GameTag.RareType, (int)dbf.RareType);
        this.SetTag(GameTag.CardType, (int)dbf.CardType);
        //if(this.GetTag(GameTag.CardType) == (int)CardType.Minion)
        //{
        //    if(myPlayer.randomGen.Next(100)>80)
        //    {
        //        this.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);  
        //    }
        //}
        //this.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);  
        if (assid == -1)
        {
            //this.SetTag(GameTag.EntityId,IDFactory.GetUniqueID());
            //this.myPlayer.myGame.CardsInGame.Add(this.GetTag(GameTag.EntityId), this);
            this.SetTag(GameTag.EntityId,this.myPlayer.myGame.CardsInGame.Count);
            this.myPlayer.myGame.CardsInGame.Add(this);
        }
        else
        {
            this.SetTag(GameTag.EntityId,assid);
            this.myPlayer.myGame.CardsInGame[this.GetTag(GameTag.EntityId)] = this;
        }

        if (System.Type.GetType(dbf.m_noteMiniGuid) != null)
        {
            Ability OneAbility = System.Activator.CreateInstance(System.Type.GetType(dbf.m_noteMiniGuid)) as Ability;
            OneAbility.AttachTo(this);
            this.SetTag(GameTag.CardTargetOpt,(int)dbf.Targets);
        }
        if (this.myPlayer.myGame.GetTag(GameTag.GameMode) == (int)GameMode.BattleGround)
        {
            //this.SetTag(GameTag.AttacksLeftThisTurn, this.GetTag(GameTag.AttacksForOneTurn));
        }
        else
        {
            this.SetTag(GameTag.AttacksLeftThisTurn, 0);
        }
    }

    public Card GetClone(Player p, bool newId=false)
    {
        Card newC;
        if (newId)
        {
            newC = new Card(this.cardDbf, p); 
        }
        else
        {
            newC = new Card(this.cardDbf, p, this.GetTag(GameTag.EntityId)); 
        }

        newC.classes = this.classes;
        newC.cardType = this.cardType;
        newC.raceType = this.raceType;
        newC.spellType = this.spellType;

        

        for(int i =0;i<this.PropertyArr.Length;i++)
        {
            newC.PropertyArr[i]=this.PropertyArr[i];
        }
        //foreach (KeyValuePair<GameTag, int> kv in this.Property)
        //{
        //    newC.SetTag(kv.Key, kv.Value);
        //}
        foreach (Ability abi in this.abilityList)
        {
            if (abi.GetType().Name != null)
            {
                bool has_abi=false;
                foreach(Ability abi2 in newC.abilityList)
                {
                    if(abi2.GetType().Name==abi.GetType().Name)
                    {
                        has_abi=true;
                        break;
                    }
                }
                if(has_abi==false)
                {
                    Ability OneAbility = System.Activator.CreateInstance(abi.GetType()) as Ability;
                    OneAbility.AttachTo(newC);
                }

            }
        }

        foreach(Card c in this.attachmentList)
        {
            Card Attachment = c.GetClone(p,newId);
            Attachment.attachedTo = newC;
            newC.attachmentList.Add(Attachment);
        }
        return newC;
    }

    public bool CanBePlayed()
    {
        bool ownersTurn = false;

        if (this.myPlayer.GetTag(GameTag.IsSimPlayer)==1 || this.myPlayer.myGame.m_Mode==GameMode.MarvelSnap)
        {
            ownersTurn = true;
        }
        else
        { 
            ownersTurn = (Game.NowGame.PlayersInGame[Game.NowGame.GetTag(GameTag.NowPlayingIndex)] == this.myPlayer); 
        }

        bool fieldNotFull = true;
        if (this.cardDbf.CardType==CardType.Minion)
            fieldNotFull = (this.myPlayer.board.Count < this.myPlayer.maxnum[(int)ZoneType.Board]);

        bool hasTarget = true;
        if ((TargetingOptions)this.GetTag(GameTag.CardTargetOpt) != TargetingOptions.NoTarget)
        {
            switch ((TargetingOptions)this.GetTag(GameTag.CardTargetOpt))
            {
                case (TargetingOptions.AllMinions):
                hasTarget = this.myPlayer.board.Merge(this.myPlayer.otherPlayer.board).Count != 0;
                break;
                case (TargetingOptions.FriendlyMinions):
                hasTarget = (this.myPlayer.board.Count != 0);
                break;
                case (TargetingOptions.OpposingMinions):
                hasTarget = (this.myPlayer.otherPlayer.board.Count != 0);
                break;
                default:
                break;
            }
        }
        return ownersTurn && fieldNotFull && (this.GetTag(GameTag.Mana) <= this.myPlayer.GetTag(GameTag.ManaLeft)) && hasTarget;
    }

    public void Refresh()
    {
        //for(int j = this.abilityList.Count-1; j>=0; j--)
        //{
        //    //this.abilityList[j].AuraRefresh();
        //}
    }
    public bool IsDying()
    {
        for(int j = this.abilityList.Count-1; j>=0; j--)
        {
            if(!this.abilityList[j].IsDying())
            {
                return false;
            }
        }
        if(this.GetTag(GameTag.IsDying)==1||this.GetTag(GameTag.Health) <=0 && ((this.GetTag(GameTag.CardType) == (int)CardType.Minion)|| (this.GetTag(GameTag.CardType) == (int)CardType.Hero))|| (this.GetTag(GameTag.CardType) == (int)CardType.Weapon))
        {
            return true;
        }
        else{
            return false;   
        }
    }

    public bool HasAbility(string abiname)
    {
        if(abiname=="Deathrattle" || abiname=="Battlecry" || abiname=="AuraActive" || abiname == "RegisterEventEffect")
        {
            foreach(Ability OneAbility in this.abilityList)
            {
                if (!(OneAbility.GetType().GetMethod(abiname).DeclaringType == typeof(Ability)))
                {
                    return true;
                } 
            } 
        }
        for(int i=this.abilityList.Count-1;i>=0;i--)
        {
            if(this.abilityList[i].GetType().Name==abiname)
            {
                return true;
            }
        }
        return false;
    }

}
