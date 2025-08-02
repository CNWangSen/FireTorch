from moviepy.video.io.ffmpeg_writer import ffmpeg_write_video

import moviepy.editor as mpy

clip = mpy.ImgSequenceClip(imglist,fps=25,with_mask=True,is_mask=False)
ffmpeg_write_video(clip,fv,fps=25,codec='png',pixel_format='rgba',with_mask=True)