using System.Collections.Generic;

public class EffectChange:UnitEffect
{
    public List<Card> TargetList;
    public Card AssignVfxCard;
    public int ManaChangeSingle;
    public int AtkChangeSingle;
    public int HpChangeSingle;
    public int ArmChangeSingle;
    public int EngChangeSingle;

    public List<int> ManaChangeList;
    public List<int> AtkChangeList;
    public List<int> HpChangeList;
    public List<int> ArmChangeList;
    public List<int> EngChangeList;

    public int HpDef;
    public bool VisualFx;
    public VfxType AssignVfxType;


	public EffectChange(Player srcPlayer, Card source, Card target = null, int manaChange = 0, int atkChange = 0, int hpChange = 0, int armChange = 0, int hpDef = -1,
        List<Card> targets = null, List<int> manaChanges = null, List<int> atkChanges = null, List<int> hpChanges = null, List<int> armChanges = null, 
        bool visualFx = true, bool injured=true,Card assignVfxCard=null, VfxType assignVfxType=VfxType.None,int engChange = 0, List<int> engChanges = null)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.TargetList = targets;

        this.AssignVfxCard = assignVfxCard;
        this.ManaChangeSingle= manaChange;
        this.AtkChangeSingle = atkChange;
        this.HpChangeSingle = hpChange;
        this.ArmChangeSingle = armChange;
        this.EngChangeSingle = engChange;

        this.ManaChangeList = manaChanges;
        this.AtkChangeList = atkChanges;
        this.HpChangeList = hpChanges;
        this.ArmChangeList = armChanges;
        this.EngChangeList = engChanges;

        this.HpDef = hpDef;
        this.VisualFx = visualFx;
        this.AssignVfxType = assignVfxType;
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
        if (TargetList == null)
        {
            this.TargetList = new List<Card>();
            this.ManaChangeList = new List<int>();
            this.AtkChangeList = new List<int>();
            this.HpChangeList = new List<int>();
            this.ArmChangeList = new List<int>();
            this.EngChangeList = new List<int>();
        }
        else 
        {
            if (this.ManaChangeList == null)
            {
                this.ManaChangeList = new List<int>();
                foreach (Card c in this.TargetList)
                {
                    this.ManaChangeList.Add(0);
                }
            }
            if (this.AtkChangeList == null)
            {
                this.AtkChangeList = new List<int>();
                foreach (Card c in this.TargetList)
                {
                    this.AtkChangeList.Add(0);
                }
            }
            if (this.HpChangeList == null)
            {
                this.HpChangeList = new List<int>();
                foreach (Card c in this.TargetList)
                {
                    this.HpChangeList.Add(0);
                }
            }
            if (this.ArmChangeList == null)
            {
                this.ArmChangeList = new List<int>();
                foreach (Card c in this.TargetList)
                {
                    this.ArmChangeList.Add(0);
                }
            }
            if (this.EngChangeList == null)
            {
                this.EngChangeList = new List<int>();
                foreach (Card c in this.TargetList)
                {
                    this.EngChangeList.Add(0);
                }
            }
        }

        if (this.TargetCard != null)
        {
            this.TargetList.Add(this.TargetCard);
            this.ManaChangeList.Add(this.ManaChangeSingle);
            this.AtkChangeList.Add(this.AtkChangeSingle);
            this.HpChangeList.Add(this.HpChangeSingle);
            this.ArmChangeList.Add(this.ArmChangeSingle);
            this.EngChangeList.Add(this.EngChangeSingle);
        }
        List<int> targetsIDs = new List<int>();
        int TotalChange = 0;

        for (int i = this.TargetList.Count-1;i>=0;i--)
        {

            this.TargetList[i].SetTag(GameTag.ManaMod,this.TargetList[i].PropertyArr[(int)(GameTag.ManaMod)]+this.ManaChangeList[i]);
            this.TargetList[i].SetTag(GameTag.AttackMod,this.TargetList[i].PropertyArr[(int)(GameTag.AttackMod)]+this.AtkChangeList[i]);
            this.TargetList[i].SetTag(GameTag.HealthMod, this.TargetList[i].PropertyArr[(int)(GameTag.HealthMod)]+this.HpChangeList[i]);
            this.TargetList[i].SetTag(GameTag.ArmorMod,this.TargetList[i].PropertyArr[(int)(GameTag.ArmorMod)]+this.ArmChangeList[i]);
            this.TargetList[i].SetTag(GameTag.EnergyMod,this.TargetList[i].PropertyArr[(int)(GameTag.EnergyMod)]+this.EngChangeList[i]);

            this.ManaChangeList[i] = this.TargetList[i].GetTag(GameTag.Mana);
            this.AtkChangeList[i] = this.TargetList[i].GetTag(GameTag.Attack);
            this.HpChangeList[i] = this.TargetList[i].GetTag(GameTag.Health) ;
            this.ArmChangeList[i] = this.TargetList[i].GetTag(GameTag.Armor);
            this.EngChangeList[i] = this.TargetList[i].GetTag(GameTag.Energy);

            targetsIDs.Add(this.TargetList[i].GetTag(GameTag.EntityId));
            TotalChange += this.AtkChangeList[i] + this.HpChangeList[i] + this.ArmChangeList[i] - this.ManaChangeList[i] + this.EngChangeList[i];
        }

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            VfxType WiseType = VfxType.Buff;
            if (TotalChange < 0)
            {
                WiseType = VfxType.Nerf;
            }
            if(this.AssignVfxType!=VfxType.None)
                WiseType = this.AssignVfxType;
            if(this.VisualFx)
                new CreateVfxCommand(this.SourceCard.GetTag(GameTag.EntityId), targetsIDs, dbfID: CustomVfxAsset, vfxType: WiseType).AddToQueue();
            //for (int i = this.TargetList.Count - 1; i >= 0; i--)
            //{
            //    if (this.HpDef != -1)
            //    {
            //        new SetActorTagCommand(this.TargetList[i].GetTag(GameTag.EntityId), hpdef:this.HpDef).AddToQueue();
            //    }
            //    new SetActorTagCommand(this.TargetList[i].GetTag(GameTag.EntityId), Cmana: this.ManaChangeList[i], Catk: this.AtkChangeList[i], Chp: this.HpChangeList[i], Carm: this.ArmChangeList[i]).AddToQueue();
            //}
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }
        this.SourcePlayer.myGame.CleanDeath();
    }
}