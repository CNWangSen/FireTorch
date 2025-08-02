using System.Collections.Generic;

public class EffectBaconshopSetPremium:UnitEffect
{

    public PremiumType Premium;
	public EffectBaconshopSetPremium(Player srcPlayer, Card srcCard, Card targetCard, PremiumType premium = PremiumType.Golden)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = srcCard;
        this.TargetCard = targetCard;
        this.Premium = premium;
	}
	public override void Resolve()
	{
        if (this.Premium==PremiumType.Golden)
        {
            this.TargetCard.SetTag(GameTag.PremiumType, (int)PremiumType.Golden);
            this.TargetCard.SetTag(GameTag.AttackDef, 2 * this.TargetCard.GetTag(GameTag.AttackDef));
            this.TargetCard.SetTag(GameTag.HealthDef, 2 * this.TargetCard.GetTag(GameTag.HealthDef));
            this.TargetCard.SetTag(GameTag.Attack, this.TargetCard.GetTag(GameTag.AttackDef));
            this.TargetCard.SetTag(GameTag.Health, this.TargetCard.GetTag(GameTag.HealthDef));
            foreach (Ability abi in this.TargetCard.abilityList)
            {
                abi.amounts = new List<int>() { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            }
        }
    }
}