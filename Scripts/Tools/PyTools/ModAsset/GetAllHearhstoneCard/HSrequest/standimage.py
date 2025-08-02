import os

for home, dirs, files in os.walk("../Images/"):
	d=os.path.join(home)
	for filename in files:
		if('.meta' not in filename):
			f=os.path.join(home, filename)
			os.rename(f,f.replace("(","").replace("‘","").replace("’","").replace("-","").replace(")","").replace(",","").replace("!","").replace("ñ","").replace(":","").replace("'","").replace("?",""))

cnt=0
for home, dirs, files in os.walk("../Images/"):
	d=os.path.join(home)
	for filename in files:
		if('.meta' not in filename):
			cnt+=1
			print(cnt)
			f=os.path.join(home, filename)
			if("." in f[:-4]):
				print(f)
				#os.rename(f,f[:-4].replace(".","")+".jpg")
				print(f[:-4].replace(".","")+".jpg")