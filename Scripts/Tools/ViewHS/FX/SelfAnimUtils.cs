using System;
using UnityEngine;

// Token: 0x020009EF RID: 2543
public class SelfAnimUtils : MonoBehaviour
{
	// Token: 0x060086C4 RID: 34500 RVA: 0x002C3168 File Offset: 0x002C1368
	public void PrintLog(string message)
	{
		Debug.Log(message);
	}

	// Token: 0x060086C5 RID: 34501 RVA: 0x002C3170 File Offset: 0x002C1370
	public void PrintLogWarning(string message)
	{
		Debug.LogWarning(message);
	}

	// Token: 0x060086C6 RID: 34502 RVA: 0x002C3178 File Offset: 0x002C1378
	public void PrintLogError(string message)
	{
		Debug.LogError(message);
	}

	// Token: 0x060086C7 RID: 34503 RVA: 0x002C3180 File Offset: 0x002C1380
	public void PlayAnimation()
	{
		if (base.GetComponent<Animation>() != null)
		{
			base.GetComponent<Animation>().Play();
		}
	}

	// Token: 0x060086C8 RID: 34504 RVA: 0x002C319C File Offset: 0x002C139C
	public void StopAnimation()
	{
		if (base.GetComponent<Animation>() != null)
		{
			base.GetComponent<Animation>().Stop();
		}
	}

	// Token: 0x060086C9 RID: 34505 RVA: 0x00027B5D File Offset: 0x00025D5D
	public void ActivateHierarchy()
	{
		base.gameObject.SetActive(true);
	}

	// Token: 0x060086CA RID: 34506 RVA: 0x00027B6B File Offset: 0x00025D6B
	public void DeactivateHierarchy()
	{
		base.gameObject.SetActive(false);
	}

	// Token: 0x060086CB RID: 34507 RVA: 0x0003CEA2 File Offset: 0x0003B0A2
	public void DestroyHierarchy()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060086CC RID: 34508 RVA: 0x002C31B7 File Offset: 0x002C13B7
	public void FadeIn(float FadeSec)
	{
		//iTween.FadeTo(base.gameObject, 1f, FadeSec);
	}

	// Token: 0x060086CD RID: 34509 RVA: 0x002C31CA File Offset: 0x002C13CA
	public void FadeOut(float FadeSec)
	{
		//iTween.FadeTo(base.gameObject, 0f, FadeSec);
	}

	// Token: 0x060086CE RID: 34510 RVA: 0x002C31E0 File Offset: 0x002C13E0
	public void SetAlphaHierarchy(float alpha)
	{
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			RenderMaterialCleaner.AttachTo(renderer);
			if (renderer.material.HasProperty("_Color"))
			{
				Color color = renderer.material.color;
				color.a = alpha;
				renderer.material.color = color;
			}
		}
	}

	// Token: 0x060086CF RID: 34511 RVA: 0x002C3240 File Offset: 0x002C1440
	public void PlayDefaultSound()
	{
		if (base.GetComponent<AudioSource>() == null)
		{
			Debug.LogError(string.Format("SelfAnimUtils.PlayDefaultSound() - Tried to play the AudioSource on {0} but it has no AudioSource. You need an AudioSource to use this function.", base.gameObject));
			return;
		}
		//if (SoundManager.Get() == null)
		//{
		//	base.GetComponent<AudioSource>().Play();
		//	return;
		//}
		//SoundManager.Get().Play(base.GetComponent<AudioSource>(), null, null, null);
	}

	// Token: 0x060086D0 RID: 34512 RVA: 0x002C3298 File Offset: 0x002C1498
	public void PlaySound(SoundDef clip)
	{
		if (clip == null)
		{
			Debug.LogError(string.Format("SelfAnimUtils.PlayDefaultSound() - No clip was given when trying to play the AudioSource on {0}. You need a clip to use this function.", base.gameObject));
			return;
		}
		if (base.GetComponent<AudioSource>() == null)
		{
			Debug.LogError(string.Format("SelfAnimUtils.PlayDefaultSound() - Tried to play clip {0} on {1} but it has no AudioSource. You need an AudioSource to use this function.", clip, base.gameObject));
			return;
		}
		//if (SoundManager.Get() == null)
		//{
		//	Debug.LogErrorFormat("TargetAnimutils2: SoundManager is null attempting to play {0}", new object[]
		//	{
		//		clip.m_AudioClip
		//	});
		//	return;
		//}
		//SoundManager.Get().PlayOneShot(base.GetComponent<AudioSource>(), clip, 1f, null);
	}

	// Token: 0x060086D1 RID: 34513 RVA: 0x002C3322 File Offset: 0x002C1522
	public void RandomRotationX()
	{
		//TransformUtil.SetEulerAngleX(base.gameObject, UnityEngine.Random.Range(0f, 360f));
	}

	// Token: 0x060086D2 RID: 34514 RVA: 0x002C333E File Offset: 0x002C153E
	public void RandomRotationY()
	{
		//TransformUtil.SetEulerAngleY(base.gameObject, UnityEngine.Random.Range(0f, 360f));
	}

	// Token: 0x060086D3 RID: 34515 RVA: 0x002C335A File Offset: 0x002C155A
	public void RandomRotationZ()
	{
		//TransformUtil.SetEulerAngleZ(base.gameObject, UnityEngine.Random.Range(0f, 360f));
	}
}
