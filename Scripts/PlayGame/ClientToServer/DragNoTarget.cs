using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DragNoTarget : DraggingActions
{
    public override bool CanDrag
    {
        get
        {

            return base.CanDrag && GetComponentInParent<OneActorManager>().CanBePlayedNow;
        }
    }

    public void OnMouseDown()
    {
        if (Targets == TargetingOptions.MakeChoice)
        {
            Request.CilentSend("DiscoverEnd");
            Player owner = null;
            if (tag.Contains("Low"))
                owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);//Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
            else
                owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
            new EffectDiscoverEnd(owner,GetComponentInParent<IDHolder>().UniqueID).Resolve();
        }
        else
        {

        }

    }

    public override void OnStartDrag()
    {
        base.OnStartDrag();
        GetComponentInParent<OneActorManager>().IsActing = true;
        //GetComponentInParent<OneActorManager>().SetHighLightColor(Color.blue);
        AudioSource HovLoop = GetComponentInParent<AudioSource>();
        if ( HovLoop != null && !OneSceneManager.Instance.IsBgMode)
        {
            HovLoop.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
            HovLoop.enabled = true;
        }
    }


    private const float EPSILON = 0.0001f;
    private const float SMOOTH_DAMP_SEC_FUDGE = 0.1f;
    private DragRotatorInfo m_info = new DragRotatorInfo();
    private float m_pitchDeg;
    private float m_rollDeg;
    private float m_pitchVel;
    private float m_rollVel;
    private Vector3 m_prevPos;
    private Vector3 m_originalAngles;
    public override void OnDraggingInUpdate(Vector3 Position)
    {
        transform.parent.position = Position; 
        Vector3 vector3 = Position - this.m_prevPos;
        if ((double)vector3.sqrMagnitude > 9.99999974737875E-05)
        {
            this.m_pitchDeg += vector3.z * this.m_info.m_PitchInfo.m_ForceMultiplier;
            this.m_pitchDeg = Mathf.Clamp(this.m_pitchDeg, this.m_info.m_PitchInfo.m_MinDegrees, this.m_info.m_PitchInfo.m_MaxDegrees);
            this.m_rollDeg -= vector3.x * this.m_info.m_RollInfo.m_ForceMultiplier;
            this.m_rollDeg = Mathf.Clamp(this.m_rollDeg, this.m_info.m_RollInfo.m_MinDegrees, this.m_info.m_RollInfo.m_MaxDegrees);
        }
        this.m_pitchDeg = Mathf.SmoothDamp(this.m_pitchDeg, 0.0f, ref this.m_pitchVel, this.m_info.m_PitchInfo.m_RestSeconds * 0.1f);
        this.m_rollDeg = Mathf.SmoothDamp(this.m_rollDeg, 0.0f, ref this.m_rollVel, this.m_info.m_RollInfo.m_RestSeconds * 0.1f);
        this.transform.parent.rotation = Quaternion.Euler(this.m_originalAngles.x + this.m_pitchDeg, this.m_originalAngles.z, this.m_originalAngles.y + this.m_rollDeg);
        this.m_prevPos = Position;
    }

    public override void OnEndDrag()
    {
        AudioSource HovLoop = GetComponentInParent<AudioSource>();
        if(HovLoop!=null)
        {
            HovLoop.enabled = false;
        }
        GetComponentInParent<OneActorManager>().IsActing = false;
        //GetComponentInParent<OneActorManager>().SetHighLightColor(Color.white);
        if (DragSuccessful())
        {
            Request.CilentSend("DragNoTarget");
            GetComponentInParent<OneActorManager>().CanBePlayedNow = false;
            float x = transform.parent.position.x;
            Player owner = null;
            if (tag.Contains("Low"))
                owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
            else
                owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);

            if (x > 15f)
            {
                //playerOwner.Trade(GetComponentInParent<IDHolder>().UniqueID, -1, tablePos);
                return;
            }
            
            if(OneSceneManager.Instance.IsSnapMode)
            {
                int tablePos = -1002;
                if(x>0.9f)
                {
                    tablePos = -1003;
                }
                if(x<-0.9f)
                {
                    tablePos = -1001;
                }

                new EffectPlay(owner,CardId:GetComponentInParent<IDHolder>().UniqueID, TargetId:-1, minionindex: tablePos).Resolve();
            }
            else{
                int tablePos=-1;
                List<float> AllX = OneSceneManager.Instance.StageDictByPlayerId[playerOwner.GetTag(GameTag.PlayerID)].GetAllXForZone(ZoneType.Board);
                if(AllX.Count==0)
                {
                    tablePos=0;
                }
                else if(x<=AllX[0])
                {
                    tablePos=0;
                }
                else if(x>AllX.Last())
                {
                    tablePos=-1;
                }
                else
                {
                    for(int i=0;i<AllX.Count-1;i++)
                    {
                        if(x>AllX[i] && x<=AllX[i+1])
                        {
                            tablePos=i+1;
                        }
                    }
                }
                new EffectPlay(owner,CardId:GetComponentInParent<IDHolder>().UniqueID, TargetId:-1, minionindex: tablePos).Resolve();
                         
            }


        
           //int tablePos = playerOwner.GetArea().tableVisual.TablePosForNewCreature(Camera.main.ScreenToWorldPoint(
           //     new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z - Camera.main.transform.position.z)).x);
        }
        else
        {
        }
    }

    protected override bool DragSuccessful()
    {
        //bool TableNotFull = (playerOwner.board.Count < 7);
        bool OnTable = transform.parent.position.z>-0.7f && transform.parent.position.z <0.96f;
        return OnTable;//TableVisual.CursorOverSomeTable && TableNotFull;
    }


}

public class DragRotatorInfo
{
    public DragRotatorAxisInfo m_PitchInfo= new DragRotatorAxisInfo();
    public DragRotatorAxisInfo m_RollInfo= new DragRotatorAxisInfo();
}
public class DragRotatorAxisInfo
{
    public float m_ForceMultiplier=100f;
    public float m_MinDegrees=-80f;
    public float m_MaxDegrees=80f;
    public float m_RestSeconds=1f;
}