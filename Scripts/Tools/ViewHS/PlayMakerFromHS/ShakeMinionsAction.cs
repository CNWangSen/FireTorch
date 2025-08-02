using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020006DD RID: 1757
[ActionCategory("Pegasus")]
[HutongGames.PlayMaker.Tooltip("Shake Minions")]
public class ShakeMinionsAction : FsmStateAction
{
    // Token: 0x06006163 RID: 24931 RVA: 0x00202AB6 File Offset: 0x00200CB6
    public override void Reset()
    {
        /*
        this.gameObject = null;
        this.MinionsToShake = ShakeMinionsAction.MinionsToShakeEnum.All;
        this.shakeType = ShakeMinionType.RandomDirection;
        this.shakeSize = ShakeMinionIntensity.SmallShake;
        this.customShakeIntensity = 0.1f;
        this.radius = 0f;
        */
    }

    // Token: 0x06006164 RID: 24932 RVA: 0x00202AF4 File Offset: 0x00200CF4
    public override void OnEnter()
    {
        this.DoShakeMinions();
        base.Finish();
    }

    // Token: 0x06006165 RID: 24933 RVA: 0x00202B04 File Offset: 0x00200D04
    private void DoShakeMinions()
    {
        /*
        GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
        if (ownerDefaultTarget == null)
        {
            base.Finish();
            return;
        }
        if (this.MinionsToShake == ShakeMinionsAction.MinionsToShakeEnum.All)
        {
            MinionShake.ShakeAllMinions(ownerDefaultTarget, this.shakeType, ownerDefaultTarget.transform.position, this.shakeSize, this.customShakeIntensity.Value, this.radius.Value, 0f);
            return;
        }
        if (this.MinionsToShake == ShakeMinionsAction.MinionsToShakeEnum.Target)
        {
            MinionShake.ShakeTargetMinion(ownerDefaultTarget, this.shakeType, ownerDefaultTarget.transform.position, this.shakeSize, this.customShakeIntensity.Value, 0f, 0f);
            return;
        }
        if (this.MinionsToShake == ShakeMinionsAction.MinionsToShakeEnum.SelectedGameObject)
        {
            MinionShake.ShakeObject(ownerDefaultTarget, this.shakeType, ownerDefaultTarget.transform.position, this.shakeSize, this.customShakeIntensity.Value, 0f, 0f);
        }
        */
    }

    // Token: 0x04004BD4 RID: 19412
    [RequiredField]
    [HutongGames.PlayMaker.Tooltip("Impact Object Location")]
    public FsmOwnerDefault gameObject;

    // Token: 0x04004BD5 RID: 19413
    [RequiredField]
    [HutongGames.PlayMaker.Tooltip("Shake Type")]
    //public ShakeMinionType shakeType = ShakeMinionType.RandomDirection;

    // Token: 0x04004BD6 RID: 19414
    //[RequiredField]
    //[HutongGames.PlayMaker.Tooltip("Minions To Shake")]
    public ShakeMinionsAction.MinionsToShakeEnum MinionsToShake;

    // Token: 0x04004BD7 RID: 19415
    //[RequiredField]
    //[HutongGames.PlayMaker.Tooltip("Shake Intensity")]
    //public ShakeMinionIntensity shakeSize = ShakeMinionIntensity.SmallShake;

    // Token: 0x04004BD8 RID: 19416
    //[RequiredField]
    //[HutongGames.PlayMaker.Tooltip("Custom Shake Intensity 0-1. Used when Shake Size is Custom")]
    public FsmFloat customShakeIntensity;

    // Token: 0x04004BD9 RID: 19417
    [RequiredField]
    [HutongGames.PlayMaker.Tooltip("Radius - 0 = for all objects")]
    public FsmFloat radius;

    // Token: 0x02001FA4 RID: 8100
    public enum MinionsToShakeEnum
    {
        // Token: 0x0400CB70 RID: 52080
        All,
        // Token: 0x0400CB71 RID: 52081
        Target,
        // Token: 0x0400CB72 RID: 52082
        SelectedGameObject
    }
}
