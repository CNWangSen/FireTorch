import cv2
import numpy as np
from PIL import Image, ImageDraw, ImageFont

def CvTool_cv2pil(img_cv,has_alpha=False):
	if has_alpha:
		return Image.fromarray(cv2.cvtColor(img_cv,cv2.COLOR_BGRA2RGBA))
	else:
		return Image.fromarray(cv2.cvtColor(img_cv,cv2.COLOR_BGR2RGB))
def CvTool_pil2cv(img_pil,has_alpha=False):
	if has_alpha:
		return cv2.cvtColor(np.asarray(img_pil),cv2.COLOR_RGBA2BGRA)
	else:
		return cv2.cvtColor(np.asarray(img_pil),cv2.COLOR_RGB2BGR)



def CvTool_PageTurn(Ffirst,Flast,Fnow,Ftotal):
	imh=1080
	imw=1920
	padp=int(imw-imw*(Fnow/Ftotal)**2)
	if padp<=0:
		padp=0
	if padp>=imw:
		padp=imw-1
	padw=imw-padp
	padsmall=padp-padw
	if(padsmall<=0):
		padsmall=0

	img=np.zeros((imh,imw,3),dtype=np.uint8)
	img[0:imh,0:imw]=Ffirst[0:imh,0:imw]

	mirror=Ffirst[0:imh,padp:padp+(padp-padsmall)]

	img[0:imh,padsmall:padp]=cv2.addWeighted(img[0:imh,padsmall:padp],0.5,cv2.flip(mirror,1),0.5,0)
	img[0:imh,padp:imw]=Flast[0:imh,padp:imw]
	return img

def CvTool_bubblesortlayer(li):
	N=len(li)
	for p1 in range(N-1):
		for p2 in range(N-1-p1):
			if li[p2].layer>li[p2+1].layer:
				li[p2],li[p2+1]=li[p2+1],li[p2] 

def CvTool_rogue(vx,vy,vz,ux,uy,uz,theta):
	co=np.cos(theta)
	sn=np.sin(theta)
	do=(1-co)*(ux*vx+uy*vy+uz*vz)
	vpx=vx*co+do*ux+sn*(uy*vz-uz*vy)
	vpy=vy*co+do*uy+sn*(-ux*vz+uz*vx)
	vpz=vz*co+do*uz+sn*(ux*vy-uy*vx)
	return vpx,vpy,vpz
def CvTool_rotatevector(v,alpha,beta,gamma):
	vx=v[0]
	vy=v[1]
	vz=0
	vx,vy,vz=CvTool_rogue(vx,vy,vz,1,0,0,alpha)
	vx,vy,vz=CvTool_rogue(vx,vy,vz,0,1,0,beta)
	vx,vy,vz=CvTool_rogue(vx,vy,vz,0,0,1,gamma)
	return [vx,vy]
def CvTool_getrotated(w,h,alpha,beta,gamma):
	v1=[-w/2,-h/2]
	v2=[w/2,-h/2]
	v3=[-w/2,h/2]
	v4=[w/2,h/2]
	v1=CvTool_rotatevector(v1,alpha,beta,gamma)
	v2=CvTool_rotatevector(v2,alpha,beta,gamma)
	v3=CvTool_rotatevector(v3,alpha,beta,gamma)
	v4=CvTool_rotatevector(v4,alpha,beta,gamma)
	l=np.array([
		[v1[0]+w/2, v1[1]+h/2],[v2[0]+w/2, v2[1]+h/2], 
		[v3[0]+w/2, v3[1]+h/2],[v4[0]+w/2, v4[1]+h/2]
	], np.float32)
	return l
def CvTool_rotatecvimg(image,alpha,beta,gamma):
	h, w = image.shape[:2]
	anl=getrotated(w,h,alpha,beta,gamma)
	A = cv2.getPerspectiveTransform(
	np.array([[0, 0], [w, 0], [0, h], [w, h]], np.float32),anl)
	image = cv2.warpPerspective(image, A, (w, h))
	return image


if __name__ == '__main__':
    CvTool_PageTurn(cv2.imread('1.png'),cv2.imread('2.png'),3,30)