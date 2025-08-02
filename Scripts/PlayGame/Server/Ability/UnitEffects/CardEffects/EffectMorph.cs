using System.Collections.Generic;

public class EffectMorph:UnitEffect
{
    public CardDbf InToDbfSingle;
    public List<Card> TargetList;
    public List<CardDbf> InToDbfList;
    public Card AssignVfxCard;

	public EffectMorph(Player srcPlayer, Card source, Card target = null, CardDbf newDbf = null, List<Card> targets = null, List<CardDbf> newDbfs = null,Card assignVfxCard=null)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.TargetList = targets;

        this.InToDbfSingle = newDbf;
        this.InToDbfList = newDbfs;
        this.AssignVfxCard = assignVfxCard;
	}
	public override void Resolve()
	{
        if (this.SourceCard.myPlayer.hero.Count == 0)
        {
            return;
        }
        int CustomVfxAsset = this.SourceCard.cardDbf.DbfId;
        if (this.AssignVfxCard != null)
        {
            CustomVfxAsset = this.AssignVfxCard.cardDbf.DbfId;
        }
        if (this.SourceCard.cardType == CardType.Spell)
        {
            //this.SourceCard = this.SourceCard.myPlayer.hero[0];
        }

        if (this.TargetList == null)
        {
            this.TargetList = new List<Card>();
            this.InToDbfList = new List<CardDbf>();
        }
        if (this.TargetCard != null)
        {
            this.TargetList.Add(this.TargetCard);
            this.InToDbfList.Add(this.InToDbfSingle);
        }
        List<int> targetsIDs = new List<int>();
        List<int> targetsZones = new List<int>();
        for(int i = this.TargetList.Count-1;i>=0;i--)
        {
            targetsIDs.Add(this.TargetList[i].GetTag(GameTag.EntityId));
            targetsZones.Add(this.TargetList[i].GetTag(GameTag.ZoneType));
            //this.TargetList[i].MorphInto(this.InToDbfList[i]);

            int CardId = this.TargetList[i].GetTag(GameTag.EntityId);
            ZoneType CardZone = (ZoneType)this.TargetList[i].GetTag(GameTag.ZoneType);

            this.TargetList[i].cardDbf = this.InToDbfList[i];
            for (int j = this.TargetList[i].abilityList.Count - 1; j >= 0; j--)
            {
                Ability AuraSourceAbility = this.TargetList[i].abilityList[j];
                if(AuraSourceAbility.AuraActive()==true)
                {
                    for(int k = AuraSourceAbility.AuraAffecting.Count-1;k>=0;k--)
                    {
                        AuraSourceAbility.AuraAffecting[k].owner.abilityList.Remove(AuraSourceAbility.AuraAffecting[k]);
                        AuraSourceAbility.AuraAffecting[k].UnRegisterEventEffect();
                        AuraSourceAbility.AuraAffecting.RemoveAt(k);
                    }
                }
                AuraSourceAbility.UnRegisterEventEffect();
            }
            this.TargetList[i].abilityList.Clear();
            this.TargetList[i].attachmentList.Clear();
            this.TargetList[i].attachedTo = null;
            this.TargetList[i].classes = this.InToDbfList[i].Classes;
            this.TargetList[i].raceType = this.InToDbfList[i].RaceType;
            this.TargetList[i].cardType = this.InToDbfList[i].CardType;

            
            //this.TargetList[i].Property = new Dictionary<GameTag,int>();
            this.TargetList[i].PropertyArr = new int[100];

            this.TargetList[i].SetTag(GameTag.PremiumType, (int)PremiumType.Normal);
            this.TargetList[i].SetTag(GameTag.ZoneType, (int)ZoneType.Aside);

            this.TargetList[i].SetTag(GameTag.Mana, this.InToDbfList[i].ManaCost);
            this.TargetList[i].SetTag(GameTag.Attack, this.InToDbfList[i].Attack);
            this.TargetList[i].SetTag(GameTag.Health, this.InToDbfList[i].MaxHealth);
            this.TargetList[i].SetTag(GameTag.Armor, 0);
            this.TargetList[i].SetTag(GameTag.ManaDef, this.InToDbfList[i].ManaCost);
            this.TargetList[i].SetTag(GameTag.AttackDef, this.InToDbfList[i].Attack);
            this.TargetList[i].SetTag(GameTag.HealthDef, this.InToDbfList[i].MaxHealth);
            this.TargetList[i].SetTag(GameTag.ArmorDef, 0);
            this.TargetList[i].SetTag(GameTag.AttacksForOneTurn, 1);
            this.TargetList[i].SetTag(GameTag.AttacksLeftThisTurn, 0);
            this.TargetList[i].SetTag(GameTag.AttackableTargets, (int)TargetingOptions.OpposingCharactersTauntFirst);

            this.TargetList[i].SetTag(GameTag.IsInjured, 0);
            this.TargetList[i].SetTag(GameTag.IsCanceled, 0);

            this.TargetList[i].SetTag(GameTag.EntityId, CardId);
            this.TargetList[i].SetTag(GameTag.ZoneType, (int)CardZone);
            if (System.Type.GetType(this.InToDbfList[i].m_noteMiniGuid) != null)
            {
                Ability OneAbility = System.Activator.CreateInstance(System.Type.GetType(this.InToDbfList[i].m_noteMiniGuid)) as Ability;
                OneAbility.AttachTo(this.TargetList[i]);
            }
        }

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new CreateVfxCommand(this.SourceCard.GetTag(GameTag.EntityId), targetsIDs, dbfID: CustomVfxAsset, vfxType: VfxType.Morph).AddToQueue();
            for (int i = targetsIDs.Count-1;i>=0;i--)
            {
                new MorphActorCommand(this.SourcePlayer.GetTag(GameTag.PlayerID),targetsZones[i],targetsIDs[i],this.InToDbfList[i].DbfId).AddToQueue();
                foreach (Ability abi in this.TargetList[i].abilityList)
                {
                    new GiveActorFxCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.TargetList[i].GetTag(GameTag.EntityId), this.TargetList[i].GetTag(GameTag.EntityId), abi.GetType().Name).AddToQueue();
                    if (!(abi.GetType().GetMethod("Deathrattle").DeclaringType == typeof(Ability)))
                    {
                        new GiveActorFxCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.TargetList[i].GetTag(GameTag.EntityId), this.TargetList[i].GetTag(GameTag.EntityId), "Deathrattle").AddToQueue();
                    }
                }
            }
        }
        this.SourcePlayer.myGame.UpdateAura();
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }
	}
}