using System.Collections.Generic;


public class CallBackAfterGetTag2:UnitEffectCallBack
{
    public delegate int EventAfterGetTag(Card source, int TagInt);
    public event EventAfterGetTag myEv;
    public CallBackAfterGetTag2(Ability SourceAbility, EventAfterGetTag Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override int Resolve(Card source, int TagInt)
    {
        return this.myEv.Invoke(source, TagInt);
    }
}


public class EffectGetTag:UnitEffect
{
    public GameTag TargetTag;
	public EffectGetTag(Card source, GameTag tg)
	{
        //this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetTag = tg;
	}
	public override int Resolve(int c=0)
	{
        
        //if (!this.SourceCard.Property.ContainsKey(this.TargetTag))
        //{
        //    this.SourceCard.Property.Add(this.TargetTag, 0);
        //}
        
        int tagV = this.SourceCard.PropertyArr[(int)this.TargetTag];
        int mod = 0;
        int fot = 0;

        //this.SourceCard.Property.TryGetValue(this.TargetTag, out tagV);

        if(this.TargetTag==GameTag.Mana)
        {
            mod = this.SourceCard.GetTag(GameTag.ManaMod);
            fot = this.SourceCard.GetTag(GameTag.ManaFot);
        }
        if(this.TargetTag==GameTag.Attack)
        {
            mod = this.SourceCard.GetTag(GameTag.AttackMod);
            fot = this.SourceCard.GetTag(GameTag.AttackFot);
        }      
        if(this.TargetTag==GameTag.Health)
        {
            mod = this.SourceCard.GetTag(GameTag.HealthMod);
            fot = this.SourceCard.GetTag(GameTag.HealthFot);
            mod -= this.SourceCard.GetTag(GameTag.Damage);
        }
        if(this.TargetTag==GameTag.Armor)
        {
            mod = this.SourceCard.GetTag(GameTag.ArmorMod);
            fot = this.SourceCard.GetTag(GameTag.ArmorFot);
        }
        if(this.TargetTag==GameTag.Energy)
        {
            mod = this.SourceCard.GetTag(GameTag.EnergyMod);
            fot = this.SourceCard.GetTag(GameTag.EnergyFot);
        }
        if(this.TargetTag==GameTag.SpellDamage)
        {
            mod = this.SourceCard.GetTag(GameTag.SpellDamageMod);
            fot = this.SourceCard.GetTag(GameTag.SpellDamageFot);
        }
        if(this.TargetTag==GameTag.DamageEff)
        {
            mod = this.SourceCard.GetTag(GameTag.DamageEffMod);
            //fot = this.SourceCard.GetTag(GameTag.SpellDamageFot);
        }    
        for(int j = this.SourceCard.abilityList.Count-1;j>=0;j--)
        {
            mod += this.SourceCard.abilityList[j].AfterGetTag(this.TargetTag);
        }

        //for(int j = this.SourceCard.myPlayer.EffectCallBacks.Count-1;j>=0;j--)
        //{
        //    if(this.SourceCard.myPlayer.EffectCallBacks[j] is CallBackAfterGetTag)
        //    {
        //        mod += this.SourceCard.myPlayer.EffectCallBacks[j].Resolve(this.SourceCard,(int)this.TargetTag); 
        //    }
        //}
        return tagV + mod + fot;//Property[tg];
    }
}