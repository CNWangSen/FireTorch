import cv2

import os
import cv2
import shutil
import Levenshtein

base="D:/DocFile/Unity3dAsset/Images/"


def Resize():
	for f in os.listdir(base):
		if('.jpg' in f):
			print(f)
		
			im=cv2.imread(base+f)
			im=cv2.resize(im,(512,512))
			cv2.imwrite(base+f,im)

def Rename():
	with open(base+'Names.txt','r',encoding='utf-8') as ipt:
		dat=ipt.readlines()
	print(dat)

	imglist=[]
	for f in os.listdir(base):
		if('.jpg' in f):
			imglist.append(f)

	print(imglist)

	namelist=[]
	for fn in imglist:
		desc=fn[35:-8].replace("_"," ")
		print(desc)
		MinDistance = 1000
		FoundIndex = 0
		for lineIndex in range(len(dat)):
			Found=False
			for j in range(len(dat[lineIndex])-len(desc)):
				ToMatch=dat[lineIndex][j:j+len(desc)]
				#print(ToMatch)
				#print(desc)
				Dis=Levenshtein.distance(ToMatch, desc)
				if(Dis<MinDistance):
					MinDistance=Dis
					FoundIndex = lineIndex
		Found=False
		if(MinDistance<10):
			Found=True
			lineIndex=FoundIndex
		if(Found):
			#print('fuck')
			rawcardname = dat[lineIndex-2].replace("Monster Name:","").replace("Card Name: ","").replace("Weapon Name: ","").replace(" ","").replace(".","").replace(",","").replace("'","").replace("\n","")
			cnt=1
			cardname=rawcardname
			while(cardname in namelist):
				cardname=rawcardname+str(cnt)
				cnt+=1
			shutil.move(base+fn,base+"Named/"+cardname+'.jpg')
			namelist.append(cardname)
			#print(cardname)
Resize()
Rename()
