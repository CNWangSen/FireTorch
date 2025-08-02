import cv2
import os
import shutil

resbase="D:/DocFile/Unity3dAsset/HsEx/Texture2D/"
outbase="D:/DocFile/Unity3dAsset/HsEx/DataSetTexture2D/"
os.mkdir(outbase)
for f in os.listdir(resbase):
	if('.png' in f):
		im = cv2.imread(resbase+f)
		try:
			h,w,c=im.shape
			if(h==512 and w==512):
				if('Mask' not in f):
					if(f[-8]=='-'):
						#print(f)
						shutil.copy(resbase+f,outbase+f)
		except:
			pass