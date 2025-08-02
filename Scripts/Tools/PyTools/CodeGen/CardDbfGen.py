import json
import chardet

path = '//DESKTOP-7NQUQQQ/FireTorch2/Assets/Resources/ServerData/BGS/NonCollectibleCards_BGS_Minion.json'
new_path = '//DESKTOP-7NQUQQQ/FireTorch2/Assets/Resources/ServerData/BGS/NonCollectibleCards_BGS_Minion_Season01.json'
with open(path,'rb') as f:
    raw_data=f.read()
    result = chardet.detect(raw_data)
    encoding = result['encoding']

with open(path, 'r',encoding=encoding) as fcc_file:
    st = fcc_file.read()

raw_data = json.loads(st)
new_data = []


name=[
"正义保护者-1","无私的英雄-1","恩佐斯的子嗣-2","梦魇融合怪-2",
"人气选手-3","方阵指挥官-3","始祖龟执盾者-3","百变泽鲁斯-3","卡德加-3","腐树巨人-4","展览馆法师-4","浴火者伯瓦尔-4","阿古斯防御者-4",
"布莱恩·铜须-5","光牙执行者-5","波戈蒙斯塔-5","硬壳清道夫-5","瑞文戴尔男爵-5","扎普·斯里维克-6",

"雄斑虎-1","恐狼前锋-1","瘟疫鼠群-2","慈祥的外婆-2","食腐土狼-2","骑乘迅猛龙-2",
"族群领袖-3","寄生恶狼-3","驯兽师-3","洞穴多头蛇-4","兔妖教头-4","比斯巨兽-4",
"长鬃草原狮-5","臃肿的蛇颈龙-5","铁皮恐角龙-5","巨狼戈德林-5","熊妈妈-6","阴森巨蟒-6","迈克斯纳-6",

"机械袋鼠-1","微型战斗机甲-1","麦田傀儡-2","吵吵机器人-2","爆爆机器人-2","金刚刃牙兽-2","机械动物管理员-2","蹦蹦兔-2","护盾机器人-2",
"废旧螺栓机甲-3","闹闹机器人-3","量产型恐吓机-3","载人收割机-3","钴制卫士-3","钢铁武道家-4","载人飞天魔像-4","安保巡游者-4","吵吵模组-4","回收机器人-4",
"机械蛋-5","斯尼德的伐木机-6","坎格尔的学徒-6","死神4000型-6",

"粗俗的矮劣魔-1","愤怒编织者-1","虚空行者-1","纳斯雷兹姆监工-2",
"小鬼首领-3","魔瘾结晶者-3","灵魂杂耍者-3","攻城恶魔-4",
"玛尔加尼斯-5","安尼赫兰战场军官-5","虚空领主-6",

"鱼人猎潮者-1","鱼人招潮者-1","石塘猎人-1","鱼人领军-2","老瞎眼-2",
"寒光先知-3","毒鳍鱼人-4",
"蛮鱼斥候-5","温顺的巨壳龙-6"
]



#print(len(name))

rawids=[]

for i in range(len(name)):
    n,t = name[i].split("-")
    rawid = ""
    for d in raw_data:
        if(d["CnName"] == n):
            nid = d["m_noteMiniGuid"]

            if("TB_BaconUps" not in nid and nid[-2:-1]!="_G"):
                rawid=nid
                rawids.append(nid)
    if(rawid==""):
        print("rawid not find! "+n)

    cnt=0
    for d in raw_data:
        if(d["CnName"] == n):
            if(d["m_noteMiniGuid"]!=rawid):
                if("TB_BaconUps" in nid or nid[-2:-1]=="_G"):
                    d["m_noteMiniGuid"]=rawid+"_G"
            d["ManaCost"] = int(t)
            new_data.append(d)
            cnt+=1
    if(cnt!=2):
        print(cnt,n)

print(rawids)        
#print(new_data)

#with open(new_path, "w",encoding='utf-8') as file:
#    json.dump(new_data, file,ensure_ascii=False)



'''
Unimpl
BGS_031 温顺的巨壳龙
BGS_029 百变泽鲁斯
BG_DAL_575 卡德加
EX1_162 恐狼前锋
磁力BG_BOT_911 BG_BOT_312

'''


