using UnityEngine;
using System.IO;


public class ExtractBG:MonoBehaviour
{
	public OneActorManager PreLoadActor;
	private int CNT=0;
	public void Update()
	{
		if(CNT==30)
		{
	    OneActorManager mgr = PreLoadActor;
		CardDbf.LoadAllCardDbf(GameMode.BattleGround);
		foreach(CardDbf db in CardDbf.AllBGSminionDbf)
		{
			if((db.m_noteMiniGuid+".txt").Contains("_G.txt"))
			{
				continue;
			}
            mgr.CustomInvokeVfxObject=null;
            mgr.CustomLaunchVfxObject=null;
            mgr.CustomLaunchReverseVfxObject=null;
            mgr.CustomImpactVfxObject=null;
            mgr.CustomFriendlyAEVfxObject=null;
            mgr.CustomOpposingAEVfxObject=null;
            mgr.CustomChainVfxObject=null;

            mgr.CustomInvokeVfxInfo = null;
            mgr.CustomLaunchVfxInfo = null;
            mgr.CustomImpactVfxInfo = null;
            mgr.CustomFriendlyAEVfxInfo = null;
            mgr.CustomOpposingAEVfxInfo = null;
            mgr.CustomChainVfxInfo = null;
            mgr.CustomVfxTargetInfo = null;
            //UnityEngine.Debug.Log("FUCKING------------------------"+db.m_noteMiniGuid);
            PreLoadActor.UpdateAsset(db,ZoneType.Board,PremiumType.Normal);

			Texture texture = PreLoadActor.Portait.gameObject.GetComponentsInChildren<Renderer>()[0].material.GetTexture("_MainTex");
			UnityEngine.Debug.Log(texture.name+"  "+db.m_noteMiniGuid);
			Texture2D texture2D = new Texture2D(texture.width, texture.height, TextureFormat.RGBA32, false);
			RenderTexture active = RenderTexture.active;
			RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 32);
			Graphics.Blit(texture, temporary, Vector2.one, Vector2.zero);
			RenderTexture.active = temporary;
			texture2D.ReadPixels(new Rect(0f, 0f, (float)temporary.width, (float)temporary.height), 0, 0);
			texture2D.Apply();
			RenderTexture.active = active;
			RenderTexture.ReleaseTemporary(temporary);
			byte[] bytes = texture2D.EncodeToPNG();
			if(db.RaceType.Count>0)
			{
				File.WriteAllText("D:/DocFile/Unity3dAsset/HsEx/HSCardImg/Test/"+db.m_noteMiniGuid+".txt", ((int)db.RaceType[0]).ToString());
			}
			else{
				File.WriteAllText("D:/DocFile/Unity3dAsset/HsEx/HSCardImg/Test/"+db.m_noteMiniGuid+".txt", "9");
			}
			
			//File.WriteAllBytes("D:/DocFile/Unity3dAsset/HsEx/HSCardImg/Test/"+db.m_noteMiniGuid+".png", bytes);
	    }
		}
		CNT+=1;

	}
	
}