import requests
import time
import json
import os
import random
import re


class GetHS:
	def __init__(self):
		self.allRaceTags=['ALL', 'BEAST', 'DEMON', 'DRAGON', 'ELEMENTAL', 'HUMAN', 'MECHANICAL', 'MURLOC', 'NAGA', 'NIGHTELF', 'ORC', 'PIRATE', 'QUILBOAR', 'TOTEM', 'UNDEAD', 'BLOODELF','TREANT','GNOME','HIGHELF','OLDGOD','WORGEN','TROLL','OGRE','GNOLL','DRAENEI','TAUREN','PANDAREN','CELESTIAL','DWARF','GOBLIN','GOLEM','EGG','FURBOLG','CENTAUR','GRONN','VULPERA','LOCK']
		self.allspellSchoolTags=['ARCANE', 'FEL', 'FIRE', 'FROST', 'HOLY', 'NATURE', 'SHADOW','SPELLCRAFT','TAVERN','PHYSICAL_COMBAT']	
		self.allClassTags=['NEUTRAL', 'DEATHKNIGHT', 'DEMONHUNTER', 'DRUID', 'HUNTER', 'MAGE', 'PALADIN', 'PRIEST', 'ROGUE', 'SHAMAN', 'WARLOCK', 'WARRIOR','WHIZBANG','DREAM','MONK']
		self.allSetTags=['ALTERAC_VALLEY', 'BATTLE_OF_THE_BANDS', 'BLACK_TEMPLE', 'BOOMSDAY', 'BRM', 'CORE', 'DALARAN', 'DARKMOON_FAIRE', 'DEMON_HUNTER_INITIATE', 'DRAGONS', 'EVENT', 'EXPERT1', 'GANGS', 'GILNEAS', 'GVG', 'HERO_SKINS', 'ICECROWN', 'ISLAND_VACATION', 'KARA', 'LEGACY', 'LOE', 'LOOTAPALOOZA', 'NAXX', 'OG', 'PATH_OF_ARTHAS', 'PLACEHOLDER_202204', 'RETURN_OF_THE_LICH_KING', 'REVENDRETH', 'SCHOLOMANCE', 'STORMWIND', 'TGT', 'THE_BARRENS', 'THE_SUNKEN_CITY', 'TITANS', 'TROLL', 'ULDUM', 'UNGORO', 'VANILLA', 'WHIZBANGS_WORKSHOP', 'WILD_WEST', 'WONDERS', 'YEAR_OF_THE_DRAGON',"TB","BATTLEGROUNDS","LETTUCE","BASIC","CREDITS","MISSIONS","TAVERNS_OF_TIME","TUTORIAL"]
		
		self.allRareTags=['FREE', 'COMMON', 'RARE', 'EPIC', 'LEGENDARY']
		self.allTypeTags=['MINION','SPELL','WEAPON','HERO', 'HEROPOWER','SECRET', 'LOCATION','ENCHANTMENT','HERO_POWER','MOVE_MINION_HOVER_TARGET','BATTLEGROUND_HERO_BUDDY','BATTLEGROUND_QUEST_REWARD','BATTLEGROUND_ANOMALY','BATTLEGROUND_SPELL','LETTUCE_ABILITY','GAME_MODE_BUTTON']
		self.allK=['cardClass', 'dbfId', 'health', 'heroPowerDbfId', 'id', 'name', 'set', 'type', 'artist', 'rarity', 'attack', 'cost', 'faction', 'collectible', 'flavor', 'spellSchool', 'text', 'mechanics', 'race', 'races', 'referencedTags', 'elite', 'targetingArrowText', 'durability', 'overload', 'spellDamage', 'battlegroundsPremiumDbfId', 'techLevel', 'collectionText', 'hasDiamondSkin', 'howToEarnGolden', 'armor', 'howToEarn', 'hideCost', 'hideStats', 'mercenariesRole', 'battlegroundsNormalDbfId', 'isBattlegroundsPoolMinion', 'battlegroundsBuddyDbfId', 'battlegroundsHero', 'isBattlegroundsBuddy', 'battlegroundsSkinParentId', 'isBattlegroundsPoolSpell', 'battlegroundsDarkmoonPrizeTurn', 'countAsCopyOfDbfId', 'classes', 'puzzleType', 'multiClassGroup', 'isMiniSet', 'mercenariesAbilityCooldown', 'questReward']

	def download(self,url,filepath):
		response = requests.get(url)
		with open(filepath, 'wb') as f:
			f.write(response.content)	
		time.sleep(0.1)#1+random.random())
	def downloadJson(self):
		self.download("https://api.hearthstonejson.com/v1/latest/zhCN/cards.json","Jsons/CardDB_zhCN.json")
		self.download("https://api.hearthstonejson.com/v1/latest/enUS/cards.json","Jsons/CardDB_enUS.json")
	
	def GetParentClass(self, dbf):
		if('type' not in dbf):
			print("NO TYPE")
			print("")
			return "Ability"
		if dbf['type'] == "MINION":
			return "MinionBase"
		if dbf['type'] == "WEAPON":
			return "WeaponBase"
		if dbf['type'] == "HERO":
			return "HeroBase"
		if dbf['type'] == "HERO_POWER":
			return "HeroPowerBase"
		if dbf['type'] == "SPELL":
			if("mechanics" in dbf):
				if("SECRET" in dbf["mechanics"]):
					return "SecretBase"
				else:
					return "SpellBase"
			else:
				return "SpellBase"
		if dbf['type'] == "LOCATION":
			return "LocationBase"
		print("FAC")
		return "Ability"
	def GetSetID(self, noteID):
		if('CORE_' in noteID):
			return 'CORE'
		if('VAN_' in noteID):
			return "VAN"
		if('LEG_' in noteID):
			return "LEG";
		if('Core_' in noteID):
			return "CORE"
		if('DALA_' in noteID):
			return 'DALA'
		if('AIBot_' in noteID):
			return 'AIBot'

		else:
			pattern = r"_[0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz]"
			print(noteID)
			match=re.search(pattern,noteID)
			if(match!=None):
				noteID=noteID[0:match.start()]
				
			if('ICCA' in noteID):
				noteID='ICCA'
			if('LOEA' in noteID):
				noteID='LOEA'
			if('BRMA' in noteID):
				noteID= 'BRMA'
			if('NAX' in noteID):
				noteID='NAX'
			if('Mekka' in noteID):
				noteID='Mekka'
			if('TU' in noteID):
				noteID ='TU'

			return noteID
	def TryGetKey(self,dbf,k):
		if(k=='health'):
			if('durability' in dbf):
				return str(dbf['durability'])
		if(k in dbf):
			return str(dbf[k])
		if(k == "race"):
			if('spellSchool' in dbf):
				return str(dbf['spellSchool'])
			return 'NONE'
		if(k=='cardClass'):
			return 'NEUTRAL';
		return "0"
	def GenHScode(self):
		for f in os.listdir("Sets/"):
			os.remove("Sets/"+f)
		with open("Jsons/CardDB_zhCN.json",encoding='utf-8') as file:
			dataCN=json.load(file)
		with open("Jsons/CardDB_enUS.json",encoding='utf-8') as file:
			data=json.load(file)

		AllFileNames=[]
		AllCardNames=[]
		AllCardIndex=[]
		for i in range(len(data)):
			d=data[i]
			FName = self.GetSetID(d["id"])
			if(FName not in AllFileNames):
				AllFileNames.append(FName)
				AllCardNames.append([])
				AllCardIndex.append([])
			FInd=AllFileNames.index(FName)
			AllCardIndex[FInd].append(i)

		for i in range(len(AllFileNames)):
			Codes="using System.Collections;\nusing System.Collections.Generic;\n\n"
			for j in AllCardIndex[i]:
				d=data[j]
				dc=dataCN[j]
				Codes+="public class "+d["id"]+":"+self.GetParentClass(data[j])+"{\n"
				Codes+="//NAME="+dc["name"]+'\n'
				if("text" in data[j]):
					Codes+="//TEXT="+dc["text"].replace('\n',' ')+'\n'
				else:
					Codes+="//TEXT=\n"
				Codes+="//MAJ="+self.TryGetKey(dc,'cardClass') +'|COST='+self.TryGetKey(dc,"cost")+'|ATK='+self.TryGetKey(dc,"attack")+'|HP='+self.TryGetKey(dc,"health")+'|RACE='+self.TryGetKey(dc,"race")
				Codes+='\n'
				Codes+="}\n"
				
			with open("Sets/"+AllFileNames[i]+'.cs','w',encoding='utf-8') as opt:
				opt.write(Codes)

	def GetCardTargets(self):
		with open("Jsons/CardDB_enUS.json",encoding='utf-8') as file:
			data=json.load(file)		
		for i in range(len(data)):
			d=data[i]
			if("classes" in d and "cardClass" not in d):
				print(d["id"])		


	def traverseJson(self):
		with open("Jsons/CardDB_enUS.json",encoding='utf-8') as file:
			data=json.load(file)
		TagsNotIn=[]
		TagsFound=[]
		s='set'
		cnt=0
		ToFoundTags=self.allSetTags
		ToFoundTags.sort()
		print(ToFoundTags)
		AllKeys=[]
		for i in range(len(data)):
			d=data[i]
			for k in d.keys():
				if(k not in AllKeys):
					AllKeys.append(k)
			if('collectible' in d):
				cnt+=1
			if(s in d):
				if(d[s] not in ToFoundTags):
					if(d[s] not in TagsNotIn):
						TagsNotIn.append(d[s])
				else:
					if(d[s] not in TagsFound):
						TagsFound.append(d[s])
		print(cnt)
		print("Not In")
		for t in TagsNotIn:
			print(t)
		print("---------------------------------")
		print("Not Found")
		for t in ToFoundTags:
			if(t not in TagsFound):
				print(t)
		print(AllKeys)

	def readjson(self):
		#41
		with open("Jsons/CardDB_enUS.json",encoding='utf-8') as file:
			data=json.load(file)

		for i in range(len(data)):
			if i<5980:
				continue
			d=data[i]
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
				filename=pathname2+d["name"].replace(",","").replace("?","").replace("!","").replace(".","").replace("-","").replace("(","").replace(")","").replace(" ","").replace("'","").replace(":","")+".jpg"
				imgurl="https://art.hearthstonejson.com/v1/512x/"+d["id"]+".jpg"
				
			except:
				print(filename,imgurl)
				continue

			self.download(imgurl,filename)
			print(i,filename)


So=GetHS()
So.downloadJson()
#So.readjson()
#So.traverseJson()
#So.GetCardTargets()
#So.GenHScode()