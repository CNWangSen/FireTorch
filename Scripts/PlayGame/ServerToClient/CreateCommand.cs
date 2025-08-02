using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CreateEmoteCommand:Command
{
    public int m_playerID;
    public int m_sourceID;
    public CardDbf m_sourceDb;
    public string m_txt;
    public float m_dur;

    public CreateEmoteCommand(int playerID, int sourceID, CardDbf db=null, string txt="", float dur=1f)
    {
        this.m_playerID = playerID;
        this.m_sourceID = sourceID;
        this.m_sourceDb = db;
        this.m_txt = txt;
        this.m_dur = dur;
    }

    public override void StartCommandExecution()
    {
        if(m_sourceDb!=null)
        {
            OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].CreateNarrator(this.m_sourceDb,this.m_txt,this.m_dur);
        }
        else{
            GameObject actor = IDHolder.GetGameObjectWithID(this.m_sourceID);
            if(actor!=null)
            {
                OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].CreateEmoteAtPosition(actor,this.m_txt,this.m_dur);
            }
            else{
                Command.CommandExecutionComplete();
            }            
        }
    }    
}
public class CreateSpellTableVfxCommand : Command
{
    public int m_sourceID;
    public SpellType m_ty;
    public CreateSpellTableVfxCommand(int sourceID, SpellType ty)
    {
        this.m_sourceID = sourceID;
        this.m_ty = ty;
    }

    public override void StartCommandExecution()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            Command.CommandExecutionComplete();
            return;
        }
        GameObject actor = IDHolder.GetGameObjectWithID(this.m_sourceID);
        if(actor!=null)
        {
            OneActorManager mgr = actor.GetComponent<OneActorManager>();
            (GameObject vfxobj, float vfxdur)=mgr.ActiveTableSpell(this.m_ty);
            Sequence DelaySeq = DOTween.Sequence();
            DelaySeq.AppendInterval(vfxdur/4f);
            DelaySeq.OnComplete(()=>{
                Command.CommandExecutionComplete();
                });
        }
        else{
            Command.CommandExecutionComplete();
        }
    }
}

public class CreateVfxCommand : Command
{
    public int m_sourceID;
    public List<int> m_targetIDs;
    public int m_dbfID;
    public VfxType m_vfxType;

    public CreateVfxCommand(int sourceID, List<int> targetIDs, VfxType vfxType = VfxType.Damage, int dbfID=0)
    {
        this.m_sourceID = sourceID;
        this.m_targetIDs = targetIDs;
        this.m_vfxType = vfxType;
        this.m_dbfID = dbfID;
        Response.ServerSend("CreateVfx");
    }

    public override void StartCommandExecution()
    {
        VfxBase.CreateVfx(m_sourceID, m_targetIDs, MyAssetsLoader.GetCustomMissileVFX(CardDbf.GetCardDbfByDbfId(this.m_dbfID)), this.m_vfxType);
    }
}
public class CreateDelayCommand : Command
{
    public float m_delaySecond;

    public CreateDelayCommand(float delaySecond)
    {
        this.m_delaySecond = delaySecond;
        Response.ServerSend("CreateDelay");
    }

    public override void StartCommandExecution()
    {
        Sequence DelaySeq = DOTween.Sequence();
        DelaySeq.AppendInterval(this.m_delaySecond);
        DelaySeq.OnComplete(() => {
            Command.CommandExecutionComplete();
        });
    }
}
public class CreateActorCommand: Command
{
    public int m_playerID;
    public int m_entityID;
    public int m_dbfID;
    public int m_premiumType;
    public int m_zoneType;
    public int m_index;
    public int m_targets;
    public bool m_HasAura;
    public bool m_HasTrigger;

    public CreateActorCommand(int playerID, int entityID, int dbfID, int premiumType, int zoneType,int index,int opt=0,bool aura=false,bool trigger=false)
    {
        this.m_playerID = playerID;
        this.m_entityID = entityID;
        this.m_dbfID = dbfID;
        this.m_premiumType = premiumType;
        this.m_zoneType = zoneType;
        this.m_index = index;
        this.m_targets = opt;
        this.m_HasAura = aura;
        this.m_HasTrigger = trigger;
        Response.ServerSend("CreateActor");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].CreateActorAtZone(this.m_entityID,(ZoneType)this.m_zoneType,CardDbf.GetCardDbfByDbfId(this.m_dbfID),this.m_index,ActorPremium:(PremiumType)this.m_premiumType,TargetOPT:this.m_targets,IsAuraActor:this.m_HasAura,IsTriggerActor:this.m_HasTrigger);
    }
}

