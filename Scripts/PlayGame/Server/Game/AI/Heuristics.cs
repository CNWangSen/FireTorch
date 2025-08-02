
using System.Collections.Generic;

public class BoardScorer
{
    public virtual float GetScore(Player fp, Player op)
    {
        return 0f;
    }
}
public class BalancingScorer : BoardScorer
{
    public override float GetScore(Player fp, Player op)
    {
        float score = 0f;
        if (fp.hero.Count == 0)
        {
            score += -100000f;
        }
        else
        {
            if (fp.hero[0].GetTag(GameTag.Health) < 0)
            {
                score += -100000f;
            }
            float Sum_EnemyAtk=0f;
            //float Sum_MyAtk=0f;
            foreach(Card c in op.board.Merge(op.weapon))
            {
                Sum_EnemyAtk+=c.GetTag(GameTag.Attack);
            }
            if(Sum_EnemyAtk>=(fp.hero[0].GetTag(GameTag.Health)+fp.hero[0].GetTag(GameTag.Armor) ))
            {
                score += -1000f-100f*(1+Sum_EnemyAtk-fp.hero[0].GetTag(GameTag.Health)-fp.hero[0].GetTag(GameTag.Armor));
            }
        }

        if (op.hero.Count == 0)
        {
            score += 100000f;
        }
        else
        {
            if (op.hero[0].GetTag(GameTag.Health) < 0)
            {

                score += 100000f;
            }
        }



        float Alpha_MA = 1.0457f;
        float Alpha_TMA = 0.2058f;
        float Alpha_HA = 3f;//9.6557f;
        float Alpha_TrA = 0.9407f;
        float Alpha_BM = 5.2249f;
        float Alpha_Aura = 9f;
        
        
        foreach (Card c in fp.board.Merge(fp.weapon))
        {
            score += Alpha_MA;
            if (c.GetTag(GameTag.Health) > 4)
            {
                score += Alpha_TMA;
            }
            score += Alpha_TrA * (c.GetTag(GameTag.Attack) + c.GetTag(GameTag.Health));
            score += Alpha_BM * c.GetTag(GameTag.Mana);
        }
        foreach (Card c in op.board.Merge(op.weapon))
        {
            score -= Alpha_MA;
            if (c.GetTag(GameTag.Health) > 4)
            {
                score -= Alpha_TMA;
            }
            score -= Alpha_TrA * (c.GetTag(GameTag.Attack) + c.GetTag(GameTag.Health));
            score -= Alpha_BM * c.GetTag(GameTag.Mana);
        }

        foreach (Card c in fp.hero)
        {
            score += Alpha_TrA * (c.GetTag(GameTag.Attack) + c.GetTag(GameTag.Health) + c.GetTag(GameTag.Armor));
        }
        foreach (Card c in op.hero)
        {
            score -= Alpha_TrA * (c.GetTag(GameTag.Attack) + c.GetTag(GameTag.Health) + c.GetTag(GameTag.Armor));
        }

        score += Alpha_HA * (fp.hand.Count - op.hand.Count);
        score += Alpha_Aura * (fp.EffectCallBacks.Count-op.EffectCallBacks.Count);
        score += 3f*(fp.deck.Count-op.deck.Count);

        return score;
    }
}
public class BalancingScorer2 : BoardScorer
{
    public override float GetScore(Player fp, Player op)
    {
        Player FriendlyPlayer = fp;
        Player OpponentPlayer = op;
        float OpHeroHpWeight = 0.1f;
        float OpMinionHpWeight = 1f;
        float OpMinionAtkWeight = 1f;
        float OpWeaponDurWeight = 1f;
        float OpWeaponAtkWeight = 1f;

        float FrHeroHpWeight = 0.1f;
        float FrMinionHpWeight = 0.9f;
        float FrMinionAtkWeight = 0.9f;
        float FrWeaponDurWeight = 0.9f;
        float FrWeaponAtkWeight = 0.9f;

        float FrHandManaWeight = 1f;

        float score = 0;
        foreach (Card c in FriendlyPlayer.hand)
        {
            score += c.GetTag(GameTag.Mana) * FrHandManaWeight;//0.1f
        }

        if (OpponentPlayer.hero[0].GetTag(GameTag.Health) <= 10)
        {
            OpHeroHpWeight = 20f;
        }
        if (FriendlyPlayer.hero[0].GetTag(GameTag.Health) <= 10)
        {
            FrHeroHpWeight = 20f;
        }
        score += FriendlyPlayer.hero[0].GetTag(GameTag.Health) * FrHeroHpWeight - OpponentPlayer.hero[0].GetTag(GameTag.Health) * OpHeroHpWeight;
        foreach (Card c in FriendlyPlayer.board)
        {
            score += c.GetTag(GameTag.Attack) * FrMinionAtkWeight;
            score += c.GetTag(GameTag.Health) * FrMinionHpWeight;
        }
        foreach (Card c in OpponentPlayer.board)
        {
            score -= c.GetTag(GameTag.Attack) * OpMinionAtkWeight;
            score -= c.GetTag(GameTag.Health) * OpMinionHpWeight;
        }
        foreach (Card c in FriendlyPlayer.weapon)
        {
            score += c.GetTag(GameTag.Attack) * FrWeaponAtkWeight;
            score += c.GetTag(GameTag.Health) * FrWeaponDurWeight;
        }
        foreach (Card c in OpponentPlayer.weapon)
        {
            score -= c.GetTag(GameTag.Attack) * OpWeaponAtkWeight;
            score -= c.GetTag(GameTag.Health) * OpWeaponDurWeight;
        }


        if (FriendlyPlayer.hero[0].GetTag(GameTag.Health) < 0)
        {
            score = -100000f;
        }
        if (OpponentPlayer.hero[0].GetTag(GameTag.Health) < 0)
        {

            score = 100000f;
        }
        return score;
    }
}