using UnityEngine;

public class SetActorTagCommand : Command
{
    public int m_targetID;
    public int m_Cdmg;
    public int m_Cheal;
    public int m_Cmana;
    public int m_Catk;
    public int m_Chp;
    public int m_Carm;
    public int m_hpDef;

    public SetActorTagCommand(int targetID, int Cdmg = 0, int Cheal = 0, int Cmana = 0, int Catk = 0, int Chp = 0, int Carm = 0 , int hpdef =-1)
    {
        this.m_targetID = targetID;
        this.m_Cdmg = Cdmg;
        this.m_Cheal = Cheal;
        this.m_Cmana = Cmana;
        this.m_Catk= Catk;
        this.m_Chp = Chp;
        this.m_Carm = Carm;
        this.m_hpDef = hpdef;
        Response.ServerSend("SetActorTag");
    }

    public override void StartCommandExecution()
    {
        //GameObject target = IDHolder.GetGameObjectWithID(this.m_targetID);
        //if (this.m_Cdmg != 0)
        //{
        //    target.GetComponent<OneActorManager>().TakeDamage(this.m_Cdmg);
        //}
        //if (this.m_Cheal != 0)
        //{
        //    target.GetComponent<OneActorManager>().TakeDamage(-this.m_Cheal);
        //}
        //target.GetComponent<OneActorManager>().SetCardNum(this.m_Cmana, this.m_Catk, this.m_Chp, this.m_Carm, hpDefSet:this.m_hpDef);
        //Command.CommandExecutionComplete();
    }
}
public class ChangeActorDescCommand:Command
{
    public int m_targetID;
    public string m_newDesc;

    public ChangeActorDescCommand(int targetID, string descTxt)
    {
        this.m_targetID=targetID;
        this.m_newDesc=descTxt;
        Response.ServerSend("ChangeActorTag");
    }

    public override void StartCommandExecution()
    {
        GameObject target = IDHolder.GetGameObjectWithID(this.m_targetID);
        target.GetComponent<OneActorManager>().SetDesc(this.m_newDesc);
        Command.CommandExecutionComplete();
    }    
}
public class ChangeActorTagCommand: Command
{
    public int m_targetID;
    public int m_Cdmg;
    public int m_Cheal;    
    public int m_Cmana;
    public int m_Catk;
    public int m_Chp;
    public int m_Carm;

    public ChangeActorTagCommand(int targetID, int Cdmg = 0, int Cheal=0, int Cmana=0,int Catk=0, int Chp=0, int Carm=0)
    {
        this.m_targetID=targetID;
        this.m_Cdmg = Cdmg;
        this.m_Cheal = Cheal;
        this.m_Cmana = Cmana;
        this.m_Catk = Catk;
        this.m_Chp = Chp;
        this.m_Carm = Carm;
        Response.ServerSend("ChangeActorTag");
    }

    public override void StartCommandExecution()
    {
        GameObject target = IDHolder.GetGameObjectWithID(this.m_targetID);
        //if (this.m_Cdmg != 0)
        //{        
        //    target.GetComponent<OneActorManager>().TakeDamage(this.m_Cdmg);
        //}
        if(this.m_Cheal != 0)
        {
            target.GetComponent<OneActorManager>().TakeDamage(-this.m_Cheal);
        }
        else{
            target.GetComponent<OneActorManager>().TakeDamage(this.m_Cdmg);
        }
        Command.CommandExecutionComplete();
    }
}


public class GiveActorFxCommand : Command
{
    public int m_playerID;
    public int m_sourceID;
    public int m_targetID;
    public string m_fxname;

    public GiveActorFxCommand(int playerID,int sourceID,int targetID, string fxname)
    {
        this.m_playerID = playerID;
        this.m_sourceID = sourceID;
        this.m_targetID = targetID;
        this.m_fxname = fxname;
        Response.ServerSend("GiveActorFxs");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].GiveActorFx(this.m_targetID,this.m_fxname);
    }
}
public class RemoveActorFxCommand : Command
{
    public int m_playerID;
    public int m_sourceID;
    public int m_targetID;
    public string m_fxname;

    public RemoveActorFxCommand(int playerID,int sourceID,int targetID, string fxname)
    {
        this.m_playerID = playerID;
        this.m_sourceID = sourceID;
        this.m_targetID = targetID;
        this.m_fxname = fxname;
        Response.ServerSend("RemoveActorFx");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].RemoveActorFx(this.m_targetID, this.m_fxname);
    }
}

public class GiveActorAttachmentCommand : Command
{
    public int m_playerID;
    public int m_sourceID;
    public int m_targetID;
    public CardDbf m_attachAsset;
    public int m_attachID;

    public GiveActorAttachmentCommand(int playerID, int sourceID, int targetID, CardDbf asst,int assid)
    {
        this.m_playerID = playerID;
        this.m_sourceID = sourceID;
        this.m_targetID = targetID;
        this.m_attachAsset = asst;
        this.m_attachID = assid;
        Response.ServerSend("GiveActorAttachment");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].GiveActorAttachment(this.m_targetID, this.m_attachAsset,this.m_attachID);
    }
}
public class RemoveActorAttachmentCommand : Command
{
    public int m_playerID;
    public int m_sourceID;
    public int m_targetID;
    public int m_assetID;


    public RemoveActorAttachmentCommand(int playerID, int sourceID, int targetID, int assetID)
    {
        this.m_playerID = playerID;
        this.m_sourceID = sourceID;
        this.m_targetID = targetID;
        this.m_assetID = assetID;
        Response.ServerSend("RemoveActorAttachment");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].RemoveActorAttachment(this.m_targetID, this.m_assetID);
    }
}


public class ChangeActorZoneCommand : Command
{

    public int m_playerID;
    public int m_sourceZone;
    public int m_entityID;
    public int m_targetZone;
    public int m_targetIndex;
    public int m_toEn;

    public ChangeActorZoneCommand(int playerID, int sourceZone, int entityID, int targetZone, int targetIndex = -1, int toEn = 0)
    {
        this.m_playerID = playerID;
        this.m_sourceZone = sourceZone;
        this.m_entityID = entityID;
        this.m_targetZone = targetZone;
        this.m_targetIndex = targetIndex;
        this.m_toEn = toEn;
        Response.ServerSend("ChangeActorZone");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].ChangeActorToZone(this.m_entityID, (ZoneType)this.m_targetZone, (ZoneType)this.m_sourceZone, this.m_targetIndex, this.m_toEn);
    }
}

public class ChangeActorIndexCommand : Command
{

    public int m_playerID;
    public int m_targetZone;
    public int m_entityID;
    public int m_targetIndex;

    public ChangeActorIndexCommand(int playerID, int entityID, int targetZone, int targetIndex)
    {
        this.m_playerID = playerID;
        this.m_targetZone = targetZone;
        this.m_entityID = entityID;
        this.m_targetIndex = targetIndex;
        Response.ServerSend("ChangeActorIndex");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].ChangeActorIndex(this.m_entityID, (ZoneType)this.m_targetZone, this.m_targetIndex);
    }
}

public class MorphActorCommand : Command
{
    public int m_playerID;
    public int m_targetZone;
    public int m_targetID;
    public int m_newDbfID;
    public MorphActorCommand(int playerID, int targetZone, int targetID, int newDbfID)
    {
        this.m_playerID = playerID;
        this.m_targetZone = targetZone;
        this.m_targetID = targetID;
        this.m_newDbfID = newDbfID;
        Response.ServerSend("MorphActor");
    }
    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].MorphActorToAsset(this.m_targetID,(ZoneType)this.m_targetZone,CardDbf.GetCardDbfByDbfId(m_newDbfID));
    }

}

public class ChangeBaconShopBgmCommand:Command
{
    private bool recruit;
    public ChangeBaconShopBgmCommand(bool Recruit=false)
    {
        this.recruit=Recruit;
    }
    public override void StartCommandExecution()
    {
        if(BaconShopChangeBgm.Instance!=null)
        {
            BaconShopChangeBgm.Instance.Change(this.recruit);
        }
        else{
            Command.CommandExecutionComplete();
        }
        
    }    
}
public class ChangeBaconShopAccCommand:Command
{
    private float AccScale;
    public ChangeBaconShopAccCommand(float accScale=1f)
    {
        this.AccScale=accScale;
    }
    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.SetAcc(this.AccScale);
        Command.CommandExecutionComplete();
    }
}