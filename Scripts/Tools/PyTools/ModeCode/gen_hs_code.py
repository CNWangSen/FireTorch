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
	



	def readjson(self):
		base='D:/Projects/UnityProj/CusCCG/Assets/Scripts/PlayGame/Server/Ability/Sets/'
		for root,direct,files in os.walk(base):
			for filename in files:
				if('.meta' not in filename) and ('ADIY' not in root):
					filepath = os.path.join(root,filename)
					#print(filepath)
					with open(filepath,'r',encoding='utf-8') as ipt:
						data=ipt.readlines()
					newdata='using System.Collections;\nusing System.Collections.Generic;\n\n'
					classdef = []
					description = []
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
					if(len(classdef)!=len(description)):
						print(filepath,len(classdef),len(description))
					else:
						with open(filepath,'w',encoding='utf-8') as opt:
							opt.write(newdata)
				
	def getCodeForDesc(self,name,desc):
		return ''

		#with open()
		'''
		with open("Jsons/CardDB_zhCN_all.json",encoding='utf-8') as file:
			data=json.load(file)
		filename=pathname2+d["name"].replace(",","").replace("?","").replace("!","").replace(".","").replace("-","").replace("(","").replace(")","").replace(" ","").replace("'","").replace(":","")+".jpg"
		



		for i in range(len(data)):

			if i<0:
				continue

			d=data[i]
			if('collectible' in data[i]):
				continue

			try:
				pathname1="Images/"+d["set"]+"/"
				pathname2="Images/"+d["set"]+"/"+d["cardClass"]+"/"
			except:
				continue
			try:
				os.mkdir(pathname1)
			except:
				pass
			try:
				os.mkdir(pathname2)
			except:
				pass

			try:
				
				imgurl="https://art.hearthstonejson.com/v1/512x/"+d["id"]+".jpg"
				
			except:
				print(filename,imgurl)
				continue

			self.download(imgurl,filename)
			print(i,filename)
			'''

So=GetHS()
#So.downloadJson()
So.readjson()