using System.Collections;
using System.Collections.Generic;

/*
Unimpl

BG_DAL_575 卡德加
BG_RLK_538 BG_RLK_538_G 噬魂者
BG21_013 雏龙走私商
BG21_036 现境大师
BG21_HERO_030_Buddy_e 载人飓风机甲
BG25_007 蛛魔之王阿努巴拉克
BG26_801 重金属双头飞龙
BGS_035 蜡烛骑士托瓦格尔
BGS_110 帝国之手 BGS_112 其拉传令官
BGS_205 永恒者艾丽斯特拉 TB_BaconUps_306
BG29_806 炫彩灼天者 BG29_807 鞭笞者特里高雷
*/

public class BaconShopRogueHero : Ability
{
    public override void Init()
    {
        owner.SetTag(GameTag.Damage,29);
    }
    public bool Done = false;
    public override void RegisterEventEffect()
    {
    	//if(owner.myPlayer.deck.)
        Game.NowGame.m_Mode=GameMode.BattleGround;//GameMode.BattleGround;
        owner.myPlayer.otherPlayer.Maker.m_Strategy = AIstrategy.AFK;
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,PrepareCombat));
        owner.myPlayer.maxnum = new List<int>
        {
            999,10,7,99999,
            5,2,1,1,
            9999,3,
        };
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }

    public void PrepareCombat()
    {
        if(Done)
        {
            
            return;
        }
        Done=true;
        for (int i = 0; i < owner.myPlayer.deck.Count; i++)
        {
            Card CreatedCard = new Card(owner.myPlayer.deck[i].cardDbf, owner.myPlayer);
            if(CreatedCard.cardDbf.CardType==CardType.Minion)
            {
                new EffectCreate(owner.myPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            if(CreatedCard.cardDbf.CardType==CardType.Spell)
            {
                new EffectCreate(owner.myPlayer,CreatedCard, ZoneType.Hand).Resolve();
            }
        }
        for (int i = 0; i < owner.myPlayer.otherPlayer.deck.Count; i++)
        {
            Card CreatedCard = new Card(owner.myPlayer.otherPlayer.deck[i].cardDbf, owner.myPlayer.otherPlayer);
            if(CreatedCard.cardDbf.CardType==CardType.Minion)
            {
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            if(CreatedCard.cardDbf.CardType==CardType.Spell)
            {
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Hand).Resolve();
            }
        }
        //new CreateDelayCommand(2f).AddToQueue();
        //new EffectTurnEnd(owner.myPlayer).Resolve();
    }
}
public class BaconShopRogueBoss : Ability
{
    public override void Init()
    {
        owner.SetTag(GameTag.Damage,29);
    }
    public bool Done=false;
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,StartCombat));
        owner.myPlayer.maxnum = new List<int>
        {
            100,10,7,99999,
            5,2,1,1,
            9999,3,
        };
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }

    public void StartCombat()
    {
        if(Done)
        {
            return;
        }
        Done=true;

        List<int> IndexList = new List<int>() { 0, 1 };
        int PlayerIndex = IndexList.Choice();
        int RoundNum = 0;
        List<Player> AllP = new List<Player> { owner.myPlayer, owner.myPlayer.otherPlayer };
        if (AllP[1].board.Count > AllP[0].board.Count)
        {
            AllP = new List<Player> { owner.myPlayer.otherPlayer, owner.myPlayer };
        }
        List<Card> OCS1 = new List<Card>();
        foreach(Card c in AllP[0].board)
        {
            OCS1.Add(c);
        }

        foreach (Card c in OCS1)
        {
            if(c.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
            {
                foreach (Ability abi in c.abilityList)
                {
                    abi.OnCombatStart();
                }
            }
        }

        List<Card> OCS2 = new List<Card>();
        foreach(Card c in AllP[1].board)
        {
            OCS2.Add(c);
        }

        foreach (Card c in OCS2)
        {
            if(c.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
            {
                foreach (Ability abi in c.abilityList)
                {
                    abi.OnCombatStart();
                }
            }
        }

        foreach (Card m in AllP[PlayerIndex].board)
        {
            m.SetTag(GameTag.AttacksLeftThisTurn, m.GetTag(GameTag.AttacksForOneTurn));
        }
        foreach (Card m in AllP[PlayerIndex].otherPlayer.board)
        {
            m.SetTag(GameTag.AttacksLeftThisTurn, m.GetTag(GameTag.AttacksForOneTurn));
        }

        while (owner.myPlayer.board.Count != 0 && owner.myPlayer.otherPlayer.board.Count != 0 && RoundNum < 1000)
        {
            Card Atker = null;
            Card Atked = null;

            foreach (Card m in AllP[PlayerIndex].board)
            {
                if (m.GetTag(GameTag.AttacksLeftThisTurn) > 0 && m.GetTag(GameTag.Attack) > 0)
                {
                    Atker = m;
                    break;
                }
            }
            if (Atker == null)
            {
                foreach (Card m in AllP[PlayerIndex].board)
                {
                    m.SetTag(GameTag.AttacksLeftThisTurn, m.GetTag(GameTag.AttacksForOneTurn));
                }
                foreach (Card m in AllP[PlayerIndex].board)
                {
                    if (m.GetTag(GameTag.AttacksLeftThisTurn) != 0 && m.GetTag(GameTag.Attack) != 0)
                    {
                        Atker = m;
                        break;
                    }
                }
            }

            List<Card> Taunt_Minions = new List<Card>();
            foreach (Card c in AllP[PlayerIndex].otherPlayer.board)
            {
                if (c.HasAbility("Taunt"))
                {
                    Taunt_Minions.Add(c);
                }
            }

            if (Taunt_Minions.Count == 0)
            {
                Atked = AllP[PlayerIndex].otherPlayer.board.Choice(AllP[PlayerIndex].otherPlayer.randomGen);
            }
            else
            {
                Atked = Taunt_Minions.Choice(AllP[PlayerIndex].otherPlayer.randomGen);
            }

            if (Atker != null & Atked != null)
            {
                new EffectAttack(Atker.myPlayer,Atker,Atked).Resolve();
                new CreateDelayCommand(0.3f).AddToQueue();
                if (Atker.GetTag(GameTag.AttacksLeftThisTurn) > 0 && Atker.GetTag(GameTag.Health)>0 && Atker.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
                {
                    PlayerIndex -= 1;
                }
            }

            PlayerIndex += 1;
            PlayerIndex = PlayerIndex % 2;
            RoundNum += 1;

        }
        Player Winner = null;
        if (owner.myPlayer.board.Count != 0)
        {
            Winner = owner.myPlayer;
        }
        else
        {
            if (owner.myPlayer.otherPlayer.board.Count != 0)
            {
                Winner = owner.myPlayer.otherPlayer;
            }
        }
        if (Winner != null)
        {
            UnityEngine.Debug.Log("------------------------------------BG end has winner-------------------");
            
            if(Winner.GetTag(GameTag.IsLowPlayer)==1)
            {
                UnityEngine.Debug.Log("Low Win");
            }
            else{
                UnityEngine.Debug.Log("Top Win");
            }
            UnityEngine.Debug.Log("Board Left Count: "+Winner.board.Count.ToString());
            UnityEngine.Debug.Log("Board ZeroLeftHp: "+Winner.board[0].GetTag(GameTag.Health).ToString());

            //UnityEngine.Debug.Log();
            if(Winner.hero.Count>0 && Winner.otherPlayer.hero.Count>0)
            {
                new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, Winner.hero[0].GetTag(GameTag.Mana) + 1, 0, 0).Resolve();
                foreach (Card c in Winner.board)
                {
                    //Winner.D
                    //new EffectDamage(,c, Winner.otherPlayer.hero[0], c.GetTag(GameTag.Mana)).Resolve();
                    c.SetTag(GameTag.AttacksLeftThisTurn, 0);
                    new EffectChange(Winner,Winner.hero[0], c).Resolve();
                    new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, c.cardDbf.ManaCost, 0, 0).Resolve();
                }
                new EffectAttack(Winner,Winner.hero[0],Winner.otherPlayer.hero[0]).Resolve();
                //new CreateDelayCommand(10f).AddToQueue();
                new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, -Winner.hero[0].GetTag(GameTag.Attack) + Winner.hero[0].cardDbf.Attack, 0, 0, visualFx:false).Resolve();

            }

        }

        new CreateDelayCommand(3f).AddToQueue();
        //new QuitGameCommand().AddToQueue();
        //UnityEngine.Application.Quit();
        //new ChangeSceneCommand("Roguelike").AddToQueue();

    }
}

















public class Bacon_TagTransferPlayerE:Ability{
//NAME=标记交换玩家附加效果[DNT]
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}



public class VAN_EX1_563:BaconShopRogueHero{
//NAME=玛里苟斯
//TEXT=<b>法术伤害+5</b>
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
    /*
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.cardType==CardType.Spell && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "EX1_563e";
    }
    */
}

public class TB_BaconShop_HERO_53_SKIN_C:BaconShopRogueHero{
//NAME=蛇眼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}

public class TB_BaconShop_HERO_78_SKIN_B:BaconShopRogueBoss{
//NAME=蛇眼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class TB_BaconShop_HERO_11_SKIN_C:BaconShopRogueBoss{
//NAME=蛇眼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class TB_BaconShop_HERO_11_SKIN_E:BaconShopRogueBoss{
//NAME=蛇眼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}