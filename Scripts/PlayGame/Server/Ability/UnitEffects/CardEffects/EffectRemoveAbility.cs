using System.Collections.Generic;

public class CallBackAfterRemoveAbility:UnitEffectCallBack
{
    public delegate void EventAfterRemoveAbility(Card sourceCard, string Abiname);
    public event EventAfterRemoveAbility myEv;
    public CallBackAfterRemoveAbility(Ability SourceAbility, EventAfterRemoveAbility Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sourceCard, string Abiname)
    {
        this.myEv.Invoke(sourceCard, Abiname);
    }
}

public class EffectRemoveAbility:UnitEffect
{
    string AbilityNameSingle;
	public EffectRemoveAbility(Player srcPlayer, Card source, Card target, string abiname)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.AbilityNameSingle = abiname;
	}
	public override void Resolve()
	{
        //this.TargetCard.LoseAbility(this.AbilityNameSingle);
        for(int i=this.TargetCard.abilityList.Count-1;i>=0;i--)
        {
            if(this.TargetCard.abilityList[i].GetType().Name==this.AbilityNameSingle)
            {
                this.TargetCard.abilityList[i].UnRegisterEventEffect();
                this.TargetCard.abilityList.RemoveAt(i);
                break;
            }
        }
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
            new RemoveActorFxCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceCard.GetTag(GameTag.EntityId), this.TargetCard.GetTag(GameTag.EntityId), this.AbilityNameSingle).AddToQueue();
        //if (LoseAbilityEvent != null)
        //{
        //    LoseAbilityEvent.Invoke(target, abiname);
        //}
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterRemoveAbility)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(this.TargetCard,this.AbilityNameSingle); 
            }
        }
    }
}