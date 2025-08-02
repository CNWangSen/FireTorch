import pyautogui as pg
import time
import random

ids=[i+1 for i in range(30)]
random.shuffle(ids)
for x in ids:
	print(x)
#print(ids)
'''
PAUSETime=10
dy=(789-532)/8
sy=532

def FuckPage(ChapterPos,SectionTime,nowChapter,nowSection):
	while nowChapter<len(ChapterPos):
		while nowSection<len(SectionTime[nowChapter]):
			pg.moveTo(990,16)
			pg.click()
			time.sleep(PAUSETime)

			pg.moveTo(751,16)
			pg.click()
			time.sleep(PAUSETime)

			pg.moveTo(ChapterPos[nowChapter][0],ChapterPos[nowChapter][1])
			pg.click()
			time.sleep(PAUSETime)

			pg.moveTo(623,sy+nowSection*dy)#SectionPos[nowChapter][nowSection][0],SectionPos[nowChapter][nowSection][1])
			pg.click()
			time.sleep(PAUSETime)

			pg.moveTo(948,573)
			pg.click()
			time.sleep(SectionTime[nowChapter][nowSection]*60)
		
			nowSection+=1

		nowSection=0
		nowChapter+=1


time.sleep(5)
ChapterPos1=[
[988,129],[1213,126],
[756,331],[982,330],[1210,325],
[759,529],[982,523],[1215,526],
[759,739],[984,726],[1210,724],
]



SectionTime1=[
[21,27,17],[4,5,9,8,11,8,25,16,3],
[8,22,22,5,6],[13,36,29,3],[4,16,16,2,7,4,3],
[10,24,22,12,1],[5,26,23,12,1],[7,25],
[6,9,11,22,29,3],[14,21,16,4,3],[27,6,27,4],
]
nowChapter1=10
nowSection1=0
#FuckPage(ChapterPos1,SectionTime1,nowChapter1,nowSection1)


#pg.moveTo(1040,897)
#pg.click()
#time.sleep(5)


ChapterPos2=[
[757,327],[987,321],[1204,319],
[756,528],[982,526],[1210,526],
[759,727],
]
SectionTime2=[
[8,22,3],[5,10,12,14,9,18],[14,8,16,12,13],
[25,20,22],[7,15,22,15],[9,10,10,13,17],
[30,1,4,10,11,8,38,4,18],
]
nowChapter2=4
nowSection2=2

#FuckPage(ChapterPos2,SectionTime2,nowChapter2,nowSection2)

#import os
#import subprocess

#base='res/readres/Aud/Bgm/'
#for f in os.listdir(base):
#	os.rename(base+f,base+f.replace(' ','_'))
#for f in os.listdir(base):
#	print(f)
#	p=subprocess.Popen('ffmpeg -i '+base+f+' '+base+'wav/'+f[:-4]+'.wav')
#	p.wait()

xl=[506,508,499,503,504,510,497,512,514,505,493,496,506,502,509,496]

miu=0
D=0
for x in xl:
	miu+=x
miu=miu/len(xl)

for x in xl:
	D+=(x-miu)**2
D=D/(len(xl)-1)
print(miu,D**(0.5))


from pydub import AudioSegment
import os

base='D:/Projects/python/pygame-hsbg-ReadPPT/res/readres/Aud/Bgm/'
for f in os.listdir(base):
	aud=AudioSegment.from_mp3(base+f)
	print(f)
	print(aud.dBFS)
'''