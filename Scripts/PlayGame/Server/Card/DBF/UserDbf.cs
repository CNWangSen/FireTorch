using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using System.Text;


public class UserDbf
{
    [JsonProperty][SerializeField]
    internal string UserName="DefaultUser";
    [JsonProperty][SerializeField]
    internal string UserPassword="DefaultUserPwd";
    [JsonProperty][SerializeField]
    internal int Gold=10000;
    [JsonProperty][SerializeField]
    internal int Dust=10000;
    [JsonProperty][SerializeField]
    internal List<int> CardCollectionNums=new List<int>();
    [JsonProperty][SerializeField]
    internal List<int> PackNums = new List<int>(){100};
    [JsonProperty][SerializeField]
    internal bool IsSuperUser = true;
    [JsonProperty][SerializeField]
    internal bool IsLogged = false;

    public static UserDbf LoggedUser = new UserDbf();

    public static void LoadLoggedUserDbfFromDisk()
    {

        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/LoggedUserDbf.json";
        string json;
        using(StreamReader sr = new StreamReader(FileUrl))
        {
            json = sr.ReadToEnd();
            sr.Close();
        }
        List<UserDbf> records = JsonConvert.DeserializeObject<List<UserDbf>>(json);
        UserDbf.LoggedUser = records[0];

        //for(int i=0;i<db.CardCollectionNums.Count;i++)
        //{
        //    if(i<CardDbf.AllAsset.Count)
        //    {
        //        CardDbf.AllAsset[i].CollectionNum=db.CardCollectionNums[i];
        //    }
        //}
    }

    public static void SaveLoggedUserDbfToDisk()
    {
        //UserDbf.LoggedUser.CardCollectionNums = new List<int>();
        //CardDbf.FliterAllCardDbf();
        //foreach (CardDbf ca in CardDbf.AllAsset)
        //{
        //    UserDbf.LoggedUser.CardCollectionNums.Add(ca.CollectionNum);
        //}
        string AllStr = "[";
        AllStr += JsonUtility.ToJson(UserDbf.LoggedUser);
        AllStr += "]";
        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/LoggedUserDbf.json";
        using(StreamWriter sw = new StreamWriter(FileUrl,false,Encoding.UTF8))
        {
            sw.WriteLine(AllStr);
            sw.Close();
            sw.Dispose();
        }
    }

}



