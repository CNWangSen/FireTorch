using UnityEngine;
using System.Collections.Generic;

public class BGMplayer: MonoBehaviour
{
	public List<AudioClip> m_possibleBGMclip = new List<AudioClip>();
	public AudioSource m_audioSource;
	public int BgmIndex=0;
	public bool enabled=false;

	void Start()
	{
		this.enabled=false;
		if(m_possibleBGMclip.Count>0)
		{
			this.enabled=true;
			m_possibleBGMclip.Shuffle();
			m_audioSource.clip = m_possibleBGMclip[BgmIndex];
			BgmIndex+=1;
		}
	}

	void Update()
	{
		if(!m_audioSource.isPlaying && this.enabled)
		{
			m_audioSource.clip = m_possibleBGMclip[BgmIndex%m_possibleBGMclip.Count];
			BgmIndex+=1;
			m_audioSource.Play();
		}
	}
}