
public class CallBackAfterCreate:UnitEffectCallBack
{
    public delegate void EventAfterCreate(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventAfterCreate myEv;
    public CallBackAfterCreate(Ability SourceAbility, EventAfterCreate Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}

public class EffectCreate:UnitEffect
{
	public int ZoneIndex;
	public bool silent;

	public EffectCreate(Player srcPlayer, Card cardToCreate, ZoneType targetZone, int targetIndex = -1, bool silent = false)
	{
		this.SourcePlayer = srcPlayer;
		this.SourceCard = cardToCreate;
		this.SourceZone = targetZone;
		this.ZoneIndex = targetIndex;
		this.silent = silent;
	}
	public override void Resolve()
	{
		if (this.SourcePlayer.zones[(int)this.SourceZone].Count >= this.SourcePlayer.maxnum[(int)this.SourceZone])
        {
            if(this.SourceZone==ZoneType.Weapon)
            {
                new EffectMove(this.SourcePlayer,this.SourcePlayer.weapon[0],ZoneType.Weapon,ZoneType.Grave).Resolve();
            }
            else
            {
                this.SourceZone = ZoneType.Grave;
            }            
        }

        if (this.ZoneIndex < 0 || this.ZoneIndex >= this.SourcePlayer.zones[(int)this.SourceZone].Count)
        {
            this.SourcePlayer.zones[(int)this.SourceZone].Add(this.SourceCard);
        }
        else
        {
            this.SourcePlayer.zones[(int)this.SourceZone].Insert(this.ZoneIndex, this.SourceCard);
        }
        this.SourceCard.SetTag(GameTag.ZoneType,(int)this.SourceZone);

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            bool IsAuraCard = false;
            bool IsTriggerCard = false;
            if(this.SourceCard.cardType==CardType.Minion)
            {
                if(this.SourceCard.HasAbility("RegisterEventEffect"))
                    IsTriggerCard=true;
            }    
            if(this.SourceCard.cardType==CardType.Minion)
            {
                if(this.SourceCard.HasAbility("AuraActive"))
                    IsAuraCard=true;
            }                
            
            new CreateActorCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceCard.GetTag(GameTag.EntityId), this.SourceCard.cardDbf.DbfId, (int)this.SourceCard.GetTag(GameTag.PremiumType), (int)this.SourceZone, this.ZoneIndex, this.SourceCard.GetTag(GameTag.CardTargetOpt),aura:IsAuraCard,trigger:IsTriggerCard).AddToQueue();
            //new ChangeActorTagCommand(this.SourceCard.GetTag(GameTag.EntityId), Cmana:this.SourceCard.GetTag(GameTag.Mana) - this.SourceCard.cardDbf.ManaCost, Catk:this.SourceCard.GetTag(GameTag.Attack) - this.SourceCard.cardDbf.Attack, Chp:this.SourceCard.GetTag(GameTag.Health) - this.SourceCard.cardDbf.MaxHealth, Carm:0).AddToQueue();
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();

            foreach (Ability abi in this.SourceCard.abilityList)
            {
                new GiveActorFxCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceCard.GetTag(GameTag.EntityId), this.SourceCard.GetTag(GameTag.EntityId), abi.GetType().Name).AddToQueue();
                if (!(abi.GetType().GetMethod("Deathrattle").DeclaringType == typeof(Ability)))
                {
                    new GiveActorFxCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceCard.GetTag(GameTag.EntityId), this.SourceCard.GetTag(GameTag.EntityId), "Deathrattle").AddToQueue();
                }
            }
        }

        foreach (Card c in this.SourcePlayer.board)
        {
            c.SetTag(GameTag.ZoneIndex, this.SourcePlayer.board.IndexOf(c));
        }

        if(!this.silent)
        {
            for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
            {
                if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterCreate)
                {
                    this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourceCard,this.SourceCard,this.SourceZone,this.SourceZone); 
                }
            }
        }
        /*
        if (CardCreateEvent != null && !silent)
        {
            CardCreateEvent.Invoke(cardToCreate, cardToCreate, targetZone, targetZone);
        }
        */

        this.SourcePlayer.myGame.UpdateAura();
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }
	}
}