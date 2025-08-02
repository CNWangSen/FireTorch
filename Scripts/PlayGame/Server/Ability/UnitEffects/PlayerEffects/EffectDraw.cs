using System.Collections.Generic;

public class EffectDraw:UnitEffect
{
    public bool FastDraw;
    public int CardIndexInDeck;
	public EffectDraw(Player srcPlayer, Card srcCard = null, bool fast = false, int cardIndex = 0)
	{
        this.SourcePlayer = srcPlayer;
        this.FastDraw = fast;
        this.CardIndexInDeck = cardIndex;
        this.SourceCard = srcCard;
	}
	public override void Resolve()
	{
        if(this.SourceCard!=null)
            new EffectChange(this.SourcePlayer,this.SourceCard,this.SourcePlayer.hero[0]).Resolve();
        Card CardDrawn = null;
        if (this.SourcePlayer.deck.Count > 0)
        {
            CardDrawn = this.SourcePlayer.deck[this.CardIndexInDeck];
            new EffectMove(this.SourcePlayer,CardDrawn, ZoneType.Deck, ZoneType.Hand).Resolve();
            if (this.SourcePlayer.hand.Count > this.SourcePlayer.maxnum[(int)ZoneType.Hand])
            {
                //DiscardACard(newCard);
            }
            else
            {
            	/*
                //this.cardsDrawThisGame.Last().Add(newCard);
                if (DrawCardEvent != null)
                {
                    DrawCardEvent.Invoke();
                }
                */
            }


        }
        else
        {
            this.SourcePlayer.SetTag(GameTag.FatiguedTimes,this.SourcePlayer.GetTag(GameTag.FatiguedTimes)+1);
            if (this.SourcePlayer.hero.Count > 0)
            {
                if (this.SourcePlayer.hero[0].GetTag(GameTag.Health) > 0)
                {
                    new EffectDamage(this.SourcePlayer, this.SourcePlayer.FatigueCard, this.SourcePlayer.hero[0], this.SourcePlayer.GetTag(GameTag.FatiguedTimes)).Resolve();
                }
            }
        }
        //this.SourcePlayer.myGame.CleanDeath();

    }
}