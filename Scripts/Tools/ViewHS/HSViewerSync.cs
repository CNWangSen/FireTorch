using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Audio;
using Newtonsoft.Json;
using Blizzard.T5.AssetManager;
using System;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker;

public class HSViewerSync : MonoBehaviour
{
    public static string absHSdir = "D:/ProgramFiles/Graphic/MyGame/Hearthstone/Data/Win/";//"D:\\DocFile\\Unity3dRef\\Assets\\CusCCG_Ex_HS2\\";
    public static string absExdir = "D:/DocFile/Unity3dRef/Assets/";
    public static bool IsReleaseMode = true;
    public static string DefaultHSSummonSpawnDeathID = "VAN_EX1_100";

    public void Start()
    {
#if UNITY_EDITOR
        IsReleaseMode=false;
#endif
        if(IsReleaseMode)
        {
            HSViewerSync.absHSdir=Path.Combine(System.Environment.CurrentDirectory,"../")+"Data/Win/";
            HSViewerSync.absExdir="ExtraAssets/";
            UnityEngine.Debug.Log(System.Environment.CurrentDirectory);
        }
        //LoadCard(0);
    }
    public void LoadCard(int CardID = 126551030)
    {   
        PrepareHSjson();

        //GetHSShader();
        //GetHSAttack();
        //GetHSBattleCryEffect(SpellType.FRIENDLY_ATTACK,zty:ZoneType.Board,cty:CardType.Minion);    
        //GetHSSpellPlayEffect("SW_046");//"VAN_CS2_189");///CS2_075");BOT_246
        AssetBundle abspelltable2 = HSViewerSync.LoadFullBundle(absHSdir,"dbf.unity3d");
        //GameObject imp = GetHSSpellFromTable(ty:SpellType.AUTO_ATTACK_WITH_HIGHLIGHT,zty:ZoneType.Board,cty:CardType.Minion);
        
        string spelltableid = StripByNote("AttackSpellController_Battlegrounds_Minion.prefab:922da2c91f4cca1458b5901204d1d26c");//"AttackSpellController.prefab:12acecc85ac575e43b87ec141b89269a");//def.m_PlayEffectDef.m_SpellPath);
        string spelltableurl = GetUrlfromGUID(spelltableid);    
        AssetBundle abspelltable = HSViewerSync.LoadFullBundle(absHSdir,spelltableurl);
        GameObject imp = abspelltable.LoadAsset<GameObject>(spelltableid);
        GameObject ins = GameObject.Instantiate(imp, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;

        /*
        (GameObject objsummon,GameObject obj2,GameObject obj, GameObject obj4) = GetHSCustomSummonSpawnDeathEffect("BOT_424");
        if(obj!=null)
        {
            GameObject summonins = GameObject.Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            foreach(Transform t in summonins.transform.GetComponentsInChildren<Transform>(true))
            {
                t.gameObject.SetActive(true);
                if(t.gameObject.GetComponent<MeshRenderer>()!=null)
                {
                    t.gameObject.GetComponent<MeshRenderer>().enabled=false;
                }
            }
            foreach(ParticleSystem ps in summonins.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Play();
            }  
        }
        */
    }
    public static GameObject GetHSSpellPlayEffect(string cardname)
    {
        GameObject summonins=null;
        CardDef def = HSViewerSync.GetHSCardDef(cardname);
        //UnityEngine.Debug.Log(def.m_GameObject.m_PathID);
        if(def!=null)
        {
            UnityEngine.Debug.Log("DefNotNull");
            UnityEngine.Debug.Log(def.m_PortraitTexturePath);
            string summonspellid = StripByNote(def.m_PlayEffectDef.m_SpellPath);
            //UnityEngine.Debug.Log(summonspellid);
            string summonspellurl = GetUrlfromGUID(summonspellid);
            //UnityEngine.Debug.Log(summonspellid);
            //UnityEngine.Debug.Log(summonspellurl);
            if(summonspellurl!="")
            {

                AssetBundle absummonspell = HSViewerSync.LoadFullBundle(absHSdir,summonspellurl);
                GameObject obj = absummonspell.LoadAsset<GameObject>(summonspellid);
                if(obj!=null)
                {
                    summonins = GameObject.Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                    SuperSpell sup = summonins.GetComponent<SuperSpell>();
                    //foreach(UnityEngine.Object ob in absummonspell.LoadAllAssets())
                    //{
                    //    UnityEngine.Debug.Log(ob.name);
                    //}
                    if(sup==null)
                    {
                        return null;
                    }
                    GameObject SpellImpact=null;
                    //SpellImpact = GameObject.Instantiate(sup.m_MissileInfo.m_Prefab.gameObject, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;

                    
                    GameObject SpellPrefab= LoadSoundDefForSpellObj(sup.m_FriendlyAreaEffectInfo.m_Prefab.gameObject, true);
                    SpellImpact = GameObject.Instantiate(SpellPrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                    SpellImpact.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
                    SpellImpact = AddPlayMakerFSMAudioClip(SpellImpact,true);

                    foreach (Transform t in SpellImpact.transform.GetComponentsInChildren<Transform>(true))
                    {
                        if(t.name=="TargetJoint")
                        {
                            t.localPosition = new Vector3(2f,0f,8f);
                        }
                    }
                    foreach (Transform t in SpellImpact.transform.GetComponentsInChildren<Transform>(true))
                    {
                        /*
                        t.gameObject.SetActive(true);
                        if(t.gameObject.GetComponent<MeshRenderer>()!=null)
                        {
                            t.gameObject.GetComponent<MeshRenderer>().enabled=true;
                        }
                        if(t.gameObject.GetComponent<SkinnedMeshRenderer>()!=null)
                        {
                            t.gameObject.GetComponent<SkinnedMeshRenderer>().enabled=true;
                        }
                        if(t.gameObject.GetComponent<Animation>()!=null)
                        {
                            t.gameObject.GetComponent<Animation>().Play();
                        }
                        */
                        //if(t.gameObject.name.Contains("Mask"))
                        //{
                        //    t.gameObject.SetActive(false);
                        //}
                    }
                    /*
                    foreach(OffScreenRenderFX osf in SpellImpact.GetComponentsInChildren<OffScreenRenderFX>())
                    {
                        if(osf.ObjectToRender!=null)
                        {
                            osf.ObjectToRender.SetActive(false);
                        }
                    }
                    foreach(ParticleSystem ps in SpellImpact.GetComponentsInChildren<ParticleSystem>())
                    {
                        var main = ps.main;
                        main.loop = true;
                        main.scalingMode = ParticleSystemScalingMode.Hierarchy;
                        ps.GetComponent<Renderer>().enabled=true;
                        ps.Play();
                    }
                      */              
                }
            }  
        }
        return summonins;
    }
    public static bool IsDefaultAttackAniClipLoaded=false;
    public static void LoadDefaultAttackAniClip()
    {
        if(!HSViewerSync.IsDefaultAttackAniClipLoaded)
        {
            GameObject DefaultAttack = GetHSSpellFromTable(SpellType.FRIENDLY_ATTACK,zty:ZoneType.Board,cty:CardType.Minion);
            
            SpellState s1 = DefaultAttack.transform.GetChild(0).gameObject.GetComponent<SpellState>();
            SpellState s2 = DefaultAttack.transform.GetChild(3).gameObject.GetComponent<SpellState>();

            OneActorManager.DefaultAttackReadyClip = s1.m_ExternalAnimatedObjects[0].m_AnimClip;
            OneActorManager.DefaultAttackFinishClip = s2.m_ExternalAnimatedObjects[0].m_AnimClip;
            HSViewerSync.IsDefaultAttackAniClipLoaded=true;
        }
    }

    public static GameObject GetHSAttack()
    {
        GameObject summonins=null;
        string summonspellid = StripByNote("AttackSpellController.prefab:12acecc85ac575e43b87ec141b89269a");
        string summonspellurl = GetUrlfromGUID(summonspellid);
        if(summonspellurl!="")
        {
            AssetBundle absummonspell = HSViewerSync.LoadFullBundle(absHSdir,summonspellurl);
            GameObject obj = absummonspell.LoadAsset<GameObject>(summonspellid);
            if(obj!=null)
            {
                summonins = GameObject.Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                AttackSpellController sup = summonins.GetComponent<AttackSpellController>();
                //foreach(UnityEngine.Object ob in absummonspell.LoadAllAssets())
                //{
                //    UnityEngine.Debug.Log(ob.name);
                //}
                if(sup==null)
                {
                    return null;
                }
                GameObject SpellImpact=null;
                //SpellImpact = GameObject.Instantiate(sup.m_MissileInfo.m_Prefab.gameObject, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;

                
                GameObject SpellPrefab= LoadSoundDefForSpellObj(sup.m_ImpactDefs[0].m_spellPrefab.gameObject, true);
                SpellImpact = GameObject.Instantiate(SpellPrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                SpellImpact.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
                SpellImpact = AddPlayMakerFSMAudioClip(SpellImpact,true);

                foreach (Transform t in SpellImpact.transform.GetComponentsInChildren<Transform>(true))
                {
                    if(t.name=="TargetJoint")
                    {
                        t.localPosition = new Vector3(2f,0f,8f);
                    }
                }
                foreach (Transform t in SpellImpact.transform.GetComponentsInChildren<Transform>(true))
                {

                    t.gameObject.SetActive(true);
                    if(t.gameObject.GetComponent<MeshRenderer>()!=null)
                    {
                        t.gameObject.GetComponent<MeshRenderer>().enabled=false;
                    }
                    if(t.gameObject.GetComponent<SkinnedMeshRenderer>()!=null)
                    {
                        t.gameObject.GetComponent<SkinnedMeshRenderer>().enabled=true;
                    }
                    if(t.gameObject.GetComponent<Animation>()!=null)
                    {
                        t.gameObject.GetComponent<Animation>().Play();
                    }

                }
                foreach(OffScreenRenderFX osf in SpellImpact.GetComponentsInChildren<OffScreenRenderFX>())
                {
                    if(osf.ObjectToRender!=null)
                    {
                        osf.ObjectToRender.SetActive(false);
                    }
                }
                foreach(ParticleSystem ps in SpellImpact.GetComponentsInChildren<ParticleSystem>())
                {
                    var main = ps.main;
                    main.loop = true;
                    main.scalingMode = ParticleSystemScalingMode.Hierarchy;
                    ps.GetComponent<Renderer>().enabled=true;
                    ps.Play();
                }
                                
            }
        }  
        
        return summonins;        
    }
    public static Dictionary<string,Shader> ShaderCahe = new Dictionary<string,Shader>();
    public static bool IsShaderLoaded=false;
    public static AssetBundle LoadFullShaderBundle(string BaseUrl, string BundleName, bool LoadDep=true)
    {
        UnityEngine.Debug.Log('f');
        //HSViewerSync.LoadAllBund();
        //return HSViewerSync.abCache[BaseUrl+BundleName];//AssetBundle.LoadFromFile(BaseUrl+BundleName);
        if(HSViewerSync.abCache.ContainsKey(BundleName))
        {
            return HSViewerSync.abCache[BundleName];
        }

        if(LoadDep)
        {
            foreach(string dependency in HSViewerSync.GetDepend(BundleName))
            {
                UnityEngine.Debug.Log(dependency);
                HSViewerSync.LoadFullShaderBundle(BaseUrl,dependency,false);
            }
        }

        if(HSViewerSync.abCache.ContainsKey(BundleName))
        {
            return HSViewerSync.abCache[BundleName];
        }
        AssetBundle bundl = AssetBundle.LoadFromFile(BaseUrl+BundleName);
        Shader[] sl = bundl.LoadAllAssets<Shader>();
        foreach(Shader s in sl)
        {
            UnityEngine.Debug.Log(s.name);
        }
        HSViewerSync.abCache[BundleName] = bundl;
        return bundl;
    }
    public static Shader GetHSShader(string shaderName="Hidden/R2TAlphaClip")
    {

        //Hidden/R2TAlphaClip
        //Custom/AlphaFillOpaque
        //Hidden/R2TAdditive
        if(!HSViewerSync.IsShaderLoaded)
        {
            PrepareHSjson();
            string summonspellid = StripByNote("ShaderPreCompiler.prefab:380ca3ee11a2643068cfb3d4766f3fd3");
            string summonspellurl = GetUrlfromGUID(summonspellid);
            UnityEngine.Debug.Log(summonspellurl);
            AssetBundle sab = HSViewerSync.LoadFullBundle(absHSdir,summonspellurl);
            GameObject ob = sab.LoadAsset<GameObject>(summonspellid);
            //GameObject summonins = GameObject.Instantiate(ob, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            ShaderPreCompiler comp = ob.GetComponent<ShaderPreCompiler>();
            foreach (Shader sh in comp.m_SceneChangeCompileShaders)
            {
                HSViewerSync.ShaderCahe[sh.name]=sh;
            }
            foreach (Shader sh in comp.m_StartupCompileShaders)
            {
                HSViewerSync.ShaderCahe[sh.name]=sh;
            }

            AssetBundle sab2 = HSViewerSync.LoadFullBundle(absHSdir,"essential_base_global-shader-0.unity3d");
            foreach(UnityEngine.Object ob2 in sab2.LoadAllAssets())
            {
                HSViewerSync.ShaderCahe[ob2.name] = (Shader)ob2;
            }

            HSViewerSync.IsShaderLoaded=true;
        }
        if(HSViewerSync.ShaderCahe.ContainsKey(shaderName))
        {
            return HSViewerSync.ShaderCahe[shaderName];
        }
        else{
            return Shader.Find(shaderName);
        }       
    }

    public static GameObject GetHSBattleCryEffect(SpellType ty,ZoneType zty = ZoneType.Board, CardType cty = CardType.Minion)
    {
        GameObject SpellImpact;
        SpellImpact = GameObject.Instantiate(GetHSSpellFromTable(ty,zty:zty,cty:cty), new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        SpellImpact.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
        SpellImpact = AddPlayMakerFSMAudioClip(SpellImpact,true);
        foreach (Transform t in SpellImpact.transform.GetComponentsInChildren<Transform>(true))
        {

            t.gameObject.SetActive(true);
            if(t.gameObject.GetComponent<MeshRenderer>()!=null)
            {
                t.gameObject.GetComponent<MeshRenderer>().enabled=false;
            }
            if(t.gameObject.GetComponent<SkinnedMeshRenderer>()!=null)
            {
                t.gameObject.GetComponent<SkinnedMeshRenderer>().enabled=true;
            }
            if(t.gameObject.GetComponent<Animation>()!=null)
            {
                t.gameObject.GetComponent<Animation>().Play();
            }
        }
        foreach(OffScreenRenderFX osf in SpellImpact.GetComponentsInChildren<OffScreenRenderFX>())
        {
            if(osf.ObjectToRender!=null)
            {
                osf.ObjectToRender.SetActive(false);
            }
        }
        foreach(ParticleSystem ps in SpellImpact.GetComponentsInChildren<ParticleSystem>())
        {
            var main = ps.main;
            main.loop = true;
            main.scalingMode = ParticleSystemScalingMode.Hierarchy;
            ps.GetComponent<Renderer>().enabled=true;
            ps.Play();
        } 
        return SpellImpact;        
    }

    public static bool hsspelltableready=false;
    public static Dictionary<SpellType,GameObject> HSSpellTableVfxCahePlayAlly = new Dictionary<SpellType,GameObject>();
    public static Dictionary<SpellType,GameObject> HSSpellTableVfxCaheHandAlly = new Dictionary<SpellType,GameObject>();
    public static Dictionary<SpellType,GameObject> HSSpellTableVfxCaheHandAbility = new Dictionary<SpellType,GameObject>();
    public static Dictionary<SpellType,GameObject> HSSpellTableVfxCaheHandWeapon = new Dictionary<SpellType,GameObject>();
    public static Dictionary<SpellType,GameObject> HSSpellTableVfxCahePlayWeapon = new Dictionary<SpellType,GameObject>();
    public static Dictionary<SpellType,GameObject> HSSpellTableVfxCahePlayHero = new Dictionary<SpellType,GameObject>();

    public static GameObject GetHSSpellFromTable(SpellType ty,ZoneType zty= ZoneType.Board,CardType cty = CardType.Minion)
    {
        HSViewerSync.PrepareHSjson();
        Dictionary<SpellType,GameObject> WiseDict=HSSpellTableVfxCahePlayAlly;
        string TableRawID = "Card_Play_Ally_SpellTable.prefab:81be4c58f5a9d454e815f1b0703d8179";
        if(zty == ZoneType.Hand)
        {
            TableRawID = "Card_Hand_Ally_SpellTable.prefab:78c9e9fcc292c4a82b35e4b168fb5200";
            WiseDict=HSSpellTableVfxCaheHandAlly;
            if(cty == CardType.Spell)
            {
                TableRawID = "Card_Hand_Ability_SpellTable.prefab:62c19ebc0789b4f00b9f393b17349cb2";
                WiseDict=HSSpellTableVfxCaheHandAbility;
            }
            if(cty==CardType.Weapon)
            {
                TableRawID = "Card_Hand_Weapon_SpellTable.prefab:548dce68672b046e1aec1fd629082eb2";
                WiseDict=HSSpellTableVfxCaheHandWeapon;
            }
        }
        if(zty == ZoneType.Weapon)
        {
            TableRawID = "Card_Play_Weapon_SpellTable.prefab:9eb63fe4f82064b50b443e1b15a4825d";
            WiseDict=HSSpellTableVfxCahePlayWeapon;
        }
        if(zty == ZoneType.Hero)
        {
            TableRawID = "Card_Play_Hero_SpellTable.prefab:c7908ae61ab34412aa7f5a9bf3c89cf2";
            WiseDict=HSSpellTableVfxCahePlayHero;
        }

        if(WiseDict.ContainsKey(ty))
        {
            return WiseDict[ty];
        }
        string spelltableid = StripByNote(TableRawID);//def.m_PlayEffectDef.m_SpellPath);
        string spelltableurl = GetUrlfromGUID(spelltableid);    

        if(spelltableurl!="")
        {
            AssetBundle abspelltable = HSViewerSync.LoadFullBundle(absHSdir,spelltableurl);
            GameObject tableobj = abspelltable.LoadAsset<GameObject>(spelltableid);
            if(tableobj!=null)
            {
                //summonins = GameObject.Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                SpellTable tb = tableobj.GetComponent<SpellTable>();
                SpellTableEntry BattleCryEntry = null;
                foreach(SpellTableEntry ent in tb.m_Table)
                {
                    if(ent.m_Type == ty)
                    {
                        BattleCryEntry = ent;
                        break;
                    }
                }
                if(BattleCryEntry!=null)
                {
                    string BattleCrySpellid = StripByNote(BattleCryEntry.m_SpellPrefabName);
                    string BattleCrySpellurl = GetUrlfromGUID(BattleCrySpellid);
                    if(BattleCrySpellurl!="")
                    {
                        AssetBundle abBattleCrySpell = HSViewerSync.LoadFullBundle(absHSdir,BattleCrySpellurl);
                        if(abBattleCrySpell!=null)
                        {
                            GameObject objBattleCry = abBattleCrySpell.LoadAsset<GameObject>(BattleCrySpellid);
                            if(objBattleCry!=null)
                            {
                                GameObject objBattleCryPrefab = LoadSoundDefForSpellObj(objBattleCry);
                                WiseDict[ty]=objBattleCryPrefab;
                                return objBattleCryPrefab;
                            }                             
                        }
                    }

                }
            }
        } 
        WiseDict[ty]=null;
        return null;
    }




    public static GameObject AddPlayMakerFSMAudioClip(GameObject SpellObj, bool Loop=false)
    {
        List<SoundDef> ToBeAdd = new List<SoundDef>();
        Spell sp = SpellObj.GetComponent<Spell>();
        if (sp != null)
        {
            sp.m_fsm = SpellObj.GetComponent<PlayMakerFSM>();
            if (sp.m_fsm != null)
            {
                sp.m_fsm.enabled = false;
            }
            return SpellObj;
        }
        return SpellObj;
    }
    public static Dictionary<string, AudioClip> PlayMakerSoundCahe = new Dictionary<string, AudioClip>();
    public static AudioClip LoadAudioClipFromSoundDefInPlayMaker(string clipstr)
    {
        if(PlayMakerSoundCahe.ContainsKey(clipstr))
        {
            return PlayMakerSoundCahe[clipstr];
        }
        AudioClip clp = null;
        string audid = HSViewerSync.StripByNote(clipstr);
        string audurl = HSViewerSync.GetUrlfromGUID(audid);
        if (audurl != null)
        {
            AssetBundle abaud = HSViewerSync.LoadFullBundle(HSViewerSync.absHSdir, audurl);
            clp = abaud.LoadAsset<AudioClip>(audid);
        }
        PlayMakerSoundCahe[clipstr] = clp;
        return clp;
    }
    public static GameObject LoadSoundDefForSpellObj(GameObject SpellObj, bool Loop=false)
    {
        List<SoundDef> ToBeAdd = new List<SoundDef>();
        /*
        GameObject SpellObj = (GameObject)Instantiate(SpellObjPrefab, Vector3.zero, Quaternion.Euler(Vector3.zero));
        DontDestroyOnLoad(SpellObj);
        SpellObj.SetActive(false);

        //AudioSource src = sup.m_StartInfo.m_Prefab.gameObject.AddComponent<AudioSource>();
        
        Spell sp = SpellObj.GetComponent<Spell>();
        if (sp != null)
        {
            sp.m_fsm = SpellObj.GetComponent<PlayMakerFSM>();
            if (sp.m_fsm != null)
            {
                //sp.m_fsm.Preprocess();
                //sp.m_fsm.SendEvent("Death");
                foreach (FsmState st in sp.m_fsm.Fsm.States)
                {
                    //UnityEngine.Debug.Log(st.Name);
                    //if (st.Name == "DeathState")
                    //{
                    foreach (FsmStateAction act in st.Actions)
                    {
                        if (act.GetType().Name == "AudioPlayClipAction")
                        {
                            //UnityEngine.Debug.Log(act.);
                            //AudioPlayClipAction apa = sp.m_fsm.GetComponent<AudioPlayClipAction>();

                            //SoundPlayClipArgs soundPlayClipArgs = new SoundPlayClipArgs();
                            //soundPlayClipArgs.m_templateSource = ((AudioPlayClipAction)act).m_TemplateSource;
                            //soundPlayClipArgs.m_def = (((AudioPlayClipAction)act).m_Sound.Value as SoundDef);
                            ToBeAdd.Add((((AudioPlayClipAction)act).m_Sound.Value as SoundDef));

                            //UnityEngine.Debug.Log("FSM audio Play");
                            //UnityEngine.Debug.Log(soundPlayClipArgs.m_def.m_AudioClip);
                        }
                    }
                    //}
                   
                }
                //Destroy(sp.m_fsm);//.enabled = false;
            }
            
            //Destroy(sp.m_fsm);
        }
        */
        //foreach(AudioSource adsrc in SpellObj.GetComponentsInChildren<AudioSource>())
        //{
        //    Destroy(adsrc);
        //}
        foreach (SoundDef sd in SpellObj.GetComponentsInChildren<SoundDef>())
        {
            ToBeAdd.Add(sd);
        }
        foreach (SoundDef sd in ToBeAdd)
        {
            if (sd.m_AudioClip != "")
            {
                string audid = StripByNote(sd.m_AudioClip);
                string audurl = GetUrlfromGUID(audid);
                if (audurl != null)
                {
                    AssetBundle abaud = HSViewerSync.LoadFullBundle(HSViewerSync.absHSdir, audurl);
                    AudioClip clip = abaud.LoadAsset<AudioClip>(audid);
                    if (clip != null)
                    {
                        AudioSource src = SpellObj.AddComponent<AudioSource>();
                        if(OneSceneManager.Instance!=null)
                            src.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
                        //UnityEngine.Debug.Log(sd.m_AudioClip);
                        src.clip = clip;
                        src.loop = Loop;

                        //src.//Play();
                        //break;
                    }
                }

            }
        }

        return SpellObj;
    }
    public static void HandleSingleSuperSpellObj(GameObject SuperSpellObj,OneActorManager mgr)
    {
        if(SuperSpellObj!=null)
        {
            SuperSpell sup = SuperSpellObj.GetComponent<SuperSpell>();
            if(sup!=null)
            {
                if(sup.m_TargetInfo!=null)
                {
                    mgr.CustomVfxTargetInfo = sup.m_TargetInfo;
                }
                if(sup.m_CustomDeathSpell!=null)
                {
                    mgr.CustomVfxTargetInfo.m_Behavior=SpellTargetBehavior.BOARD_CENTER;
                    mgr.CustomFriendlyAEVfxObject = sup.m_CustomDeathSpell.gameObject;//LoadSoundDefForSpellObj(sup.m_CustomDeathSpell.gameObject,true);
                }
                if(sup.m_SpellPrefab!=null)
                {
                    mgr.CustomVfxTargetInfo.m_Behavior=SpellTargetBehavior.BOARD_RANDOM;
                    mgr.CustomFriendlyAEVfxObject = sup.m_SpellPrefab.gameObject;//LoadSoundDefForSpellObj(sup.m_SpellPrefab.gameObject,true);
                }
                if(sup.m_StartInfo.m_Prefab!=null)
                {
                    if(sup.m_StartInfo.m_Prefab.gameObject!=null)
                    {
                        mgr.CustomInvokeVfxInfo = sup.m_StartInfo;
                        mgr.CustomInvokeVfxObject = sup.m_StartInfo.m_Prefab.gameObject;//LoadSoundDefForSpellObj(sup.m_StartInfo.m_Prefab.gameObject,true);
                    }
                }
                if(sup.m_MissileInfo.m_Prefab!=null)
                {
                    if(sup.m_MissileInfo.m_Prefab.gameObject!=null)
                    {
                        mgr.CustomLaunchVfxInfo = sup.m_MissileInfo;
                        mgr.CustomLaunchVfxObject = sup.m_MissileInfo.m_Prefab.gameObject;//LoadSoundDefForSpellObj(sup.m_MissileInfo.m_Prefab.gameObject,true);
                    }
                }
                if(sup.m_MissileInfo.m_ReversePrefab!=null)
                {
                    if(sup.m_MissileInfo.m_ReversePrefab.gameObject!=null)
                    {
                        mgr.CustomLaunchVfxInfo = sup.m_MissileInfo;
                        mgr.CustomLaunchReverseVfxObject = sup.m_MissileInfo.m_ReversePrefab.gameObject;//LoadSoundDefForSpellObj(sup.m_MissileInfo.m_ReversePrefab.gameObject,true);
                    }
                }
                if(sup.m_ImpactInfo.m_Prefab!=null)
                {
                    if(sup.m_ImpactInfo.m_Prefab.gameObject!=null)
                    {
                        mgr.CustomImpactVfxInfo = sup.m_ImpactInfo;
                        mgr.CustomImpactVfxObject = sup.m_ImpactInfo.m_Prefab.gameObject;//LoadSoundDefForSpellObj(sup.m_ImpactInfo.m_Prefab.gameObject);
                    }
                }
                
                if(sup.m_FriendlyAreaEffectInfo.m_Prefab!=null)
                {
                    if(sup.m_FriendlyAreaEffectInfo.m_Prefab.gameObject!=null)
                    {
                        mgr.CustomFriendlyAEVfxInfo = sup.m_FriendlyAreaEffectInfo;
                        mgr.CustomFriendlyAEVfxObject = sup.m_FriendlyAreaEffectInfo.m_Prefab.gameObject;//LoadSoundDefForSpellObj(sup.m_FriendlyAreaEffectInfo.m_Prefab.gameObject);
                    }
                }
                if(sup.m_OpponentAreaEffectInfo.m_Prefab!=null)
                {
                    if(sup.m_OpponentAreaEffectInfo.m_Prefab.gameObject!=null)
                    {
                        mgr.CustomOpposingAEVfxInfo = sup.m_OpponentAreaEffectInfo;
                        mgr.CustomOpposingAEVfxObject = sup.m_OpponentAreaEffectInfo.m_Prefab.gameObject;//LoadSoundDefForSpellObj(sup.m_OpponentAreaEffectInfo.m_Prefab.gameObject);
                    }
                }      
                if(sup.m_ChainInfo.m_Prefab!=null)
                {
                    if(sup.m_ChainInfo.m_Prefab.gameObject!=null)
                    {
                        mgr.CustomChainVfxInfo = sup.m_ChainInfo;
                        mgr.CustomChainVfxObject = sup.m_ChainInfo.m_Prefab.gameObject;//LoadSoundDefForSpellObj(sup.m_ChainInfo.m_Prefab.gameObject);
                    }
                }
    
            }
        }
    }
    public static Dictionary<string,(GameObject,GameObject,GameObject,GameObject,GameObject,GameObject,GameObject)> HSInvokeLaunchImpactVfxCahe = new Dictionary<string,(GameObject,GameObject,GameObject,GameObject,GameObject,GameObject,GameObject)>();
    public static Dictionary<string,(SpellStartInfo,SpellMissileInfo,SpellImpactInfo,SpellAreaEffectInfo,SpellAreaEffectInfo,SpellChainInfo,SpellTargetInfo)> HSInvokeLaunchImpactVfxInfoCahe = new Dictionary<string,(SpellStartInfo,SpellMissileInfo,SpellImpactInfo,SpellAreaEffectInfo,SpellAreaEffectInfo,SpellChainInfo,SpellTargetInfo)>();

    public static void SetHSInvokeLaunchImpactVfx(GameObject obj,string cardID)
    {

        OneActorManager mgr = obj.GetComponent<OneActorManager>();
        if(HSViewerSync.HSInvokeLaunchImpactVfxCahe.ContainsKey(cardID))
        {
            (GameObject ob1,GameObject ob2,GameObject ob3,GameObject ob4,GameObject ob5,GameObject ob6,GameObject ob7) = HSViewerSync.HSInvokeLaunchImpactVfxCahe[cardID];
            (SpellStartInfo nf1, SpellMissileInfo nf2, SpellImpactInfo nf3, SpellAreaEffectInfo nf4, SpellAreaEffectInfo nf5, SpellChainInfo nf6, SpellTargetInfo nf7) = HSInvokeLaunchImpactVfxInfoCahe[cardID];
            mgr.CustomInvokeVfxObject=ob1;
            mgr.CustomLaunchVfxObject=ob2;
            mgr.CustomLaunchReverseVfxObject=ob3;
            mgr.CustomImpactVfxObject=ob4;
            mgr.CustomFriendlyAEVfxObject=ob5;
            mgr.CustomOpposingAEVfxObject=ob6;
            mgr.CustomChainVfxObject=ob7;

            mgr.CustomInvokeVfxInfo = nf1;
            mgr.CustomLaunchVfxInfo = nf2;
            mgr.CustomImpactVfxInfo = nf3;
            mgr.CustomFriendlyAEVfxInfo = nf4;
            mgr.CustomOpposingAEVfxInfo = nf5;
            mgr.CustomChainVfxInfo = nf6;
            mgr.CustomVfxTargetInfo = nf7;
            return;
        }
        CardDef def = HSViewerSync.GetHSCardDef(cardID);
        if(def!=null)
        {
            foreach(CardEffectDef effdef in def.m_SubSpellEffectDefs)
            {
                HandleSingleSuperSpellObj(GetSuperSpellObjFromSpellDef(effdef), mgr);
            }
            foreach(CardEffectDef effdef in def.m_TriggerEffectDefs)
            {
                HandleSingleSuperSpellObj(GetSuperSpellObjFromSpellDef(effdef), mgr);
            }
            HandleSingleSuperSpellObj(GetSuperSpellObjFromSpellDef(def.m_PlayEffectDef), mgr);
            HandleSingleSuperSpellObj(GetSuperSpellObjFromSpellDef(def.m_AttackEffectDef), mgr);
            HandleSingleSuperSpellObj(GetSuperSpellObjFromSpellDef(def.m_DeathEffectDef), mgr);
            HandleSingleSuperSpellObj(GetSuperSpellObjFromSpellDef(def.m_LifetimeEffectDef), mgr);

        }

        HSViewerSync.HSInvokeLaunchImpactVfxCahe[cardID]=(mgr.CustomInvokeVfxObject,mgr.CustomLaunchVfxObject,mgr.CustomLaunchReverseVfxObject,mgr.CustomImpactVfxObject,mgr.CustomFriendlyAEVfxObject,mgr.CustomOpposingAEVfxObject,mgr.CustomChainVfxObject);
        HSViewerSync.HSInvokeLaunchImpactVfxInfoCahe[cardID]=(mgr.CustomInvokeVfxInfo,mgr.CustomLaunchVfxInfo,mgr.CustomImpactVfxInfo,mgr.CustomFriendlyAEVfxInfo,mgr.CustomOpposingAEVfxInfo,mgr.CustomChainVfxInfo,mgr.CustomVfxTargetInfo);
        //if(HSViewerSync.HSInvokeLaunchImpactVfxCahe[cardID]==(null,null,null,null,null) && cardID!="HERO_08bp")
        //{
        //    SetHSInvokeLaunchImpactVfx(obj,"HERO_08bp");
        //    HSViewerSync.HSInvokeLaunchImpactVfxCahe[cardID]=(mgr.CustomInvokeVfxObject,mgr.CustomLaunchVfxObject,mgr.CustomImpactVfxObject,mgr.CustomFriendlyAEVfxObject,mgr.CustomOpposingAEVfxObject);
        //}
    }

    public static GameObject GetSuperSpellObjFromSpellDef(CardEffectDef effdef)
    {
        GameObject SuperSpellObj=null;

        if(effdef!=null)
        {
            string spellid = StripByNote(effdef.m_SpellPath);
            string spellurl = GetUrlfromGUID(spellid);
            if(spellurl!="")
            {
                AssetBundle abspell = HSViewerSync.LoadFullBundle(absHSdir,spellurl);
                SuperSpellObj = abspell.LoadAsset<GameObject>(spellid);
                //SuperSpellObj = GameObject.Instantiate(ob, new Vector3(-100f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            }
        }
        return SuperSpellObj;
    }

    public GameObject plane;
    public AudioSource audsrc1;
    public AudioSource audsrc2;
    public AudioSource audsrc3;

    public static Dictionary<string,(AudioClip,AudioClip,AudioClip,AudioClip)> HSCardAudClipCahe = new Dictionary<string,(AudioClip,AudioClip,AudioClip,AudioClip)>();
    public static Dictionary<string,(GameObject,GameObject,GameObject,GameObject)> HSSummonSpawnDeathVfxCahe = new Dictionary<string,(GameObject,GameObject,GameObject,GameObject)>();


    public static (AudioClip,AudioClip,AudioClip,AudioClip) GetHSCardAudClips(string cardname)
    {
        if(cardname.Contains("SZB_"))
        {
            return (null,null,null,null);
        }
        if(HSCardAudClipCahe.ContainsKey(cardname))
        {
            return HSCardAudClipCahe[cardname];
        }

        CardDef def = HSViewerSync.GetHSCardDef(cardname);
        if(def==null)
            return (null,null,null,null);
        AudioClip PlayAud = GetAudioClipFromCardEffectDef(def.m_PlayEffectDef,"Play");
        AudioClip AttackAud = GetAudioClipFromCardEffectDef(def.m_AttackEffectDef,"Attack");
        AudioClip DeathAud = GetAudioClipFromCardEffectDef(def.m_DeathEffectDef,"Death");
        AudioClip StingerAud = GetAudioClipFromCardEffectDef(def.m_PlayEffectDef,"Stinger");

        HSCardAudClipCahe[cardname] = (PlayAud,AttackAud,DeathAud,StingerAud);
        return (PlayAud,AttackAud,DeathAud,StingerAud);
    }

    public static AudioClip GetAudioClipFromCardEffectDef(CardEffectDef effdef,string TryFind="")
    {
        AudioClip wav=null;
        //UnityEngine.Debug.Log("FAC");
        if(effdef.m_SoundSpellPaths.Count==0)
        {
            return null;
        }

        string soundid=StripByNote(effdef.m_SoundSpellPaths[0]);
        if(TryFind!="")
        {
            bool Found=false;
            foreach(string s in effdef.m_SoundSpellPaths)
            {
                if(s.Contains(TryFind))
                {
                    soundid=StripByNote(s);
                    Found=true;
                    break;
                }
            }
            if(!Found)
            {
                return null;
            }
        }

        string soundurl=GetUrlfromGUID(soundid);
        if(soundurl=="")
            return null;
        AssetBundle assetbundleSound = HSViewerSync.LoadFullBundle(absHSdir,soundurl);
        GameObject soundobj = assetbundleSound.LoadAsset<GameObject>(soundid);

        if(soundobj!=null)
        {
            string wavpathid = StripByNote(soundobj.GetComponentInChildren<SoundDef>().m_AudioClip);
            string wavname=soundobj.GetComponentInChildren<SoundDef>().m_AudioClip.Split(":")[0];
            string wavpathurl = GetUrlfromGUID(wavpathid);
            AssetBundle assetbundleWav = null;
            if(System.IO.File.Exists(absHSdir+wavpathurl) && wavpathurl!="")
            {
                assetbundleWav = HSViewerSync.LoadFullBundle(absHSdir,wavpathurl); 
                wav = assetbundleWav.LoadAsset<AudioClip>(wavpathid);
            }
            if(wav==null)
            {
                (wavpathurl,wavpathid) = GetUrlfromGUIDlocale(wavpathid);
                if(System.IO.File.Exists(absHSdir+wavpathurl) && wavpathurl!="")
                {
                    assetbundleWav = HSViewerSync.LoadFullBundle(absHSdir,wavpathurl); 
                    wav = assetbundleWav.LoadAsset<AudioClip>(wavpathid);
                }
            }
        }        
        /*
        string soundid=StripByNote(effdef.m_SoundSpellPaths[0]);
        string soundurl=GetUrlfromGUID(soundid);
        AssetBundle assetbundleSound = HSViewerSync.LoadFullBundle(absHSdir,soundurl);
        GameObject soundobj = assetbundleSound.LoadAsset<GameObject>(soundid);

        if(soundobj!=null)
        {
            string wavpathid = StripByNote(soundobj.GetComponentInChildren<SoundDef>().m_AudioClip);
            string wavname=soundobj.GetComponentInChildren<SoundDef>().m_AudioClip.Split(":")[0];
            string wavpathurl = GetUrlfromGUID(wavpathid);
            AssetBundle assetbundleWav = null;
            if(System.IO.File.Exists(absHSdir+wavpathurl) && wavpathurl!="")
            {
                assetbundleWav = HSViewerSync.LoadFullBundle(absHSdir,wavpathurl); 
                wav = assetbundleWav.LoadAsset<AudioClip>(wavpathid);
            }
            if(wav==null)
            {
                wavpathurl = wavpathurl.Replace("enus","zhcn");
                if(System.IO.File.Exists(absHSdir+wavpathurl) && wavpathurl !="")
                {
                    assetbundleWav = HSViewerSync.LoadFullBundle(absHSdir,wavpathurl);
                    AudioClip[] wavs = assetbundleWav.LoadAllAssets<AudioClip>();
                    foreach(AudioClip aud in wavs)
                    {
                        if(aud.name+".wav" == wavname)
                        {
                            wav = aud;
                        }
                    }               
                }
            }
        }
        */
        return wav;
    }

    public static Dictionary<string,CardDef> cardDefCache = new Dictionary<string,CardDef>();
    public static CardDef GetHSCardDef(string cardname)
    {
        if(HSViewerSync.cardDefCache.ContainsKey(cardname))
        {
            return cardDefCache[cardname];
        }
        PrepareHSjson();
        CardDef def = null;
        
        string HSCardID = HSViewerSync.GetHSID(cardname);
        string CardDefGUID = GetCardDefGUID(HSCardID);
        string CardDefUrl = GetUrlfromGUID(CardDefGUID);

        if(CardDefUrl!="")
        {
            AssetBundle assetbundleDef = HSViewerSync.LoadFullBundle(absHSdir,CardDefUrl);
            GameObject defobj = assetbundleDef.LoadAsset<GameObject>(CardDefGUID);
            def = defobj.GetComponentInChildren<CardDef>();           
        }

        if(def==null)
        {
            string TempName = "HERO_09bp";
            if(cardname!=TempName)
                def = HSViewerSync.GetHSCardDef(TempName);
        }
        HSViewerSync.cardDefCache[cardname] = def;
        return def;
    }

    public static (GameObject,GameObject,GameObject,GameObject) GetHSCustomSummonSpawnDeathEffect(string cardname)
    {
        if(HSViewerSync.HSSummonSpawnDeathVfxCahe.ContainsKey(cardname))
        {
            return HSViewerSync.HSSummonSpawnDeathVfxCahe[cardname];
        }
        GameObject summonPrefab=null;
        GameObject spawnPrefab=null;
        GameObject deathPrefab=null;
        GameObject discardPrefab=null;

        CardDef def = HSViewerSync.GetHSCardDef(cardname);

        if(def!=null)
        {
            string summonspellid = StripByNote(def.m_CustomSummonSpellPath);//m_CustomSummonSpellPath);
            string summonspellurl = GetUrlfromGUID(summonspellid);
            if(summonspellurl!="")
            {
                AssetBundle absummonspell = HSViewerSync.LoadFullBundle(absHSdir,summonspellurl);
                summonPrefab = absummonspell.LoadAsset<GameObject>(summonspellid);
            }
            string spawnspellid = StripByNote(def.m_CustomSpawnSpellPath);//m_CustomSummonSpellPath);
            string spawnspellurl = GetUrlfromGUID(spawnspellid);
            if(spawnspellurl!="")
            {
                AssetBundle abspawnspell = HSViewerSync.LoadFullBundle(absHSdir,spawnspellurl);
                spawnPrefab = abspawnspell.LoadAsset<GameObject>(spawnspellid);
            }     
            string deathspellid = StripByNote(def.m_CustomDeathSpellPath);//m_CustomSummonSpellPath);
            string deathspellurl = GetUrlfromGUID(deathspellid);
            if(deathspellurl!="")
            {
                AssetBundle abdeathspell = HSViewerSync.LoadFullBundle(absHSdir,deathspellurl);
                deathPrefab = abdeathspell.LoadAsset<GameObject>(deathspellid);
            }
            string discardspellid = StripByNote(def.m_CustomDiscardSpellPath);//m_CustomSummonSpellPath);
            string discardspellurl = GetUrlfromGUID(discardspellid);
            if(discardspellurl!="")
            {
                AssetBundle abdiscardspell = HSViewerSync.LoadFullBundle(absHSdir,discardspellurl);
                discardPrefab = abdiscardspell.LoadAsset<GameObject>(discardspellid);
            }           
        }

        HSViewerSync.HSSummonSpawnDeathVfxCahe[cardname]=(summonPrefab,spawnPrefab,deathPrefab,discardPrefab);
        return (summonPrefab,spawnPrefab,deathPrefab,discardPrefab);
    }


    public static ScriptableAssetCatalog cata;
    public static ScriptableAssetVariantCatalog cata_cn;
    public static ScriptableAssetMap map;
    public static AssetBundleDependencyGraph deps;
    public static bool hsjsonready=false;
    


    public static Dictionary<string,AssetBundle> abCache = new Dictionary<string,AssetBundle>();
    public static Dictionary<string,Material> matCache = new Dictionary<string,Material>();
    public static Dictionary<string,UberShaderAnimation> ubCache = new Dictionary<string,UberShaderAnimation>();
    public static Dictionary<string,string> HSID= new Dictionary<string,string>(){};

    public static string GetHSID(string ScriptName)
    {
        return ScriptName;
        //if(HSID.ContainsKey(ScriptName))
        //    return HSID[ScriptName];
        //return "";
    }
    public static bool Loaded=false;
    public static void LoadAllBund()
    {
        if(Loaded==false)
        {
            HSViewerSync.PrepareHSjson();
            DirectoryInfo folder = new DirectoryInfo(@"D:\DocFile\Unity3dRef\Assets\CusCCG_Ex_HS\");
            foreach(FileInfo File in folder.GetFiles("*.unity3d"))
            {
                if(!HSViewerSync.abCache.ContainsKey(File.FullName))
                {
                    HSViewerSync.abCache[File.FullName]=AssetBundle.LoadFromFile(File.FullName);
                    //UnityEngine.Debug.Log(File.FullName);                    
                }
            }
        }
        Loaded=true;

        
        
    }
    public static AssetBundle LoadFullBundle(string BaseUrl, string BundleName, bool LoadDep=true)
    {
        //HSViewerSync.LoadAllBund();
        //return HSViewerSync.abCache[BaseUrl+BundleName];//AssetBundle.LoadFromFile(BaseUrl+BundleName);
        if(HSViewerSync.abCache.ContainsKey(BundleName))
        {
            return HSViewerSync.abCache[BundleName];
        }

        if(LoadDep)
        {
            foreach(string dependency in HSViewerSync.GetDepend(BundleName))
            {
                HSViewerSync.LoadFullBundle(BaseUrl,dependency,false);
            }
        }

        if(HSViewerSync.abCache.ContainsKey(BundleName))
        {
            return HSViewerSync.abCache[BundleName];
        }
        AssetBundle bundl = AssetBundle.LoadFromFile(BaseUrl+BundleName);
        //foreach(Shader s in bundl.LoadAllAssets<Shader>())
        //{
        //    UnityEngine.Debug.Log(s.name);
        //    HSViewerSync.ShaderCahe[s.name]=s;
        //}
        HSViewerSync.abCache[BundleName] = bundl;
        return bundl;
    }
    public static void PrepareHSjson()
    {
        if(HSViewerSync.hsjsonready==false)
        {
            
            AssetBundle Manifest = AssetBundle.LoadFromFile(absHSdir+"asset_manifest.unity3d");
            //abCache[absHSdir+"asset_manifest.unity3d"] = Manifest;
            HSViewerSync.cata = Manifest.LoadAsset<ScriptableAssetCatalog>("Assets/AssetManifest/base_assets_catalog.asset");
            HSViewerSync.map = Manifest.LoadAsset<ScriptableAssetMap>("Assets/AssetManifest/AssetMaps/cards_map.asset");
            HSViewerSync.deps = Manifest.LoadAsset<AssetBundleDependencyGraph>("Assets/AssetManifest/bundle_deps.asset");
            
            AssetBundle ManifestLocale = AssetBundle.LoadFromFile(absHSdir+"asset_manifest_zhcn.unity3d");
            //abCache[absHSdir+"asset_manifest_zhcn.unity3d"] = ManifestLocale;
            HSViewerSync.cata_cn = ManifestLocale.LoadAsset<ScriptableAssetVariantCatalog>("Assets/AssetManifest/asset_catalog_locale_zhcn.asset");

            HSViewerSync.hsjsonready=true;
        }
    }
    public static List<string> GetDepend(string BundleName)
    {
        List<string> bds= new List<string>();
        int BInd = Array.IndexOf(deps.allBundleNames,BundleName);
        if(BInd<deps.bundles.Length && BInd>0)
        {
            foreach(int ind in deps.bundles[BInd].allDependencies)
            {
                bds.Add(deps.allBundleNames[ind]);
            }            
        }
        return bds;
    }
    public static bool SetHSSummonSpawnDeathVFX(GameObject obj, string cardID = "RLK_605")
    {
        (GameObject SummonVfx,GameObject SpawnVfx,GameObject DeathVfx,GameObject DiscardVfx) = GetHSCustomSummonSpawnDeathEffect(cardID);
        obj.GetComponent<OneActorManager>().CustomSummonVFXObject = SummonVfx;
        obj.GetComponent<OneActorManager>().CustomSpawnVFXObject = SpawnVfx;
        obj.GetComponent<OneActorManager>().CustomDeathVFXObject = DeathVfx;
        obj.GetComponent<OneActorManager>().CustomDiscardVFXObject = DiscardVfx;

        if(SummonVfx!=null)
        {
            return true;
        }
        if(cardID!=HSViewerSync.DefaultHSSummonSpawnDeathID)//"TOY_501t")
            return HSViewerSync.SetHSSummonSpawnDeathVFX(obj,HSViewerSync.DefaultHSSummonSpawnDeathID);
        return false;
    }
    public static bool SetHSMat(GameObject obj, string cardID="RLK_605")
    {
        if(cardID.Contains("SGS_")||cardID.Contains("TMP_")||cardID.Contains("SNAP_")||cardID.Contains("YGO_")||cardID.Contains("FUS_"))
        {
            return false;
        }
        if(cardID.Contains("SZB_"))
        {
            return Viewer.SetSzbMat(obj,cardID);
        }
        (Material mat , UberShaderAnimation ani )= HSViewerSync.GetHSCardMaterial(cardID);
        if(mat!=null)
        {
            obj.GetComponent<Renderer>().material = Material.Instantiate(mat) as Material;
            if(ani !=null)
            {
                if(obj.GetComponent<UberShaderController>()!=null)
                {
                    UberShaderController m_uberShaderController = obj.GetComponent<UberShaderController>();
                    m_uberShaderController.UberShaderAnimation = UnityEngine.Object.Instantiate<UberShaderAnimation>(ani);
                    m_uberShaderController.m_MaterialIndex = 0;
                    m_uberShaderController.enabled = true;
                }
                else{
                    UberShaderController m_uberShaderController = obj.AddComponent<UberShaderController>();
                    m_uberShaderController.UberShaderAnimation = UnityEngine.Object.Instantiate<UberShaderAnimation>(ani);
                    m_uberShaderController.m_MaterialIndex = 0;
                    m_uberShaderController.enabled = true;                    
                }

            }       
            return true;
        }
        return false;
    }
    public static string GetCardDefGUID(string cardID)
    {
        if(map.map.ContainsKey(cardID))
        {
            return HSViewerSync.StripByNote(map.map[cardID]);
        }
        
        return "";
    }
    public static string GetUrlfromGUID(string guidToMatch)
    {
        
        for(int i=0;i<HSViewerSync.cata.m_assets.Count;i++)
        {
            if(HSViewerSync.cata.m_assets[i].guid == guidToMatch)
            {
                int bundid = HSViewerSync.cata.m_assets[i].bundleId;
                return HSViewerSync.cata.m_bundleNames[bundid];
            }
        }
        
        return "";
    }
    public static (string,string) GetUrlfromGUIDlocale(string guidToMatch)
    {
        
        for(int i=0;i<HSViewerSync.cata_cn.m_assets.Count;i++)
        {
            if(HSViewerSync.cata_cn.m_assets[i].baseGuid == guidToMatch)
            {
                int bundid = HSViewerSync.cata_cn.m_assets[i].bundleId;
                return (HSViewerSync.cata_cn.m_bundleNames[bundid],HSViewerSync.cata_cn.m_assets[i].guid);
            }
        }
        
        return ("","");
    }
    public static string StripByNote(string rawstr)
    {
        if(rawstr=="")
            return "";
        string[] Splited= rawstr.Split(":");
        if(Splited.Length>1)
        {
            return Splited[1];
        }
        return "";
    }

    public static Dictionary<string,Texture2D> cardRawTexImageCache=new Dictionary<string,Texture2D>();
    public static Texture2D GetHSCardRawTexture(string cardname="PatchesthePirate")
    {
        if(cardname.Contains("SZB_"))
        {
            return Viewer.GetSzbCardRawTexture(cardname);
        }
        if(cardRawTexImageCache.ContainsKey(cardname))
        {
            return cardRawTexImageCache[cardname];
        }

        CardDef def = HSViewerSync.GetHSCardDef(cardname);
        if(def==null)
            return null;
    
        Texture2D rawtex=null;
        if(def!=null)
        {
            string TexID=HSViewerSync.StripByNote(def.m_PortraitTexturePath);
            string TexUrl=HSViewerSync.GetUrlfromGUID(TexID);
            AssetBundle assetbundleTex = HSViewerSync.LoadFullBundle(absHSdir,TexUrl);
            rawtex = assetbundleTex.LoadAsset<Texture2D>(TexID);  

        }
        cardRawTexImageCache[cardname]=rawtex;
        return rawtex;
    }
    public static (Material, UberShaderAnimation) GetHSCardMaterial(string cardname="PatchesthePirate")
    {        
        if(matCache.ContainsKey(cardname))
        {
            return (matCache[cardname],ubCache[cardname]);
        }

        Material mat=null;
        UberShaderAnimation ub=null;
        CardDef def = HSViewerSync.GetHSCardDef(cardname);
        if(def==null)
            return (null,null);
    
        if(def!=null)
        {
            string MatID=HSViewerSync.StripByNote(def.m_PremiumPortraitMaterialPath);
            string AniID=HSViewerSync.StripByNote(def.m_PremiumUberShaderAnimationPath);
            string TexID=HSViewerSync.StripByNote(def.m_PortraitTexturePath);
            string PtexID = HSViewerSync.StripByNote(def.m_PremiumPortraitTexturePath);

            string MatUrl=HSViewerSync.GetUrlfromGUID(MatID);
            string AniUrl=HSViewerSync.GetUrlfromGUID(AniID);
            string TexUrl=HSViewerSync.GetUrlfromGUID(TexID);
            string PtexUrl=HSViewerSync.GetUrlfromGUID(PtexID);


            string SigMatID=HSViewerSync.StripByNote(def.m_SignaturePortraitMaterialPath);
            string SigAniID=HSViewerSync.StripByNote(def.m_SignatureUberShaderAnimationPath);
            string SigTexID=HSViewerSync.StripByNote(def.m_SignaturePortraitTexturePath);

            string SigMatUrl=HSViewerSync.GetUrlfromGUID(SigMatID);
            string SigAniUrl=HSViewerSync.GetUrlfromGUID(SigAniID);
            string SigTexUrl=HSViewerSync.GetUrlfromGUID(SigTexID);

            if(TexID!=""&&TexUrl!="")
            {
                //UnityEngine.Debug.Log("ID Valid");
                (mat,ub)= HSViewerSync.LoadCardFromMatAniTex(MatID,AniID,TexID,PtexID,
                    MatUrl,AniUrl,TexUrl,PtexUrl,SigMatID,SigAniID,SigTexID,SigMatUrl,SigAniUrl,SigTexUrl);                
            }
        }
        

        matCache[cardname] = mat;
        ubCache[cardname] = ub;
        return (mat,ub);

    }
    public static (Material, UberShaderAnimation) LoadCardFromMatAniTex(string MatID, string AniID, string TexID, string PtexID, string MatUrl, string AniUrl, string TexUrl, string PtexUrl, string SigMatID, string SigAniID, string SigTexID, string SigMatUrl, string SigAniUrl, string SigTexUrl)
    {
        AssetBundle assetbundleMat = null;
        if(MatUrl!="")
            assetbundleMat = HSViewerSync.LoadFullBundle(absHSdir,MatUrl);
        
        AssetBundle assetbundleAni = null;
        if(AniUrl!="")
            assetbundleAni = HSViewerSync.LoadFullBundle(absHSdir,AniUrl);
        AssetBundle assetbundlePtex = null;
        if(PtexUrl!="")
            assetbundlePtex = HSViewerSync.LoadFullBundle(absHSdir,PtexUrl);
        



        Material mat = null;
        UberShaderAnimation ani = null;
/*
        if(SigMatUrl!="")
        {
            AssetBundle assetbundleSigAni = null;
            if(SigAniUrl!="")
                assetbundleSigAni = HSViewerSync.LoadFullBundle(BaseUrl,SigAniUrl);
            AssetBundle assetbundleSigTex = null;
            if(SigTexUrl!="")
                assetbundleSigTex = HSViewerSync.LoadFullBundle(BaseUrl,SigTexUrl);

            AssetBundle assetbundleSigMat = HSViewerSync.LoadFullBundle(BaseUrl,SigMatUrl);        
            mat = assetbundleSigMat.LoadAsset<Material>(SigMatID);
            if(mat != null)
            {
                Texture2D matTex = null;
                if(assetbundleSigTex!=null)
                {
                    matTex = assetbundleSigTex.LoadAsset<Texture2D>(SigTexID);
                }
                if(matTex!=null)
                {
                    mat.SetTexture("_MainTex",matTex);
                    mat.SetTexture("_ShadowTex",null);
                }

                if(assetbundleSigAni!=null)
                {
                    ani = assetbundleSigAni.LoadAsset<UberShaderAnimation>(SigAniUrl);
                }
            }
        }
*/        

        if(mat==null)
        {
            if(assetbundleMat!=null)
            {
                mat = assetbundleMat.LoadAsset<Material>(MatID);
            }
            if(mat!=null)
            {
                Texture2D matTex = null;
                if(assetbundlePtex!=null)
                {
                    matTex = assetbundlePtex.LoadAsset<Texture2D>(PtexID);
                }
                if(matTex==null)
                {
                    UnityEngine.Debug.Log("_Pnull!");
                    AssetBundle assetbundleTex = HSViewerSync.LoadFullBundle(absHSdir,TexUrl);
                    matTex = assetbundleTex.LoadAsset<Texture2D>(TexID);               
                }

                if(matTex!=null)
                {
                    mat.SetTexture("_MainTex",matTex);
                    //Texture ShadowTex = mat.GetTexture("_ShadowTex");
                    //if(ShadowTex!=null)
                    //{
                    //    string ShadowTexName=ShadowTex.name;
                    //    UnityEngine.Debug.Log(ShadowTexName);
                    //}
                    mat.SetTexture("_ShadowTex",null);
                }

                if(assetbundleAni!=null)
                {
                    ani = assetbundleAni.LoadAsset<UberShaderAnimation>(AniID);
                }
            }
            if(mat==null)
            {
                
                AssetBundle assetbundleTex = HSViewerSync.LoadFullBundle(absHSdir,TexUrl);
                if(assetbundleTex!=null)
                {
                    Texture2D matTex = assetbundleTex.LoadAsset<Texture2D>(TexID);
                    if(matTex!=null)
                    {
                        if(OneSceneManager.Instance!=null)
                        {
                            mat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                            mat.SetTexture("_BaseMap",matTex);
                        }
                    }     
                }
            }         
        }

        return (mat, ani);
    }


}
