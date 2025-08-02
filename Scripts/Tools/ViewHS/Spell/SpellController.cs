using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020008E5 RID: 2277
public class SpellController : MonoBehaviour
{
	/*
	// Token: 0x06007C2E RID: 31790 RVA: 0x00288D32 File Offset: 0x00286F32
	public Card GetSource()
	{
		if (this.m_sources == null || this.m_sources.Count <= 0)
		{
			return null;
		}
		return this.m_sources[0];
	}

	// Token: 0x06007C2F RID: 31791 RVA: 0x00288D58 File Offset: 0x00286F58
	public List<Card> GetSources()
	{
		return this.m_sources;
	}

	// Token: 0x06007C30 RID: 31792 RVA: 0x00288D60 File Offset: 0x00286F60
	public void SetSource(Card card)
	{
		this.m_sources.Clear();
		this.m_sources.Add(card);
	}

	// Token: 0x06007C31 RID: 31793 RVA: 0x00288D79 File Offset: 0x00286F79
	public void SetSource(List<Card> cards)
	{
		this.m_sources.Clear();
		this.m_sources.AddRange(cards);
	}

	// Token: 0x06007C32 RID: 31794 RVA: 0x00288D92 File Offset: 0x00286F92
	public bool IsSource(Card card)
	{
		return this.m_sources.Contains(card);
	}

	// Token: 0x06007C33 RID: 31795 RVA: 0x00288DA0 File Offset: 0x00286FA0
	public void RemoveSource()
	{
		this.m_sources.Clear();
	}

	// Token: 0x06007C34 RID: 31796 RVA: 0x00288DAD File Offset: 0x00286FAD
	public List<Card> GetTargets()
	{
		return this.m_targets;
	}

	// Token: 0x06007C35 RID: 31797 RVA: 0x00288DB5 File Offset: 0x00286FB5
	public Card GetTarget()
	{
		if (this.m_targets.Count != 0)
		{
			return this.m_targets[0];
		}
		return null;
	}

	// Token: 0x06007C36 RID: 31798 RVA: 0x00288DD2 File Offset: 0x00286FD2
	public void AddTarget(Card card)
	{
		this.m_targets.Add(card);
	}

	// Token: 0x06007C37 RID: 31799 RVA: 0x00288DE0 File Offset: 0x00286FE0
	public void RemoveTarget(Card card)
	{
		this.m_targets.Remove(card);
	}

	// Token: 0x06007C38 RID: 31800 RVA: 0x00288DEF File Offset: 0x00286FEF
	public void RemoveAllTargets()
	{
		this.m_targets.Clear();
	}

	// Token: 0x06007C39 RID: 31801 RVA: 0x00288DFC File Offset: 0x00286FFC
	public bool IsTarget(Card card)
	{
		return this.m_targets.Contains(card);
	}

	// Token: 0x06007C3A RID: 31802 RVA: 0x00288E0A File Offset: 0x0028700A
	public void AddFinishedTaskListCallback(SpellController.FinishedTaskListCallback callback)
	{
		if (this.m_finishedTaskListListeners.Contains(callback))
		{
			return;
		}
		this.m_finishedTaskListListeners.Add(callback);
	}

	// Token: 0x06007C3B RID: 31803 RVA: 0x00288E27 File Offset: 0x00287027
	public void AddFinishedCallback(SpellController.FinishedCallback callback)
	{
		if (this.m_finishedListeners.Contains(callback))
		{
			return;
		}
		this.m_finishedListeners.Add(callback);
	}

	// Token: 0x06007C3C RID: 31804 RVA: 0x00288E44 File Offset: 0x00287044
	public bool IsProcessingTaskList()
	{
		return this.m_processingTaskList;
	}

	// Token: 0x06007C3D RID: 31805 RVA: 0x00288E4C File Offset: 0x0028704C
	public PowerTaskList GetPowerTaskList()
	{
		return this.m_taskList;
	}

	// Token: 0x06007C3E RID: 31806 RVA: 0x00288E54 File Offset: 0x00287054
	public bool AttachPowerTaskList(PowerTaskList taskList)
	{
		if (this.m_taskList != taskList)
		{
			this.DetachPowerTaskList();
			this.m_taskList = taskList;
		}
		this.m_taskListId = this.m_taskList.GetId();
		return this.AddPowerSourceAndTargets(taskList);
	}

	// Token: 0x06007C3F RID: 31807 RVA: 0x00288E85 File Offset: 0x00287085
	public void SetPowerTaskList(PowerTaskList taskList)
	{
		if (this.m_taskList == taskList)
		{
			return;
		}
		this.DetachPowerTaskList();
		this.m_taskList = taskList;
	}

	// Token: 0x06007C40 RID: 31808 RVA: 0x00288E9F File Offset: 0x0028709F
	public PowerTaskList DetachPowerTaskList()
	{
		PowerTaskList taskList = this.m_taskList;
		this.RemoveSource();
		this.RemoveAllTargets();
		this.m_taskList = null;
		return taskList;
	}

	// Token: 0x06007C41 RID: 31809 RVA: 0x00288EBC File Offset: 0x002870BC
	public void DoPowerTaskList()
	{
		this.m_processingTaskList = true;
		if (this.IsLostFrameTimeCatchUpEnabled())
		{
			float clientLostTimeCatchUpThreshold = GameState.Get().GetClientLostTimeCatchUpThreshold();
			float lostFrameTimeCatchUpSeconds = this.GetLostFrameTimeCatchUpSeconds();
			if (lostFrameTimeCatchUpSeconds > 0f && clientLostTimeCatchUpThreshold > 0f && GameState.Get().GetTimeTracker().GetAccruedLostTimeInSeconds() > Math.Max(lostFrameTimeCatchUpSeconds, clientLostTimeCatchUpThreshold))
			{
				if (GameState.Get().GetTimeTracker() is GameStateFrameTimeTracker)
				{
					GameState.Get().GetTimeTracker().AdjustAccruedLostTime(-lostFrameTimeCatchUpSeconds);
				}
				this.OnFinishedTaskList();
				this.OnFinished();
				return;
			}
		}
		base.gameObject.SetActive(true);
		GameState.Get().AddServerBlockingSpellController(this);
		base.StartCoroutine(this.WaitForCardsThenDoTaskList());
	}

	// Token: 0x06007C42 RID: 31810 RVA: 0x001D9166 File Offset: 0x001D7366
	public void ForceKill()
	{
		this.OnFinishedTaskList();
	}

	// Token: 0x06007C43 RID: 31811 RVA: 0x00005004 File Offset: 0x00003204
	public virtual bool ShouldReconnectIfStuck()
	{
		return true;
	}

	// Token: 0x06007C44 RID: 31812 RVA: 0x001D7ACA File Offset: 0x001D5CCA
	protected virtual void OnProcessTaskList()
	{
		this.OnFinishedTaskList();
		this.OnFinished();
	}

	// Token: 0x06007C45 RID: 31813 RVA: 0x00288F65 File Offset: 0x00287165
	protected virtual void OnFinishedTaskList()
	{
		GameState.Get().RemoveServerBlockingSpellController(this);
		this.m_processingTaskList = false;
		this.FireFinishedTaskListCallbacks();
		if (this.m_pendingFinish)
		{
			this.m_pendingFinish = false;
			this.OnFinished();
		}
	}

	// Token: 0x06007C46 RID: 31814 RVA: 0x00288F95 File Offset: 0x00287195
	protected virtual void OnFinished()
	{
		if (this.m_processingTaskList)
		{
			this.m_pendingFinish = true;
			return;
		}
		base.gameObject.SetActive(false);
		this.FireFinishedCallbacks();
	}

	// Token: 0x06007C47 RID: 31815 RVA: 0x00288FBC File Offset: 0x002871BC
	protected virtual bool AddPowerSourceAndTargets(PowerTaskList taskList)
	{
		if (!this.HasSourceCard(taskList))
		{
			return false;
		}
		if (!SpellUtils.CanAddPowerTargets(taskList))
		{
			return false;
		}
		List<Entity> sourceEntities = taskList.GetSourceEntities(true);
		List<Card> list = new List<Card>();
		foreach (Entity entity in sourceEntities)
		{
			if (entity != null)
			{
				list.Add(entity.GetCard());
			}
		}
		this.SetSource(list);
		List<PowerTask> taskList2 = this.m_taskList.GetTaskList();
		for (int i = 0; i < taskList2.Count; i++)
		{
			PowerTask task = taskList2[i];
			Card targetCardFromPowerTask = this.GetTargetCardFromPowerTask(task);
			if (!(targetCardFromPowerTask == null) && !list.Contains(targetCardFromPowerTask) && !this.IsTarget(targetCardFromPowerTask))
			{
				this.AddTarget(targetCardFromPowerTask);
			}
		}
		if (list.Count > 0)
		{
			if (!list.Exists((Card c) => c == null))
			{
				return true;
			}
		}
		return this.m_targets.Count > 0;
	}

	// Token: 0x06007C48 RID: 31816 RVA: 0x002890D8 File Offset: 0x002872D8
	protected virtual bool HasSourceCard(PowerTaskList taskList)
	{
		List<Entity> sourceEntities = taskList.GetSourceEntities(true);
		if (sourceEntities == null || sourceEntities.Count == 0)
		{
			return false;
		}
		List<Card> list = new List<Card>();
		foreach (Entity entity in sourceEntities)
		{
			if (entity != null)
			{
				list.Add(entity.GetCard());
			}
		}
		if (list != null && list.Count != 0)
		{
			if (!list.Exists((Card c) => c == null))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007C49 RID: 31817 RVA: 0x000CEF09 File Offset: 0x000CD109
	protected virtual float GetLostFrameTimeCatchUpSeconds()
	{
		return 0f;
	}

	// Token: 0x06007C4A RID: 31818 RVA: 0x00289180 File Offset: 0x00287380
	private IEnumerator WaitForCardsThenDoTaskList()
	{
		Card sourceCard = this.GetSource();
		if (sourceCard != null)
		{
			while (this.IsCardBusy(sourceCard))
			{
				yield return null;
			}
		}
		foreach (Card targetCard in this.m_targets)
		{
			if (!(targetCard == null))
			{
				while (this.IsCardBusy(targetCard))
				{
					yield return null;
				}
				targetCard = null;
			}
		}
		List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
		this.OnProcessTaskList();
		yield break;
		yield break;
	}

	// Token: 0x06007C4B RID: 31819 RVA: 0x0028918F File Offset: 0x0028738F
	protected bool IsLostFrameTimeCatchUpEnabled()
	{
		return SpellController.ALLOW_LOST_FRAME_TIME_CATCH_UP && GameState.Get() != null && GameState.Get().GetGameEntity() != null && GameState.Get().AreLostTimeGuardianConditionsMet() && GameState.Get().GetGameEntity().IsGameSpeedupConditionInEffect();
	}

	// Token: 0x06007C4C RID: 31820 RVA: 0x002891D0 File Offset: 0x002873D0
	protected bool IsCardBusy(Card card)
	{
		Entity entity = card.GetEntity();
		return !this.WillEntityLoadCard(entity) && (entity.IsLoadingAssets() || ((!TurnStartManager.Get() || !TurnStartManager.Get().IsCardDrawHandled(card)) && !card.IsActorReady()));
	}

	// Token: 0x06007C4D RID: 31821 RVA: 0x00289220 File Offset: 0x00287420
	private bool WillEntityLoadCard(Entity entity)
	{
		int entityId = entity.GetEntityId();
		foreach (PowerTask powerTask in this.m_taskList.GetTaskList())
		{
			Network.PowerHistory power = powerTask.GetPower();
			Network.PowerType type = power.Type;
			if (type == Network.PowerType.FULL_ENTITY)
			{
				Network.HistFullEntity histFullEntity = power as Network.HistFullEntity;
				if (entityId == histFullEntity.Entity.ID)
				{
					return true;
				}
			}
			else if (type == Network.PowerType.SHOW_ENTITY)
			{
				Network.HistShowEntity histShowEntity = power as Network.HistShowEntity;
				if (entityId == histShowEntity.Entity.ID)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06007C4E RID: 31822 RVA: 0x002892C8 File Offset: 0x002874C8
	private void FireFinishedTaskListCallbacks()
	{
		SpellController.FinishedTaskListCallback[] array = this.m_finishedTaskListListeners.ToArray();
		this.m_finishedTaskListListeners.Clear();
		for (int i = 0; i < array.Length; i++)
		{
			array[i](this);
		}
	}

	// Token: 0x06007C4F RID: 31823 RVA: 0x00289304 File Offset: 0x00287504
	private void FireFinishedCallbacks()
	{
		SpellController.FinishedCallback[] array = this.m_finishedListeners.ToArray();
		this.m_finishedListeners.Clear();
		for (int i = 0; i < array.Length; i++)
		{
			array[i](this);
		}
	}

	// Token: 0x06007C50 RID: 31824 RVA: 0x00289340 File Offset: 0x00287540
	protected Card GetTargetCardFromPowerTask(PowerTask task)
	{
		Network.PowerHistory power = task.GetPower();
		if (power.Type != Network.PowerType.TAG_CHANGE)
		{
			return null;
		}
		Network.HistTagChange histTagChange = power as Network.HistTagChange;
		Entity entity = GameState.Get().GetEntity(histTagChange.Entity);
		if (entity == null)
		{
			Debug.LogWarning(string.Format("{0}.GetTargetCardFromPowerTask() - WARNING trying to target entity with id {1} but there is no entity with that id", this, histTagChange.Entity));
			return null;
		}
		return entity.GetCard();
	}

	// Token: 0x040063F9 RID: 25593
	public const float FINISH_FUDGE_SEC = 10f;

	// Token: 0x040063FA RID: 25594
	private static readonly PlatformDependentValue<bool> ALLOW_LOST_FRAME_TIME_CATCH_UP = new PlatformDependentValue<bool>(PlatformCategory.OS)
	{
		PC = false,
		Mac = false,
		iOS = true,
		Android = true
	};

	// Token: 0x040063FB RID: 25595
	private List<SpellController.FinishedTaskListCallback> m_finishedTaskListListeners = new List<SpellController.FinishedTaskListCallback>();

	// Token: 0x040063FC RID: 25596
	private List<SpellController.FinishedCallback> m_finishedListeners = new List<SpellController.FinishedCallback>();

	// Token: 0x040063FD RID: 25597
	protected List<Card> m_sources = new List<Card>();

	// Token: 0x040063FE RID: 25598
	protected List<Card> m_targets = new List<Card>();

	// Token: 0x040063FF RID: 25599
	protected PowerTaskList m_taskList;

	// Token: 0x04006400 RID: 25600
	protected int m_taskListId;

	// Token: 0x04006401 RID: 25601
	protected bool m_processingTaskList;

	// Token: 0x04006402 RID: 25602
	protected bool m_pendingFinish;

	// Token: 0x020022A9 RID: 8873
	// (Invoke) Token: 0x060119E0 RID: 72160
	public delegate void FinishedTaskListCallback(SpellController spellController);

	// Token: 0x020022AA RID: 8874
	// (Invoke) Token: 0x060119E4 RID: 72164
	public delegate void FinishedCallback(SpellController spellController);
*/
}
