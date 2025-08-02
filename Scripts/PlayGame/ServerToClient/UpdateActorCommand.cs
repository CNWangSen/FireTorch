using System.Collections.Generic;
using UnityEngine;

public class UpdateActorCommand : Command
{
    //public Game G;
    public List<int> EntityIds = new List<int>();
    public List<int> Manas = new List<int>();
    public List<int> Attacks = new List<int>();
    public List<int> Healths = new List<int>();
    public List<int> Armors = new List<int>();
    public List<int> Energys = new List<int>();
    public List<int> HealthDefs = new List<int>();
    public List<bool> HighLight = new List<bool>();

    public UpdateActorCommand(Game game)
    {
        //this.G = game;
        Response.ServerSend("UpdateActor");
        foreach(Player p in game.PlayersInGame)
        {
            bool ThisPlayersTurn =  (Game.NowGame.PlayersInGame[Game.NowGame.GetTag(GameTag.NowPlayingIndex)] == p || game.m_Mode==GameMode.MarvelSnap);
            List<Card> ToListUpdate = new List<Card>();

            foreach(Card c in p.hero.Merge(p.board).Merge(p.weapon).Merge(p.power).Merge(p.hand).Merge(p.deck).Merge(p.grave))
            {
                ToListUpdate.Add(c);
                foreach(Card cp in c.attachmentList)
                {
                    ToListUpdate.Add(cp);
                }
            }
            foreach(Card c in ToListUpdate)
            {
                //GameObject target = IDHolder.GetGameObjectWithID(c.GetTag(GameTag.EntityId));
                //if(target!=null)
                //    target.GetComponent<OneActorManager>().SetCardNum(c.GetTag(GameTag.Mana), c.GetTag(GameTag.Attack), c.GetTag(GameTag.Health), c.GetTag(GameTag.Armor), hpDefSet:c.GetTag(GameTag.HealthDef));
                this.EntityIds.Add(c.GetTag(GameTag.EntityId));
                this.Manas.Add(c.GetTag(GameTag.Mana));
                this.Attacks.Add(c.GetTag(GameTag.Attack));
                this.Healths.Add(c.GetTag(GameTag.Health));
                this.Armors.Add(c.GetTag(GameTag.Armor));
                this.Energys.Add(c.GetTag(GameTag.Energy));
                this.HealthDefs.Add(c.GetTag(GameTag.HealthDef));
                bool High=false;
                if(p.GetTag(GameTag.IsControledByAI)==1 || !ThisPlayersTurn)
                {
                }
                else{
                    switch((ZoneType)c.GetTag(GameTag.ZoneType))
                    {
                        case(ZoneType.Deck):
                            High=(c.GetTag(GameTag.CanBePlayedFromDeck)==1) && (c.GetTag(GameTag.Mana) <= p.GetTag(GameTag.ManaLeft)) && c.CanBePlayed();
                            break;
                        case(ZoneType.Hand):
                            High=(c.GetTag(GameTag.Mana) <= p.GetTag(GameTag.ManaLeft)) && c.CanBePlayed();
                            break;
                        case(ZoneType.Board):
                            High=(c.GetTag(GameTag.Attack) > 0) && (c.GetTag(GameTag.AttacksLeftThisTurn) > 0);
                            if(OneSceneManager.Instance.IsBgMode)
                            {
                                High=false;
                            }
                            break;
                        case(ZoneType.Hero):
                            High=(c.GetTag(GameTag.Attack) > 0) && (c.GetTag(GameTag.AttacksLeftThisTurn) > 0);
                            break;
                        case(ZoneType.Power):
                            High=(c.GetTag(GameTag.AttacksLeftThisTurn) > 0) && (p.GetTag(GameTag.ManaLeft) >= c.GetTag(GameTag.Mana));
                            break;
                        case(ZoneType.MinionPower):
                            High=(c.GetTag(GameTag.AttacksLeftThisTurn) > 0) && (p.GetTag(GameTag.ManaLeft) >= c.GetTag(GameTag.Mana));
                            break;
                        default:
                            break;
                    }
                }
                this.HighLight.Add(High);
            }
        }
        new ExeUpdateActorCommand(this.EntityIds,this.Manas,this.Attacks,this.Healths,this.Armors,this.HealthDefs,this.HighLight,this.Energys).AddToQueue();
    }

    public override void StartCommandExecution()
    {
        /*
        for(int i=0;i<this.EntityIds.Count;i++)
        {
            GameObject target = IDHolder.GetGameObjectWithID(this.EntityIds[i]);
            if(target!=null)
                target.GetComponent<OneActorManager>().SetCardNum(this.Manas[i], this.Attacks[i], this.Healths[i], this.Armors[i], hpDefSet:this.HealthDefs[i]);
        }
        */
        Command.CommandExecutionComplete();
        
    }
}





public class ExeUpdateActorCommand : Command
{
    public List<int> EntityIds = new List<int>();
    public List<int> Manas = new List<int>();
    public List<int> Attacks = new List<int>();
    public List<int> Healths = new List<int>();
    public List<int> Armors = new List<int>();
    public List<int> Energys = new List<int>();
    public List<int> HealthDefs = new List<int>();
    public List<bool> HighLight = new List<bool>();
    //public List<Vector3> HighLightColor = new List<Vector3>();


    public ExeUpdateActorCommand(List<int> entityIds, List<int> manas, List<int> attacks, List<int> healths, List<int> armors, List<int> healthDefs, List<bool> hightlight, List<int> energys)
    {
        this.EntityIds=entityIds;
        this.Manas=manas;
        this.Attacks=attacks;
        this.Healths=healths;
        this.Armors=armors;
        this.Energys=energys;
        this.HealthDefs=healthDefs;
        this.HighLight = hightlight;
        //this.HighLightColor = hightlightColor;
    }

    public override void StartCommandExecution()
    {
        for(int i=0;i<this.EntityIds.Count;i++)
        {
            GameObject target = IDHolder.GetGameObjectWithID(this.EntityIds[i]);
            
            if(target!=null)
            {
                OneActorManager mgr = target.GetComponent<OneActorManager>();
                mgr.SetCardNum(this.Manas[i], this.Attacks[i], this.Healths[i], this.Armors[i], hpDefSet:this.HealthDefs[i],engSet:this.Energys[i]);
                mgr.CanAttackNow=this.HighLight[i];
                mgr.CanBePlayedNow=this.HighLight[i];
                //if(mgr.CardDbf.CardType==CardType.HeroPower)
                if(mgr.zoneType==ZoneType.MinionPower || mgr.zoneType==ZoneType.Power)
                {
                    HeroPowerButton Btn;
                    if(mgr.m_ActorTargetOpts==TargetingOptions.NoTarget)
                    {
                        Btn=mgr.DragNoTarget.GetComponent<HeroPowerButton>();
                    }
                    else
                    {
                        Btn=mgr.DragOnTarget.GetComponent<HeroPowerButton>();
                    }
                    Btn.Highlighted = this.HighLight[i];
                }
            }
        }
        Command.CommandExecutionComplete();
    }
}