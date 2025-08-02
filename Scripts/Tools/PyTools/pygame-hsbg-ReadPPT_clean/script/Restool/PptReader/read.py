from script.Restool.PptReader.blitthing import *
from script.Restool.PptReader.CvTools import *
from script.Restool.PptReader.DubTools import *
from script.Restool.PptReader.StrTools import *

import os
import subprocess
import random
from datetime import datetime

class RDer:
	def __init__(self,dat,basePath,outPath,changeBGMevery=5):
		self.screenw=1920
		self.screenh=1080
		self.fps=30
		self.dat=dat
		self.respath=basePath+'res/readres/'
		self.utilpath=self.respath+'Utils/'
		self.imgpath=self.respath+'Img/'
		self.audpath=self.respath+'Aud/'
		self.vidpath=self.respath+'Vid/'
		self.outbase=outPath
		self.vidname=self.outbase+'done/Temp/raw.mp4'
		self.audname=self.outbase+'done/Temp/raw.wav'
		self.outname=self.outbase+datetime.now().strftime("%Y%m%d%H%M")+'.mp4'
		self.trunkMaxMs=20*60*1000
		self.shadowcolor=(0,0,0)
		self.fontcolor=(255,255,255)
		self.fontsize=60
		self.fontcx=960
		self.fontcy=860
		self.imgcx=960
		self.imgcy=540
		self.fontname="SH.otf"#'HSC.ttf'#'SH.otf'
		self.capfont=ImageFont.truetype(font=basePath+'res/img_font/'+self.fontname,size=self.fontsize,encoding="utf-8")
		#self.capfont.set_variation_by_name("bold")
		self.readedframe=None
		self.randomBgmEnabled=True
		self.videoCount=-1
		self.changeBgmEvery=changeBGMevery
		self.bgmNameList=[]
		self.chosenBgmList=[]
		if(self.randomBgmEnabled):
			self.bgmNameList=os.listdir(self.audpath+'Bgm/')
		self.targetBgmDb=-20
		self.targetManDb=-15
		self.gameDbChange=-7
		self.vidTransBegin=False
		self.vidTrans=True
		self.vidTransFirstFrame=None
		self.vidTransLastFrame=None
		self.vidTransNowFrame=0
		self.vidTransTotalFrame=30

		fourcc=cv2.VideoWriter_fourcc(*'mp4v')
		self.video=cv2.VideoWriter(self.vidname,fourcc,self.fps,(self.screenw,self.screenh))
		self.trunk=AudioSegment.silent(self.trunkMaxMs)
		self.bgmtrunk=AudioSegment.silent(self.trunkMaxMs)
		self.black_bg=Image.new('RGB',(self.screenw,self.screenh),(0,0,0))
		self.screen=self.black_bg.copy()
		self.recordframe=0
		self.vidlist=[]
		self.imglist=[]
		self.cpnlist=[]
		self.imgseqlist=[]
		self.imgseqbase=self.respath+'frameseq/'
		self.preman=[]
		self.camerashaking=False

	def getms(self):
		return int(self.recordframe*1000/self.fps)

	def run(self):
		for d_ in range(len(self.dat)):
			print(d_)
			dat_i=self.dat[d_].replace('\n','')
			if dat_i=='##':
				break
			if dat_i!='':
				Done=self.process(dat_i)
				if Done:
					break
		self.donerecord()
	
	def process(self,dat_):
		mode=dat_[0]
		comd=dat_[1:len(dat_)]
		if (comd=='' and mode=='') or mode=='#':
			return False
		comd=StrTool_ParseCmdFromStr(comd)
		if mode in ['q']:
			self.addcpn(comd)
		if mode in ['w']:
			self.addimg(comd)
		if mode in ['e']:
			if(self.videoCount==0):
				self.vidTransBegin=True
			self.addvid(comd)
			if(self.randomBgmEnabled):
				if(self.videoCount%self.changeBgmEvery==0 and self.videoCount>=0):
					bgmIndex=random.randint(0,len(self.bgmNameList)-1)
					randomAudPath=self.bgmNameList[bgmIndex]
					self.bgmNameList.pop(bgmIndex)
					print(randomAudPath)
					self.chosenBgmList.append(randomAudPath)
					self.addaud(StrTool_ParseCmdFromStr('name=Bgm/'+randomAudPath+'|bgm=1|startms='+str(random.randint(10,15)*1000)))
			self.videoCount+=1
		if mode in ['r']:
			self.addaud(comd)
		if mode in ['t']:
			self.addman(comd)
		if mode in ['y']:
			self.addimgseq(comd)

		if mode in ['a']:
			self.waitcpn(comd)
		if mode in ['s']:
			self.waitimg(comd)
		if mode in ['d']:
			self.waitvid(comd)

		if mode in ['z']:
			self.hold(comd)
		if mode in ['Z']:
			self.holdtillclear(comd)
		if mode in ['x']:
			self.imglist=[]
		if mode in ['c']:
			self.cpnlist=[]
		if mode in ['v']:
			self.vidlist=[]
		if mode in ['b']:
			return True
		if mode in ['n']:
			self.camerashaking=True
		if mode in ['N']:
			self.camerashaking=False

	def recording(self):
		self.video.write(self.screen)
		self.recordframe+=1
	def donerecord(self):
		self.video.release()
		self.trunk=self.trunk.overlay(self.bgmtrunk[0:self.getms()].fade_out(5000),position=0)
		self.trunk.export(self.outbase+'done/Temp/bgmtrunk.wav',format='wav')
		self.trunk=self.trunk[0:self.getms()]
		self.trunk.export(self.audname,format='wav')
		with open(self.outbase+'done/Temp/bgmList.txt','w') as opt:
			opt.write("BGM: \n")
			for bgm in self.chosenBgmList:
				opt.write(bgm[:-4])
				opt.write('\n')
		p=subprocess.Popen('ffmpeg -threads 1 -i '+self.vidname+' -i '+self.audname+' -crf 18 '+self.outname+' -y')
		p.wait()


	def addcpn(self,kwargs):
		self.cpnlist.append(PstCpn(**kwargs,cx=self.fontcx,cy=self.fontcy,nowf=self.getms()))
	def addimg(self,kwargs):
		self.imglist.append(PstImg(img=Image.open(self.imgpath+kwargs['name']).convert('RGBA'),**kwargs,nowf=self.getms()))
	def addimgseq(self,kwargs):
		namelist=os.listdir(self.imgseqbase+kwargs['name'])
		self.imgseqlist.append([namelist,kwargs])
	def addvid(self,kwargs):
		mute=kwargs['mute']
		speed=kwargs['speed']
		if(os.path.exists(self.vidpath+"CFR/"+kwargs['name'])==False):
			p0=subprocess.Popen('ffmpeg -threads 1 -i '+self.vidpath+kwargs['name']+' -vsync cfr -preset 5 -crf 18 '+self.vidpath+"CFR/"+kwargs['name']+' -y')
			p0.wait()
		p=subprocess.Popen('ffmpeg -i '+self.vidpath+"CFR/"+kwargs['name']+' '+self.audname+' -y')
		p.wait()
		aud=self.loaddubaudio(self.audname)+self.gameDbChange
		if(speed!=1):
			aud=aud._spawn(aud.raw_data,overrides={"frame_rate":int(aud.frame_rate*speed)}).set_frame_rate(aud.frame_rate)#self.speed_change(aud,speed)
		if mute==1:
			aud=None
		vid=cv2.VideoCapture(self.vidpath+"CFR/"+kwargs['name'])
		vidfps=vid.get(cv2.CAP_PROP_FPS)
		vidrepeat=0
		if((self.fps-vidfps)!=0):
			vidrepeat=int(vidfps/(self.fps-vidfps))
		self.vidlist.append(PstVid(vid=vid,**kwargs,aud=aud,fps=vidfps,repeat=vidrepeat))
		self.waittrans()
	def addaud(self,kwargs,man=False):
		loaded=self.loaddubaudio(self.audpath+kwargs['name'],**kwargs,man=man)
		rawDb=loaded.dBFS
		if(man==False):
			loaded+=(self.targetBgmDb-rawDb)
		else:
			loaded+=(self.targetManDb-rawDb)
		if 'mute' in kwargs:
			if kwargs['mute']==1:
				pass
			else:
				self.playdubaudio(loaded,**kwargs)
		else:
			self.playdubaudio(loaded,**kwargs)

		return int(loaded.duration_seconds*1000)
	def addman(self,kwargs):
		DubTool_getman(kwargs['txt'],self.audpath+'man.mp3')
		dur=self.addaud({**StrTool_ParseCmdFromStr('name=man.mp3'),**kwargs},man=True)
		kwargs['dur']=dur
		self.addcpn(kwargs)

		if 'delayms' in kwargs:
			if kwargs['delayms']==-1:
				self.hold(StrTool_ParseCmdFromStr('ms='+str(dur)))
		else:
			self.hold(StrTool_ParseCmdFromStr('ms='+str(dur)))
		
	def waitcpn(self,kwargs):
		hold=True
		while hold:
			self.holdoneframe()
			hold=False
			for m in self.cpnlist:
				if m.vaildbefore<999999 or m.blitonce:
					hold=True
	def waitimg(self,kwargs):
		hold=True
		while hold:
			self.holdoneframe()
			hold=False
			for m in self.imglist:
				if m.vaildbefore<999999 or m.blitonce:
					hold=True
	def waitvid(self,kwargs):
		while len(self.vidlist)>0:
			self.holdoneframe()
	def waittrans(self,):
		if(self.vidTrans==False or self.vidTransBegin==False):
			return 0
		self.vidTransNowFrame=0
		videntity=self.vidlist[len(self.vidlist)-1]
		cvcap=videntity.content

		while(self.vidTransNowFrame<self.vidTransTotalFrame):
			if(self.vidTransNowFrame==0):
				self.vidTransFirstFrame=self.readedframe
				ret,self.vidTransLastFrame=cvcap.read()
			self.imglist.append(PstImg(CvTool_cv2pil(CvTool_PageTurn(self.vidTransFirstFrame,self.vidTransLastFrame,self.vidTransNowFrame,self.vidTransTotalFrame)).convert('RGBA'),blitonce=True,cx=videntity.cx,cy=videntity.cy,layer=videntity.layer))
			self.vidTransNowFrame+=1
		
			self.screen=self.black_bg.copy()
			#self.procvid()
			self.procimgseq()
			self.procimg()
			self.proccpn()
			if self.camerashaking:
				self.shakescreen=self.black_bg.copy()
				self.shakescreen.paste(self.screen,(random.randint(-10,10),random.randint(-10,10)))
				self.screen=self.shakescreen
			self.black_bg=self.screen.copy()
			self.screen=CvTool_pil2cv(self.screen)
			self.recording()


	def holdtillclear(self,kwargs):
		holdcpn=True
		while len(self.vidlist) or holdcpn or len(self.imgseqlist)>0:
			self.holdoneframe()
			holdcpn=False
			for m in self.cpnlist:
				if m.vaildbefore<999999 or m.blitonce:
					holdcpn=True
	def hold(self,kwargs):		
		holdms=kwargs['ms']
		holdframe=int(holdms/1000*self.fps)
		startframe=self.recordframe
		while True:
			if self.recordframe-startframe>holdframe:
				break
			self.holdoneframe()

	def holdoneframe(self):
		self.screen=self.black_bg.copy()
		self.procvid()
		self.procimgseq()
		self.procimg()
		self.proccpn()
		if self.camerashaking:
			self.shakescreen=self.black_bg.copy()
			self.shakescreen.paste(self.screen,(random.randint(-10,10),random.randint(-10,10)))
			self.screen=self.shakescreen
		self.black_bg=self.screen.copy()
		self.screen=CvTool_pil2cv(self.screen)
		self.recording()
		

	def clearaud(self,**kwargs):
		self.bgmtrunk=AudioSegment.silent(self.trunkMaxMs).overlay(self.bgmtrunk[0:self.getms()],position=0).fade_out(2000)

	def playdubaudio(self,audiotoplay=None,delayms=0,**kwargs):
		if 'bgm' in kwargs:
			self.bgmtrunk=AudioSegment.silent(self.trunkMaxMs).overlay(self.bgmtrunk[0:self.getms()],position=0).fade_out(2000)
			self.bgmtrunk=self.bgmtrunk.overlay(audiotoplay.fade_in(2000),position=self.recordframe*1000/self.fps+delayms)
		else:
			self.trunk=self.trunk.overlay(audiotoplay,position=self.recordframe*1000/self.fps+delayms)
	def loaddubaudio(self,path=None,nerf=0,man=False,**kwargs):
		if nerf==0:
			loaded=AudioSegment.from_mp3(path)
		else:
			loaded=AudioSegment.from_mp3(path)+nerf
		if man:
			loaded=DubTool_del_ht_silence(loaded)
			loaded+=10
			#loaded=loaded+20
		if 'startms' in kwargs:
			loaded=loaded[kwargs['startms']:loaded.duration_seconds*1000]+loaded
		return loaded


	def procvid(self):
		for i in range(len(self.vidlist)-1,-1,-1):
			videntity=self.vidlist[i]
			if videntity.seqzero==1:
				if i!=0:
					continue
			if videntity.order!=-1:
				shouldwait=False
				for j in range(len(self.vidlist)-1,-1,-1):
					videntity2=self.vidlist[j]
					if videntity2.order!=-1:
						if videntity2.order<videntity.order:
							shouldwait=True
				if shouldwait:
					continue

			if videntity.startms!=-1:
				if videntity.begin==False:
					videntity.content.set(cv2.CAP_PROP_POS_FRAMES,int(videntity.startms*self.fps/1000))
					videntity.alreadyf+=int(videntity.startms*self.fps/1000)
				#if videntity.startms<=self.getms():
				#	continue
			if videntity.endms!=-1:
				if videntity.endms<int(videntity.alreadyf*1000/self.fps):
					videntity.end=True
					videntity.content.release()
					continue

			if videntity.begin==False:
				videntity.begin=True
				if videntity.aud!=None:
					if videntity.startms!=-1 and videntity.endms!=-1:
						self.playdubaudio(videntity.aud[videntity.startms:videntity.endms])
					else:
						self.playdubaudio(videntity.aud)

			#repeat=False

			#if(videntity.repeat>0):
			#	if((videntity.alreadyf+1)%videntity.repeat==0):
			#		repeat=True
			#if(repeat):
			#	ret=True
			#else:
			cvcap=videntity.content
			ret,TryReadf=cvcap.read()
			#if(videntity.speed!=1):
			#	for rep in range(videntity.speed-1):
			#		ret,self.readedframe=cvcap.read()

			videntity.alreadyf+=1
			if(videntity.speed==2):
				ret,TryReadf=cvcap.read()
				videntity.alreadyf+=1

			if ret:
				#if((videntity.speed==2 and videntity.alreadyf%2==1) or (videntity.speed!=2)):
				self.readedframe=TryReadf
				self.readedframe=cv2.resize(self.readedframe,(self.screenw,self.screenh))
				self.imglist.append(PstImg(CvTool_cv2pil(self.readedframe).convert('RGBA'),blitonce=True,cx=videntity.cx,cy=videntity.cy,layer=videntity.layer))
			else:
				cvcap.release()
				videntity.end=True
				if i+1<len(self.vidlist):
					videntity=self.vidlist[i+1]
					if videntity.seqzero==1:
						cvcap=videntity.content
						if videntity.startms!=-1:
							cvcap.set(cv2.CAP_PROP_POS_FRAMES,int(videntity.startms*self.fps/1000))
						ret,TryReadf=cvcap.read()
						videntity.alreadyf+=1
						if ret:
							self.readedframe=TryReadf
							self.imglist.append(PstImg(CvTool_cv2pil(self.readedframe).convert('RGBA'),blitonce=True,cx=videntity.cx,cy=videntity.cy,layer=videntity.layer))

		for i in range(len(self.vidlist)-1,-1,-1):
			videntity=self.vidlist[i]
			if videntity.end:
				self.vidlist.pop(i)

	def procimgseq(self):
		if len(self.imgseqlist)>0:
			namel=self.imgseqlist[0][0]
			kwargs=self.imgseqlist[0][1]
			if len(namel)>0:
				frame=cv2.imread(self.imgseqbase+kwargs['name']+namel[0])
				namel.pop(0)
				self.imglist.append(PstImg(CvTool_cv2pil(frame).convert('RGBA'),blitonce=True,**kwargs))
			else:
				self.imgseqlist.pop(0)
	def clearinvaild(self,li):
		nowt=self.getms()
		for i in range(len(li)-1,-1,-1):
			if li[i].vaildbefore<nowt or li[i].blitonce:
				li.pop(i)

	def procimg(self):
		CvTool_bubblesortlayer(self.imglist)
		for im in self.imglist:
			if im.ismoving:
				eff=((self.getms()-im.bornf)/im.mdur)**im.mpow
				if eff>1:
					eff=1
				im.cx=im.mfx+(im.mtx-im.mfx)*eff
				im.cy=im.mfy+(im.mty-im.mfy)*eff
			toblit=im.content
			if im.isrotating:
				eff=((self.getms()-im.bornf)/im.rdur)**im.rpow
				if eff>1:
					eff=1
				ra=im.rfa+(im.rta-im.rfa)*eff
				rb=im.rfb+(im.rtb-im.rfb)*eff
				rg=im.rfg+(im.rtg-im.rfg)*eff
				if im.has_cvimg==False:
					im.cvimg=CvTool_pil2cv(im.content,has_alpha=True)
					im.has_cvimg=True
				toblit=im.cvimg
				toblit=CvTool_rotatecvimg(toblit,ra,rb,rg)
				toblit=CvTool_cv2pil(toblit,has_alpha=True).convert('RGBA')
			if im.isscaling:
				eff=((self.getms()-im.bornf)/im.sdur)**im.spow
				if eff>1:
					eff=1
				seff=im.sfe+(im.ste-im.sfe)*eff
				w,h=toblit.size
				toblit=toblit.resize((int(w*seff),int(h*seff)),Image.ANTIALIAS)			
			w,h=toblit.size
			self.screen.paste(toblit,(int(im.cx-w/2),int(im.cy-h/2)),mask=toblit)
		self.clearinvaild(self.imglist)

	def proccpn(self):
		self.clearinvaild(self.cpnlist)
		for cpn in self.cpnlist:
			if cpn.startms<=self.getms():
				self.blitcaption(cpn.content,cpn.cx,cpn.cy)
	def blitcaption(self,tx,cx,cy):
		d=ImageDraw.Draw(self.screen)
		left, top, right, bottom=d.textbbox(xy=(0,0),text=tx,font=self.capfont)#d.textsize(tx,font=self.capfont)
		width, height = right - left, bottom - top
		x=cx-width/2
		y=cy-height/2
		d.text((x,y),tx,self.fontcolor,self.capfont,stroke_width=4, stroke_fill='black')