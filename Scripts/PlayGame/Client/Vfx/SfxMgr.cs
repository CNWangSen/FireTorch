using System;
using UnityEngine;
using System.Collections.Generic;

public class SfxMgr:MonoBehaviour
{
	public Dictionary<string,int> nowPlaying=new Dictionary<string,int>();
	public List<string> nowPlayingKeys = new List<string>();

	public AudioClip FX_MinionAttackLaunch;
	public static SfxMgr Instance;
	public void Awake()
	{
		Instance = this;
	}
	public void Update()
	{
		foreach(string s in nowPlayingKeys)
		{
			if(nowPlaying[s]>0)
				nowPlaying[s]-=1;
		}
	}

	public static SfxMgr Get()
	{
		return Instance;
	}
	public bool CanPlay(string sdef)
	{
		if(nowPlaying.ContainsKey(sdef))
		{
			if(nowPlaying[sdef]>0)
			{
				return false;
			}
			else{
				nowPlaying[sdef]=10;
				return true;
			}			
		}
		else{
			nowPlaying[sdef]=10;
			nowPlayingKeys.Add(sdef);
			return true;			
		}
	}
	public void PlayClip(AudioClip clip,GameObject srcobj=null)
	{
		UnityEngine.Debug.Log("PlayingSFX!111");
		if(srcobj!=null)
		{
			UnityEngine.Debug.Log("PlayingSFX!222");
            if (clip != null)
            {
            	UnityEngine.Debug.Log("PlayingSFX!333");
                AudioSource src = srcobj.AddComponent<AudioSource>();
                src.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("ALoud")[0];
                src.clip = clip;
                src.Play();
            }  			
		}
		else{
			
		}
	}
	public void PlaySoundByDef(SoundDef def, GameObject srcobj=null)
	{
		if (def == null)
		{
			foreach (SoundDef sd in srcobj.GetComponentsInChildren<SoundDef>())
	        {
	            def=sd;
	        }
			/*
			if (!this.m_VolumeScale.IsNone)
			{
				SoundManager.Get().SetVolume(source, this.m_VolumeScale.Value);
			}
			SoundManager.Get().Play(source, null, null, null);
			*/
		}
		else{

		}
		if(def==null)
		{

		}
		else
		{
			/*
			SoundPlayClipArgs soundPlayClipArgs = new SoundPlayClipArgs();
			soundPlayClipArgs.m_templateSource = source;
			soundPlayClipArgs.m_def = soundDef;
			if (!this.m_VolumeScale.IsNone)
			{
				soundPlayClipArgs.m_volume = new float?(this.m_VolumeScale.Value);
			}
			soundPlayClipArgs.m_parentObject = source.gameObject;
			if (SoundManager.Get() != null)
			{
				SoundManager.Get().PlayClip(soundPlayClipArgs, true, null);
			}
			*/
            if (def.m_AudioClip!="")//soundPlayClipArgs.m_def.m_AudioClip != "")
            {
            	if (SfxMgr.Get().CanPlay(def.m_AudioClip))
            	{
					AudioClip clip = HSViewer.LoadAudioClipFromSoundDefInPlayMaker(def.m_AudioClip);//soundPlayClipArgs.m_def.m_AudioClip);//abaud.LoadAsset<AudioClip>(audid);
	                if (clip != null)
	                {
	                    AudioSource src = srcobj.AddComponent<AudioSource>();
	                    src.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
	                    src.clip = clip;
	                    src.Play();
	                }            		
            	}
            }
		}		
	}
}