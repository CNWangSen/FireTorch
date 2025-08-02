using UnityEditor;

public class DrawCardWhenDie : Ability
{
    public override void Deathrattle()
    {
        base.Deathrattle();
        new EffectDraw(owner.myPlayer).Resolve();
    }
}

