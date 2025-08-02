import cv2
import numpy
import os
from pydub import AudioSegment
from pydub.silence import split_on_silence


def DubTool_detect_leading_silence(sound,silence_thresh=-50,chunk_size=10):
	trim_ms=0
	assert chunk_size>0
	while sound[trim_ms:trim_ms+chunk_size].dBFS<silence_thresh and trim_ms<len(sound):
		trim_ms+=chunk_size
	trim_ms-=300
	if trim_ms<0:
		trim_ms=0
	if trim_ms>len(sound):
		trim_ms=len(sound)
	return trim_ms
def DubTool_del_ht_silence(sound):
	start_trim=DubTool_detect_leading_silence(sound)
	end_trim=DubTool_detect_leading_silence(sound.reverse())
	sound=sound[start_trim:len(sound)-end_trim]
	return sound

class Sol:
	def __init__(self):
		self.rawvid=cv2.VideoCapture('D:/DocFile/Capture/raw.mp4')
		self.targetw=1080
		self.targeth=1080

		self.vidfps=self.rawvid.get(cv2.CAP_PROP_FPS)
		self.fourcc=cv2.VideoWriter_fourcc(*'mp4v')

	def distance(self,im1,im2):
		return 1000
		dis= numpy.sum(numpy.abs(im1-im2))
		return dis
	def cutframes(self,f1,f2,x,y,w,h):
		h=int(self.targeth/self.targetw*w)
		firstframe = None
		first = True

		if(f1==f2):
			self.rawvid.set(cv2.CAP_PROP_POS_FRAMES,f1)
			ret,im=self.rawvid.read()
			while ret:
				ret,im=self.rawvid.read()
				if(ret):
					if(first):
						firstframe = im
						first=False
					else:
						dis = self.distance(im,firstframe)
						if(dis<100):
							break
						else:
							print(dis)
					self.videoWriter.write(cv2.resize(im[y:y+h,x:x+w],[self.targetw,self.targeth]))
		else:	
			for f in range(f1,f2):
				#print(f)
				self.rawvid.set(cv2.CAP_PROP_POS_FRAMES,f)
				ret,im=self.rawvid.read()
				if(ret):
					if(first):
						firstframe = im
						first=False
					else:
						dis = self.distance(im,firstframe)
						if(dis<100):
							break
						else:
							print(dis)
					self.videoWriter.write(cv2.resize(im[y:y+h,x:x+w],[self.targetw,self.targeth]))
		
			for f in range(f2,f1,-1):
				#print(f)
				self.rawvid.set(cv2.CAP_PROP_POS_FRAMES,f)
				ret,im=self.rawvid.read()
				if(ret):
					if(first):
						firstframe = im
						first=False
					else:
						dis = self.distance(im,firstframe)
						if(dis<100):
							break
						else:
							print(dis)
					self.videoWriter.write(cv2.resize(im[y:y+h,x:x+w],[self.targetw,self.targeth]))
		
	def cut(self):
		t0=5
		t1=t0
		#左上
		x=int(630*1920/1920)
		y=int(0*1080/1080)
		w=1080
		h=1080
		self.targetw=w
		self.targeth=h
		self.videoWriter=cv2.VideoWriter('D:/DocFile/Capture/_VID.mp4',self.fourcc,self.vidfps,(self.targetw, self.targeth))
		self.cutframes(int(t0*self.vidfps),int(t1*self.vidfps),x,y,w,h)
		self.videoWriter.release()

	def CropAud(self):
		audpath="D:/DocFile/Capture/raw/"
		for f in os.listdir(audpath):
			print(f)
			if(".mp3" in f):
				rawaud=AudioSegment.from_mp3(audpath+f)
				print(rawaud.duration_seconds)
				sd = DubTool_del_ht_silence(rawaud)
				print(sd.duration_seconds)
				sd.export(audpath+"crop/"+f)


So=Sol()
So.cut()
#So.CropAud()

'''
A0NAME
A1START
A2THANKS
A3WOW
A4WELLPLAYED
A5OOPS
A6GREETINGS
A7THREATEN
A8ATTACK
A9CONCEDE
'''