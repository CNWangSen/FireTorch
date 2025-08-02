import os
import json
import shutil

class Sol:
	def __init__(self):
		self.imgbase = "D:/Projects/unity/NoUseProj/Copy/CusCCGStreamingAssetCards/"
		self.ScriptNames=[]
		self.HSID=[]
		self.ConvertedHS=[]
		self.audbase = "D:/DocFile/Unity3dAsset/AudioClip/"
		self.audExbase= "D:/DocFile/Unity3dAsset/CusCCG_Ex_CardAud/"
		for d1 in os.listdir(self.imgbase):
			if(".meta" not in d1):
				try:
					os.mkdir(self.audExbase+d1+"/")
				except:
					pass
				
				for d2 in os.listdir(self.imgbase+d1+"/"):
					if(".meta" not in d2):
						try:
							os.mkdir(self.audExbase+d1+"/"+d2+"/")
						except:
							pass				
	def GetAllScriptNames(self):
		for root,direct,files in os.walk(self.imgbase):
			for filename in files:
				if('.meta' not in filename):
					sc=filename.replace(".jpg","")
					print(sc)
					if(sc not in self.ScriptNames):
						self.ScriptNames.append(sc)

	def GetAllHSID(self):
		with open("D:/DocFile/Unity3dAsset/MonoBehaviour_Important/CARD.json",encoding='utf-8') as file:
			data = json.load(file)
		d=data["Records"]
		for j in range(len(d)):
			hsid=d[j]["m_name"]["m_locValues"][0].replace("‘","").replace("’","").replace("?","").replace("!","").replace("-","").replace(".","").replace("ñ","").replace(" ","").replace(",","").replace("'","").replace(":","").replace("(","").replace(")","")
			if("THD_" not in d[j]["m_noteMiniGuid"]):
				self.ConvertedHS.append(hsid)
			else:
				self.ConvertedHS.append("")

		for i in range(len(self.ScriptNames)):
			ToBeFound=self.ScriptNames[i]
			
			possibleNames=[]
			possibleIndex=[]
			for j in range(len(d)):
				Now = self.ConvertedHS[j]
				if(Now == ToBeFound):
					possibleNames.append(d[j]["m_noteMiniGuid"])
					possibleIndex.append(Now)

			if(len(possibleNames)>0):
				shortest=possibleNames[0]
				HasVan=False
				if(possibleIndex[0]=="PatchesthePirate"):
					print(possibleNames)
				#for n in possibleNames:
				#	if("EX1_" in n):
				#		self.HSID.append(n)
				#		HasVan=True
				#		break
				if(HasVan==False):
					for i in range(len(possibleNames)):
						if(len(possibleNames[i])<len(shortest)):
							shortest=possibleNames[i]
					self.HSID.append(shortest)
			else:
				self.HSID.append("")
				print(i,ToBeFound)


		with open("ans.txt","w",encoding="utf-8") as opt:
			opt.write("    public static Dictionary<string,string> HSID= new Dictionary<string,string>(){")
			for i in range(len(self.ScriptNames)):
				opt.write('"')
				opt.write(self.ScriptNames[i])
				opt.write('":"')
				opt.write(self.HSID[i])
				opt.write('",')
			opt.write("};")
	def GetHSAud(self):
		audfiles=os.listdir(self.audbase)
		for root,direct,files in os.walk(self.imgbase):
			for filename in files:
				if('.meta' not in filename):
					sc=filename.replace(".jpg","")
					Index=self.ScriptNames.index(sc)
					mini=self.HSID[Index]

					
					if(mini!=""):
						print(mini)
						for f in audfiles:
							if(mini+'_' in f):
								dst=root.replace("D:/Projects/unity/CusCCG/Assets/StreamingAssets/Cards/","D:/DocFile/Unity3dAsset/CusCCG_Ex_CardAud/")+"/"+f
								shutil.copy(self.audbase+f,dst)
								print(dst)
					#print(root+'/'+sc)
	def Clean(self):
		for root,direct,files in os.walk(self.audExbase):
			for filename in files:
				miniName=""
				for n in self.HSID:
					if(n!=""):
						if(n+"_" in filename):
							miniName=n
							break
				use=False

				if(miniName!=""):
					print(root+'/'+filename)
					if("Attack" in filename):
						shutil.move(root+'/'+filename,root+'/'+miniName+"_Attack.wav")
						use=True
					else:
						if("Play" in filename):
							shutil.move(root+'/'+filename,root+'/'+miniName+"_Play.wav")
							use=True
						else:
							if("Death" in filename):
								shutil.move(root+'/'+filename,root+'/'+miniName+"_Death.wav")
								use=True
				if(use==False):
					os.remove(root+'/'+filename)
	def MatchAud(self):
		for root,direct,files in os.walk(self.audExbase):
			for filename in files:
				miniName=""
				for n in self.HSID:
					if(n!=""):
						if(n in filename):
							miniName=n
							break

				scriptn=self.ScriptNames[self.HSID.index(miniName)]
				if(scriptn!=""):
					shutil.move(root+'/'+filename,root+'/'+filename.replace(miniName,scriptn))	
	def FindEmpty(self):
		for root,direct,files in os.walk(self.imgbase):
			for filename in files:
				if('.meta' not in filename):
					Ex=False
					if(os.path.exists(root.replace("D:/Projects/unity/CusCCG/Assets/StreamingAssets/Cards/","D:/DocFile/Unity3dAsset/CusCCG_Ex_CardAud/")+"/"+filename.replace('.jpg','')+'_Attack.wav')):
						Ex=True
					if(Ex==False):
						print('aud not found '+root+'/'+filename)
					
So=Sol()
So.GetAllScriptNames()
So.GetAllHSID()
#So.GetHSAud()
#So.Clean()
#So.MatchAud()
#So.FindEmpty()