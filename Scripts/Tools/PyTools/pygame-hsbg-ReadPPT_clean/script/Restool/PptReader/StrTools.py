import re

def StrTool_ParseCmdFromStr(cmdstr):
	cml=[]
	for s in cmdstr.split('|'):
		findres=re.findall(r"([a-zA-Z]*)=([^,)]*)",s)
		if len(findres)==0:
			break
		par=findres[0]
		p1=par[1]
		if par[1].isdecimal() or (par[1][0]=='-' and par[1][1:].isdecimal()):
			p1=int(par[1])
		cml.append((par[0],p1))
	kwargs=dict([(i,j) for (i,j) in cml])
	return kwargs