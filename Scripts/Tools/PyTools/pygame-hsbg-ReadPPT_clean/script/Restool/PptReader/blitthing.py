class PstImg:
	def __init__(self,img=None,cx=-1,cy=-1,dur=-1,nowf=0,layer=0,
		blitonce=False,order=-1,
		mfx=-1,mfy=-1,mtx=-1,mty=-1,mdur=-1,mpow=2,
		rfa=0,rfb=0,rfg=0,rta=0,rtb=0,rtg=0,rdur=-1,rpow=2,
		sfe=10,ste=10,sdur=-1,spow=2,
		**kwargs):
		self.content=img
		self.cvimg=None
		self.has_cvimg=False
		self.bornf=nowf
		self.cx=cx
		self.cy=cy
		self.layer=layer
		self.vaildbefore=nowf+dur
		if cx==-1:
			self.cx=960
		if cy==-1:
			self.cy=540
		if dur==-1:
			self.vaildbefore=999999
		self.blitonce=blitonce

		self.order=order

		self.mfx=mfx
		self.mfy=mfy
		self.mtx=mtx
		self.mty=mty
		self.mdur=mdur
		self.ismoving=False
		if self.mdur!=-1:
			self.ismoving=True
			self.vaildbefore=nowf+self.mdur
		self.mpow=mpow

		self.degree2rad=3.1415926/180
		self.rfa=rfa*self.degree2rad
		self.rfb=rfb*self.degree2rad
		self.rfg=rfg*self.degree2rad
		self.rta=rta*self.degree2rad
		self.rtb=rtb*self.degree2rad
		self.rtg=rtg*self.degree2rad
		self.rdur=rdur
		self.isrotating=False
		if self.rdur!=-1:
			self.isrotating=True
			self.vaildbefore=nowf+self.rdur
		self.rpow=rpow

		self.sfe=sfe/10
		self.ste=ste/10
		self.sdur=sdur
		self.isscaling=False
		if self.sdur!=-1:
			self.isscaling=True
			self.vaildbefore=nowf+self.sdur
		self.spow=spow

class PstVid:
	def __init__(self,vid=None,cx=-1,cy=-1,startms=-1,endms=-1,layer=0,speed=1,fps=30,repeat=0,
		subx1=0,suby1=0,subx2=1920,suby2=1080,resizew=1920,resizeh=1080,
		order=-1,aud=None,seqzero=0,
		**kwargs):
		self.content=vid
		self.cx=cx
		self.cy=cy
		self.layer=layer
		self.speed=speed
		self.fps=fps
		self.repeat=repeat
		if cx==-1:
			self.cx=960
		if cy==-1:
			self.cy=540
		self.startms=startms
		self.endms=endms
		self.alreadyf=0

		self.subx1=subx1
		self.suby1=suby1
		self.subx2=subx2
		self.suby2=suby2
		self.resizew=resizew
		self.resizeh=resizeh

		self.order=order
		self.begin=False
		self.end=False
		self.aud=aud

		self.seqzero=seqzero



class PstCpn:
	def __init__(self,txt=None,cx=-1,cy=-1,dur=1000,nowf=0,layer=0,delay=-1,
		**kwargs):
		self.content=txt
		self.cx=cx
		self.cy=cy
		self.layer=layer
		self.vaildbefore=nowf+dur
		self.startms=nowf
		if delay!=-1:
			self.startms+=delay
			self.vaildbefore+=delay
		if cx==-1:
			self.cx=960
		if cy==-1:
			self.cy=860
		if dur==-1:
			self.vaildbefore=999999

		self.blitonce=False