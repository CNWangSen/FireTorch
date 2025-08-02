from pydub import AudioSegment
from pydub.silence import split_on_silence
import edge_tts
import asyncio

def DubTool_detect_leading_silence(sound,silence_thresh=-50,chunk_size=10):
	trim_ms=0
	assert chunk_size>0
	while sound[trim_ms:trim_ms+chunk_size].dBFS<silence_thresh and trim_ms<len(sound):
		trim_ms+=chunk_size
	trim_ms-=300
	if trim_ms<0:
		trim_ms=0
	if trim_ms>len(sound):
		trim_ms=len(sound)
	return trim_ms
def DubTool_del_ht_silence(sound):
	start_trim=DubTool_detect_leading_silence(sound)
	end_trim=DubTool_detect_leading_silence(sound.reverse())
	sound=sound[start_trim:len(sound)-end_trim]
	return sound
async def DubTool_my_function(text,output):
	#GenL=[
	#'zh-CN-XiaoxiaoNeural',#0
	#'zh-CN-XiaoyiNeural',#1
	#'zh-CN-YunjianNeural',#2
	#'zh-CN-YunxiNeural',#3
	#'zh-CN-YunxiaNeural',#4
	#'zh-CN-YunyangNeural',#5波音
	#'zh-CN-liaoning-XiaobeiNeural',#6 东北
	#'zh-CN-shaanxi-XiaoniNeural',#7
	#'zh-HK-HiuGaaiNeural',#8
	#'zh-HK-HiuMaanNeural',#9
	#'zh-HK-WanLungNeural',#10
	#'zh-TW-HsiaoChenNeural',#11
	#'zh-TW-HsiaoYuNeural',#12
	#'zh-TW-YunJheNeural',#13
	#]
	tts = edge_tts.Communicate(text=text,voice='zh-CN-YunyangNeural',volume='+1000%',connect_timeout=1000,receive_timeout=1000)
	await tts.save(output)
def DubTool_getman(txt,path):
	asyncio.run(DubTool_my_function(text = txt,output=path))