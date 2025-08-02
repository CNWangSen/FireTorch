using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
public class Command
{
    public static Queue<Command> CommandQueue = new Queue<Command>();
    public static bool playingQueue = false;
    public static bool isGameOver = false;
    
    public static bool isRecording = true;
    public static Queue<Command> RecordedCommandQueue = new Queue<Command>();
    public static bool isReplaying = false;

    public string GUID = "";

    public static void BeginRecord()
    {
        isRecording = true;
        isReplaying = false;
    }
    public static void SaveRecord()
    {
        List<Command> ToSave = new List<Command>();
        foreach(Command cmd in RecordedCommandQueue)
        {
            cmd.GUID = cmd.GetType().Name;
            ToSave.Add(cmd);
        }
        var settings = new JsonSerializerSettings
        {
            Formatting = Newtonsoft.Json.Formatting.Indented,
            NullValueHandling = NullValueHandling.Include,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };
        string AllStr = Newtonsoft.Json.JsonConvert.SerializeObject(ToSave, settings);

        /*
        string AllStr = "[";
        int N = RecordedCommandQueue.Count;
        int i=0;
        foreach(Command cmd in RecordedCommandQueue)
        {
            AllStr += JsonUtility.ToJson(cmd);
            if(i!=N-1)
            {
                AllStr+=",";
            }
            i+=1;
        }
        AllStr+="]";
        */
        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() +  "/RecordGamePlay.json";
        File.WriteAllText(FileUrl,AllStr);
    }
    public static void LoadRecord()
    {
        isReplaying = true;
        isRecording = false;

        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/RecordGamePlay.json";
        string strJson;
        using(StreamReader sr = new StreamReader(FileUrl))
        {
            strJson = sr.ReadToEnd();
            sr.Close();
        }
        //List<Command> CommandNames = new List<Command>();

        //Dictionary<string, Type> guids = new Dictionary<string, Type>();
        //guids.Add(typeof(Person).GUID.ToString(), typeof(Person));
        //guids.Add(typeof(Student).GUID.ToString(), typeof(Student));
        //guids.Add(typeof(Teacher).GUID.ToString(), typeof(Teacher));

        List<Command> list = new List<Command>();
        using (StringReader sr = new StringReader(strJson))
        {
            JsonTextReader jtr = new JsonTextReader(sr);
            while (jtr.Read())
            {
                if (jtr.TokenType == JsonToken.StartObject)
                {
                    JObject obj = JObject.Load(jtr);
                    //obj.ToString().Dump();
                    //foreach (var element in guids.Keys)
                    //{
                    //    if (obj.Property("GUID").Value.ToString() == element)
                    //    {
                    //        list.Add((Command)Newtonsoft.Json.JsonConvert.DeserializeObject(obj.ToString(), guids[element]));
                    //    }
                    //}
                    if(obj.Property("GUID").Value.ToString()!="UpdateActorCommand")
                        list.Add((Command)Newtonsoft.Json.JsonConvert.DeserializeObject(obj.ToString(), System.Type.GetType(obj.Property("GUID").Value.ToString())));
                }
            }
        }
        //list.Dump();

        //CommandNames = JsonConvert.DeserializeObject<Queue<Command>>(json);
        //RecordedCommandQueue = JsonConvert.DeserializeObject<Queue<Command>>(json);
        RecordedCommandQueue.Clear();
        foreach(Command cmd in list)
        {
            RecordedCommandQueue.Enqueue(cmd);
        }
    }
    public static void PlayFirstCommandFromQueue()
    {
        playingQueue = true;
        if(isReplaying)
        {
            RecordedCommandQueue.Dequeue().StartCommandExecution();
        }
        else
        {
            CommandQueue.Dequeue().StartCommandExecution();
        }
    }
    public virtual void AddToQueue()
    {
        if(isGameOver)
        {
            return;
        }
        else
        {
            CommandQueue.Enqueue(this);
            if(isRecording && !isReplaying)
            {
                RecordedCommandQueue.Enqueue(this);
            }
            if (!playingQueue)
                PlayFirstCommandFromQueue();            
        }
    }

    public virtual void StartCommandExecution()
    {
    }

    public static void CommandExecutionComplete()
    {
        if (CommandQueue.Count > 0)
            PlayFirstCommandFromQueue();
        else {
            playingQueue = false;
        }
        /*
        if (Game.NowGame.GetTag(GameTag.GameState) == (int)GameState.Running)
        {
            foreach (Player p in Game.NowGame.PlayersInGame)
            {
                HighlightPlayableCards(p);// Game.NowGame.PlayersInGame[Game.NowGame.NowPlayingIndex]);
            }

        }
        */
        OneSceneManager.Instance.CorrectActorPositionInStages();
    }
    public static void HighlightPlayableCards(Player p)
    {
        /*
        if (p.GetTag(GameTag.IsControledByAI)==1)
        {
            return;

        }
        bool removeAllHighlights = false;
        if (p.myGame.GetTag(GameTag.NowPlayingIndex) != p.myGame.PlayersInGame.IndexOf(p))
        {
            removeAllHighlights = true;
        }
        foreach (Card cl in p.deck)
        {
            GameObject g = IDHolder.GetGameObjectWithID(cl.GetTag(GameTag.EntityId));
            if (g != null)
            {
                g.GetComponent<OneActorManager>().CanBePlayedNow = (cl.GetTag(GameTag.CanBePlayedFromDeck)==1) && (cl.GetTag(GameTag.Mana) <= p.GetTag(GameTag.ManaLeft)) && !removeAllHighlights && cl.CanBePlayed();
            }
        }
        foreach (Card cl in p.hand)
        {
            GameObject g = IDHolder.GetGameObjectWithID(cl.GetTag(GameTag.EntityId));
            if (g != null)
            {
                g.GetComponent<OneActorManager>().CanBePlayedNow = (cl.GetTag(GameTag.Mana) <= p.GetTag(GameTag.ManaLeft)) && !removeAllHighlights && cl.CanBePlayed();
            }
        }
        foreach (Card cl in p.board.Merge(p.hero))
        {
            GameObject g = IDHolder.GetGameObjectWithID(cl.GetTag(GameTag.EntityId));
            if (g != null)
            {
                g.GetComponent<OneActorManager>().CanAttackNow = (cl.GetTag(GameTag.Attack) > 0) && (cl.GetTag(GameTag.AttacksLeftThisTurn) > 0) && !removeAllHighlights;

                foreach (Card pcl in cl.attachmentList)
                {
                    GameObject gp = IDHolder.GetGameObjectWithID(pcl.GetTag(GameTag.EntityId));
                    if (gp != null)
                    {
                        HeroPowerButton Btn;
                        if (pcl.cardDbf.Targets == TargetingOptions.NoTarget)
                        {
                            Btn = gp.GetComponent<OneActorManager>().DragNoTarget.GetComponent<HeroPowerButton>();
                        }
                        else
                        {
                            Btn = gp.GetComponent<OneActorManager>().DragOnTarget.GetComponent<HeroPowerButton>();
                        }


                        Btn.Highlighted = (pcl.GetTag(GameTag.AttacksLeftThisTurn) > 0) && (p.GetTag(GameTag.ManaLeft) >= pcl.GetTag(GameTag.Mana)) && !removeAllHighlights;
                    }
                }
                
            }

        }
        foreach (Card cl in p.power)
        {
            GameObject g = IDHolder.GetGameObjectWithID(cl.GetTag(GameTag.EntityId));
            if(g!=null)
            {
                HeroPowerButton Btn;
                if(cl.cardDbf.Targets==TargetingOptions.NoTarget)
                {
                    Btn=g.GetComponent<OneActorManager>().DragNoTarget.GetComponent<HeroPowerButton>();
                }
                else
                {
                    Btn=g.GetComponent<OneActorManager>().DragOnTarget.GetComponent<HeroPowerButton>();
                }
                Btn.Highlighted = (cl.GetTag(GameTag.AttacksLeftThisTurn) > 0) && (p.GetTag(GameTag.ManaLeft) >= cl.GetTag(GameTag.Mana)) && !removeAllHighlights; 
            }
        }
        */
    }
}

