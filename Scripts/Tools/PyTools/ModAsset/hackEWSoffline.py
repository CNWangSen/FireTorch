"""
import cv2

im=cv2.imread("D:/Download/Share/c.jpg",cv2.IMREAD_UNCHANGED)

r,g,b=cv2.split(im)

a=r.copy()
h,w,c=im.shape

for i in range(h):
	for j in range(w):
		if(r[i][j]+b[i][j]+g[i][j]>150):
			a[i][j]=0
		else:
			a[i][j]=255
		r[i][j]=0
		g[i][j]=0
		b[i][j]=0

cv2.imwrite("D:/Download/Share/c2.png",cv2.merge([r,g,b,a]))
"""
import pyautogui as pg
import time


def VegraffSword():
	time.sleep(5)
	Cnt=0
	while(Cnt<2000010):
		pg.moveTo(547,980)#Start
		time.sleep(0.1)
		pg.click()

		pg.keyDown('d')
		time.sleep(5.3)
		pg.keyUp('d')
		pg.press('3')
		pg.press('3')
		pg.press('3')
		pg.press('3')
		pg.press('3')
		pg.press('3')
		time.sleep(3.4)
		pg.moveTo(895,863)#PlayAgain
		time.sleep(0.3)
		pg.click()
		Cnt+=1

def qSummon():
	time.sleep(5)
	Cnt=0
	while(Cnt<2000010):
		pg.moveTo(547,980)#Start
		time.sleep(0.1)
		pg.click()

		pg.press('q')
		pg.press('q')
		pg.press('q')
		pg.press('q')
		pg.press('3')
		pg.press('3')
		pg.press('3')
		pg.press('q')
		pg.press('q')
		pg.press('q')
		pg.press('3')

		time.sleep(3.4)
		pg.moveTo(895,863)#PlayAgain
		time.sleep(0.3)
		pg.click()
		Cnt+=1

qSummon()
