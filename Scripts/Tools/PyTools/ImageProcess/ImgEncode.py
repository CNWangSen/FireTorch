import base64

img_path="D:/DocFile/Unity3dRef/Assets/CusCCG_Ex_CardImg/FUS_001.jpg"
img_path="D:/Projects/GameHackProj/BepInPvz/BepInRH-AB/gatlingcattail"
with open(img_path,'rb') as f:
    image_base64 = base64.b64encode(f.read())

print(image_base64)