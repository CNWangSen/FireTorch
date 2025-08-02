import os
import json
import shutil
import random
Filted=[
    "巫妖王",  # 阿尔萨斯
    "希尔瓦娜斯·风行者",
    "伊利丹·怒风",
    "萨尔",
    "吉安娜·普罗德摩尔",
    "死亡之翼",
    "乌瑟尔·光明使者",
    "拉格纳罗斯",
    "阿克蒙德",
    "玛法里奥·怒风",
    "凯恩·血蹄",
    "瓦里安·乌瑞恩",
    "加尔鲁什·地狱咆哮",
    "泰兰德·语风",
    "古尔丹",
    "雷克萨",
    "麦迪文",
    "火车王里诺艾",  # 玩家文化梗
    "霍格",
    "米尔豪斯·法力风暴",
    "布莱恩·铜须",
    "老瞎眼",
    "光明之翼",
    "格罗玛什·地狱咆哮",
    "迪亚波罗",  # 暗黑破坏神联动
    "克尔苏加德",
    "奥妮克希亚",
    "奈法利安",
    "瓦丝琪女士",
    "迦顿男爵",
    "范达尔·雷矛",
    "德雷克塔尔",
    "大检察官怀特迈恩",
    "暴龙王克鲁什",
    "艾萨拉女王",
    "卡德加",
    "沃金",
    "提里奥·弗丁",
    "伊瑟拉",
    "阿莱克丝塔萨",
    "血骨傀儡",
    "玉珑",
    "砮皂",
    "雪怒",
    "滑矛领主",
    "重拳先生",
    "海盗帕奇斯",
    "芬利爵士",
    "奔波尔霸",
    "厨师曲奇",
    "钩牙船长",
    "变装大师",
    "阿尔福斯",
    "深水领主卡拉瑟雷斯",
    "安东尼达斯",
    "巴琳达·斯通赫尔斯",
    "加尔范上尉",
    "拉希奥",
    "希奈丝特拉",
    "珑心",
    "玛克扎尔王子",
    "尼尔鲁·火刃",
    "卡斯迪诺夫教授",
    "奈姆希·灵沼",
    "莱欧洛克斯",
    "比格沃斯先生",
    "苔丝·格雷迈恩",
    "邦桑迪",
    "吉恩·格雷迈恩",
    "莉莉安·沃斯",
    "高弗雷勋爵",
    "血怒者科尔拉克"
]

cost_1 = [  # 次要功能性角色或低阶精英
    "滑矛领主", "重拳先生", "海盗帕奇斯", "砮皂", 
    "暴龙王克鲁什", "希奈丝特拉", "珑心", "玛克扎尔王子",
    "尼尔鲁·火刃", "卡斯迪诺夫教授", "奈姆希·灵沼", 
    "莱欧洛克斯", "比格沃斯先生"
]

cost_2 = [  # 文化符号或中阶副本BOSS
    "老瞎眼", "迪亚波罗", "奔波尔霸", "芬利爵士",
    "厨师曲奇", "钩牙船长", "变装大师", "阿尔福斯",
    "深水领主卡拉瑟雷斯", "安东尼达斯", 
    "巴琳达·斯通赫尔斯", "加尔范上尉", "拉希奥"
]

cost_3 = [  # 高人气支线领袖/高阶副本BOSS
    "雷克萨", "卡德加", "光明之翼", "米尔豪斯·法力风暴",
    "火车王里诺艾", "霍格", "大检察官怀特迈恩",
    "范达尔·雷矛", "德雷克塔尔", "迦顿男爵", 
    "血骨傀儡", "玉珑", "雪怒"
]

cost_4 = [  # 阵营领袖/团队副本核心BOSS
    "玛法里奥·怒风", "泰兰德·语风", "瓦里安·乌瑞恩",
    "加尔鲁什·地狱咆哮", "奥妮克希亚", "艾萨拉女王",
    "格罗玛什·地狱咆哮", "麦迪文", "布莱恩·铜须",
    "提里奥·弗丁", "伊瑟拉", "阿莱克丝塔萨", "沃金"
]

cost_5 = [  # 灭世级反派/守护巨龙/阵营至高领袖
    "巫妖王", "死亡之翼", "阿克蒙德", "拉格纳罗斯",
    "古尔丹", "伊利丹·怒风", "克尔苏加德", "奈法利安"
]

character_stats = {
    # 5费：灭世级战力（攻击5-6，生命14-15）
    "巫妖王": [6, 15],         # 冰霜属性，高攻高血[1,5](@ref)
    "死亡之翼": [6, 14],       # 黑龙王，高攻但护甲破损[1](@ref)
    "阿克蒙德": [5, 15],       # 燃烧军团统帅，均衡型[1](@ref)
    "拉格纳罗斯": [6, 13],     # 火元素领主，极端攻击[2](@ref)
    "古尔丹": [5, 14],         # 术士，生命汲取特性[4](@ref)
    "伊利丹·怒风": [6, 12],   # 恶魔猎手，高攻低防[5](@ref)
    "克尔苏加德": [5, 13],     # 巫妖，法术型防御[1](@ref)
    "奈法利安": [5, 14],       # 黑龙王子，均衡型[2](@ref)

    # 4费：阵营核心战力（攻击4-5，生命12-14）
    "玛法里奥·怒风": [4, 14], # 德鲁伊，防御型[5](@ref)
    "泰兰德·语风": [4, 13],   # 月神祭司，治疗特性[5](@ref)
    "瓦里安·乌瑞恩": [5, 12],# 战士，人类血防较低[7](@ref)
    "加尔鲁什·地狱咆哮": [5,13],# 狂暴战，高攻[4](@ref)
    "奥妮克希亚": [5, 12],     # 黑龙，喷吐攻击[2](@ref)
    "艾萨拉女王": [4, 14],     # 法系，高生命[8](@ref)
    "格罗玛什·地狱咆哮": [5,11],# 兽人战士，高攻[4](@ref)
    "麦迪文": [4, 13],         # 法师，均衡[3](@ref)
    "布莱恩·铜须": [4, 12],   # 矮人，防御型[6](@ref)
    "提里奥·弗丁": [4, 14],   # 圣骑士，高防[5](@ref)
    "伊瑟拉": [4, 15],         # 绿龙，生命恢复特性[5](@ref)
    "阿莱克丝塔萨": [4, 14],   # 红龙女王，治疗向[5](@ref)
    "沃金": [4, 12],           # 巨魔，均衡[4](@ref)

    # 3费：标志性支线战力（攻击3-4，生命10-12）
    "雷克萨": [4, 11],         # 兽王猎人，野兽加成[4](@ref)
    "卡德加": [3, 12],         # 法师，法术型[3](@ref)
    "光明之翼": [3, 10],       # 精灵龙，低血高敏[8](@ref)
    "米尔豪斯·法力风暴": [2,10],# 侏儒法师，脆皮[6](@ref)
    "火车王里诺艾": [4, 9],    # 人类，爆发型低防[1](@ref)
    "霍格": [3, 13],           # 野兽，高血中攻[7](@ref)
    "大检察官怀特迈恩": [2,14],# 牧师，治疗向[5](@ref)
    "范达尔·雷矛": [3, 11],   # 矮人战士，均衡[6](@ref)
    "德雷克塔尔": [3, 12],     # 萨满，元素加成[4](@ref)
    "迦顿男爵": [4, 10],       # 火元素，高攻[2](@ref)
    "血骨傀儡": [3, 15],       # 亡灵，极端高血[5](@ref)
    "玉珑": [3, 12],           # 青龙天神，均衡[8](@ref)
    "雪怒": [4, 11],           # 白虎天神，高攻[8](@ref)

    # 2费：文化符号与功能性（攻击2-3，生命9-11）
    "老瞎眼": [3, 10],         # 鱼人，野兽高攻[7](@ref)
    "迪亚波罗": [3, 9],        # 恶魔，联动角色[8](@ref)
    "奔波尔霸": [2, 11],       # 鱼人，生存型[7](@ref)
    "芬利爵士": [2, 10],       # 鱼人，探险家[7](@ref)
    "厨师曲奇": [1, 12],       # 地精，辅助型[6](@ref)
    "钩牙船长": [3, 9],        # 海盗，爆发型[7](@ref)
    "变装大师": [2, 10],       # 特殊机制角色[8](@ref)
    "阿尔福斯": [1, 11],       # 通灵学员，脆皮[1](@ref)
    "深水领主卡拉瑟雷斯": [3, 10],
    "安东尼达斯": [2, 10],     # 老年法师[3](@ref)
    "巴琳达·斯通赫尔斯": [2,9],# 人类法师[7](@ref)
    "加尔范上尉": [3, 9],      # 兽人战士[4](@ref)
    "拉希奥": [3, 10],         # 黑龙王子，青年期[8](@ref)

    # 1费：边缘功能性（攻击0-2，生命8-10）
    "滑矛领主": [1, 9],        # 鱼人，低威胁[7](@ref)
    "重拳先生": [2, 8],        # 地精，爆发型[6](@ref)
    "海盗帕奇斯": [1, 8],      # 微型角色[7](@ref)
    "砮皂": [0, 10],           # 圣物，纯防御[8](@ref)
    "暴龙王克鲁什": [2, 9],    # 幼年暴龙[8](@ref)
    "希奈丝特拉": [1, 10],     # 黑龙，衰老期[1](@ref)
    "珑心": [0, 9],            # 熊猫人，非战斗型[8](@ref)
    "玛克扎尔王子": [2, 8],    # 次级恶魔[5](@ref)
    "尼尔鲁·火刃": [1, 9],    # 低阶术士[4](@ref)
    "卡斯迪诺夫教授": [0,10],  # 学者，无攻击[8](@ref)
    "奈姆希·灵沼": [1, 8],    # 亡灵学徒[5](@ref)
    "莱欧洛克斯": [2, 8],      # 巨魔猎手[4](@ref)
    "比格沃斯先生": [0, 8]     # 宠物猫[1](@ref)
}

from enum import Enum

# 精选的13个核心种族（名称与C#枚举完全对齐）
class RaceType(Enum):
    Beast = 1
    Demon = 2
    Dragon = 3
    Elemental = 4
    Human = 5
    Murloc = 7
    Naga = 8
    Nightelf = 9
    Orc = 10
    Undead = 14
    Troll = 21
    Dwarf = 28
    Goblin = 29
    Celestial = 27  # 天神单独归类
    Pandaren = 26   # 熊猫人（仅珑心使用）

# 角色种族字典（60个角色全覆盖）
character_race = {
    # 5费
    "巫妖王": RaceType.Undead,
    "死亡之翼": RaceType.Dragon,
    "阿克蒙德": RaceType.Demon,
    "拉格纳罗斯": RaceType.Elemental,
    "古尔丹": RaceType.Demon,
    "伊利丹·怒风": RaceType.Demon,
    "克尔苏加德": RaceType.Undead,
    "奈法利安": RaceType.Dragon,

    # 4费
    "玛法里奥·怒风": RaceType.Nightelf,
    "泰兰德·语风": RaceType.Nightelf,
    "瓦里安·乌瑞恩": RaceType.Human,
    "加尔鲁什·地狱咆哮": RaceType.Orc,
    "奥妮克希亚": RaceType.Dragon,
    "艾萨拉女王": RaceType.Naga,
    "格罗玛什·地狱咆哮": RaceType.Orc,
    "麦迪文": RaceType.Human,
    "布莱恩·铜须": RaceType.Dwarf,
    "提里奥·弗丁": RaceType.Human,
    "伊瑟拉": RaceType.Dragon,
    "阿莱克丝塔萨": RaceType.Dragon,
    "沃金": RaceType.Troll,

    # 3费
    "雷克萨": RaceType.Orc,
    "卡德加": RaceType.Human,
    "光明之翼": RaceType.Dragon,
    "米尔豪斯·法力风暴": RaceType.Goblin,  # 侏儒归为Goblin（根据C#枚举定义）
    "火车王里诺艾": RaceType.Human,
    "霍格": RaceType.Beast,
    "大检察官怀特迈恩": RaceType.Human,
    "范达尔·雷矛": RaceType.Dwarf,
    "德雷克塔尔": RaceType.Orc,
    "迦顿男爵": RaceType.Elemental,
    "血骨傀儡": RaceType.Undead,
    "玉珑": RaceType.Celestial,
    "雪怒": RaceType.Celestial,

    # 2费
    "老瞎眼": RaceType.Murloc,
    "迪亚波罗": RaceType.Demon,
    "奔波尔霸": RaceType.Murloc,
    "芬利爵士": RaceType.Murloc,
    "厨师曲奇": RaceType.Murloc,
    "钩牙船长": RaceType.Troll,
    "变装大师": RaceType.Orc,
    "阿尔福斯": RaceType.Undead,
    "深水领主卡拉瑟雷斯": RaceType.Naga,
    "安东尼达斯": RaceType.Human,
    "巴琳达·斯通赫尔斯": RaceType.Human,
    "加尔范上尉": RaceType.Orc,
    "拉希奥": RaceType.Dragon,

    # 1费
    "滑矛领主": RaceType.Naga,
    "重拳先生": RaceType.Orc,
    "海盗帕奇斯": RaceType.Demon,
    "砮皂": RaceType.Celestial,
    "暴龙王克鲁什": RaceType.Beast,
    "希奈丝特拉": RaceType.Dragon,
    "珑心": RaceType.Pandaren,
    "玛克扎尔王子": RaceType.Demon,
    "尼尔鲁·火刃": RaceType.Orc,
    "卡斯迪诺夫教授": RaceType.Human,
    "奈姆希·灵沼": RaceType.Undead,
    "莱欧洛克斯": RaceType.Troll,
    "比格沃斯先生": RaceType.Beast
}

# 验证总数
print(len(character_race))  # 输出应为60

from enum import Enum

class ClassType(Enum):
    DeathKnight = 1    # 死亡骑士
    DemonHunter = 2    # 恶魔猎手
    Druid = 3          # 德鲁伊
    Hunter = 4         # 猎人
    Mage = 5           # 法师
    Paladin = 6        # 圣骑士
    Priest = 7         # 牧师
    Rogue = 8          # 潜行者
    Shaman = 9         # 萨满
    Warlock = 10       # 术士
    Warrior = 11       # 战士
    Monk = 12          # 武僧

# 角色职业字典（覆盖全部60个角色）
character_class = {
    # 5费
    "巫妖王": ClassType.DeathKnight,       # 死亡骑士领袖[8](@ref)
    "死亡之翼": ClassType.Warlock,         # 堕落黑龙（暗影烈焰施法者）[4](@ref)
    "阿克蒙德": ClassType.Warlock,        # 燃烧军团术士统帅[8](@ref)
    "拉格纳罗斯": ClassType.Shaman,       # 火元素领主（元素操控）[6](@ref)
    "古尔丹": ClassType.Warlock,          # 术士[4](@ref)
    "伊利丹·怒风": ClassType.DemonHunter, # 恶魔猎手[8](@ref)
    "克尔苏加德": ClassType.DeathKnight,  # 巫妖（死亡骑士变体）[8](@ref)
    "奈法利安": ClassType.Warlock,        # 黑龙术士[4](@ref)

    # 4费
    "玛法里奥·怒风": ClassType.Druid,    # 德鲁伊[4](@ref)
    "泰兰德·语风": ClassType.Priest,     # 月神牧师[8](@ref)
    "瓦里安·乌瑞恩": ClassType.Warrior,  # 战士[4](@ref)
    "加尔鲁什·地狱咆哮": ClassType.Warrior, # 战士[4](@ref)
    "奥妮克希亚": ClassType.Warlock,      # 黑龙（龙息术士）[4](@ref)
    "艾萨拉女王": ClassType.Mage,         # 法师（永恒之井施法者）[4](@ref)
    "格罗玛什·地狱咆哮": ClassType.Warrior, # 战士[4](@ref)
    "麦迪文": ClassType.Mage,            # 大法师[4](@ref)
    "布莱恩·铜须": ClassType.Warrior,    # 战士（探险家）[4](@ref)
    "提里奥·弗丁": ClassType.Paladin,    # 圣骑士[8](@ref)
    "伊瑟拉": ClassType.Druid,           # 绿龙（梦境守护者）[6](@ref)
    "阿莱克丝塔萨": ClassType.Priest,    # 红龙（生命祭司）[8](@ref)
    "沃金": ClassType.Shaman,            # 暗矛部族萨满[6](@ref)

    # 3费
    "雷克萨": ClassType.Hunter,          # 兽王猎人[4](@ref)
    "卡德加": ClassType.Mage,            # 法师[4](@ref)
    "光明之翼": ClassType.Mage,          # 精灵龙（魔法生物）[4](@ref)
    "米尔豪斯·法力风暴": ClassType.Mage, # 法师[4](@ref)
    "火车王里诺艾": ClassType.Rogue,     # 潜行者（文化梗）[4](@ref)
    "霍格": ClassType.Hunter,            # 野兽（猎人宠物类）[4](@ref)
    "大检察官怀特迈恩": ClassType.Priest, # 牧师[8](@ref)
    "范达尔·雷矛": ClassType.Warrior,    # 战士[4](@ref)
    "德雷克塔尔": ClassType.Shaman,      # 萨满[6](@ref)
    "迦顿男爵": ClassType.Warlock,       # 火元素（术士召唤物逻辑）[4](@ref)
    "血骨傀儡": ClassType.DeathKnight,   # 亡灵构造体[8](@ref)
    "玉珑": ClassType.Monk,              # 天神（武僧精神导师）[6](@ref)
    "雪怒": ClassType.Monk,              # 白虎（武僧战斗风格）[6](@ref)

    # 2费
    "老瞎眼": ClassType.Hunter,          # 鱼人（猎人宠物逻辑）[4](@ref)
    "迪亚波罗": ClassType.Warlock,       # 恶魔（术士召唤物）[4](@ref)
    "奔波尔霸": ClassType.Rogue,         # 鱼人（潜行特性）[8](@ref)
    "芬利爵士": ClassType.Paladin,       # 圣骑士（探险精神）[8](@ref)
    "厨师曲奇": ClassType.Monk,          # 烹饪（武僧生活职业延伸）[6](@ref)
    "钩牙船长": ClassType.Rogue,         # 海盗（潜行者特性）[8](@ref)
    "变装大师": ClassType.Rogue,         # 潜行者[8](@ref)
    "阿尔福斯": ClassType.Warlock,       # 通灵学院术士[4](@ref)
    "深水领主卡拉瑟雷斯": ClassType.Shaman, # 娜迦萨满[6](@ref)
    "安东尼达斯": ClassType.Mage,        # 法师[4](@ref)
    "巴琳达·斯通赫尔斯": ClassType.Mage, # 法师[4](@ref)
    "加尔范上尉": ClassType.Warrior,     # 战士[4](@ref)
    "拉希奥": ClassType.Rogue,           # 人形态黑龙（潜行伪装）[8](@ref)

    # 1费
    "滑矛领主": ClassType.Hunter,        # 鱼人（猎人向）[4](@ref)
    "重拳先生": ClassType.Warrior,       # 地精战士[4](@ref)
    "海盗帕奇斯": ClassType.Rogue,       # 潜行者[8](@ref)
    "砮皂": ClassType.Paladin,           # 圣物（圣骑士精神象征）[8](@ref)
    "暴龙王克鲁什": ClassType.Hunter,    # 野兽（猎人宠物）[4](@ref)
    "希奈丝特拉": ClassType.Warlock,     # 黑龙术士[4](@ref)
    "珑心": ClassType.Monk,              # 熊猫人武僧[6](@ref)
    "玛克扎尔王子": ClassType.Warlock,  # 恶魔术士[4](@ref)
    "尼尔鲁·火刃": ClassType.Warlock,   # 术士[4](@ref)
    "卡斯迪诺夫教授": ClassType.Mage,   # 学者（法师变体）[4](@ref)
    "奈姆希·灵沼": ClassType.Warlock,  # 通灵学徒[4](@ref)
    "莱欧洛克斯": ClassType.Hunter,     # 巨魔猎人[4](@ref)
    "比格沃斯先生": ClassType.Hunter    # 宠物猫（猎人逻辑）[4](@ref)
}

# 验证总数
print(len(character_class))  # 输出应为60
class Sol:
	def __init__(self):
		self.ScriptNames=[]
		self.HSID=[]
		self.ConvertedHS=[]				

        
	#13 13 13 13 8
	def GetMinionDict(self,DbfId,m_noteMiniGuid,CnName,ManaCost,lv):
		#print(len(Filted))
		rc = character_race[CnName].value
		cl = character_class[CnName].value

		atk=character_stats[CnName][0]
		hp=character_stats[CnName][1]

		pair=[atk,hp]
		if(lv==1):
			atk=pair[0]
			hp=pair[1]
			des ="<b>技能：</b>对一个随机敌方随从造成3点伤害。"
		if(lv==2):
			atk=pair[0]*2
			hp=pair[1]*2
			des ="<b>技能：</b>对一个随机敌方随从造成6点伤害。"
		if(lv==3):
			atk=pair[0]*4
			hp=pair[1]*4
			des ="<b>技能：</b>对一个随机敌方随从造成12点伤害。"

		dic={
        "DbfId": DbfId,
        "m_noteMiniGuid": m_noteMiniGuid,
        "Classes":[cl],
        "CnName": CnName,
        "ScriptName": "CORE_CS2_024",
        "CardType": 0,
        "RareType": 4,
        "RaceType": [rc],
        "ManaCost": ManaCost,
        "Attack": atk,
        "MaxHealth": hp,
        "Description": des
		}
		return dic

	def ToJson(self):
		for n in cost_5:
			if(n not in self.Names):
				print(n)
		data = []

		ManaPool=[]

		for i in range(13):
			ManaPool.append(1)
			ManaPool.append(2)
			ManaPool.append(3)
			ManaPool.append(4)
		for i in range(8):
			ManaPool.append(5)



		for n in cost_1:
			i = self.Names.index(n)
			data.append(self.GetMinionDict(self.ID1s[i],self.Note1s[i],self.Names[i],1,1))
			data.append(self.GetMinionDict(self.ID2s[i],self.Note2s[i],self.Names[i],1,2))
			data.append(self.GetMinionDict(self.ID3s[i],self.Note3s[i],self.Names[i],1,3))			

		for n in cost_2:
			i = self.Names.index(n)
			data.append(self.GetMinionDict(self.ID1s[i],self.Note1s[i],self.Names[i],2,1))
			data.append(self.GetMinionDict(self.ID2s[i],self.Note2s[i],self.Names[i],2,2))
			data.append(self.GetMinionDict(self.ID3s[i],self.Note3s[i],self.Names[i],2,3))	

		for n in cost_3:
			i = self.Names.index(n)
			data.append(self.GetMinionDict(self.ID1s[i],self.Note1s[i],self.Names[i],3,1))
			data.append(self.GetMinionDict(self.ID2s[i],self.Note2s[i],self.Names[i],3,2))
			data.append(self.GetMinionDict(self.ID3s[i],self.Note3s[i],self.Names[i],3,3))	

		for n in cost_4:
			i = self.Names.index(n)
			data.append(self.GetMinionDict(self.ID1s[i],self.Note1s[i],self.Names[i],4,1))
			data.append(self.GetMinionDict(self.ID2s[i],self.Note2s[i],self.Names[i],4,2))
			data.append(self.GetMinionDict(self.ID3s[i],self.Note3s[i],self.Names[i],4,3))	

		for n in cost_5:
			i = self.Names.index(n)
			data.append(self.GetMinionDict(self.ID1s[i],self.Note1s[i],self.Names[i],5,1))
			data.append(self.GetMinionDict(self.ID2s[i],self.Note2s[i],self.Names[i],5,2))
			data.append(self.GetMinionDict(self.ID3s[i],self.Note3s[i],self.Names[i],5,3))	
	
		with open("out/test.json","w",encoding="utf-8") as file:
			json.dump(data,file,ensure_ascii=False)

	def CheckRes(self):
		self.Names=[]
		self.ID1s=[]
		self.Note1s=[]
		self.ID2s=[]
		self.Note2s=[]
		self.ID3s=[]
		self.Note3s=[]


		for i in range(len(self.NamesLv1)):
			name = self.NamesLv1[i]

			id1=self.IDsLv1[i]
			no1=self.NotesLv1[i]

			id2=-1
			no2=""
			id3=-1
			no3=""

			Found2=False
			Found3=False
			for j in range(len(self.NamesLv2)):
				if(self.NotesLv2[j]==no1.replace("H_01","H_02")):
					id2=self.IDsLv2[j]
					no2=self.NotesLv2[j]
					Found2=True
					break

			for j in range(len(self.NamesLv3)):
				if(self.NotesLv3[j]==no1.replace("H_01","H_03")):
					id3=self.IDsLv3[j]
					no3=self.NotesLv3[j]
					Found3=True
					break

			if(Found2 and Found3):
				self.Names.append(name)
				self.ID1s.append(id1)
				self.Note1s.append(no1)					
				self.ID2s.append(id2)
				self.Note2s.append(no2)
				self.ID3s.append(id3)
				self.Note3s.append(no3)

		print(len(self.Names))


	def GetAllHSID(self):
		with open("D:/DocFile/Unity3dRef/Extract/MonoBehaviour_Important/CARD.json",encoding='utf-8') as file:
			data = json.load(file)
		#
		self.NamesLv1=[]
		self.IDsLv1=[]
		self.NotesLv1=[]

		self.NamesLv2=[]
		self.IDsLv2=[]
		self.NotesLv2=[]

		self.NamesLv3=[]
		self.IDsLv3=[]
		self.NotesLv3=[]

		for d in data["Records"]:
			m_ID=d["m_ID"]
			m_noteMiniGuid = d["m_noteMiniGuid"]
			m_name = d["m_name"]["m_locValues"][-2]

			if("H_01" in m_noteMiniGuid):
				self.NamesLv1.append(m_name)
				self.IDsLv1.append(m_ID)
				self.NotesLv1.append(m_noteMiniGuid)
			if("H_02" in m_noteMiniGuid):
				self.NamesLv2.append(m_name)
				self.IDsLv2.append(m_ID)
				self.NotesLv2.append(m_noteMiniGuid)
			if("H_03" in m_noteMiniGuid):
				self.NamesLv3.append(m_name)
				self.IDsLv3.append(m_ID)
				self.NotesLv3.append(m_noteMiniGuid)	

		print(len(self.NamesLv1))
		print(len(self.NamesLv2))
		print(len(self.NotesLv3))
		self.CheckRes()
		self.ToJson()

					
So=Sol()
So.GetAllHSID()
