import os
import re
import shutil

class Sol:
	def __init__(self):
		self.copyPath='D:/Projects/PythonProj/Tools/UnityTools/CodeModifier/Copy/'
		self.modiPath='D:/Projects/PythonProj/Tools/UnityTools/CodeModifier/Modified/'
		self.codepath='D:/Projects/UnityProj/CusCCGV3/Assets/Scripts/PlayGame/'
		self.dirlist = []
		self.ProjFilePaths=[]
		self.CopyFilePaths=[]
		self.ModiFilePaths=[]
		self.get_filelist()

	def modiCode(self):
		for i in range(len(self.ModiFilePaths)):
			data=self.readSingleFile(self.CopyFilePaths[i])
			ans=''
			for k in range(len(data)):
				ans+=self.modiSingleLine(data[k])
			with open(self.ModiFilePaths[i],'w',encoding='utf-8') as opt:
				opt.write(ans)
	def readSingleFile(self,filePath):
		with open(filePath,'r',encoding='utf-8') as ipt:
			data=ipt.readlines()
		return data
	def modiSingleLine(self,rawText):
		DoThing='DoMove'
		if(DoThing not in rawText):
			return rawText
		modText=''
		CritIndex = rawText.index(DoThing)
		
		indent = ''
		for c in range(len(rawText)):
			if(rawText[c].isalpha()==False):
				indent+=rawText[c]
			else:
				break
		playerWho = rawText[c:CritIndex-1]
		modText+=indent
		modText+='new EffectMove('+playerWho+', '
		modText+=rawText[CritIndex+7:-2]
		modText+='.Resolve();\n'
		print(modText)
		return modText

	def replaceCode(self):
		for i in range(len(self.ModiFilePaths)):
			shutil.copy(self.ModiFilePaths[i],self.ProjFilePaths[i])
	def repairCode(self):
		for i in range(len(self.ModiFilePaths)):
			shutil.copy(self.CopyFilePaths[i],self.ProjFilePaths[i])		
	def copyCode(self):
		self.createPath()
		for f in self.ProjFilePaths:
			#print(self.copyPath+f[46:])
			try:
				shutil.copy(f,self.copyPath+f[46:])
			except:
				print('failed copy ' + f)
			try:
				shutil.copy(f,self.modiPath+f[46:])
			except:
				print('failed copy ' + f)
	def createPath(self):
		for d in self.dirlist:
			#print(d[46:])
			try:
				os.mkdir(self.modiPath+d[46:])
			except:
				print('failed mkdir '+d)
	def get_filelist(self):
		self.dirlist = []
		self.ProjFilePaths=[]
		self.CopyFilePaths=[]
		self.ModiFilePaths=[]
		for home, dirs, files in os.walk(self.codepath):
			d=os.path.join(home)
			if(d not in self.dirlist):
				self.dirlist.append(d)
			for filename in files:
				if('.meta' not in filename):
					f=os.path.join(home, filename)
					self.ProjFilePaths.append(f)
					self.CopyFilePaths.append(self.copyPath+f[46:])
					self.ModiFilePaths.append(self.modiPath+f[46:])

So=Sol()
#So.copyCode()
So.modiCode()
So.replaceCode()
#So.repairCode()