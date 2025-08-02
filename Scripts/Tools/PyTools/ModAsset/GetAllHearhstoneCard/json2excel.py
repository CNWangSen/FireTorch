import csv
import json
import pandas as pd

class Sol:
	def __init__(self):
		self.jsonpath='D:/Projects/unity/CusCCGV2/Assets/Resources/Cards/AllCards.json'
		self.opt_csvpath='AllCards.csv'
		self.opt_jsonpath='AllCards.json'
	def json2excel(self):
		with open(self.jsonpath, 'r',encoding='utf-8') as f:
			data = json.load(f)
		f = open(self.opt_csvpath, 'w', encoding='gbk')
		csv_write = csv.writer(f)
		csv_write.writerow(data[0].keys())
		count=0
		for row in data:
			csv_write.writerow(row.values())
			count+=1
		f.close()
		data = pd.read_csv(self.opt_csvpath,encoding='gbk')
		res = data.dropna(how="all")
		res.to_csv(self.opt_csvpath, index=False,encoding='gbk')

	def str2int(self,st):
		return int(st)
	def str2list(self,st):
		li=[]
		for s in st.replace("[","").replace("]","").split(','):
			if(s!=''):
				li.append(int(s))
		return li
	def excel2json(self):
		csvfile = open(self.opt_csvpath,'r', encoding='gbk')
		jsonfile = open(self.opt_jsonpath, 'w',encoding='utf-8')
		fieldnames = ("SetId","DbfId","Classes","CnName","ScriptName","CardType","RareType","MinionType","ManaCost","Attack","MaxHealth","Targets","Description","RelatedDbfId")
		reader = csv.DictReader( csvfile, fieldnames)
		res=[]
		count=0
		for row in reader:
			if(count!=0):
				row["SetId"] = self.str2int(row["SetId"])
				row['DbfId'] = self.str2int(row['DbfId'])
				row['CardType'] = self.str2int(row['CardType'])
				row['RareType'] = self.str2int(row['RareType'])
				row['ManaCost'] = self.str2int(row['ManaCost'])
				row['Attack'] = self.str2int(row['Attack'])
				row['MaxHealth'] = self.str2int(row['MaxHealth'])
				row['Targets'] = self.str2int(row['Targets'])

				row['Classes'] = self.str2list(row['Classes'])
				row['MinionType'] = self.str2list(row['MinionType'])
				row['RelatedDbfId'] = self.str2list(row['RelatedDbfId'])

				res.append(row)
			count+=1
		out = json.dumps( res ,ensure_ascii=False)
		jsonfile.write(out)


So=Sol()
So.json2excel()
So.excel2json()