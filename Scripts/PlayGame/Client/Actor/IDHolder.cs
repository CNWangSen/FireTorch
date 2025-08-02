using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IDHolder : MonoBehaviour {

    public int UniqueID;
    private static Dictionary<int, GameObject> allGameObject = new Dictionary<int, GameObject>(); 

    public static GameObject GetGameObjectWithID(int ActorId)
    {
        if(allGameObject.ContainsKey(ActorId))
        {
            return allGameObject[ActorId]; 
        }
        return null;
    }
    public static void AddGameObjectWithID(GameObject actor, int ActorId)
    {
        actor.AddComponent<IDHolder>().UniqueID = ActorId;
        allGameObject[ActorId]=actor;
        //allGameObject.Add(ActorId, actor);
    }

    public static void ClearIDHoldersList()
    {
        allGameObject.Clear();
    }
}
