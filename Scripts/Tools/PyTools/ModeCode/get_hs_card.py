import requests
import time
import json
import os
import random
import copy

class CardDbf:
	def __init__(self,dbfId=0,setId=0,cnName="",enName="",cardType=4,rareType=0,raceType=[],manaCost=0,attack=0,maxHealth=0,targets=0,classes=[],desc=""):
		self.DbfId=dbfId
		self.SetId=setId
		self.CnName=cnName
		self.ScriptName=enName
		self.RareType=rareType
		self.Targets=targets
		self.Description=desc
		self.ManaCost=manaCost

		self.Classes=classes

		self.CardType=cardType
		self.RaceType=raceType
		self.Attack=attack
		self.MaxHealth=maxHealth

		self.enDescription=""



class GetHS:
	def __init__(self):
		self.ClassList=["NEUTRAL","DEATHKNIGHT","DEMONHUNTER","DRUID","HUNTER","MAGE","PALADIN","PRIEST","ROGUE","SHAMAN","WARLOCK","WARRIOR"]
		self.CardTypeList=["MINION","SPELL","WEAPON","HERO","HEROPOWER","SECRET","LOCATION"]
		self.CardBaseList=["MinionBase","SpellBase","WeaponBase","HeroBase","HeroPowerBase","SecretBase","LocationBase"]
		self.RareTypeList=["FREE","COMMON","RARE","EPIC","LEGENDARY"]
		self.RaceTypeList=["ALL","BEAST","DEMON","DRAGON","ELEMENTAL","HUMAN","MECHANICAL","MURLOC","NAGA","NIGHTELF","ORC","PIRATE","QUILBOAR","TOTEM","UNDEAD","ARCANE","FEL","FIRE","FROST","HOLY","NATURE","SHADOW"]
		self.ToGen=[]
	def download(self,url,filepath):
		response = requests.get(url)
		with open(filepath, 'wb') as f:
			f.write(response.content)	
		time.sleep(0.1)#+random.random())
	def downloadJson(self):
		#self.download("https://api.hearthstonejson.com/v1/latest/zhCN/cards.json","Jsons/CardDB_zhCN_all.json")
		#self.download("https://api.hearthstonejson.com/v1/latest/enUS/cards.json","Jsons/CardDB_enUS_all.json")
		self.download("https://api.hearthstonejson.com/v1/latest/zhCN/cards.collectible.json","Jsons/CardDB_zhCN.json")
		self.download("https://api.hearthstonejson.com/v1/latest/enUS/cards.collectible.json","Jsons/CardDB_enUS.json")
	

	def genCsharp(self):
		self.genDbf()

		for setname in os.listdir("Images/"):
			try:
				os.mkdir("CSharps/"+setname)
			except:
				pass
			for Majorname in os.listdir("Images/"+setname+"/"):
				MajorCode="using System.Collections;\nusing System.Collections.Generic;\n\n"
				for f in os.listdir("Images/"+setname+"/"+Majorname+"/"):
					scriptName = f.replace(".jpg","")
					dbf=None
					for d in self.ToGen:
						if(d.ScriptName==scriptName):
							dbf=d
							break
					if(dbf!=None):
						MajorCode+="//----------------------------------------------------------------------\n"
						MajorCode+="//"+dbf.enDescription.replace("\n","")+'\n'
						MajorCode+="public class "+dbf.ScriptName+":"+self.CardBaseList[dbf.CardType]+'\n'
						MajorCode+="{\n}\n"
					else:
						print("False")
				with open("CSharps/"+setname+"/"+Majorname+"_"+setname+".cs","w",encoding="utf-8") as opt:
					opt.write(MajorCode)


	def genDbf(self):
		with open("Jsons/CardDB_zhCN.json",encoding='utf-8') as file:
			dataCN=json.load(file)
		with open("Jsons/CardDB_enUS.json",encoding='utf-8') as file:
			data=json.load(file)

		self.ToGen=[]
		for i in range(len(data)):
			if i<0:
				continue
			d=data[i]
			dCN=dataCN[i]
			#if('collectible' not in data[i]):
			#	continue
			try:
				s=d["set"]
			except:
				continue
			if(d["set"]!="ISLAND_VACATION"):
				continue

			scriptname=d["name"].replace(",","").replace("?","").replace("!","").replace(".","").replace("-","").replace("(","").replace(")","").replace(" ","").replace("'","").replace(":","").replace('"','')
			
			dbf=CardDbf(cnName=dCN["name"],enName=scriptname,rareType=self.RareTypeList.index(d["rarity"]),
				classes=[self.ClassList.index(d["cardClass"])],manaCost=d["cost"],desc=dCN["text"],
				)
			dbf.CardType=self.CardTypeList.index(d["type"])
			try:
				dbf.Attack=d["attack"]
			except:
				pass
			try:
				dbf.MaxHealth=d["durability"]
			except:
				pass
			try:
				dbf.MaxHealth=d["health"]
			except:
				pass
			try:
				#print(d["races"])
				dbf.RaceType=[]
				for rc in d["races"]:
					dbf.RaceType.append(self.RaceTypeList.index(rc))
			except:
				pass
			try:
				if(dbf.CardType==1):
					dbf.RaceType=[]
					#print(d["spellSchool"])
					#for rc in d["spellSchool"]:
					dbf.RaceType.append(self.RaceTypeList.index(d["spellSchool"]))
			except:
				pass
			try:
				if("SECRET" in d["mechanics"]):
					print(d["class"])
					dbf.CardType=self.CardTypeList["SECRET"]
			except:
				pass
			dbf.enDescription = d["text"]
			self.ToGen.append(copy.copy(dbf))
	def genJson(self):
		self.genDbf()
		json_data = json.dumps([p.__dict__ for p in self.ToGen],ensure_ascii=False)
		print(json_data)
		with open ('CardsToGen.json','w',encoding='utf-8') as f:
			json.dump([p.__dict__ for p in self.ToGen],f,ensure_ascii=False)



	def readjson(self):
		#41
		#self.downloadJson()
		with open("Jsons/CardDB_enUS.json",encoding='utf-8') as file:
			data=json.load(file)

		for i in range(len(data)):

			if i<5596:
				continue

			d=data[i]
			#if('collectible' not in data[i]):
			#	continue
			try:
				s=d["set"]
			except:
				continue
			if(d["set"]!="ISLAND_VACATION"):
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
				filename=pathname2+d["name"].replace(",","").replace("?","").replace("!","").replace(".","").replace("-","").replace("(","").replace(")","").replace(" ","").replace("'","").replace(":","").replace('"','')+".jpg"
				imgurl="https://art.hearthstonejson.com/v1/512x/"+d["id"]+".jpg"
				
			except:
				print(filename,imgurl)
				continue

			self.download(imgurl,filename)
			print(i,filename)


So=GetHS()
So.downloadJson()
#So.readjson()
#So.genJson()
#So.genCsharp()