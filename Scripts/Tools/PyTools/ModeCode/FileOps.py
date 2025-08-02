import os
import shutil

allFN=[]
for r,d,f in os.walk(r"D:\Projects\unity\CusCCG\Assets\Addons\PlayMaker"):
	for fr in f:
		if(".meta" not in fr and ".cs" in fr and "Action" in fr):
			print(fr)
			allFN.append(fr)

base=r"D:\Projects\unity\CusCCG\Assets\Scripts\Tools\ViewHS\PlayMakerFromHS\\"
for f in os.listdir(base):
	if(".meta" not in f and f in allFN):
		print(f)
		os.remove(base+f)
		os.remove(base+f+".meta")
#for f in os.listdir(r"D:\DocFile\Unity3dAsset\HScode\Assembly-CSharp\HutongGames\PlayMaker\Actions"):
#	if("Action" in f):
#		clsname = f.replace('.cs','')
#		res="using System;\nusing System.Collections;\nusing UnityEngine;\n\nnamespace HutongGames.PlayMaker.Actions\n{"
#		res+="\n\tpublic class "+clsname+" : FsmStateAction\n\t{\n\t}\n}"
#		print(clsname)
#		with open("Csharp/"+clsname+".cs","w",encoding="utf-8") as opt:
#			opt.write(res)
#base="D:/DocFile/Unity3dRef/Assets/CusCCG_Ex_HS/"
#for f in os.listdir(base):
#	if("soundotherminion_base_zhcn-c9f52d29-audio-2.unity3d" in f):
#		print(f)


#for r,d,f in os.walk("../../../"):
#	for p in f:
#		if('git' in p):
#			print(p)

'''

base="../../../Resources/Cards/"
for d1 in os.listdir(base):
	if(".meta" not in d1):
		for d2 in os.listdir(base+d1+'/'):
			if(".meta" not in d2 and ".asset" not in d2):
				for d3 in os.listdir(base+d1+'/'+d2):
					if(".meta" not in d3 and ".asset" not in d3):
						for n in os.listdir(base+d1+"/"+d2+'/'+d3):
							
							fp=base+d1+'/'+d2+'/'+d3+'/'+n
							fp2=base+d1+'/'+d2+'/'+n
							#print(fp)
							shutil.move(fp,fp2)
					if('.asset' not in d3 and '.meta' not in d3):
						shutil.rmtree(base+d1+'/'+d2+'/'+d3)
						#print(base+d1+'/'+d2+'/'+d3)
base="../../../Resources/Cards/"
for d1 in os.listdir(base):
	if(".meta" not in d1):
		for d2 in os.listdir(base+d1+'/'):
			if(".meta" not in d2 and ".asset" not in d2):
				for d3 in os.listdir(base+d1+'/'+d2):
					if(".meta" not in d3 and ".asset" not in d3):
						p1=base+d1+'/'+d2+'/'+d3
						p2=base+d1+'/'+d2+'/'+d3+'.meta'
						shutil.rmtree(p1)
						os.remove(p2)

'''
