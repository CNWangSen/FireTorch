from script.Restool.PptReader.read import RDer
from PIL import Image, ImageDraw, ImageFont
import cv2
import os
import datetime
import random

#  0-Gen CMD
#  1-Gen Vid
#  2-Gen Cover
mode=1
line3t='炉石传说斗蛐蛐'
line4t='谁能捣毁雷兽窟？'

class Sol:
	def __init__(self):
		self.basePath='D:/Projects/PythonProj/Game/pygame-hsbg-ReadPPT/'
		self.outputPath='D:/DocFile/Capture/'
		with open('script/Data/reader.txt','r',encoding='utf-8') as ipt:
			self.dat=ipt.readlines()
		self.line3Txt=''
		self.line4Txt=''
		self.winName=[]
		self.losName=[]
	def launch(self):
		Rd=RDer(self.dat,self.basePath,self.outputPath,changeBGMevery=4)
		Rd.randomBgmEnabled=True
		Rd.vidTrans=True
		Rd.run()

	def GenCMD(self):
		HeroNameList=["DK","DH",
		"玛法里奥","雷克萨","吉安娜",
		"帕拉丁","安度因","瓦莉拉",
		"萨尔","古尔丹","加尔鲁什"]
		HeroShortList=["孝","瞎",
		"德","猎","法",
		"骑","牧","贼",
		"萨","术","战"
		]

		HeroWinList =[0,1,
		0,1,0,
		1,1,1,
		1,0,1]
		Shuffle =[]
		res=''
		count=0
		for i in range(len(HeroNameList)):
			Shuffle.append(i)
		Shuffle = [0,1,2,3,4]	
		random.shuffle(Shuffle)

		res+='ename=0.mp4|mute=0|seqzero=1|speed=1\n'
		res+='ttxt=put your rule here\n'
		res+='a\nv\n\n'
		for ind in Shuffle:
			res+='ename='+str(ind+1)+'.mp4|mute=0|seqzero=1|speed=1\n'
			res+='ttxt='+self.GetInWords(count,HeroNameList[ind])+'\n'
			res+='d\n'
			res+='ttxt='+self.GetOutWords(HeroWinList[ind],HeroNameList[ind],HeroShortList[ind])+'\n'
			res+='a\n\nd\n'
			count+=1

		shortWin = ''
		shortLos = ''
		for n in self.winName:
			shortWin+=n
		for n in self.losName:
			shortLos+=n

		res+='ename=0.mp4|mute=0|seqzero=1|speed=1\n'
		res+='ttxt='+shortWin+'挑战成功\n'
		res+='ttxt='+shortLos+'挑战失败\n'

		res+='ttxt=炉石斗蛐蛐，欢乐每一期\n'
		res+='ttxt=我是玛瑙，我们下期再见\n'
		res+='a\nv\n'
		with open('script/Data/reader.txt','w',encoding='utf-8') as ipt:
			ipt.write(res)
	def GetInWords(self,cnt,name):
		Able=[str(cnt+1)+'号选手'+name+'登场','接下来登场的是'+name,'第'+str(cnt+1)+'位登场的选手是'+name]
		return random.choice(Able)
	def GetOutWords(self,win,name,shortname):
		if(win==1):
			self.winName.append(shortname)
			return name+'挑战成功'
		self.losName.append(shortname)
		return name+'挑战失败'



	def newcover(self):
		fontpath=self.basePath+'res/img_font/'
		im=Image.open(self.outputPath+'c.png')
		fontname1='SH.otf'
		nf=120
		fontsize1=305-nf
		fon1=ImageFont.truetype(font=fontpath+fontname1,size=fontsize1,encoding="utf-8")
		fontname2='SH.otf'
		fontsize2=200-nf
		fon2=ImageFont.truetype(font=fontpath+fontname2,size=fontsize2,encoding="utf-8")
		fontname3='SH.otf'
		fontsize3=270-nf+40
		fon3=ImageFont.truetype(font=fontpath+fontname3,size=fontsize3,encoding="utf-8")
		fontname4='SH.otf'
		fontsize4=270-nf+50
		fon4=ImageFont.truetype(font=fontpath+fontname4,size=fontsize4,encoding="utf-8")
		d=ImageDraw.Draw(im)
		line1='炉石传说斗蛐蛐'
		line2='斗蛐蛐'
		line3=self.line3Txt
		line4=self.line4Txt
		sx=150
		linespace=40
		y1=sx
		y2=y1+fontsize1+linespace
		y3=y2+fontsize2+linespace+150-80
		y4=y3+fontsize3+linespace
		col=(255,255,255)
		shadow=(0,0,0)
		#d=self.pastshad((255,0,255),shadow,fon1,'万宁',sx+300,y1,d,5)
		#d=self.pastshad((255,255,0),shadow,fon1,line1,sx,y1,d,5)
		#d=self.pastshad((0,255,255),shadow,fon2,line2,sx,y2,d,5)
		d=self.pastshad((255,255,0),shadow,fon3,line3,sx,y3,d,15)
		d=self.pastshad((255,255,0),shadow,fon4,line4,sx,y4,d,15)
		#d.text((sx,y1),line1,col,fon1)
		#d.text((sx+50,y2),line2,col,fon2)
		#d.text((sx,y3),line3,col,fon3)
		#d.text((sx,y4),line4,col,fon4)
		im.save(self.outputPath+datetime.datetime.now().strftime("%Y%m%d")+'.png')
	def pastshad(self,col,shadow,fon,txt,x,y,d,cst):
		d.text((x-cst,y-cst),txt,shadow,fon)
		d.text((x-cst,y+cst),txt,shadow,fon)
		d.text((x+cst,y-cst),txt,shadow,fon)
		d.text((x+cst,y+cst),txt,shadow,fon)
		d.text((x+cst,y),txt,shadow,fon)
		d.text((x-cst,y),txt,shadow,fon)
		d.text((x,y+cst),txt,shadow,fon)
		d.text((x,y-cst),txt,shadow,fon)
		d.text((x,y),txt,col,fon)
		return d
	def makecover(self):
		iml=[]
		base=self.outputPath
		for fn in os.listdir(base):
			if('.jpg' in fn):
				iml.append(cv2.imread(base+fn))
		im1=iml[0]
		im2=iml[1]
		imo=iml[0]
		imo=cv2.resize(imo,(1920,1080))
		w=180
		h=int(w/960*1080)
		imo[0:1080,0:960]=cv2.resize(im1[256-h:256+h,256-w:256+w],(960,1080))
		imo[0:1080,960:1920]=cv2.resize(im2[256-h:256+h,256-w:256+w],(960,1080))
		cv2.imwrite(base+'c.png',imo)
		self.newcover()
	def FastMerge(self):
		import datetime
		import subprocess
		outpath=self.outputPath+'Merge/'
		mergepath=outpath+'FastMerge/'
		with open(mergepath+'concatlist.txt','w',encoding='utf-8') as opt:
			for f in os.listdir(mergepath):
				if '.mp4' in f:
					opt.write('file '+f+'\n')
		cmd='ffmpeg -f concat -i '+mergepath+'concatlist.txt -c copy '+outpath+datetime.datetime.now().strftime("%Y%m%d%H%M")+'.mp4'
		p=subprocess.Popen(cmd)
		p.wait()


So=Sol()
if(mode==0):
	So.GenCMD()
if(mode==1):
	So.launch()
if(mode==2):
	So.line3Txt=line3t
	So.line4Txt=line4t
	So.newcover()
