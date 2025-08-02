using System.Collections.Generic;

public class EffectGiveAbility:UnitEffect
{
    string AbilityNameSingle;
    List<Card> TargetList;
    List<string> AbilityNameList;
    bool CreateVfx;
	public EffectGiveAbility(Player srcPlayer, Card source, Card target=null, string abiname=null, List<Card> targets = null, List<string> abinames = null, bool createVfx = true)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.AbilityNameSingle = abiname;
        this.TargetList = targets;
        this.AbilityNameList = abinames;
        this.CreateVfx = createVfx;
	}
	public override void Resolve()
	{

		int CustomVfxAsset = this.SourceCard.cardDbf.DbfId;
        if (this.SourceCard.cardType == CardType.Spell)
        {
            if(this.SourceCard.myPlayer.hero.Count==0)
            {
                //return;
            }
            else{
                //this.SourceCard = this.SourceCard.myPlayer.hero[0];
            }
        }

        if (this.TargetList == null)
        {
            this.TargetList = new List<Card>();
            this.AbilityNameList = new List<string>();
            this.TargetList.Add(this.TargetCard);
            this.AbilityNameList.Add(this.AbilityNameSingle);
        }
        List<int> targetIds = new List<int>();
        for (int i = this.TargetList.Count - 1; i >= 0; i--)
        {

            //new EffectGiveAbility(this.TargetList[i].myPlayer,this.TargetList[i],this.TargetList[i],this.AbilityNameList[i],createVfx:false).Resolve();
            if (System.Type.GetType(this.AbilityNameList[i]) != null)
            {
                Ability OneAbility = System.Activator.CreateInstance(System.Type.GetType(this.AbilityNameList[i])) as Ability;
                OneAbility.AttachTo(this.TargetList[i]);
            }
        }
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            if(this.CreateVfx)
                new CreateVfxCommand(this.SourceCard.GetTag(GameTag.EntityId), targetIds, dbfID: CustomVfxAsset).AddToQueue();
            for (int i = this.TargetList.Count - 1; i >= 0; i--)
            {
                new GiveActorFxCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceCard.GetTag(GameTag.EntityId), this.TargetList[i].GetTag(GameTag.EntityId), this.AbilityNameList[i]).AddToQueue();
            }
        }
    }
}