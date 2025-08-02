using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DragPackOpen : DraggingActions
{
	public Vector3 RawPos;
    public override bool CanDrag
    {
        get
        {
            return true;
        }
    }

    public void OnMouseDown()
    {
    }

    public override void OnStartDrag()
    {
    	RawPos=transform.parent.position;
        base.OnStartDrag();
        AudioSource HovLoop = GetComponentInParent<AudioSource>();
        if ( HovLoop != null)
        {
            HovLoop.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
            HovLoop.enabled = true;
        }
    }


    private const float EPSILON = 0.0001f;
    private const float SMOOTH_DAMP_SEC_FUDGE = 0.9f;
    private DragRotatorInfo m_info = new DragRotatorInfo();
    private float m_pitchDeg;
    private float m_rollDeg;
    private float m_pitchVel;
    private float m_rollVel;
    private Vector3 m_prevPos;
    private Vector3 m_originalAngles = new Vector3(0f,0f,0f);
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
        if (DragSuccessful())
        {
        	transform.parent.position=RawPos;
    		this.transform.parent.rotation = Quaternion.Euler(Vector3.zero);
 			OpenPackManager.Instance.OpenPack();
        }
        else
        {
        	transform.parent.position=RawPos;
    		this.transform.parent.rotation = Quaternion.Euler(Vector3.zero);
        }
    }

    protected override bool DragSuccessful()
    {
        bool OnTable = transform.parent.position.x>-0.6f && transform.parent.position.x <3.5f;
        return OnTable;
    }


}