import csv
import json
import pandas as pd
import os
class Sol:
	def __init__(self):
		self.opt_jsonpath = 'AllCards.json'
		self.opt_csvpath = "AllCards.csv"
		self.dbcnPath='dbcn.json'
		self.dbusPath='dbus.json'
		self.allRaceTags=['ALL', 'BEAST', 'DEMON', 'DRAGON', 'ELEMENTAL', 'HUMAN', 'MECHANICAL', 'MURLOC', 'NAGA', 'NIGHTELF', 'ORC', 'PIRATE', 'QUILBOAR', 'TOTEM', 'UNDEAD', 'ARCANE', 'FEL', 'FIRE', 'FROST', 'HOLY', 'NATURE', 'SHADOW']
		
		self.allClassTags=['NEUTRAL', 'DEATHKNIGHT', 'DEMONHUNTER', 'DRUID', 'HUNTER', 'MAGE', 'PALADIN', 'PRIEST', 'ROGUE', 'SHAMAN', 'WARLOCK', 'WARRIOR']
		self.allSetTags=['ALTERAC_VALLEY', 'BATTLE_OF_THE_BANDS', 'BLACK_TEMPLE', 'BOOMSDAY', 'BRM', 'CORE', 'DALARAN', 'DARKMOON_FAIRE', 'DEMON_HUNTER_INITIATE', 'DRAGONS', 'EVENT', 'EXPERT1', 'GANGS', 'GILNEAS', 'GVG', 'HERO_SKINS', 'ICECROWN', 'ISLAND_VACATION', 'KARA', 'LEGACY', 'LOE', 'LOOTAPALOOZA', 'NAXX', 'OG', 'PATH_OF_ARTHAS', 'PLACEHOLDER_202204', 'RETURN_OF_THE_LICH_KING', 'REVENDRETH', 'SCHOLOMANCE', 'STORMWIND', 'TGT', 'THE_BARRENS', 'THE_SUNKEN_CITY', 'TITANS', 'TROLL', 'ULDUM', 'UNGORO', 'VANILLA', 'WHIZBANGS_WORKSHOP', 'WILD_WEST', 'WONDERS', 'YEAR_OF_THE_DRAGON']
		
		self.allRareTags=['FREE', 'COMMON', 'RARE', 'EPIC', 'LEGENDARY']
		self.allTypeTags=['MINION','SPELL','WEAPON','HERO', 'HEROPOWER','SECRET', 'LOCATION']

		self.allScriptNames=[]

		self.SetId=[]
		self.DbfId=[]
		self.Classes=[]
		self.CnName=[]
		self.ScriptName=[]
		self.CardType=[]
		self.RareType=[]
		self.RaceType=[]
		self.ManaCost=[]
		self.Attack=[]
		self.MaxHealth=[]
		self.Targets=[]
		self.Description=[]
		self.RelatedDbfId=[]
		self.DescriptionUs=[]
		
		self.InRecord=[]
	def GenCSharp(self):
		for i in range(len(self.allSetTags)):
			InSet=[]
			for j in range(len(self.allClassTags)):
				InClass=[]
				InSet.append(InClass)
			self.allScriptNames.append(InSet)

		for i in range(len(self.ScriptName)):
			self.allScriptNames[self.SetId[i]][self.Classes[i][0]].append(self.ScriptName[i])

		already=[]
		for i in range(len(self.allSetTags)):
			try:
				os.mkdir("CSharp/"+self.allSetTags[i]+"/")
			except:
				pass
			for j in range(len(self.allClassTags)):
				res=""
				res+="using UnityEngine;\nusing System.Collections;\nusing System.Collections.Generic;\n\n"
				ToWriteScriptNames=self.allScriptNames[i][j]
				ToWriteScriptNames.sort()
				for sn in ToWriteScriptNames:
					if(sn not in already):
						already.append(sn)
					else:
						continue
					Ind=self.ScriptName.index(sn)
					res+='//----------------------------------------------------------------------\n'
					res+='//'+self.DescriptionUs[Ind]+'\n'

					if(self.CardType[self.ScriptName.index(sn)]==self.allTypeTags.index("MINION")):
						res+="public class "+sn+":MinionBase\n{\n}\n"
					elif(self.CardType[self.ScriptName.index(sn)]==self.allTypeTags.index("SPELL")):
						res+="public class "+sn+":SpellBase\n{\n}\n"
					elif(self.CardType[self.ScriptName.index(sn)]==self.allTypeTags.index("WEAPON")):
						res+="public class "+sn+":WeaponBase\n{\n}\n"
					elif(self.CardType[self.ScriptName.index(sn)]==self.allTypeTags.index("HERO")):
						res+="public class "+sn+":HeroBase\n{\n}\n"
					elif(self.CardType[self.ScriptName.index(sn)]==self.allTypeTags.index("HEROPOWER")):
						res+="public class "+sn+":HeroPowerBase\n{\n}\n"
					elif(self.CardType[self.ScriptName.index(sn)]==self.allTypeTags.index("SECRET")):
						res+="public class "+sn+":SecretBase\n{\n}\n"
					elif(self.CardType[self.ScriptName.index(sn)]==self.allTypeTags.index("LOCATION")):
						res+="public class "+sn+":LocationBase\n{\n}\n"
					else:
						res+="public class "+sn+":Ability\n{\n}\n"
				with open("CSharp/"+self.allSetTags[i]+"/"+self.allClassTags[j]+"_"+self.allSetTags[i]+".cs",'w',encoding='utf-8') as opt:
					opt.write(res)

	def json2json(self):
		with open(self.dbcnPath, 'r',encoding='utf-8') as fcn:
			self.dbcnJS = json.load(fcn)
		with open(self.dbusPath, 'r',encoding='utf-8') as fus:
			self.dbusJS = json.load(fus)
		#len = 6261
		allRaceTags=[]

		for i in range(len(self.dbusJS)):
			self.handleOneCard(self.dbcnJS[i],self.dbusJS[i])
			#dcn=self.dbcnJS[i]
			#if("type" in dcn):
			#	r=dcn["type"]
			#	if(r not in allRaceTags):
			#		allRaceTags.append(r)
		#allRaceTags.sort()
		#print(allRaceTags)
		self.ExportJson()
		self.ExportExcel()
		self.GenCSharp()
	def ExportExcel(self):
		with open(self.opt_jsonpath, 'r',encoding='utf-8') as f:
			data = json.load(f)
		f = open(self.opt_csvpath, 'w', encoding='gbk')
		csv_write = csv.writer(f)
		csv_write.writerow(data[0].keys())
		count=0
		for row in data:
			try:
				csv_write.writerow(row.values())
			except:
				print(row.values())
			count+=1
		f.close()
		data = pd.read_csv(self.opt_csvpath,encoding='gbk')
		res = data.dropna(how="all")
		res.to_csv(self.opt_csvpath, index=False,encoding='gbk')
	def ExportJson(self):
		jsonfile = open(self.opt_jsonpath, 'w',encoding='utf-8')
		fieldnames = ("SetId","DbfId","Classes","CnName","ScriptName","CardType","RareType","MinionType","ManaCost","Attack","MaxHealth","Targets","Description","RelatedDbfId")
		res=[]
		for i in range(len(self.CnName)):
			row={}

			row["SetId"] = self.SetId[i]
			row['DbfId'] = self.DbfId[i]#str2int(row['DbfId'])
			row['Classes'] = self.Classes[i]#self.str2list(row['Classes'])
			row['CnName'] = self.CnName[i]
			row['ScriptName'] = self.ScriptName[i]
			row['CardType'] = self.CardType[i]#self.str2int(row['CardType'])
			row['RareType'] = self.RareType[i]#self.str2int(row['RareType'])
			row['MinionType'] = self.RaceType[i]#self.str2list(row['MinionType'])			
			row['ManaCost'] = self.ManaCost[i]#self.str2int(row['ManaCost'])

			row['Attack'] = self.Attack[i]#self.str2int(row['Attack'])
			row['MaxHealth'] = self.MaxHealth[i]#self.str2int(row['MaxHealth'])
			row['Targets'] = self.Targets[i]#self.str2int(row['Targets'])
			row['Description'] = self.Description[i]

			row['RelatedDbfId'] = self.RelatedDbfId[i]#self.str2list(row['RelatedDbfId'])
			res.append(row)
		out = json.dumps( res ,ensure_ascii=False)
		jsonfile.write(out)

	def handleOneCard(self,dcn,dus):
		m_SetId=0
		if "set" in dus:
			m_SetId=self.allSetTags.index(dus["set"])
		m_DbfId=0
		m_Classes=[]
		if "classes" in dus:
			for c in dus["classes"]:
				m_Classes.append(self.allClassTags.index(c))
		else:
			if "cardClass" in dus:
				m_Classes.append(self.allClassTags.index(dus["cardClass"]))
		if(len(m_Classes)==0):
			print("False At Classes")
		m_CnName=""
		if "name" in dcn:
			m_CnName = dcn["name"]
		else:
			print("False At CnName")
		m_ScriptName=""
		if "name" in dus:
			m_ScriptName = dus["name"].replace("‘","").replace("’","").replace("?","").replace("!","").replace("-","").replace(".","").replace("ñ","").replace(" ","").replace(",","").replace("'","").replace(":","").replace("(","").replace(")","")
		else:
			print("False At ScriptName")
		m_CardType=0

		if "type" in dus:
			m_CardType = self.allTypeTags.index(dus["type"])
		if "mechanics" in dus:
			if "SECRET" in dus["mechanics"]:
				if(m_CardType==self.allTypeTags.index("SPELL")):
					m_CardType=self.allTypeTags.index("SECRET")

		m_RareType=0
		if "rarity" in dus:
			m_RareType = self.allRareTags.index(dus["rarity"])
		else:
			print("False At RareType")

		m_RaceType=[]
		if "races" in dus:
			for r in dus["races"]:
				m_RaceType.append(self.allRaceTags.index(r))
		else:
			if "spellSchool" in dus:
				m_RaceType.append(self.allRaceTags.index(dus["spellSchool"]))
		
		m_ManaCost=0
		if "cost" in dus:
			m_ManaCost = dus["cost"]
		m_Attack=0
		if "attack" in dus:
			m_Attack = dus["attack"]
		m_MaxHealth=0
		if "health" in dus:
			m_MaxHealth = dus["health"]
		else:
			if "durability" in dus:
				m_MaxHealth = dus["durability"]

		m_Targets=0

		m_Description=""
		if "text" in dcn:
			m_Description = dcn["text"].replace("$","").replace("\n","")

		m_RelatedDbfId=[]

		m_DescriptionUs=""
		if "text" in dus:
			m_DescriptionUs = dus["text"].replace("\n","")

		if m_ScriptName in self.InRecord:
			return;
		self.SetId.append(m_SetId)
		self.DbfId.append(m_DbfId)
		self.Classes.append(m_Classes)
		self.CnName.append(m_CnName)
		self.ScriptName.append(m_ScriptName)
		self.CardType.append(m_CardType)
		self.RareType.append(m_RareType)
		self.RaceType.append(m_RaceType)
		self.ManaCost.append(m_ManaCost)
		self.Attack.append(m_Attack)
		self.MaxHealth.append(m_MaxHealth)
		self.Targets.append(m_Targets)
		self.Description.append(m_Description)
		self.RelatedDbfId.append(m_RelatedDbfId)
		self.DescriptionUs.append(m_DescriptionUs)
"""
                CardDbf ca = ScriptableObject.CreateInstance<CardDbf>();
                ca.DbfId = dbf.DbfId;
                ca.SetId = dbf.SetId;
                ca.CnName = dbf.CnName;
                ca.ScriptName = dbf.ScriptName;
                ca.CardType = dbf.CardType;
                ca.RareType = dbf.RareType;
                ca.MinionType = dbf.MinionType;
                ca.ManaCost = dbf.ManaCost;
                ca.Attack = dbf.Attack;
                ca.MaxHealth = dbf.MaxHealth;
                ca.Targets = dbf.Targets;
                ca.Classes = dbf.Classes;
                ca.Description = dbf.Description;
                AssetDatabase.CreateAsset(ca,"Assets/Resources/Cards/blueCube.asset");
"""

So=Sol()
So.json2json()
