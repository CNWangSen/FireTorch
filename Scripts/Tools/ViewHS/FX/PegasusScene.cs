using System;
using UnityEngine;

// Token: 0x02000623 RID: 1571
public class PegasusScene : MonoBehaviour
{
	// Token: 0x060055E7 RID: 21991 RVA: 0x001C3FD8 File Offset: 0x001C21D8
	protected virtual void Awake()
	{
		//SceneMgr sceneMgr = SceneMgr.Get();
		//if (sceneMgr != null)
		//{
		//	sceneMgr.SetScene(this);
		//	return;
		//}
		//Log.All.PrintWarning("PegasusScene.Awake called when SceneMgr is null!", Array.Empty<object>());
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x0000258D File Offset: 0x0000078D
	public virtual void PreUnload()
	{
	}

	// Token: 0x060055E9 RID: 21993 RVA: 0x0001F56D File Offset: 0x0001D76D
	public virtual bool IsUnloading()
	{
		return false;
	}

	// Token: 0x060055EA RID: 21994 RVA: 0x0000258D File Offset: 0x0000078D
	public virtual void Unload()
	{
	}

	// Token: 0x060055EB RID: 21995 RVA: 0x0001F56D File Offset: 0x0001D76D
	public virtual bool IsTransitioning()
	{
		return false;
	}

	// Token: 0x060055EC RID: 21996 RVA: 0x001C400C File Offset: 0x001C220C
	public virtual bool HandleKeyboardInput()
	{
		/*
		if (BackButton.backKey != KeyCode.None && InputCollection.GetKeyUp(BackButton.backKey))
		{
			if (DialogManager.Get().ShowingDialog())
			{
				DialogManager.Get().GoBack();
				return true;
			}
			if (ChatMgr.Get().IsFriendListShowing() || ChatMgr.Get().IsChatLogFrameShown())
			{
				ChatMgr.Get().GoBack();
				return true;
			}
			if (OptionsMenu.Get() != null && OptionsMenu.Get().IsShown())
			{
				OptionsMenu.Get().Hide(true);
				return true;
			}
			if (MiscellaneousMenu.Get() != null && MiscellaneousMenu.Get().IsShown())
			{
				MiscellaneousMenu.Get().Hide();
				return true;
			}
			if (BnetBar.Get() != null && BnetBar.Get().IsGameMenuShown())
			{
				BnetBar.Get().HideGameMenu();
				return true;
			}
			if (Navigation.GoBack())
			{
				return true;
			}
		}
		*/
		return false;
	}

	// Token: 0x060055ED RID: 21997 RVA: 0x001C40E8 File Offset: 0x001C22E8
	public virtual void ExecuteSceneDrivenTransition(Action onTransitionCompleteCallback)
	{
		//Log.All.PrintError("Scene.ExecuteSceneDrivenTransition - Function was not overridden!", Array.Empty<object>());
		onTransitionCompleteCallback();
	}

	// Token: 0x02001E1A RID: 7706
	// (Invoke) Token: 0x06010823 RID: 67619
	public delegate void BackButtonPressedDelegate();
}
