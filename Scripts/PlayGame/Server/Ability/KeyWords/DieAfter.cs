using UnityEditor;

public class DieAfterAttack : Ability
{
    public DieAfterAttack()
    { }

    public override void AfterAttack(Card target=null)
    {
        base.AfterAttack(target);
        owner.SetTag(GameTag.Health,0);
    }
}

public class DieAfterTurnEnd : Ability
{
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,DieAtTheEndOfTurnCauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void DieAtTheEndOfTurnCauseEvent()
    {
        new EffectDestroy(owner.myPlayer,owner,owner).Resolve();
    }
}