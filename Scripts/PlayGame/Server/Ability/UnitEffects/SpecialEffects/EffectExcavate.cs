using System.Collections.Generic;

public class EffectExcavate:UnitEffect
{
    private static List<string> CommonPool = new List<string>(){"WW_001t4","WW_001t","WW_001t2","WW_001t18"};//WW_001t3
    private static List<string> RarePool = new List<string>(){"WW_001t7","WW_001t8","WW_001t5"};//WW_001t16 WW_001t9
    private static List<string> EpicPool = new List<string>(){"WW_001t17","WW_001t13","WW_001t12"};//WW_001t11 WW_001t14
    private static List<string> LegendaryPool = new List<string>(){"WW_001t26"};
	public EffectExcavate(Player srcPlayer)
	{
        this.SourcePlayer = srcPlayer;
	}
	public override void Resolve()
	{
        List<List<string>> DigPool = new List<List<string>>(){EffectExcavate.CommonPool,EffectExcavate.RarePool,EffectExcavate.EpicPool,EffectExcavate.LegendaryPool};
        string DigID = DigPool[this.SourcePlayer.GetTag(GameTag.CntExcavate)%4].Choice(this.SourcePlayer.randomGen);
        this.SourcePlayer.ChangeTag(GameTag.CntExcavate,1);
        if(DigID!=null)
        {
            Card CreatedCard=new Card(CardDbf.GetCardDbfByGuid(DigID),this.SourcePlayer);
            new EffectCreate(this.SourcePlayer,CreatedCard,ZoneType.Hand).Resolve();
        }
    }
}