using UnityEngine;
using System.Collections.Generic;

public class PlayRandomClipsOnAwake:MonoBehaviour{
	public List<AudioClip> ToPlay;

	public void Start()
	{
		AudioSource aus = this.gameObject.GetComponent<AudioSource>();
		if(aus!=null && ToPlay.Count>0)
		{
			int Index = UnityEngine.Random.Range(0,ToPlay.Count);
			AudioClip cp = ToPlay[Index];
			if(cp!=null)
			{
				aus.clip=cp;
				aus.Play();
			}
		}
	}
}