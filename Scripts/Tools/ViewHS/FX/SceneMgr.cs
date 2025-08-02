using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
//using Hearthstone;
//using Hearthstone.Core;
//using Hearthstone.Core.Jobs;
//using Hearthstone.Core.Services;
//using Hearthstone.Streaming;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000627 RID: 1575
public class SceneMgr:MonoBehaviour// : IService, IHasUpdate
{
	/*
	// Token: 0x0600561C RID: 22044 RVA: 0x001C5B6C File Offset: 0x001C3D6C
	public void RegisterDetermineStartupSceneCallback(StartupSceneSource source, DetermineStartupSceneCallback cb)
	{
		DetermineStartupSceneCallback determineStartupSceneCallback;
		if (this.m_startupSceneCallbacks.TryGetValue(source, out determineStartupSceneCallback))
		{
			Log.All.PrintError("RegisterDetermineStartupSceneCallback error: source={0} already registered to {1} - will overwrite with {2}.", new object[]
			{
				source,
				determineStartupSceneCallback,
				cb
			});
		}
		this.m_startupSceneCallbacks[source] = cb;
	}

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x0600561D RID: 22045 RVA: 0x001C5BBC File Offset: 0x001C3DBC
	// (set) Token: 0x0600561E RID: 22046 RVA: 0x001C5BC4 File Offset: 0x001C3DC4
	public LoadingScreen LoadingScreen { get; private set; }

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x0600561F RID: 22047 RVA: 0x001C5BCD File Offset: 0x001C3DCD
	public GameObject SceneObject
	{
		get
		{
			if (this.m_sceneObject == null)
			{
				this.m_sceneObject = new GameObject("SceneMgr", new Type[]
				{
					typeof(HSDontDestroyOnLoad)
				});
			}
			return this.m_sceneObject;
		}
	}

	// Token: 0x06005620 RID: 22048 RVA: 0x001C5C06 File Offset: 0x001C3E06
	public IEnumerator<IAsyncJobResult> Initialize(ServiceLocator serviceLocator)
	{
		FatalErrorMgr.Get().AddErrorListener(new FatalErrorMgr.ErrorCallback(this.OnFatalError));
		this.m_transitioning = true;
		LoadComponentFromResource<LoadingScreen> loadLoadingScreen = new LoadComponentFromResource<LoadingScreen>("Prefabs/LoadingScreen", LoadResourceFlags.AutoInstantiateOnLoad | LoadResourceFlags.FailOnError);
		yield return loadLoadingScreen;
		this.LoadingScreen = loadLoadingScreen.LoadedComponent;
		this.LoadingScreen.RegisterSceneListeners(this);
		this.LoadingScreen.transform.parent = this.SceneObject.transform;
		HearthstoneApplication.Get().WillReset += this.WillReset;
		if (this.IsModeRequested(SceneMgr.Mode.FATAL_ERROR))
		{
			yield break;
		}
		this.QueueLoadBoxJob();
		this.RegisterSceneLoadedEvent(new SceneMgr.SceneLoadedCallback(this.UpdatePerformanceTrackingFromModeSwitch));
		yield break;
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x001C5C18 File Offset: 0x001C3E18
	public Type[] GetDependencies()
	{
		return new Type[]
		{
			typeof(GameDownloadManager),
			typeof(Network),
			typeof(GameDbf),
			typeof(IAssetLoader),
			typeof(FontTable)
		};
	}

	// Token: 0x06005622 RID: 22050 RVA: 0x001C5C6C File Offset: 0x001C3E6C
	public void Shutdown()
	{
		SceneMgr.s_instance = null;
		this.LoadingScreen.UnregisterSceneListeners(this);
		this.UnregisterSceneLoadedEvent(new SceneMgr.SceneLoadedCallback(this.UpdatePerformanceTrackingFromModeSwitch));
		HearthstoneApplication.Get().WillReset -= this.WillReset;
	}

	// Token: 0x06005623 RID: 22051 RVA: 0x001C5CAC File Offset: 0x001C3EAC
	public void LoadShaderPreCompiler()
	{
		if (PlatformSettings.IsMobile() && PlatformSettings.RuntimeOS != OSCategory.Android)
		{
			AssetReference assetReference = new AssetReference("ShaderPreCompiler.prefab:380ca3ee11a2643068cfb3d4766f3fd3");
			GameObject gameObject = AssetLoader.Get().InstantiatePrefab(assetReference, AssetLoadingOptions.None);
			if (gameObject == null)
			{
				Debug.LogError(string.Format("SceneMgr.LoadShaderPreCompiler() - FAILED to load prefab", assetReference));
				return;
			}
			gameObject.transform.parent = this.SceneObject.transform;
		}
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x001C5D18 File Offset: 0x001C3F18
	public void Update()
	{
		if (!this.m_reloadMode)
		{
			if (this.m_nextMode == SceneMgr.Mode.INVALID)
			{
				return;
			}
			if (this.m_mode == this.m_nextMode)
			{
				this.m_nextMode = SceneMgr.Mode.INVALID;
				return;
			}
		}
		this.m_transitioning = true;
		this.m_performFullCleanup = !this.m_reloadMode;
		this.m_prevMode = this.m_mode;
		this.m_mode = this.m_nextMode;
		this.m_nextMode = SceneMgr.Mode.INVALID;
		this.m_reloadMode = false;
		if (this.m_scene != null)
		{
			if (this.m_switchModeCoroutine != null)
			{
				Processor.CancelCoroutine(this.m_switchModeCoroutine);
			}
			IEnumerator routine = this.IsDoingSceneDrivenTransition() ? this.SwitchModeWithSceneDrivenTransition() : this.SwitchMode();
			this.m_switchModeCoroutine = Processor.RunCoroutine(routine, this);
			return;
		}
		this.LoadMode();
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x001C5DD4 File Offset: 0x001C3FD4
	public static SceneMgr Get()
	{
		if (SceneMgr.s_instance == null)
		{
			SceneMgr.s_instance = HearthstoneServices.Get<SceneMgr>();
		}
		return SceneMgr.s_instance;
	}

	// Token: 0x06005626 RID: 22054 RVA: 0x001C5DEC File Offset: 0x001C3FEC
	public static bool IsInitialized()
	{
		return SceneMgr.s_instance != null;
	}

	// Token: 0x06005627 RID: 22055 RVA: 0x001C5DF8 File Offset: 0x001C3FF8
	private void WillReset()
	{
		Log.Reset.Print("SceneMgr.WillReset()", Array.Empty<object>());
		if (HearthstoneApplication.IsPublic())
		{
			TimeScaleMgr.Get().SetGameTimeScale(1f);
			TimeScaleMgr.Get().SetTimeScaleMultiplier(1f);
		}
		Processor.StopAllCoroutinesWithObjectRef(this);
		FatalErrorMgr.Get().AddErrorListener(new FatalErrorMgr.ErrorCallback(this.OnFatalError));
		this.m_mode = SceneMgr.Mode.STARTUP;
		this.m_nextMode = SceneMgr.Mode.INVALID;
		this.m_prevMode = SceneMgr.Mode.INVALID;
		this.m_reloadMode = false;
		PegasusScene scene = this.m_scene;
		if (scene != null)
		{
			scene.PreUnload();
		}
		this.FireScenePreUnloadEvent(scene);
		if (this.m_scene != null)
		{
			this.m_scene.Unload();
			this.m_scene = null;
			this.m_sceneLoaded = false;
		}
		this.FireSceneUnloadedEvent(scene);
		this.PostUnloadCleanup();
		this.QueueLoadBoxJob();
		Log.Reset.Print("\tSceneMgr.WillReset() completed", Array.Empty<object>());
	}

	// Token: 0x06005628 RID: 22056 RVA: 0x001C5EE4 File Offset: 0x001C40E4
	public void SetNextMode(SceneMgr.Mode mode, SceneMgr.TransitionHandlerType transitionHandler = SceneMgr.TransitionHandlerType.SCENEMGR, SceneMgr.OnSceneLoadCompleteForSceneDrivenTransition onLoadCompleteCallback = null)
	{
		if (this.IsModeRequested(SceneMgr.Mode.FATAL_ERROR))
		{
			return;
		}
		this.CacheModeForResume(mode);
		this.m_nextMode = mode;
		this.m_reloadMode = false;
		this.m_transitionHandlerType = transitionHandler;
		if (transitionHandler == SceneMgr.TransitionHandlerType.CURRENT_SCENE || transitionHandler == SceneMgr.TransitionHandlerType.NEXT_SCENE)
		{
			if (transitionHandler == SceneMgr.TransitionHandlerType.CURRENT_SCENE && onLoadCompleteCallback == null)
			{
				Log.All.PrintError("SceneMgr - SetNextMode did not provide the required callback!", Array.Empty<object>());
			}
			this.m_onSceneLoadCompleteForSceneDrivenTransitionCallback = onLoadCompleteCallback;
		}
	}

	// Token: 0x06005629 RID: 22057 RVA: 0x001C5F42 File Offset: 0x001C4142
	public void ReloadMode()
	{
		if (this.IsModeRequested(SceneMgr.Mode.FATAL_ERROR))
		{
			return;
		}
		this.m_nextMode = this.m_mode;
		this.m_reloadMode = true;
	}

	// Token: 0x0600562A RID: 22058 RVA: 0x001C5F62 File Offset: 0x001C4162
	public void ReturnToPreviousMode()
	{
		if (this.IsModeRequested(SceneMgr.Mode.FATAL_ERROR))
		{
			return;
		}
		this.CacheModeForResume(this.m_prevMode);
		this.m_nextMode = this.m_prevMode;
		this.m_reloadMode = false;
	}

	// Token: 0x0600562B RID: 22059 RVA: 0x001C5F8E File Offset: 0x001C418E
	public SceneMgr.Mode GetPrevMode()
	{
		return this.m_prevMode;
	}

	// Token: 0x0600562C RID: 22060 RVA: 0x001C5F96 File Offset: 0x001C4196
	public SceneMgr.Mode GetMode()
	{
		return this.m_mode;
	}

	// Token: 0x0600562D RID: 22061 RVA: 0x001C5F9E File Offset: 0x001C419E
	public SceneMgr.Mode GetNextMode()
	{
		return this.m_nextMode;
	}

	// Token: 0x0600562E RID: 22062 RVA: 0x001C5FA6 File Offset: 0x001C41A6
	public PegasusScene GetScene()
	{
		return this.m_scene;
	}

	// Token: 0x0600562F RID: 22063 RVA: 0x001C5FAE File Offset: 0x001C41AE
	public void SetScene(PegasusScene scene)
	{
		this.m_scene = scene;
	}

	// Token: 0x06005630 RID: 22064 RVA: 0x001C5FB7 File Offset: 0x001C41B7
	public bool IsSceneLoaded()
	{
		return this.m_sceneLoaded;
	}

	// Token: 0x06005631 RID: 22065 RVA: 0x001C5FBF File Offset: 0x001C41BF
	public bool WillTransition()
	{
		return this.m_reloadMode || (this.m_nextMode != SceneMgr.Mode.INVALID && this.m_nextMode != this.m_mode);
	}

	// Token: 0x06005632 RID: 22066 RVA: 0x001C5FE6 File Offset: 0x001C41E6
	public bool IsTransitioning()
	{
		return this.m_transitioning;
	}

	// Token: 0x06005633 RID: 22067 RVA: 0x001C5FEE File Offset: 0x001C41EE
	public bool IsTransitionNowOrPending()
	{
		return this.IsTransitioning() || this.WillTransition();
	}

	// Token: 0x06005634 RID: 22068 RVA: 0x001C6005 File Offset: 0x001C4205
	public bool IsDoingSceneDrivenTransition()
	{
		return this.m_transitionHandlerType == SceneMgr.TransitionHandlerType.CURRENT_SCENE || this.m_transitionHandlerType == SceneMgr.TransitionHandlerType.NEXT_SCENE;
	}

	// Token: 0x06005635 RID: 22069 RVA: 0x001C601B File Offset: 0x001C421B
	public bool IsModeRequested(SceneMgr.Mode mode)
	{
		return this.m_mode == mode || this.m_nextMode == mode;
	}

	// Token: 0x06005636 RID: 22070 RVA: 0x001C6034 File Offset: 0x001C4234
	public bool IsInGame()
	{
		return this.IsModeRequested(SceneMgr.Mode.GAMEPLAY);
	}

	// Token: 0x06005637 RID: 22071 RVA: 0x001C603D File Offset: 0x001C423D
	public bool IsInTavernBrawlMode()
	{
		return this.GetMode() == SceneMgr.Mode.TAVERN_BRAWL || (this.GetMode() == SceneMgr.Mode.FIRESIDE_GATHERING && FiresideGatheringManager.Get().InBrawlMode());
	}

	// Token: 0x06005638 RID: 22072 RVA: 0x001C6061 File Offset: 0x001C4261
	public bool IsInDuelsMode()
	{
		return this.GetMode() == SceneMgr.Mode.PVP_DUNGEON_RUN;
	}

	// Token: 0x06005639 RID: 22073 RVA: 0x001C606D File Offset: 0x001C426D
	public void NotifySceneLoaded()
	{
		this.m_sceneLoaded = true;
		if (this.ShouldUseSceneLoadDelays())
		{
			Processor.RunCoroutine(this.WaitThenFireSceneLoadedEvent(), this);
			return;
		}
		this.FireSceneLoadedEvent();
	}

	// Token: 0x0600563A RID: 22074 RVA: 0x001C6092 File Offset: 0x001C4292
	public void RegisterScenePreUnloadEvent(SceneMgr.ScenePreUnloadCallback callback)
	{
		this.RegisterScenePreUnloadEvent(callback, null);
	}

	// Token: 0x0600563B RID: 22075 RVA: 0x001C609C File Offset: 0x001C429C
	public void RegisterScenePreUnloadEvent(SceneMgr.ScenePreUnloadCallback callback, object userData)
	{
		SceneMgr.ScenePreUnloadListener scenePreUnloadListener = new SceneMgr.ScenePreUnloadListener();
		scenePreUnloadListener.SetCallback(callback);
		scenePreUnloadListener.SetUserData(userData);
		if (this.m_scenePreUnloadListeners.Contains(scenePreUnloadListener))
		{
			return;
		}
		this.m_scenePreUnloadListeners.Add(scenePreUnloadListener);
	}

	// Token: 0x0600563C RID: 22076 RVA: 0x001C60D8 File Offset: 0x001C42D8
	public bool UnregisterScenePreUnloadEvent(SceneMgr.ScenePreUnloadCallback callback)
	{
		return this.UnregisterScenePreUnloadEvent(callback, null);
	}

	// Token: 0x0600563D RID: 22077 RVA: 0x001C60E4 File Offset: 0x001C42E4
	public bool UnregisterScenePreUnloadEvent(SceneMgr.ScenePreUnloadCallback callback, object userData)
	{
		SceneMgr.ScenePreUnloadListener scenePreUnloadListener = new SceneMgr.ScenePreUnloadListener();
		scenePreUnloadListener.SetCallback(callback);
		scenePreUnloadListener.SetUserData(userData);
		return this.m_scenePreUnloadListeners.Remove(scenePreUnloadListener);
	}

	// Token: 0x0600563E RID: 22078 RVA: 0x001C6111 File Offset: 0x001C4311
	public static bool UnregisterScenePreUnloadEventFromInstance(SceneMgr.ScenePreUnloadCallback callback)
	{
		return SceneMgr.s_instance != null && SceneMgr.s_instance.UnregisterScenePreUnloadEvent(callback);
	}

	// Token: 0x0600563F RID: 22079 RVA: 0x001C6127 File Offset: 0x001C4327
	public void RegisterSceneUnloadedEvent(SceneMgr.SceneUnloadedCallback callback)
	{
		this.RegisterSceneUnloadedEvent(callback, null);
	}

	// Token: 0x06005640 RID: 22080 RVA: 0x001C6134 File Offset: 0x001C4334
	public void RegisterSceneUnloadedEvent(SceneMgr.SceneUnloadedCallback callback, object userData)
	{
		SceneMgr.SceneUnloadedListener sceneUnloadedListener = new SceneMgr.SceneUnloadedListener();
		sceneUnloadedListener.SetCallback(callback);
		sceneUnloadedListener.SetUserData(userData);
		if (this.m_sceneUnloadedListeners.Contains(sceneUnloadedListener))
		{
			return;
		}
		this.m_sceneUnloadedListeners.Add(sceneUnloadedListener);
	}

	// Token: 0x06005641 RID: 22081 RVA: 0x001C6170 File Offset: 0x001C4370
	public bool UnregisterSceneUnloadedEvent(SceneMgr.SceneUnloadedCallback callback)
	{
		return this.UnregisterSceneUnloadedEvent(callback, null);
	}

	// Token: 0x06005642 RID: 22082 RVA: 0x001C617C File Offset: 0x001C437C
	public bool UnregisterSceneUnloadedEvent(SceneMgr.SceneUnloadedCallback callback, object userData)
	{
		SceneMgr.SceneUnloadedListener sceneUnloadedListener = new SceneMgr.SceneUnloadedListener();
		sceneUnloadedListener.SetCallback(callback);
		sceneUnloadedListener.SetUserData(userData);
		return this.m_sceneUnloadedListeners.Remove(sceneUnloadedListener);
	}

	// Token: 0x06005643 RID: 22083 RVA: 0x001C61A9 File Offset: 0x001C43A9
	public void RegisterScenePreLoadEvent(SceneMgr.ScenePreLoadCallback callback)
	{
		this.RegisterScenePreLoadEvent(callback, null);
	}

	// Token: 0x06005644 RID: 22084 RVA: 0x001C61B4 File Offset: 0x001C43B4
	public void RegisterScenePreLoadEvent(SceneMgr.ScenePreLoadCallback callback, object userData)
	{
		SceneMgr.ScenePreLoadListener scenePreLoadListener = new SceneMgr.ScenePreLoadListener();
		scenePreLoadListener.SetCallback(callback);
		scenePreLoadListener.SetUserData(userData);
		if (this.m_scenePreLoadListeners.Contains(scenePreLoadListener))
		{
			return;
		}
		this.m_scenePreLoadListeners.Add(scenePreLoadListener);
	}

	// Token: 0x06005645 RID: 22085 RVA: 0x001C61F0 File Offset: 0x001C43F0
	public bool UnregisterScenePreLoadEvent(SceneMgr.ScenePreLoadCallback callback)
	{
		return this.UnregisterScenePreLoadEvent(callback, null);
	}

	// Token: 0x06005646 RID: 22086 RVA: 0x001C61FC File Offset: 0x001C43FC
	public bool UnregisterScenePreLoadEvent(SceneMgr.ScenePreLoadCallback callback, object userData)
	{
		SceneMgr.ScenePreLoadListener scenePreLoadListener = new SceneMgr.ScenePreLoadListener();
		scenePreLoadListener.SetCallback(callback);
		scenePreLoadListener.SetUserData(userData);
		return this.m_scenePreLoadListeners.Remove(scenePreLoadListener);
	}

	// Token: 0x06005647 RID: 22087 RVA: 0x001C6229 File Offset: 0x001C4429
	public void RegisterSceneLoadedEvent(SceneMgr.SceneLoadedCallback callback)
	{
		this.RegisterSceneLoadedEvent(callback, null);
	}

	// Token: 0x06005648 RID: 22088 RVA: 0x001C6234 File Offset: 0x001C4434
	public void RegisterSceneLoadedEvent(SceneMgr.SceneLoadedCallback callback, object userData)
	{
		SceneMgr.SceneLoadedListener sceneLoadedListener = new SceneMgr.SceneLoadedListener();
		sceneLoadedListener.SetCallback(callback);
		sceneLoadedListener.SetUserData(userData);
		if (this.m_sceneLoadedListeners.Contains(sceneLoadedListener))
		{
			return;
		}
		this.m_sceneLoadedListeners.Add(sceneLoadedListener);
	}

	// Token: 0x06005649 RID: 22089 RVA: 0x001C6270 File Offset: 0x001C4470
	public bool UnregisterSceneLoadedEvent(SceneMgr.SceneLoadedCallback callback)
	{
		return this.UnregisterSceneLoadedEvent(callback, null);
	}

	// Token: 0x0600564A RID: 22090 RVA: 0x001C627C File Offset: 0x001C447C
	public bool UnregisterSceneLoadedEvent(SceneMgr.SceneLoadedCallback callback, object userData)
	{
		SceneMgr.SceneLoadedListener sceneLoadedListener = new SceneMgr.SceneLoadedListener();
		sceneLoadedListener.SetCallback(callback);
		sceneLoadedListener.SetUserData(userData);
		return this.m_sceneLoadedListeners.Remove(sceneLoadedListener);
	}

	// Token: 0x0600564B RID: 22091 RVA: 0x001C62A9 File Offset: 0x001C44A9
	private IEnumerator WaitThenFireSceneLoadedEvent()
	{
		yield return new WaitForSeconds(0.15f);
		this.FireSceneLoadedEvent();
		yield break;
	}

	// Token: 0x0600564C RID: 22092 RVA: 0x001C62B8 File Offset: 0x001C44B8
	private void FireScenePreUnloadEvent(PegasusScene prevScene)
	{
		SceneMgr.ScenePreUnloadListener[] array = this.m_scenePreUnloadListeners.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Fire(this.m_prevMode, prevScene);
		}
	}

	// Token: 0x0600564D RID: 22093 RVA: 0x001C62F0 File Offset: 0x001C44F0
	private void FireSceneUnloadedEvent(PegasusScene prevScene)
	{
		if (this.IsDoingSceneDrivenTransition())
		{
			this.m_transitioning = false;
		}
		SceneMgr.SceneUnloadedListener[] array = this.m_sceneUnloadedListeners.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Fire(this.m_prevMode, prevScene);
		}
	}

	// Token: 0x0600564E RID: 22094 RVA: 0x001C6338 File Offset: 0x001C4538
	private void FireScenePreLoadEvent()
	{
		SceneMgr.ScenePreLoadListener[] array = this.m_scenePreLoadListeners.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Fire(this.m_prevMode, this.m_mode);
		}
	}

	// Token: 0x0600564F RID: 22095 RVA: 0x001C6374 File Offset: 0x001C4574
	private void FireSceneLoadedEvent()
	{
		if (!this.IsDoingSceneDrivenTransition())
		{
			this.m_transitioning = false;
		}
		SceneMgr.SceneLoadedListener[] array = this.m_sceneLoadedListeners.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Fire(this.m_mode, this.m_scene);
		}
		HearthstonePerformance.Get().SendCustomEvent("SceneLoaded" + Enum.GetName(typeof(SceneMgr.Mode), this.m_mode));
	}

	// Token: 0x06005650 RID: 22096 RVA: 0x001C63EC File Offset: 0x001C45EC
	private SceneMgr.Mode DetermineStartupScene()
	{
		foreach (KeyValuePair<StartupSceneSource, DetermineStartupSceneCallback> keyValuePair in new SortedList<StartupSceneSource, DetermineStartupSceneCallback>(this.m_startupSceneCallbacks))
		{
			if (keyValuePair.Key == StartupSceneSource.DEFAULT_NORMAL_STARTUP)
			{
				break;
			}
			DetermineStartupSceneCallback value = keyValuePair.Value;
			SceneMgr.Mode result = SceneMgr.Mode.INVALID;
			if (value(ref result))
			{
				return result;
			}
		}
		return SceneMgr.Mode.LOGIN;
	}

	// Token: 0x06005651 RID: 22097 RVA: 0x001C645C File Offset: 0x001C465C
	private void LoadMode()
	{
		this.FireScenePreLoadEvent();
		SceneManager.LoadSceneAsync(EnumUtils.GetString<SceneMgr.Mode>(this.m_mode), LoadSceneMode.Additive);
	}

	// Token: 0x06005652 RID: 22098 RVA: 0x001C6476 File Offset: 0x001C4676
	private IEnumerator SwitchMode()
	{
		if (this.m_scene.IsUnloading())
		{
			yield break;
		}
		PegasusScene prevScene = this.m_scene;
		prevScene.PreUnload();
		this.FireScenePreUnloadEvent(prevScene);
		if (this.LoadingScreen.GetPhase() == LoadingScreen.Phase.WAITING_FOR_SCENE_UNLOAD && this.LoadingScreen.GetFreezeFrameCamera() != null)
		{
			yield return new WaitForEndOfFrame();
		}
		if (this.ShouldUseSceneUnloadDelays())
		{
			if (Box.Get() != null)
			{
				while (Box.Get().HasPendingEffects())
				{
					yield return 0;
				}
			}
			else
			{
				yield return new WaitForSeconds(0.15f);
			}
		}
		this.m_scene.Unload();
		this.m_scene = null;
		this.m_sceneLoaded = false;
		this.FireSceneUnloadedEvent(prevScene);
		this.PostUnloadCleanup();
		this.LoadModeFromModeSwitch();
		yield break;
	}

	// Token: 0x06005653 RID: 22099 RVA: 0x001C6485 File Offset: 0x001C4685
	private IEnumerator SwitchModeWithSceneDrivenTransition()
	{
		if (this.m_scene.IsUnloading())
		{
			yield break;
		}
		PegasusScene prevScene = this.m_scene;
		this.m_sceneLoaded = false;
		this.FireScenePreLoadEvent();
		SceneManager.LoadSceneAsync(EnumUtils.GetString<SceneMgr.Mode>(this.m_mode), LoadSceneMode.Additive);
		while (!this.m_sceneLoaded)
		{
			yield return null;
		}
		Action action = delegate()
		{
			prevScene.PreUnload();
			this.FireScenePreUnloadEvent(prevScene);
			prevScene.Unload();
			this.FireSceneUnloadedEvent(prevScene);
		};
		if (this.m_transitionHandlerType == SceneMgr.TransitionHandlerType.CURRENT_SCENE && this.m_onSceneLoadCompleteForSceneDrivenTransitionCallback != null)
		{
			this.m_onSceneLoadCompleteForSceneDrivenTransitionCallback(action);
			this.m_onSceneLoadCompleteForSceneDrivenTransitionCallback = null;
		}
		else if (this.m_transitionHandlerType == SceneMgr.TransitionHandlerType.NEXT_SCENE)
		{
			this.m_scene.ExecuteSceneDrivenTransition(action);
		}
		else
		{
			Log.All.PrintError("No callback for scene driven scene transition.", Array.Empty<object>());
			action();
		}
		yield break;
	}

	// Token: 0x06005654 RID: 22100 RVA: 0x001C6494 File Offset: 0x001C4694
	private bool ShouldUseSceneUnloadDelays()
	{
		return this.m_prevMode != this.m_mode;
	}

	// Token: 0x06005655 RID: 22101 RVA: 0x001C64A7 File Offset: 0x001C46A7
	private bool ShouldUseSceneLoadDelays()
	{
		return this.m_mode != SceneMgr.Mode.LOGIN && this.m_mode != SceneMgr.Mode.HUB && this.m_mode != SceneMgr.Mode.FATAL_ERROR;
	}

	// Token: 0x06005656 RID: 22102 RVA: 0x001C64CC File Offset: 0x001C46CC
	private void PostUnloadCleanup()
	{
		Time.captureFramerate = 0;
		if (Application.isEditor && this.m_mode == SceneMgr.Mode.FATAL_ERROR)
		{
			Log.All.PrintWarning("Not destroying the previous scene's objects for easier debugging! You can (probably) ignore warnings or errors after this point!", Array.Empty<object>());
			AudioListener[] array = UnityEngine.Object.FindObjectsOfType<AudioListener>();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].enabled = false;
			}
			return;
		}
		this.DestroyAllObjectsOnModeSwitch();
		if (this.m_performFullCleanup)
		{
			HearthstoneApplication hearthstoneApplication = HearthstoneApplication.Get();
			if (hearthstoneApplication != null)
			{
				hearthstoneApplication.UnloadUnusedAssets();
			}
		}
	}

	// Token: 0x06005657 RID: 22103 RVA: 0x001C6548 File Offset: 0x001C4748
	private void DestroyAllObjectsOnModeSwitch()
	{
		int sceneCount = SceneManager.sceneCount;
		for (int i = 0; i < sceneCount; i++)
		{
			foreach (GameObject gameObject in SceneManager.GetSceneAt(i).GetRootGameObjects())
			{
				if (this.ShouldDestroyOnModeSwitch(gameObject))
				{
					UnityEngine.Object.DestroyImmediate(gameObject);
				}
			}
		}
	}

	// Token: 0x06005658 RID: 22104 RVA: 0x001C65A0 File Offset: 0x001C47A0
	private bool ShouldDestroyOnModeSwitch(GameObject go)
	{
		if (go == null)
		{
			return false;
		}
		if (go.transform.parent != null)
		{
			return false;
		}
		if (go.GetComponent<HSDontDestroyOnLoad>() != null)
		{
			return false;
		}
		if (go.scene.buildIndex == -1)
		{
			Debug.LogErrorFormat("GameObject ({0}) appears to be marked Don't Destroy On Load, but is being destroyed by our code anyway!", new object[]
			{
				go.name
			});
		}
		return (!(PegUI.Get() != null) || !(go == PegUI.Get().gameObject)) && (!(OverlayUI.Get() != null) || !(go == OverlayUI.Get().gameObject)) && (!(Box.Get() != null) || !(go == Box.Get().gameObject) || !this.DoesModeShowBox(this.m_mode)) && !AssetLoader.Get().IsSharedPrefabInstance(go) && !AssetLoader.Get().IsWaitingOnObject(go) && !(go == iTweenManager.Get().gameObject);
	}

	// Token: 0x06005659 RID: 22105 RVA: 0x001C66AC File Offset: 0x001C48AC
	private void CacheModeForResume(SceneMgr.Mode mode)
	{
		if (PlatformSettings.OS != OSCategory.iOS && PlatformSettings.OS != OSCategory.Android)
		{
			return;
		}
		switch (mode)
		{
		case SceneMgr.Mode.HUB:
		case SceneMgr.Mode.FRIENDLY:
			Options.Get().SetInt(Option.LAST_SCENE_MODE, 0);
			return;
		case SceneMgr.Mode.GAMEPLAY:
		case SceneMgr.Mode.PACKOPENING:
		case SceneMgr.Mode.FATAL_ERROR:
		case SceneMgr.Mode.RESET:
			break;
		case SceneMgr.Mode.COLLECTIONMANAGER:
		case SceneMgr.Mode.TOURNAMENT:
		case SceneMgr.Mode.DRAFT:
		case SceneMgr.Mode.CREDITS:
		case SceneMgr.Mode.ADVENTURE:
		case SceneMgr.Mode.TAVERN_BRAWL:
		case SceneMgr.Mode.FIRESIDE_GATHERING:
		case SceneMgr.Mode.BACON:
		case SceneMgr.Mode.GAME_MODE:
			Options.Get().SetInt(Option.LAST_SCENE_MODE, (int)mode);
			break;
		default:
			return;
		}
	}

	// Token: 0x0600565A RID: 22106 RVA: 0x001C672A File Offset: 0x001C492A
	private bool DoesModeShowBox(SceneMgr.Mode mode)
	{
		if (mode <= SceneMgr.Mode.GAMEPLAY)
		{
			if (mode != SceneMgr.Mode.STARTUP && mode != SceneMgr.Mode.GAMEPLAY)
			{
				return true;
			}
		}
		else if (mode != SceneMgr.Mode.FATAL_ERROR && mode != SceneMgr.Mode.RESET)
		{
			return true;
		}
		return false;
	}

	// Token: 0x0600565B RID: 22107 RVA: 0x001C6748 File Offset: 0x001C4948
	private void LoadModeFromModeSwitch()
	{
		bool flag = this.DoesModeShowBox(this.m_prevMode);
		bool flag2 = this.DoesModeShowBox(this.m_mode);
		if (!flag && flag2)
		{
			Processor.QueueJob("SceneMgr.Reload", this.Job_ReloadBox(), Array.Empty<IJobDependency>());
			return;
		}
		if (flag && !flag2)
		{
			this.LoadingScreen.SetAssetLoadStartTimestamp(this.m_boxLoadTimestamp);
			this.m_boxLoadTimestamp = 0L;
		}
		this.LoadMode();
	}

	// Token: 0x0600565C RID: 22108 RVA: 0x001C67BC File Offset: 0x001C49BC
	private void QueueLoadBoxJob()
	{
		IJobDependency[] dependencies = HearthstoneJobs.BuildDependencies(new object[]
		{
			new WaitForGameDownloadManagerState(),
			new WaitForSplashScreen(),
			typeof(SceneMgr),
			typeof(IAssetLoader),
			typeof(SpecialEventManager),
			typeof(DemoMgr),
			typeof(FiresideGatheringManager),
			typeof(TavernBrawlManager),
			typeof(NetCache),
			typeof(GameMgr),
			typeof(AchieveManager),
			typeof(HealthyGamingMgr),
			typeof(ShownUIMgr),
			typeof(SoundManager),
			typeof(SetRotationManager),
			typeof(PopupDisplayManager)
		});
		Processor.QueueJob("SceneMgr.LoadBox", this.Job_LoadBox(), dependencies);
	}

	// Token: 0x0600565D RID: 22109 RVA: 0x001C68B5 File Offset: 0x001C4AB5
	private IEnumerator<IAsyncJobResult> Job_LoadBox()
	{
		LoadUIScreen loadUIScreen = new LoadUIScreen("TheBox.prefab:6b55a928ffdc1b341b5dbe8f8a88e768");
		yield return loadUIScreen;
		if (this.IsModeRequested(SceneMgr.Mode.FATAL_ERROR))
		{
			yield break;
		}
		yield return new JobResultCollection(new IAsyncJobResult[]
		{
			new WaitForNetCacheObject<NetCache.NetCacheProfileProgress>(),
			HearthstoneServices.CreateServiceDependency(typeof(SetRotationManager))
		});
		SceneMgr.Mode mode = this.DetermineStartupScene();
		if (mode != SceneMgr.Mode.INVALID)
		{
			this.m_nextMode = mode;
		}
		yield break;
	}

	// Token: 0x0600565E RID: 22110 RVA: 0x001C68C4 File Offset: 0x001C4AC4
	private IEnumerator<IAsyncJobResult> Job_ReloadBox()
	{
		LoadUIScreen loadUIScreen = new LoadUIScreen("TheBox.prefab:6b55a928ffdc1b341b5dbe8f8a88e768");
		yield return loadUIScreen;
		this.LoadMode();
		yield break;
	}

	// Token: 0x0600565F RID: 22111 RVA: 0x001C68D4 File Offset: 0x001C4AD4
	private void OnFatalError(FatalErrorMessage message, object userData)
	{
		if (UserAttentionManager.IsBlockedBy(UserAttentionBlocker.SET_ROTATION_INTRO))
		{
			this.SetNextMode(SceneMgr.Mode.FATAL_ERROR, SceneMgr.TransitionHandlerType.SCENEMGR, null);
			return;
		}
		if (!ReconnectMgr.Get().IsReconnectAllowed(message))
		{
			FatalErrorMgr.Get().RemoveErrorListener(new FatalErrorMgr.ErrorCallback(this.OnFatalError));
			ReconnectMgr.Get().FullResetRequired = true;
			this.GoToFatalErrorScreen(message);
			return;
		}
		switch (this.m_mode)
		{
		case SceneMgr.Mode.STARTUP:
		case SceneMgr.Mode.PACKOPENING:
		case SceneMgr.Mode.TOURNAMENT:
		case SceneMgr.Mode.CREDITS:
			return;
		case SceneMgr.Mode.LOGIN:
		case SceneMgr.Mode.GAMEPLAY:
			this.GoToFatalErrorScreen(message);
			return;
		case SceneMgr.Mode.HUB:
			StoreManager.Get().HandleDisconnect();
			return;
		case SceneMgr.Mode.COLLECTIONMANAGER:
			CollectionManager.Get().HandleDisconnect();
			return;
		case SceneMgr.Mode.TAVERN_BRAWL:
		{
			CollectionManager collectionManager = CollectionManager.Get();
			if (collectionManager.IsInEditMode())
			{
				collectionManager.HandleDisconnect();
				return;
			}
			return;
		}
		}
		Log.Offline.PrintDebug("Bypassing Fatal Error To HUB.", Array.Empty<object>());
		Navigation.Clear();
		this.SetNextMode(SceneMgr.Mode.HUB, SceneMgr.TransitionHandlerType.SCENEMGR, null);
		DialogManager.Get().ShowReconnectHelperDialog(null, null);
	}

	// Token: 0x06005660 RID: 22112 RVA: 0x001C69E4 File Offset: 0x001C4BE4
	private void GoToFatalErrorScreen(FatalErrorMessage message)
	{
		if (HearthstoneApplication.Get().ResetOnErrorIfNecessary())
		{
			Log.Offline.PrintDebug("SceneMgr.GoToFatalErrorScreen() - Auto resetting. Do not display Fatal Error Screen.", Array.Empty<object>());
			return;
		}
		Log.BattleNet.PrintDebug("Set FatalError mode={0}, m_allowClick={1}, m_redirectToStore={2}", new object[]
		{
			this.m_mode,
			message.m_allowClick,
			message.m_redirectToStore
		});
		FatalErrorMgr.Get().SetUnrecoverable(this.m_mode == SceneMgr.Mode.STARTUP && (!message.m_allowClick || !message.m_redirectToStore));
		this.SetNextMode(SceneMgr.Mode.FATAL_ERROR, SceneMgr.TransitionHandlerType.SCENEMGR, null);
	}

	// Token: 0x06005661 RID: 22113 RVA: 0x001C6A88 File Offset: 0x001C4C88
	public bool DoesCurrentSceneSupportOfflineActivity()
	{
		switch (this.m_mode)
		{
		case SceneMgr.Mode.STARTUP:
		case SceneMgr.Mode.HUB:
		case SceneMgr.Mode.COLLECTIONMANAGER:
		case SceneMgr.Mode.PACKOPENING:
		case SceneMgr.Mode.TOURNAMENT:
		case SceneMgr.Mode.CREDITS:
		case SceneMgr.Mode.TAVERN_BRAWL:
			return true;
		}
		return false;
	}

	// Token: 0x06005662 RID: 22114 RVA: 0x001C6AF0 File Offset: 0x001C4CF0
	private void UpdatePerformanceTrackingFromModeSwitch(SceneMgr.Mode mode, PegasusScene scene, object userData)
	{
		if (mode == SceneMgr.Mode.GAMEPLAY)
		{
			HearthstonePerformance hearthstonePerformance = HearthstonePerformance.Get();
			if (hearthstonePerformance != null)
			{
				hearthstonePerformance.CaptureBoxInteractableTime();
				this.UnregisterSceneLoadedEvent(new SceneMgr.SceneLoadedCallback(this.UpdatePerformanceTrackingFromModeSwitch));
			}
		}
	}
	*/
	// Token: 0x040044AA RID: 17578
	public GameObject m_StartupCamera;

	// Token: 0x040044AB RID: 17579
	private const float SCENE_UNLOAD_DELAY = 0.15f;

	// Token: 0x040044AC RID: 17580
	private const float SCENE_LOADED_DELAY = 0.15f;

	// Token: 0x040044AD RID: 17581
	private static SceneMgr s_instance;

	// Token: 0x040044AE RID: 17582
	private int m_startupAssetLoads;

	// Token: 0x040044AF RID: 17583
	private SceneMgr.Mode m_mode = SceneMgr.Mode.STARTUP;

	// Token: 0x040044B0 RID: 17584
	private SceneMgr.Mode m_nextMode;

	// Token: 0x040044B1 RID: 17585
	private SceneMgr.Mode m_prevMode;

	// Token: 0x040044B2 RID: 17586
	private bool m_reloadMode;

	// Token: 0x040044B3 RID: 17587
	//private PegasusScene m_scene;

	// Token: 0x040044B4 RID: 17588
	private bool m_sceneLoaded;

	// Token: 0x040044B5 RID: 17589
	private bool m_transitioning;

	// Token: 0x040044B6 RID: 17590
	private bool m_performFullCleanup;

	/*
	// Token: 0x040044B7 RID: 17591
	private List<SceneMgr.ScenePreUnloadListener> m_scenePreUnloadListeners = new List<SceneMgr.ScenePreUnloadListener>();

	// Token: 0x040044B8 RID: 17592
	private List<SceneMgr.SceneUnloadedListener> m_sceneUnloadedListeners = new List<SceneMgr.SceneUnloadedListener>();

	// Token: 0x040044B9 RID: 17593
	private List<SceneMgr.ScenePreLoadListener> m_scenePreLoadListeners = new List<SceneMgr.ScenePreLoadListener>();

	// Token: 0x040044BA RID: 17594
	private List<SceneMgr.SceneLoadedListener> m_sceneLoadedListeners = new List<SceneMgr.SceneLoadedListener>();

	// Token: 0x040044BB RID: 17595
	private SceneMgr.OnSceneLoadCompleteForSceneDrivenTransition m_onSceneLoadCompleteForSceneDrivenTransitionCallback;

	// Token: 0x040044BC RID: 17596
	private SceneMgr.TransitionHandlerType m_transitionHandlerType;

	// Token: 0x040044BD RID: 17597
	private SortedList<StartupSceneSource, DetermineStartupSceneCallback> m_startupSceneCallbacks = new SortedList<StartupSceneSource, DetermineStartupSceneCallback>();
*/
	// Token: 0x040044BE RID: 17598
	private long m_boxLoadTimestamp;

	// Token: 0x040044BF RID: 17599
	private Coroutine m_switchModeCoroutine;

	// Token: 0x040044C1 RID: 17601
	private GameObject m_sceneObject;

	// Token: 0x02001E22 RID: 7714
	public enum Mode
	{
		// Token: 0x0400C6AB RID: 50859
		INVALID,
		// Token: 0x0400C6AC RID: 50860
		STARTUP,
		// Token: 0x0400C6AD RID: 50861
		[Description("Login")]
		LOGIN,
		// Token: 0x0400C6AE RID: 50862
		[Description("Hub")]
		HUB,
		// Token: 0x0400C6AF RID: 50863
		[Description("Gameplay")]
		GAMEPLAY,
		// Token: 0x0400C6B0 RID: 50864
		[Description("CollectionManager")]
		COLLECTIONMANAGER,
		// Token: 0x0400C6B1 RID: 50865
		[Description("PackOpening")]
		PACKOPENING,
		// Token: 0x0400C6B2 RID: 50866
		[Description("Tournament")]
		TOURNAMENT,
		// Token: 0x0400C6B3 RID: 50867
		[Description("Friendly")]
		FRIENDLY,
		// Token: 0x0400C6B4 RID: 50868
		[Description("FatalError")]
		FATAL_ERROR,
		// Token: 0x0400C6B5 RID: 50869
		[Description("Draft")]
		DRAFT,
		// Token: 0x0400C6B6 RID: 50870
		[Description("Credits")]
		CREDITS,
		// Token: 0x0400C6B7 RID: 50871
		[Description("Reset")]
		RESET,
		// Token: 0x0400C6B8 RID: 50872
		[Description("Adventure")]
		ADVENTURE,
		// Token: 0x0400C6B9 RID: 50873
		[Description("TavernBrawl")]
		TAVERN_BRAWL,
		// Token: 0x0400C6BA RID: 50874
		[Description("FiresideGathering")]
		FIRESIDE_GATHERING,
		// Token: 0x0400C6BB RID: 50875
		[Description("Bacon")]
		BACON,
		// Token: 0x0400C6BC RID: 50876
		[Description("GameMode")]
		GAME_MODE,
		// Token: 0x0400C6BD RID: 50877
		[Description("PvPDungeonRun")]
		PVP_DUNGEON_RUN
	}

	// Token: 0x02001E23 RID: 7715
	public enum TransitionHandlerType
	{
		// Token: 0x0400C6BF RID: 50879
		INVALID,
		// Token: 0x0400C6C0 RID: 50880
		SCENEMGR,
		// Token: 0x0400C6C1 RID: 50881
		CURRENT_SCENE,
		// Token: 0x0400C6C2 RID: 50882
		NEXT_SCENE
	}

/*
	// Token: 0x02001E24 RID: 7716
	// (Invoke) Token: 0x06010857 RID: 67671
	public delegate void ScenePreUnloadCallback(SceneMgr.Mode prevMode, PegasusScene prevScene, object userData);

	// Token: 0x02001E25 RID: 7717
	// (Invoke) Token: 0x0601085B RID: 67675
	public delegate void SceneUnloadedCallback(SceneMgr.Mode prevMode, PegasusScene prevScene, object userData);

	// Token: 0x02001E26 RID: 7718
	// (Invoke) Token: 0x0601085F RID: 67679
	public delegate void ScenePreLoadCallback(SceneMgr.Mode prevMode, SceneMgr.Mode mode, object userData);

	// Token: 0x02001E27 RID: 7719
	// (Invoke) Token: 0x06010863 RID: 67683
	public delegate void SceneLoadedCallback(SceneMgr.Mode mode, PegasusScene scene, object userData);

	// Token: 0x02001E28 RID: 7720
	private class ScenePreUnloadListener : EventListener<SceneMgr.ScenePreUnloadCallback>
	{
		// Token: 0x06010866 RID: 67686 RVA: 0x00496A66 File Offset: 0x00494C66
		public void Fire(SceneMgr.Mode prevMode, PegasusScene prevScene)
		{
			this.m_callback(prevMode, prevScene, this.m_userData);
		}
	}

	// Token: 0x02001E29 RID: 7721
	private class SceneUnloadedListener : EventListener<SceneMgr.SceneUnloadedCallback>
	{
		// Token: 0x06010868 RID: 67688 RVA: 0x00496A83 File Offset: 0x00494C83
		public void Fire(SceneMgr.Mode prevMode, PegasusScene prevScene)
		{
			this.m_callback(prevMode, prevScene, this.m_userData);
		}
	}

	// Token: 0x02001E2A RID: 7722
	private class ScenePreLoadListener : EventListener<SceneMgr.ScenePreLoadCallback>
	{
		// Token: 0x0601086A RID: 67690 RVA: 0x00496AA0 File Offset: 0x00494CA0
		public void Fire(SceneMgr.Mode prevMode, SceneMgr.Mode mode)
		{
			this.m_callback(prevMode, mode, this.m_userData);
		}
	}

	// Token: 0x02001E2B RID: 7723
	private class SceneLoadedListener : EventListener<SceneMgr.SceneLoadedCallback>
	{
		// Token: 0x0601086C RID: 67692 RVA: 0x00496ABD File Offset: 0x00494CBD
		public void Fire(SceneMgr.Mode mode, PegasusScene scene)
		{
			this.m_callback(mode, scene, this.m_userData);
		}
	}

	// Token: 0x02001E2C RID: 7724
	// (Invoke) Token: 0x0601086F RID: 67695
	public delegate void OnSceneLoadCompleteForSceneDrivenTransition(Action onTransitionComplete);
*/
}
