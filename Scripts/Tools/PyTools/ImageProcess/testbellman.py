import numpy as np

gamma=0.9
v1=8
v2=10
v3=10
v4=10
for i in range(1000):
	v1=gamma*v2-1
	v2=gamma*v4+1
	v3=gamma*v4+1
	v4=gamma*v4+1

print(v1,v2,v3,v4)