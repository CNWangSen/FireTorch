using System.Collections.Generic;

public class CallBackAfterGameStart:UnitEffectCallBack
{
    public delegate void EventAfterGameStart();
    public event EventAfterGameStart myEv;
    public CallBackAfterGameStart(Ability SourceAbility, EventAfterGameStart Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve()
    {
        this.myEv.Invoke();
    }
}

public class EffectGameStart:UnitEffect
{

	public EffectGameStart(Player srcPlayer)
	{
        this.SourcePlayer = srcPlayer;
	}
	public override void Resolve()
	{
        List<Card> Po = this.SourcePlayer.hero.Merge(this.SourcePlayer.board).Merge(this.SourcePlayer.power);
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterGameStart)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(); 
            }
        }
	}
}