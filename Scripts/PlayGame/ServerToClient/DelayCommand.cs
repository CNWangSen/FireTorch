using DG.Tweening;

public class DelayCommand2 : Command
{
    public int DelayMs;
    public DelayCommand2(int ms)
    {
        this.DelayMs = ms;
    }
    public override void StartCommandExecution()
    {
        Sequence Seq = DOTween.Sequence();
        Seq.AppendInterval(DelayMs/1000);
        Seq.OnComplete(() =>
        {
            Command.CommandExecutionComplete();
        });
    }
}