using System;

public class Facing
{
    public Player p;
    public void MakeFacingAITurn()
    {
        while (MakeOneAIMove(true))
        {
        }
    }

    bool MakeOneAIMove(bool attackFirst)
    {
        if (this.p.otherPlayer.hero.Count == 0)
        {
            return false;
        }
        if (attackFirst)
            return AttackWithACreature() || AttackWithHero() || PlayACardFromHand() || UseHeroPower();
        else
            return PlayACardFromHand() || UseHeroPower() || AttackWithACreature() || AttackWithHero();
    }

    bool PlayACardFromHand()
    {
        Card MaxCostCard = null;
        foreach (Card c in this.p.hand)
        {
            if (c.CanBePlayed())
            {
                if ((TargetingOptions)c.GetTag(GameTag.CardTargetOpt) != TargetingOptions.NoTarget && p.GetRandomTargetMatchOption((TargetingOptions)c.GetTag(GameTag.CardTargetOpt)) == null)
                { }
                else
                {
                    if (MaxCostCard == null)
                    {
                        MaxCostCard = c;
                    }
                    else
                    {
                        MaxCostCard = (c.GetTag(GameTag.Mana) > MaxCostCard.GetTag(GameTag.Mana)) ? c : MaxCostCard;
                    }
                }
            }
        }
        if (MaxCostCard != null)
        {
            int ind = new Random().Next(0, this.p.board.Count + 1);

            if (this.p.IsValidTargetForOption((TargetingOptions)MaxCostCard.GetTag(GameTag.CardTargetOpt), this.p.otherPlayer.hero[0]))
            {
                if ((TargetingOptions)MaxCostCard.GetTag(GameTag.CardTargetOpt) != TargetingOptions.NoTarget)
                {
                    new EffectPlay(this.p, CardId:MaxCostCard.GetTag(GameTag.EntityId), TargetId:this.p.otherPlayer.hero[0].GetTag(GameTag.EntityId), minionindex:ind).Resolve();
                }
                else
                {
                    new EffectPlay(this.p, CardId:MaxCostCard.GetTag(GameTag.EntityId), TargetId:-1, minionindex:ind).Resolve();
                }
            }
            else
            {
                Card RandomTarget = this.p.GetRandomTargetMatchOption((TargetingOptions)MaxCostCard.GetTag(GameTag.CardTargetOpt));
                if (RandomTarget != null)
                {
                    new EffectPlay(this.p, CardId:MaxCostCard.GetTag(GameTag.EntityId), TargetId:RandomTarget.GetTag(GameTag.EntityId), minionindex:ind).Resolve();
                }

                else
                {
                    new EffectPlay(this.p, CardId:MaxCostCard.GetTag(GameTag.EntityId), TargetId:-1, minionindex:ind).Resolve();
                }
            }
            return true;
        }
        return false;
    }


    bool UseHeroPower()
    {
        Card MaxCostCard = null;
        foreach (Card c in this.p.power)
        {
            if (this.p.GetTag(GameTag.ManaLeft) >= c.GetTag(GameTag.Mana) && c.GetTag(GameTag.AttacksLeftThisTurn) > 0)
            {
                if ((TargetingOptions)c.GetTag(GameTag.CardTargetOpt) != TargetingOptions.NoTarget && this.p.GetRandomTargetMatchOption((TargetingOptions)c.GetTag(GameTag.CardTargetOpt)) == null)
                { }
                else
                {
                    if (MaxCostCard == null)
                    {
                        MaxCostCard = c;
                    }
                    else
                    {
                        MaxCostCard = (c.GetTag(GameTag.Mana) > MaxCostCard.GetTag(GameTag.Mana)) ? c : MaxCostCard;
                    }
                }
            }
        }
        if (MaxCostCard != null)
        {
            if (this.p.IsValidTargetForOption((TargetingOptions)MaxCostCard.GetTag(GameTag.CardTargetOpt), this.p.otherPlayer.hero[0]))
            {
                new EffectUseHeroPower(this.p,SourceId:MaxCostCard.GetTag(GameTag.EntityId),TargetId:this.p.otherPlayer.hero[0].GetTag(GameTag.EntityId)).Resolve();
            }
            else
            {
                Card RandomTarget = p.GetRandomTargetMatchOption((TargetingOptions)MaxCostCard.GetTag(GameTag.CardTargetOpt));
                if (RandomTarget != null)
                {
                    new EffectUseHeroPower(this.p,SourceId:MaxCostCard.GetTag(GameTag.EntityId),TargetId:RandomTarget.GetTag(GameTag.EntityId)).Resolve();
                }
                else
                {
                    new EffectUseHeroPower(this.p,SourceId:MaxCostCard.GetTag(GameTag.EntityId),TargetId:-1).Resolve();
                }
            }
            //p.GetArea().heroPowerVisual.heroPowerObjects[p.power.IndexOf(MaxCostCard)].GetComponentInChildren<HeroPowerButton>().WasUsedThisTurn = true;
            return true;
        }
        return false;

    }

    bool AttackWithACreature()
    {
        foreach (Card cl in this.p.board)
        {
            if (cl.GetTag(GameTag.AttacksLeftThisTurn) > 0 && cl.GetTag(GameTag.Attack) > 0)
            {
                if ((TargetingOptions)cl.GetTag(GameTag.AttackableTargets) == TargetingOptions.OpposingCharacters)
                {
                    new EffectAttack(this.p,SourceId:cl.GetTag(GameTag.EntityId),TargetId:this.p.otherPlayer.hero[0].GetTag(GameTag.EntityId)).Resolve();
                    return true;
                }
                else
                {
                    Card t = null;
                    if (this.p.GetValidTargetMatchOption((TargetingOptions)cl.GetTag(GameTag.AttackableTargets)).Contains(this.p.otherPlayer.hero[0]))
                    {
                        t = this.p.otherPlayer.hero[0];//GetRandomTargetMatchOption((TargetingOptions)cl.GetTag(GameTag.AttackableTargets));
                    }
                    else 
                    {
                        t = this.p.GetRandomTargetMatchOption((TargetingOptions)cl.GetTag(GameTag.AttackableTargets));
                    }
                    if (t != null)
                    {
                        new EffectAttack(this.p,SourceId:cl.GetTag(GameTag.EntityId),TargetId:t.GetTag(GameTag.EntityId)).Resolve();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
        return false;
    }

    bool AttackWithHero()
    {
        if (p.hero[0].GetTag(GameTag.AttacksLeftThisTurn) > 0 && p.hero[0].GetTag(GameTag.Attack) > 0)
        {
            Card t = null;
            if (this.p.GetValidTargetMatchOption((TargetingOptions)p.hero[0].GetTag(GameTag.AttackableTargets)).Contains(this.p.otherPlayer.hero[0]))
            {
                t = this.p.otherPlayer.hero[0];//GetRandomTargetMatchOption((TargetingOptions)cl.GetTag(GameTag.AttackableTargets));
            }
            else 
            {
                t = this.p.GetRandomTargetMatchOption((TargetingOptions)p.hero[0].GetTag(GameTag.AttackableTargets));
            }
            if (t != null)
            {
                new EffectAttack(this.p,SourceId:p.hero[0].GetTag(GameTag.EntityId),TargetId:t.GetTag(GameTag.EntityId)).Resolve();
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }
}