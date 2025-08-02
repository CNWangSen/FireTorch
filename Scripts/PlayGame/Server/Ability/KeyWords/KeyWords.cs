

public class DivineShield: Ability
{
    public override int BeforeTakeDamage(Card source = null, int amount = 0)
    {
        if(amount!=0)
        {
            new EffectRemoveAbility(owner.myPlayer, owner,owner,"DivineShield").Resolve();
                        
        }
        else{
                   
        }

        return 0;
    }
}

public class DivineShieldPro: DivineShield
{
    private int Cnt=0;
    public override int BeforeTakeDamage(Card source = null, int amount = 0)
    {
        if(amount!=0 && Cnt>2)
        {

            new EffectRemoveAbility(owner.myPlayer, owner,owner,"DivineShieldPro").Resolve();          
        }
        else{

            Cnt+=1;
        }
        //new EffectChange(owner.myPlayer,owner,owner).Resolve();
        return 0;
    }
}

public class Immue : Ability
{
    private bool has = true;
    public override int BeforeTakeDamage(Card source = null, int amount = 0)
    {
        if (has)
        {
            return 0;
        }
        else
        {
            return amount;
        }
    }
}

public class ImmueForOneTurn : Ability
{
    private bool has = true;
    public override int BeforeTakeDamage(Card source = null, int amount = 0)
    {
        if (has)
        {
            return 0;
        }
        else
        {
            return amount;
        }
    }
}

public class Rush:Ability
{
    public override void RegisterEventEffect()
    {
        owner.SetTag(GameTag.AttacksLeftThisTurn,owner.GetTag(GameTag.AttacksForOneTurn));
        owner.SetTag(GameTag.IsAwake, 1);
        owner.SetTag(GameTag.AttackableTargets,(int)TargetingOptions.OpposingMinions);
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this, this.CauseEvent));
    }
    public void CauseEvent()
    {
        owner.SetTag(GameTag.AttackableTargets,(int)TargetingOptions.OpposingCharactersTauntFirst);
    }
}

public class Charge : Ability
{
    public override void RegisterEventEffect()
    {
        owner.SetTag(GameTag.AttacksLeftThisTurn,owner.GetTag(GameTag.AttacksForOneTurn));
        owner.SetTag(GameTag.IsAwake, 1);
    }
}


public class Silent : Ability
{
    public override void RegisterEventEffect()
    {
        for (int i = owner.abilityList.Count - 1; i >= 0; i--)
        {
            if (owner.abilityList[i] != this)
            {
                new EffectRemoveAbility(owner.myPlayer, owner.myPlayer.hero[0], owner, owner.abilityList[i].GetType().Name).Resolve();
            }
        }
    }
}

public class CanNotAttackHero : Ability
{
    public override void Battlecry(Card target = null)
    {
        owner.SetTag(GameTag.AttackableTargets,(int)TargetingOptions.OpposingMinions);
        //owner.myPlayer.DoGiveCardVisualAbility(owner, "CanNotAttackHero");
    }
}

public class CanNotAttack : Ability
{
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.SetTag(GameTag.AttacksForOneTurn,0);
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.SetTag(GameTag.AttacksForOneTurn,1);
    }
}

public class Freezing:Ability{
    public override void AfterMakeDamage(Card target = null, int amount = 0)
    {
        new EffectGiveAbility(owner.myPlayer,owner,target,"Frozen").Resolve();
    }
}
public class Frozen : Ability
{
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.SetTag(GameTag.AttacksForOneTurn,0);
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,FrozenCauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.SetTag(GameTag.AttacksForOneTurn,1);
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void FrozenCauseEvent()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Board || (ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            new EffectRemoveAbility(owner.myPlayer, owner, target:owner, abiname:"Frozen").Resolve();
        }
    }
}


public class LifeSteal : Ability
{
    public override void AfterMakeDamage(Card target = null, int amount = 0)
    {
        if(owner.myPlayer.hero.Count>0)
            new EffectHeal(owner.myPlayer,owner,owner.myPlayer.hero[0],amount,visualFx:false).Resolve();
    }
}

public class Poisonous : Ability
{
    
    public override void AfterMakeDamage(Card target = null, int amount = 0)
    {
        if (target != null && amount > 0 && !target.HasAbility("DivineShield") && target.cardType==CardType.Minion)
        {
            //new EffectDestroy(owner.myPlayer,owner,target).Resolve();
            //target.PropertyArr[(int)GameTag.Health]=0;//target.GetTag(GameTag.Health);//GameTag.IsDying,1);
            //target.PropertyArr[(int)GameTag.HealthMod]=0;
            //target.SetTag(GameTag.Health, 0);
            //target.SetTag(GameTag.Damage,target.GetTag(GameTag.Health));
            target.SetTag(GameTag.IsDying,1);
        }
    }
}

public class Toxic : Poisonous
{
    
    public override void AfterMakeDamage(Card target = null, int amount = 0)
    {
        if (target != null && amount > 0 && !target.HasAbility("DivineShield") && target.cardType==CardType.Minion)
        {
            //new EffectDestroy(owner.myPlayer,owner,target).Resolve();
            //target.PropertyArr[(int)GameTag.Health]=0;//target.GetTag(GameTag.Health);//GameTag.IsDying,1);
            //target.PropertyArr[(int)GameTag.HealthMod]=0;
            //target.SetTag(GameTag.Health, 0);
            //target.SetTag(GameTag.Damage,target.GetTag(GameTag.Health));
            target.SetTag(GameTag.IsDying,1);
        }
    }
}
public class Stealth : Ability
{
    public override void AfterAttack(Card target)
    {
        new EffectRemoveAbility(owner.myPlayer,owner,owner,"Stealth").Resolve();
    }
}

public class Taunt : Ability
{
}

public class WindFury : Ability
{
    public override void RegisterEventEffect()
    {
        if (owner.GetTag(GameTag.IsAwake) == 1 && owner.GetTag(GameTag.AttacksForOneTurn) == 1)
        {
            owner.SetTag(GameTag.AttacksLeftThisTurn, owner.GetTag(GameTag.AttacksLeftThisTurn) + 2 - 1);
        }
        owner.SetTag(GameTag.AttacksForOneTurn, 2);
    }
}
public class WindFuryPro : Ability
{
    public override void RegisterEventEffect()
    {
        if (owner.GetTag(GameTag.IsAwake) == 1 && owner.GetTag(GameTag.AttacksForOneTurn) == 2)
        {
            owner.SetTag(GameTag.AttacksLeftThisTurn, owner.GetTag(GameTag.AttacksLeftThisTurn) + 4 - 1);
        }
        owner.SetTag(GameTag.AttacksForOneTurn, 4);
    }
}

public class Elusive : Ability
{

}

public class Reborn : Ability
{
    private bool Used = false;
    public override void Deathrattle()
    {
        base.Deathrattle();
        if (!Used)
        {
            Card Reborned = new Card(owner.cardDbf, owner.myPlayer);
            new EffectRemoveAbility(Reborned.myPlayer,Reborned,Reborned,"Reborn").Resolve();
            Reborned.SetTag(GameTag.PremiumType,owner.GetTag(GameTag.PremiumType));
            new EffectCreate(owner.myPlayer,Reborned,ZoneType.Board,owner.GetTag(GameTag.ZoneIndex)).Resolve();
            new EffectChange(owner.myPlayer,Reborned,Reborned,hpChange:-Reborned.GetTag(GameTag.Health)+1,visualFx:false).Resolve();
        }

    }
}