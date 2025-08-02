using UnityEditor;

public class AttackFacing : Ability
{
    public override void RegisterEventEffect()
    {
        owner.SetTag(GameTag.AttacksForOneTurn,0);
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEventEffect));
    }
    public override void UnRegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }

    public void CauseEventEffect()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Board)
        {
            float minx = -11.86f;
            float maxx = 11.21f;
            float cx = (minx + maxx) / 2f;
            float bw = (maxx - minx);
            float c1 = -bw / 12f;
            float c2 = bw / 6f;

            int myindex = owner.myPlayer.board.IndexOf(owner);
            int myN = owner.myPlayer.board.Count;
            int enN = owner.myPlayer.otherPlayer.board.Count;
            float myx= cx + c1 * (myN - 1) + c2 * myindex;
            bool blocked = false;
            float colw =2f;
            for (int i = 0; i < enN; i++)
            {
                float newx = cx + c1 * (enN - 1) + c2 * i;
                float offset = newx - myx;
                if (offset<colw && offset>-colw)
                {
                    new EffectDamage(owner.myPlayer,owner, owner.myPlayer.otherPlayer.board[i], 0).Resolve();
                    blocked = true;
                }
            }
            if (!blocked)
            {
                new EffectDamage(owner.myPlayer,owner, owner.myPlayer.otherPlayer.hero[0], 0).Resolve();
            }
        }
    }
}


public class HealAdjacent : Ability
{
    public override void RegisterEventEffect()
    {
        owner.SetTag(GameTag.AttacksForOneTurn,0);
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEventEffect));
    }
    public override void UnRegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }

    public void CauseEventEffect()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Board)
        {
            int myind = owner.myPlayer.board.IndexOf(owner);
            int allc = owner.myPlayer.board.Count;
            if (myind - 1 >= 0 && myind - 1 < allc)
            {
               // new EffectHeal(owner.myPlayer,owner, owner.myPlayer.board[myind - 1], amounts[0]).Resolve();
            }
            if (myind + 1 >= 0 && myind + 1 < allc)
            {
                //new EffectHeal(owner.myPlayer,owner, owner.myPlayer.board[myind + 1], amounts[0]).Resolve();
            }
        }
    }
}