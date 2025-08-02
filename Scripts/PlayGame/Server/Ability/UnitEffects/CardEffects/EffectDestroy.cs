using System.Collections.Generic;

public class CallBackAfterDestroy:UnitEffectCallBack
{
    public delegate void EventAfterDestroy(Card source,Card target);
    public event EventAfterDestroy myEv;
    public CallBackAfterDestroy(Ability SourceAbility, EventAfterDestroy Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card source, Card target)
    {
        this.myEv.Invoke(source, target);
    }
}

public class EffectDestroy:UnitEffect
{
    public List<Card> TargetList;
    public Card AssignVfxCard;
    public bool CreateVfx;
	public EffectDestroy(Player srcPlayer, Card source, Card target=null, List<Card> targets=null, Card assignVfxCard=null,bool createVfx =true)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.TargetList = targets;
        this.AssignVfxCard = assignVfxCard;
        this.CreateVfx = createVfx;
	}
	public override void Resolve()
	{
		if (this.SourceCard.myPlayer.hero.Count == 0 || this.SourceCard.GetTag(GameTag.HasDead)>0)
        {
            return;
        }
        int CustomVfxAsset = this.SourceCard.cardDbf.DbfId;
        if (this.AssignVfxCard != null)
        {
            CustomVfxAsset = this.AssignVfxCard.cardDbf.DbfId;
        }
        if (this.SourceCard.cardType == CardType.Spell)
        {
            //this.SourceCard = this.SourceCard.myPlayer.hero[0];
        }
        if (this.TargetList == null)
        {
            this.TargetList = new List<Card>();
        }
        if (this.TargetCard != null)
        {
            this.TargetList.Add(this.TargetCard);
        }
        List<int> targetsIDs = new List<int>();
        foreach (Card c in this.TargetList)
        {
            targetsIDs.Add(c.GetTag(GameTag.EntityId));
        }
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0 && this.CreateVfx)
            new CreateVfxCommand(this.SourceCard.GetTag(GameTag.EntityId), targetsIDs, dbfID: CustomVfxAsset, vfxType: VfxType.Destroy).AddToQueue();
        for (int i = this.TargetList.Count - 1; i >= 0; i--)
        {
            //this.TargetList[i].Die();
            //myPlayer.lastMinionDie = this;
            this.TargetList[i].SetTag(GameTag.AidDeathPos,this.TargetList[i].myPlayer.zones[this.TargetList[i].GetTag(GameTag.ZoneType)].IndexOf(this.TargetList[i]));
            new EffectMove(this.TargetList[i].myPlayer, this.TargetList[i], (ZoneType)this.TargetList[i].GetTag(GameTag.ZoneType), ZoneType.Grave).Resolve();
            

            if ((this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)){
                if(this.SourceCard.cardType==CardType.Minion)
                {
                    //new CreateSpellTableVfxCommand(this.SourceCard.GetTag(GameTag.EntityId),SpellType.SUMMON_IN_FRIENDLY).AddToQueue();
                    if(this.SourceCard.HasAbility("Deathrattle"))
                        new CreateSpellTableVfxCommand(this.SourceCard.GetTag(GameTag.EntityId),SpellType.DEATHRATTLE_DEATH).AddToQueue();
                }                
            }
            if (this.TargetList[i].abilityList.Count != 0)
            {
                for (int j = 0; j < this.TargetList[i].abilityList.Count; j++)
                {
                    this.TargetList[i].abilityList[j].Deathrattle();
                    //this.TargetList[i].abilityList[j].UnRegisterEventEffect();
                }
            }
            this.TargetList[i].SetTag(GameTag.HasDead,1);

            for(int j = this.SourcePlayer.EffectCallBacks.Count-1;j>=0;j--)
            {
                if(this.SourcePlayer.EffectCallBacks[j] is CallBackAfterDestroy)
                {
                    this.SourcePlayer.EffectCallBacks[j].Resolve(this.SourceCard,this.TargetList[i]); 
                }
            }
            if (this.TargetList[i].cardType == CardType.Hero)
            {
                new EffectPlayerDefeat(this.TargetList[i].myPlayer).Resolve();
            }
        }
	}
}