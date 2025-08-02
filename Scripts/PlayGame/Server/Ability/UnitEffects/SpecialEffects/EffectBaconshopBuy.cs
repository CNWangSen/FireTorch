using System.Collections.Generic;

public class EffectBaconshopBuy:UnitEffect
{
    int TargetId;
	public EffectBaconshopBuy(Player srcPlayer, int id)
	{
        this.SourcePlayer = srcPlayer;
        this.TargetId = id;
	}
	public override void Resolve()
	{
        int BuyCoin = 3;
        Card c = this.SourcePlayer.GetCardFromID(this.TargetId);
        if(c.cardDbf.m_noteMiniGuid.Contains("H_01"))
        {
            BuyCoin=c.GetTag(GameTag.Mana);
        }
        if (this.SourcePlayer.GetTag(GameTag.ManaLeft) >= BuyCoin)
        {
            this.SourcePlayer.SetTag(GameTag.ManaLeft,this.SourcePlayer.GetTag(GameTag.ManaLeft) - BuyCoin);
            new EffectMove(this.SourcePlayer.otherPlayer,c, ZoneType.Board, ZoneType.Removed, silent: true).Resolve();
            new EffectCreate(this.SourcePlayer, new Card(c.cardDbf, this.SourcePlayer), ZoneType.Hand).Resolve();
            Card newc = this.SourcePlayer.hand[this.SourcePlayer.hand.Count - 1];
            new EffectChange(this.SourcePlayer,newc, newc, -newc.GetTag(GameTag.Mana), 0, 0, 0,visualFx:false).Resolve();
        }
    }
}

public class EffectBaconshopReturn:UnitEffect
{
    int TargetId;
    public EffectBaconshopReturn(Player srcPlayer, int id)
    {
        this.SourcePlayer = srcPlayer;
        this.TargetId = id;
    }
    public override void Resolve()
    {
        Card c = this.SourcePlayer.GetCardFromID(this.TargetId);
        new EffectMove(this.SourcePlayer,c, ZoneType.Board, ZoneType.Hand, silent: true).Resolve();
        //new EffectCreate(this.SourcePlayer, new Card(c.cardDbf, this.SourcePlayer), ZoneType.Hand).Resolve();
        //Card newc = this.SourcePlayer.hand[this.SourcePlayer.hand.Count - 1];
        new EffectChange(this.SourcePlayer,c, c, -c.GetTag(GameTag.Mana), 0, 0, 0,visualFx:false).Resolve();
    }
}