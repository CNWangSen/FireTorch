using System.Collections.Generic;

public class YGO_870000:MinionBase{
//NAME=青眼白龙
	public override void Init()
	{
		TaskInitAbility("Charge");
	}
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer!=owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "Taunt";
    }
}