using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class miniHearthJsonDef
{
	public bool collectible=false;

	public string set="NONE";

	public string id="";
	public int dbfId=0;

	public string type="";
	public string name="";
	public string cardClass="";
	public List<string> classes=new List<string>(){};
	
	public string rarity="";
	public string race="";
	public List<string> races=new List<string>();
	public string spellSchool="";

	public int cost=0;
	public int attack=0;
	public int health=0;
	public int durability=0;
	public int armor=0;


	public string text="";
	public string targetingArrowText="";


	public int techLevel=0;
	public bool isBattlegroundsPoolMinion=false;

	public bool hideCost=false;
	public bool hideStats=false;
	public List<string> mechanics=new List<string>();
/*
hasDiamondSkin howToEarn isMiniSet

faction  referencedTags

overload spellDamage

 heroPowerDbfId elite collectionText

countAsCopyOfDbfId puzzleType

questReward multiClassGroup

battlegroundsPremiumDbfId battlegroundsNormalDbfId battlegroundsBuddyDbfId battlegroundsHero isBattlegroundsBuddy
battlegroundsSkinParentId isBattlegroundsPoolSpell battlegroundsDarkmoonPrizeTurn 



mercenariesRole mercenariesAbilityCooldown
*/
	public static List<string> allModTags = new List<string>(){ "NonCollectibleCards", "CollectibleCards"};
	public static List<string> allRaceTags = new List<string>(){"ALL", "BEAST", "DEMON", "DRAGON", "ELEMENTAL", "HUMAN", "MECHANICAL", "MURLOC", "NAGA", "NIGHTELF", "ORC", "PIRATE", "QUILBOAR", "TOTEM", "UNDEAD", "BLOODELF","TREANT","GNOME","HIGHELF","OLDGOD","WORGEN","TROLL","OGRE","GNOLL","DRAENEI","TAUREN","PANDAREN","CELESTIAL","DWARF","GOBLIN","GOLEM","EGG","FURBOLG","CENTAUR","GRONN","VULPERA","LOCK"};
	public static List<string> allspellSchoolTags = new List<string>(){"ARCANE", "FEL", "FIRE", "FROST", "HOLY", "NATURE", "SHADOW","SPELLCRAFT","TAVERN","PHYSICAL_COMBAT"};
	public static List<string> allClassTags = new List<string>(){"NEUTRAL", "DEATHKNIGHT", "DEMONHUNTER", "DRUID", "HUNTER", "MAGE", "PALADIN", "PRIEST", "ROGUE", "SHAMAN", "WARLOCK", "WARRIOR","MONK","DREAM","WHIZBANG"};
	public static List<string> allSetTags = new List<string>(){"ALTERAC_VALLEY", "BATTLE_OF_THE_BANDS", "BLACK_TEMPLE", "BOOMSDAY", "BRM", "CORE", "DALARAN", "DARKMOON_FAIRE", "DEMON_HUNTER_INITIATE", "DRAGONS", "EVENT", "EXPERT1", "GANGS", "GILNEAS", "GVG", "HERO_SKINS", "ICECROWN", "ISLAND_VACATION", "KARA", "LEGACY", "LOE", "LOOTAPALOOZA", "NAXX", "OG", "PATH_OF_ARTHAS", "PLACEHOLDER_202204", "RETURN_OF_THE_LICH_KING", "REVENDRETH", "SCHOLOMANCE", "STORMWIND", "TGT", "THE_BARRENS", "THE_SUNKEN_CITY", "TITANS", "TROLL", "ULDUM", "UNGORO", "VANILLA", "WHIZBANGS_WORKSHOP", "WILD_WEST", "WONDERS", "YEAR_OF_THE_DRAGON","TB","BATTLEGROUNDS","LETTUCE","BASIC","CREDITS","MISSIONS","TAVERNS_OF_TIME","TUTORIAL","NONE","ShadowVerse","SanGuoSha"};
	public static List<string> allRareTags = new List<string>(){"FREE", "COMMON", "RARE", "EPIC", "LEGENDARY",""};
	public static List<string> allTypeTags = new List<string>(){"MINION","SPELL","WEAPON","HERO", "HERO_POWER","SECRET", "LOCATION", "ENCHANTMENT","MOVE_MINION_HOVER_TARGET","BATTLEGROUND_HERO_BUDDY","BATTLEGROUND_QUEST_REWARD","BATTLEGROUND_ANOMALY","BATTLEGROUND_SPELL","LETTUCE_ABILITY","GAME_MODE_BUTTON","NONE"};
}