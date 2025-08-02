import os

base="D:/Projects/unity/CusCCG/Assets/Scripts/PlayGame/Server/Ability/Sets/"

ToMod={"AT_005t":"Boar"}

for r,d,f in os.walk(base):
	for c in f:
		if(('.meta' not in c) and ('.cs' in c)):
			fp=r+'/'+c
			print(fp)

			with open(fp,'r',encoding='utf-8') as ipt:
				dat=ipt.read()
			print(dat)
			for k in ToMod.keys():
				if(ToMod[k]!=""):
					dat=dat.replace(k,ToMod[k])
			print(dat)
			with open(fp,'w',encoding='utf-8') as opt:
				opt.write(dat)