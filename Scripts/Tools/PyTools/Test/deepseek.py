from openai import OpenAI
#import mimetypes
#import base64

client = OpenAI(api_key="sk-9ced44952b564ef2b185a28a419723d6", base_url="https://api.deepseek.com")


li=["蛊雕","白虎","玄武","朱雀","梼杌","水麒麟","獬豸","横公鱼","狴犴","英招","当康","赤鱬","灭蒙鸟",
"天狐","赤眼猪妖","当扈","青鸟","比翼鸟","角端","陆吾","鸣蛇","钩蛇","天马","朱厌","诸怀","兕","飞廉","三足乌","祸斗","诸犍","鲲鹏",
"蜚","独角兽","夫诸","凿齿","九婴","乘黄","猰貐","巴蛇","陵鱼","雷神","屏蓬","火光兽","鱼妇","九凤","化蛇","相柳",
"狍鸮","犀渠","山膏","耳鼠","何罗鱼","犼","长右","羬羊",]


ans = []
for l in li:
    response = client.chat.completions.create(
        model="deepseek-reasoner",
        messages=[
            {"role": "system", "content": "You are a helpful assistant with web access"},
            {"role": "user", "content": "用不超过40个英文单词描述《山海经》中“"+l+"”的插画，要有细节和想象。"},
        ],
        stream=False,
        extra_body={
            "web_search": True  # 3. 启用联网搜索参数
        }
    )

    r = response.choices[0].message.content

    print(r)

    ans.append(r)


res = ""

for a in ans:
    res+=a+"\n"

with open("ans.txt","w") as opt:
    opt.write(res)