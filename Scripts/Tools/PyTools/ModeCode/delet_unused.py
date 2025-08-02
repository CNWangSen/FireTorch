import requests
import time
import json
import os
import random


class GetHS:
	def __init__(self):
		pass
	def download(self,url,filepath):
		response = requests.get(url)
		with open(filepath, 'wb') as f:
			f.write(response.content)	
		time.sleep(0.1)#1+random.random())
	def downloadJson(self):
		self.download("https://api.hearthstonejson.com/v1/latest/zhCN/cards.json","Jsons/CardDB_zhCN_all.json")
		self.download("https://api.hearthstonejson.com/v1/latest/enUS/cards.json","Jsons/CardDB_enUS_all.json")
		#self.download("https://api.hearthstonejson.com/v1/latest/zhCN/cards.collectible.json","Jsons/CardDB_zhCN.json")
		#self.download("https://api.hearthstonejson.com/v1/latest/enUS/cards.collectible.json","Jsons/CardDB_enUS.json")
	



	def derepeat(self):
		base1='D:/Projects/UnityProj/CusCCG/Assets/Resources/Cards/ICECROWN/'
		base2='D:/Projects/UnityProj/CusCCG/Assets/Resources/Cards/ALTERAC_VALLEY/'
		Majors=[]
		for p in os.listdir(base1):
			if('.meta' not in p):
				Majors.append(p)
		for maj in Majors:
			icc=base1+maj
			alt=base2+maj
			iccs=os.listdir(icc)
			for f in os.listdir(alt):
				#print()
				if(f in iccs):
					os.remove(alt+'/'+f)
		#print(os.listdir(base1))

	def readjson(self):
		base='D:/Projects/UnityProj/CusCCG/Assets/Scripts/PlayGame/Server/Ability/Sets/'
		for root,direct,files in os.walk(base):
			for filename in files:
				if('.meta' not in filename) and ('CORE' in root or 'EXPERT1' in root or 'LEGACY' in root):
					filepath = os.path.join(root,filename)
					#print(filepath)
					with open(filepath,'r',encoding='utf-8') as ipt:
						data=ipt.readlines()
					#newdata='using System.Collections;\nusing System.Collections.Generic;\n\n'
					classdef = []
					#description = []
					for i in range(len(data)):
						l=data[i]
						if('class' in l):
							classdef.append(l)
							description.append(data[i-1])
							newdata+='//----------------------------------------------------------------------\n'
							newdata+=data[i-1]
							newdata+=data[i]
							newdata+='{\n'
							newdata+=self.getCodeForDesc(data[i],data[i-1])
							newdata+='}\n'
	def countAll(self):
		base='D:/Projects/UnityProj/CusCCG/Assets/StreamingAssets/Cards/'
		paths=[]
		repeatPath=[]
		repeat=[]
		for root,direct,files in os.walk(base):
			for f in files:
				if('.meta' not in f):
					if(f not in paths):		
						paths.append(f)
					else:
						if(root not in repeatPath):
							repeatPath.append(root)
						filepath = os.path.join(root,f)
						repeat.append(filepath)
						print(filepath)

		
		for p in repeat:
			os.remove(p)
		#print(repeatPath)
		print(len(paths),len(repeat))
So=GetHS()
#So.downloadJson()
#So.readjson()
#So.derepeat()
So.countAll()