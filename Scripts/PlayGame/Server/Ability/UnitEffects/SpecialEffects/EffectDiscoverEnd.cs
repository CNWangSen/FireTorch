using System.Collections.Generic;

public class CallBackAfterDiscoverEnd:UnitEffectCallBack
{
    public delegate void EventAfterDiscoverEnd(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventAfterDiscoverEnd myEv;
    public CallBackAfterDiscoverEnd(Ability SourceAbility, EventAfterDiscoverEnd Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}

public class EffectDiscoverEnd:UnitEffect
{
    int TargetId;
	public EffectDiscoverEnd(Player srcPlayer, int chosenid)
	{
        this.SourcePlayer = srcPlayer;
        this.TargetId = chosenid;
	}
	public override void Resolve()
	{
        Card ChosenCard = null;
        for (int i = this.SourcePlayer.aside.Count - 1; i >= 0; i--)
        {
            Card c = this.SourcePlayer.aside[i];
            if (c.GetTag(GameTag.EntityId) != this.TargetId)
            {
                new EffectMove(this.SourcePlayer,c, ZoneType.Aside, ZoneType.Grave).Resolve();
            }
            else
            {
                ChosenCard = c;
            }
        }
        if (ChosenCard != null)
        {
            for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
            {
                if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterDiscoverEnd)
                {
                    this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourcePlayer.ChoiceSource,ChosenCard,ZoneType.Board,ZoneType.Board); 
                }
            }
            //if (MakeChoiceEvent != null)
            //{
            //    MakeChoiceEvent.Invoke(ChoiceSource, ChosenCard, ZoneType.Aside, ZoneType.Hand);
            //}
        }
    }
}