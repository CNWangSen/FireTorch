using System.Collections;
using System.Collections.Generic;

public class FTBG_LT_Bonds_Checker:Ability
{
	private static Dictionary<ClassType,int> ClassCount = new Dictionary<ClassType,int>();
	private static Dictionary<RaceType,int> RaceCount = new Dictionary<RaceType,int>();
	public static void AddBondsForPlayer(Player p)
	{
		ClassCount.Clear();
		RaceCount.Clear();
		List<string> ClassDbf = new List<string>();
		List<string> RaceDbf = new List<string>();

		foreach(Card c in p.board)
		{
			if(!ClassDbf.Contains(c.cardDbf.CnName))
			{
				if(ClassCount.ContainsKey(c.classes[0]))
				{
					ClassCount[c.classes[0]]+=1;
				}
				else{
					ClassCount[c.classes[0]]=1;
				}
				ClassDbf.Add(c.cardDbf.CnName);
			}

			if(!RaceDbf.Contains(c.cardDbf.CnName))
			{
				if(RaceCount.ContainsKey(c.raceType[0]))
				{
					RaceCount[c.raceType[0]]+=1;
				}
				else{
					RaceCount[c.raceType[0]]=1;
				}
				RaceDbf.Add(c.cardDbf.CnName);
			}
		}
		AddClassBond(p,ClassType.DeathKnight,3);
		AddClassBond(p,ClassType.DemonHunter,3);
		AddClassBond(p,ClassType.Druid,3);
		AddClassBond(p,ClassType.Hunter,3);
		AddClassBond(p,ClassType.Mage,3);
		AddClassBond(p,ClassType.Paladin,3);
		AddClassBond(p,ClassType.Priest,3);
		AddClassBond(p,ClassType.Rogue,3);
		AddClassBond(p,ClassType.Shaman,3);
		AddClassBond(p,ClassType.Warlock,3);
		AddClassBond(p,ClassType.Warrior,3);
		AddClassBond(p,ClassType.Monk,3);

		AddRaceBond(p,RaceType.Beast,3);
		AddRaceBond(p,RaceType.Demon,3);
		AddRaceBond(p,RaceType.Dragon,3);
		AddRaceBond(p,RaceType.Elemental,3);
		AddRaceBond(p,RaceType.Human,3);
		AddRaceBond(p,RaceType.Murloc,3);
		AddRaceBond(p,RaceType.Naga,3);
		AddRaceBond(p,RaceType.Nightelf,3);
		AddRaceBond(p,RaceType.Orc,3);
		AddRaceBond(p,RaceType.Undead,3);
		AddRaceBond(p,RaceType.Troll,3);
		AddRaceBond(p,RaceType.Dwarf,3);
		AddRaceBond(p,RaceType.Goblin,3);
		AddRaceBond(p,RaceType.Celestial,3);
		AddRaceBond(p,RaceType.Pandaren,3);
	}

	private static void AddClassBond(Player p,ClassType ty,int num)
	{
		if(ClassCount.ContainsKey(ty))
		{
			if(ClassCount[ty]==3)
				new EffectCreate(p,new Card(CardDbf.GetCardDbfByGuid("FTBG_LT_Bond_"+ty.ToString()),p),ZoneType.Power).Resolve();
		}
	}
	private static void AddRaceBond(Player p,RaceType ty,int num)
	{
		if(RaceCount.ContainsKey(ty))
		{
			if(RaceCount[ty]==2)
				new EffectCreate(p,new Card(CardDbf.GetCardDbfByGuid("FTBG_LT_Bond_"+ty.ToString()),p),ZoneType.Power).Resolve();
		}
	}
}
public class FTBG_LT_Bond_DeathKnight:HeroPowerBase
{
}
public class FTBG_LT_Bond_DemonHunter:HeroPowerBase
{
}
public class FTBG_LT_Bond_Druid:HeroPowerBase
{
}
public class FTBG_LT_Bond_Hunter:HeroPowerBase
{
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Power);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.classes.Contains(ClassType.Hunter) && c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "FTBG_LT_Bond_Hunter_e";
    }
}
public class FTBG_LT_Bond_Hunter_e:Ability
{
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.AttackMod)
		{
			return 3;
		}
		if(tg==GameTag.HealthMod)
		{
			return 3;
		}
		return 0;
	}
}
public class FTBG_LT_Bond_Mage:HeroPowerBase
{
}
public class FTBG_LT_Bond_Paladin:HeroPowerBase
{
}
public class FTBG_LT_Bond_Priest:HeroPowerBase
{
}
public class FTBG_LT_Bond_Rogue:HeroPowerBase
{
}
public class FTBG_LT_Bond_Shaman:HeroPowerBase
{
}
public class FTBG_LT_Bond_Warlock:HeroPowerBase
{
}
public class FTBG_LT_Bond_Warrior:HeroPowerBase
{
}
public class FTBG_LT_Bond_Monk:HeroPowerBase
{
}



public class FTBG_LT_Bond_Beast:HeroPowerBase
{
}
public class FTBG_LT_Bond_Demon:HeroPowerBase
{
}
public class FTBG_LT_Bond_Dragon:HeroPowerBase
{
}
public class FTBG_LT_Bond_Elemental:HeroPowerBase
{
}
public class FTBG_LT_Bond_Human:HeroPowerBase
{
}
public class FTBG_LT_Bond_Murloc:HeroPowerBase
{
}
public class FTBG_LT_Bond_Naga:HeroPowerBase
{
}
public class FTBG_LT_Bond_Nightelf:HeroPowerBase
{
}
public class FTBG_LT_Bond_Orc:HeroPowerBase
{
}
public class FTBG_LT_Bond_Undead:HeroPowerBase
{
}
public class FTBG_LT_Bond_Troll:HeroPowerBase
{
}
public class FTBG_LT_Bond_Dwarf:HeroPowerBase
{
}
public class FTBG_LT_Bond_Goblin:HeroPowerBase
{
}
public class FTBG_LT_Bond_Celestial:HeroPowerBase
{
}
public class FTBG_LT_Bond_Pandaren:HeroPowerBase
{
}
