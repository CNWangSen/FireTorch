using UnityEngine;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker;
using System;

public class TestSceneMono: MonoBehaviour
{
    private Animator Avator;
    
    public void Start2()
    {
        AssetBundle bd = AssetBundle.LoadFromFile("D:/Projects/GameHackProj/BepInPvz/BepInRH-AB/test");
        GameObject DiamondIns1 = GameObject.Instantiate(bd.LoadAsset<GameObject>("_LegPortraitOffScreen"), new Vector3(-100f,-100f,-100f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        GameObject DiamondIns2 = GameObject.Instantiate(bd.LoadAsset<GameObject>("__LegPortraitMesh"), new Vector3(0f,0f,0f), Quaternion.Euler(new Vector3(90f, 0f, 0f))) as GameObject;
        Avator=DiamondIns1.transform.GetChild(0).GetChild(0).GetComponent<Animator>();
    }

    public void Update1()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {  
            Avator.SetBool("Start",true);
            //Avator.Play("Attack-1");
        }
        if(Input.GetKeyDown(KeyCode.N))
        {  
            Avator.SetBool("Attack",true);
            //Avator.Play("Attack-1");
        }
        if(Input.GetKeyDown(KeyCode.B))
        {  
            Avator.SetBool("Emote",true);
            //Avator.Play("idle");
        }
    }

    public void Start()
    {
        GameObject Diamond;
        //PackOpeningFX_EDR.prefab:8ee56b7fc752e9f48a5a9eb2470d882e
        //Diamond = HSViewer.GetHSprefab("UnopenedEDRPack_Golden.prefab:b36dc7c199eaca04ba3f7e1f3d0edf8d");//);
        //PackOpeningFX_ICC.prefab:49a143909a35dbb4787d424766e3128e");//
        Diamond = HSViewer.GetHSLegendaryModel("HERO_02ax");//"HERO_10as");//HERO_10as 
        //Diamond = HSViewer.GetHSprefab("UNG.prefab:019a45dcb1dd20a4e93c150e2a54b12f");//STW.prefab:f9e7857518f178f469f1e0b3bcf72fb3");//LT24_001H_03,EX1_298,GDB_145
        //AssetBundle bd = AssetBundle.LoadFromFile("D:/Projects/GameHackProj/BepInPvz/BepInRH-AB/gatlingcattail");
        //Diamond = bd.LoadAsset<GameObject>("GatlingCattailPrefab");
        //Diamond = HSViewer.GetHSDiamondModel("LOE_011");
        //Diamond = HSViewer.GetHSprefab("MusicFestival_Epic.asset:faecf8d9425871248bbbeacee9ab455a");
        if(Diamond!=null)
        {
            GameObject DiamondIns = GameObject.Instantiate(Diamond, new Vector3(0f,0f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            DiamondIns.SetActive(true);
            //OpenPackManager.NormalizeVFX(DiamondIns);
            Spell sp = DiamondIns.GetComponent<Spell>();
            if(sp!=null)
            {
                sp.m_fsm = DiamondIns.GetComponent<PlayMakerFSM>();
                if(sp.m_fsm!=null)
                {
                    sp.m_fsm.SendEvent("Death");
                    sp.m_fsm.SendEvent("Action");
                    sp.m_fsm.SendEvent("Birth");                   
                }                
            }

        }
	}
}
