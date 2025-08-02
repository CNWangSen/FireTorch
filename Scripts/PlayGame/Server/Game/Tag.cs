public enum GameState 
{
    Loading,
    Running,
    GameOver,
}
public enum PlayerState
{
    Playing,
}
public enum PlayerSide
{
    Friendly,
    Opposing,
    All,
}

public enum GameTag
{
    LowPlayerID,
    TopPlayerID,

    EntityId,
    CardDbfId,
    ZoneType,
    ZoneIndex,
    CardType,
    SchoolType,
    PremiumType,
    RareType,
    CardTargetOpt,

    Mana,
    Attack,
    Health,
    Armor,
    Energy,
    ManaDef,
    AttackDef,
    HealthDef,
    ArmorDef,
    EnergyDef,
    SpellDamage,

    ManaMod,
    AttackMod,
    HealthMod,
    ArmorMod,
    EnergyMod,
    SpellDamageMod,

    ManaFot,
    AttackFot,
    HealthFot,
    ArmorFot,
    EnergyFot,
    SpellDamageFot,

    Damage,

    AttacksForOneTurn,
    AttacksLeftThisTurn,
    AttackableTargets,
    CanBePlayedFromDeck,

    IsAwake,
    IsInjured,
    IsCanceled,

    PlayerID,
    TeamID,
    FatiguedTimes,
    HealEff,
    DamageTakenEff,
    DamageEff,
    DamageEffMod,
    GoFirst,
    RandomSeed,
    ManaThisTurn,
    ManaLeft,
    ManaOverLoad,
    BonusManaThisTurn,
    IsControledByAI,
    IsLowPlayer,
    IsSimPlayer,
    MaxTotalMana,
    NowTurnNum,


    GameID,
    NowPlayingIndex,
    GameState,
    GameMode,
    NowRoundNum,



    CntInvokeGara,
    CntHeroPowerUsed,
    CntJadeGolem,
    CntDamageTakenThisTurn,
    CntHealTakenThisTurn,
    CntManaUsedOnSpell,
    CntSpellUsed,
    CntSecretUsed,
    CntDraw,
    CntDrawThisTurn,
    CntCardUsed,
    CntCardUsedThisTurn,
    CntExcavate,
    CntCorpse,
    CntLeapFrog,
    AidDeathPos,
    IsDying,
    HasDead,
    IsPlayerTurnEnd,
}

public enum KeyWord
{ 
    Battlecry,
    Deathrattle,
    Windfury,

}
public enum VfxType
{
    Damage=0,
    Heal,
    Buff=2,
    Nerf,
    Destroy=4,
    DieCard=5,
    DieMinion=6,
    DieHero,
    DieWeapon=8,
    SpawnCard,
    SpawnMinion=10,
    SpawnHero,
    SpawnWeapon=12,
    AtkSmall,
    AtkMid=14,
    AtkLarge,
    Morph=16,
    Move=17,
    Atk=18,
    BaconStar=19,
    AttackLaunch=20,
    None=21,
}

public enum ActorFx
{
    Sleep,
    Taunt,
    Poisonous,
    DivineShield,
    Deathrattle,
    WillDie,
    Damage,
}
public enum ClassType
{
    Neutral=0,
    DeathKnight=1,
    DemonHunter=2,
    Druid=3,
    Hunter=4,
    Mage=5,
    Paladin=6,
    Priest=7,
    Rogue=8,
    Shaman=9,
    Warlock=10,
    Warrior=11,
    Monk=12,
    Dream=13,
    Whizbang=14,
}

public enum RaceType
{
    All=0,
    Beast=1,
    Demon=2,
    Dragon=3,
    Elemental=4,
    Human=5,
    Mechanical=6,
    Murloc=7,
    Naga=8,
    Nightelf=9,
    Orc=10,
    Pirate=11,
    Quilboar=12,
    Totem=13,
    Undead=14,
    Bloodelf=15,
    Treant=16,
    Gnome=17,
    Highelf=18,
    Oldgod=19,
    Worgen=20,
    Troll=21,
    Ogre=22,
    Gnoll=23,
    Draenei=24,
    Tauren=25,
    Pandaren=26,
    Celestial=27,
    Dwarf=28,
    Goblin=29,
    Golem=30,
    Egg=31,
    Furbolg=32,
    Centaur=33,
    Gronn=34,
    Vulpera=35,
    None=36,
}

public enum SpellSchoolType
{
    Arcane=0,
    Fel,
    Fire=2,
    Frost,
    Holy=4,
    Nature=5,
    Shadow=6,
    Spellcraft,
    Tavern,
    Physical,
}


public enum TargetingOptions
{
    NoTarget=0,
    AllMinions=1,
    OpposingMinions=2,
    FriendlyMinions=3,
    AllCharacters=4,
    OpposingCharacters=5,
    FriendlyCharacters=6,
    AllHeros=7,
    OpposingHeros=8,
    FriendlyHeros=9,
    AllHands=10,
    OpposingHands=11,
    FriendlyHands=12,
    AllDecks=13,
    OpposingDecks=14,
    FriendlyDecks=15,
    AllPowers=16,
    OpposingPowers=17,
    FriendlyPowers=18,
    AllWeapons=19,
    OpposingWeapons=20,
    FriendlyWeapons=21,
    Any=22,
    MakeChoice=23,
    OpposingCharactersTauntFirst=24,
    OpposingMinionsTauntFirst=25,
    FriendlyMinionsAndHands=26,
}



public enum ZoneType
{
    Deck=0,
    Hand=1,
    Board=2,
    Grave=3,
    Head=4,
    Hero=5,
    Power=6,
    Weapon=7,
    Removed=8,
    Aside=9,
    MinionPower=10,
    BoardLeft=11,
    BoardRight=12,
    Site=13,
}

public enum CardType
{
    Minion=0,
    Spell=1,
    Weapon=2,
    Hero=3,
    HeroPower=4,
    Secret,
    Location,
    Enchant,
    AidHover,
    BgHeroBuddy,
    BgQuestReward,
    BgAnomaly,
    BgSpell,
    LtAbility,
    AidGame,
    None,
}

public enum RareType
{
    Free=0,
    Common=1,
    Rare=2,
    Epic=3,
    Legendary=4,
    None=5,
}

public enum PremiumType
{
    None=0,
    Normal=1,
    Golden=2,
    Diamond=3,
    Mythic=4,
    Signature=5,
    Invalid=6,

}
public enum AIstrategy
{
    Arggo,
    MidRange,
    Control,
    Balance,

    AFK,
    Random,
    Facing,
    HBFS,
    CheatingMCTS,
}

public enum GameMode
{
    StandardPlay,
    WildPlay,
    BattleGround,
    Mercenary,
    MarvelSnap,
    CardMonster,
    JJC,
    Rogue,
}
public enum ActionType
{
    PlayCard,
    CardAttack,
    HeroPower,
    TurnEnd,

    DrawCard,

    CreateCard,
    MoveCard,
    Damage,
    Heal,
    Destroy,
    Morph,
    Change,



    ChooseCardToPlay,
    ChoosePlayTarget,

    ChooseCardToAttack,
    ChooseAttackTarget,
    
    ChoosePowerToUse,
    ChoosePowerTarget,
}


public enum EmoteType
{
    THANKS,
    WOW,
    WELL_PLAYED,
    OOPS,
    GREETINGS,
    THREATEN,
    START,
    CONCEDE,
    ATTACK,   
    INVALID,
    SORRY,
    // Token: 0x0400EACB RID: 60107
    TIME,
    // Token: 0x0400EACC RID: 60108
    THINK1,
    // Token: 0x0400EACD RID: 60109
    THINK2,
    // Token: 0x0400EACE RID: 60110
    THINK3,
    // Token: 0x0400EACF RID: 60111
    GOOD_GAME,
    // Token: 0x0400EAD0 RID: 60112
    LOWCARDS,
    // Token: 0x0400EAD1 RID: 60113
    NOCARDS,
    // Token: 0x0400EAD2 RID: 60114
    ERROR_NEED_WEAPON,
    // Token: 0x0400EAD3 RID: 60115
    ERROR_NEED_MANA,
    // Token: 0x0400EAD4 RID: 60116
    ERROR_MINION_ATTACKED,
    // Token: 0x0400EAD5 RID: 60117
    ERROR_I_ATTACKED,
    // Token: 0x0400EAD6 RID: 60118
    ERROR_SUMMON_SICKNESS,
    // Token: 0x0400EAD7 RID: 60119
    ERROR_HAND_FULL,
    // Token: 0x0400EAD8 RID: 60120
    ERROR_FULL_MINIONS,
    // Token: 0x0400EAD9 RID: 60121
    ERROR_STEALTH,
    // Token: 0x0400EADA RID: 60122
    ERROR_PLAY,
    // Token: 0x0400EADB RID: 60123
    ERROR_TARGET,
    // Token: 0x0400EADC RID: 60124
    ERROR_TAUNT,
    // Token: 0x0400EADD RID: 60125
    ERROR_GENERIC,
    // Token: 0x0400EADE RID: 60126
    PICKED,
    // Token: 0x0400EADF RID: 60127
    DEATH_LINE,
    // Token: 0x0400EAE0 RID: 60128
    HAPPY_NEW_YEAR_LUNAR,
    // Token: 0x0400EAE1 RID: 60129
    MIRROR_START,
    // Token: 0x0400EAE2 RID: 60130
    HAPPY_HOLIDAYS,
    // Token: 0x0400EAE3 RID: 60131

    // Token: 0x0400EAE4 RID: 60132
    HAPPY_NEW_YEAR,
    // Token: 0x0400EAE5 RID: 60133
    FIRE_FESTIVAL_FIREWORKS_RANK_ONE,
    // Token: 0x0400EAE6 RID: 60134
    FIRE_FESTIVAL_FIREWORKS_RANK_TWO,
    // Token: 0x0400EAE7 RID: 60135
    FIRE_FESTIVAL_FIREWORKS_RANK_THREE,
    // Token: 0x0400EAE8 RID: 60136
    FIRE_FESTIVAL,
    // Token: 0x0400EAE9 RID: 60137
    FROST_FESTIVAL_FIREWORKS_RANK_ONE,
    // Token: 0x0400EAEA RID: 60138
    FROST_FESTIVAL_FIREWORKS_RANK_TWO,
    // Token: 0x0400EAEB RID: 60139
    FROST_FESTIVAL_FIREWORKS_RANK_THREE,
    // Token: 0x0400EAEC RID: 60140
    GREETINGS_DISABLE,
    // Token: 0x0400EAED RID: 60141
    WELL_PLAYED_DISABLE,
    // Token: 0x0400EAEE RID: 60142
    OOPS_DISABLE,
    // Token: 0x0400EAEF RID: 60143
    THREATEN_DISABLE,
    // Token: 0x0400EAF0 RID: 60144
    THANKS_DISABLE,
    // Token: 0x0400EAF1 RID: 60145
    WOW_DISABLE,
    // Token: 0x0400EAF2 RID: 60146
    PIRATE_DAY,
    // Token: 0x0400EAF3 RID: 60147
    HAPPY_HALLOWEEN,
    // Token: 0x0400EAF4 RID: 60148
    DUNGEON_CRAWL_DEFEAT_TAUNT,
    // Token: 0x0400EAF5 RID: 60149
    DUNGEON_CRAWL_DEFEAT_TAUNT_SUPER_RARE,
    // Token: 0x0400EAF6 RID: 60150
    HAPPY_NOBLEGARDEN,
    // Token: 0x0400EAF7 RID: 60151
    MIRROR_GREETINGS,
    // Token: 0x0400EAF8 RID: 60152
    BATTLEGROUNDS_VISUAL_ONE,
    // Token: 0x0400EAF9 RID: 60153
    BATTLEGROUNDS_VISUAL_TWO,
    // Token: 0x0400EAFA RID: 60154
    BATTLEGROUNDS_VISUAL_THREE,
    // Token: 0x0400EAFB RID: 60155
    BATTLEGROUNDS_VISUAL_FOUR,
    // Token: 0x0400EAFC RID: 60156
    BATTLEGROUNDS_VISUAL_FIVE,
    // Token: 0x0400EAFD RID: 60157
    BATTLEGROUNDS_VISUAL_SIX,
    // Token: 0x0400EAFE RID: 60158
    BATTLEGROUNDS_VISUAL_HOT_STREAK,
    // Token: 0x0400EAFF RID: 60159
    BATTLEGROUNDS_VISUAL_TRIPLE,
    // Token: 0x0400EB00 RID: 60160
    BATTLEGROUNDS_VISUAL_TECH_UP_01,
    // Token: 0x0400EB01 RID: 60161
    BATTLEGROUNDS_VISUAL_TECH_UP_02,
    // Token: 0x0400EB02 RID: 60162
    BATTLEGROUNDS_VISUAL_TECH_UP_03,
    // Token: 0x0400EB03 RID: 60163
    BATTLEGROUNDS_VISUAL_TECH_UP_04,
    // Token: 0x0400EB04 RID: 60164
    BATTLEGROUNDS_VISUAL_TECH_UP_05,
    // Token: 0x0400EB05 RID: 60165
    BATTLEGROUNDS_VISUAL_TECH_UP_06,
    // Token: 0x0400EB06 RID: 60166
    BATTLEGROUNDS_VISUAL_KNOCK_OUT,
    // Token: 0x0400EB07 RID: 60167
    BATTLEGROUNDS_VISUAL_BANANA,
    // Token: 0x0400EB08 RID: 60168
    BATTLEGROUNDS_VISUAL_HERO_BUDDY,
    // Token: 0x0400EB09 RID: 60169
    BATTLEGROUNDS_VISUAL_DOUBLE_HERO_BUDDY,
    // Token: 0x0400EB0A RID: 60170
    COLLECTIBLE_BATTLEGROUNDS_EMOTE,
    // Token: 0x0400EB0B RID: 60171
    BATTLEGROUNDS_VISUAL_QUEST_COMPLETE,
    // Token: 0x0400EB0C RID: 60172
    BATTLEGROUNDS_VISUAL_TECH_UP_07,
}
