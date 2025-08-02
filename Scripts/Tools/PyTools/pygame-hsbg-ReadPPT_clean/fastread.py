import cv2
import numpy as np
import subprocess
from pydub import AudioSegment

class FastReader:
	def __init__(self):
		self.base='D:/DocFile/Capture/done/Temp/'
		self.videoipt='raw.mp4'
		self.videoopt='out.mp4'
	
	def Speed(self):	
		vidipt=cv2.VideoCapture(self.base+self.videoipt)
		fourcc=cv2.VideoWriter_fourcc(*'mp4v')
		vidopt=cv2.VideoWriter(self.base+'nomusic.mp4',fourcc,30,(1920,1080))
		IsCuted=False
		cuted=None
		tick=0
		self.RecordFrame=0
		while True:
			ret,TryReadf=vidipt.read()
			#ret,TryReadf=vidipt.read()
			if(ret):
				Marker=np.sum(TryReadf[1030:1063,0:43])
				print(Marker)
				if(Marker<547252):
					vidopt.write(TryReadf)
					self.RecordFrame+=1
					tick=0
					if(IsCuted==False):
						cuted=TryReadf[1014:1080,0:63]
						IsCuted=True
				else:
					tick+=1
					if(tick<10):
						if(IsCuted):
							TryReadf[1014:1080,0:63]=cuted
						vidopt.write(TryReadf)
						self.RecordFrame+=1
			else:
				break
		vidopt.release()

	def AddMusic(self):
		vid=cv2.VideoCapture(self.base+'nomusic.mp4')
		TotalDurMs = int(vid.get(cv2.CAP_PROP_FRAME_COUNT)/30*1000)
		bgm=AudioSegment.from_wav(self.base+'Derniervol.wav')
		trunk=bgm+bgm+bgm+bgm
		bgmcut=trunk[0:TotalDurMs]
		bgmcut.export(self.base+'Derniervolcut.wav')

		p=subprocess.Popen('ffmpeg -i '+self.base+'nomusic.mp4 -i '+self.base+'Derniervolcut.wav '+self.base+self.videoopt+' -y')
		p.wait()

So=FastReader()
So.Speed()
So.AddMusic()
