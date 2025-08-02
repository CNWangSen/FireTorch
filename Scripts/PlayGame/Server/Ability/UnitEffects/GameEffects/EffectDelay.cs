public class EffectDelay:UnitEffect
{
    public int DelayMs;
	public EffectDelay(int ms)
	{
        this.DelayMs = ms;
	}
	public override void Resolve()
	{
        new CreateDelayCommand(this.DelayMs/1000).AddToQueue();
	}
}