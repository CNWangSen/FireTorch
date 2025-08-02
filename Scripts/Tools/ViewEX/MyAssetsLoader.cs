using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class MyAssetsLoader: MonoBehaviour
{
    public string NowSceneName;
	public static string GetStreamingsAssetPath()
	{
        if(Application.isMobilePlatform)
        {
            return Application.persistentDataPath;
        }
        return Application.streamingAssetsPath;
	}
    public static MyAssetsLoader Get()
    {
        return Instance;
    }
    public static MyAssetsLoader Instance;
    public static Dictionary<string,Texture2D> cardTexImageCache = new Dictionary<string,Texture2D>();
    public static VfxAsset GetCustomSummonVFX(CardDbf dbf)
    {
        return null;
    }
    public static VfxAsset GetCustomDeathVFX(CardDbf dbf)
    {
        return null;
    }
    public static VfxAsset GetCustomMissileVFX(CardDbf dbf)
    {
        return null;
    }
    public static AudAsset GetCustomAudAsset(CardDbf dbf)
    {
        return null;
    }
    public static Material GetCustomMaterial(CardDbf dbf)
    {
        return null;
    }
    public static Texture2D GetCardDbfImageTexutre(CardDbf asset)
    {
        if(MyAssetsLoader.cardTexImageCache.ContainsKey(asset.m_noteMiniGuid))
        {
            return MyAssetsLoader.cardTexImageCache[asset.m_noteMiniGuid];
        }
        Texture2D _texture2d = new Texture2D(512,512);
        if(Application.isMobilePlatform)
        {
            string FileUrlDroid = "CardsDroid/"+CardDbf.AllSetNames[asset.SetId]+"/"+CardDbf.AllClassNames[(int)asset.Classes[0]]+"/"+asset.m_noteMiniGuid+".jpg";
            if(OneSceneManager.Instance.IsBgMode)
            {
                if(OneSceneManager.Instance.IsMyScene)
                {
                    
                    FileUrlDroid = "Cards/FTBG/"+asset.m_noteMiniGuid+".png";
                    FileUrlDroid = FileUrlDroid.Replace("_G.png","");
                    FileUrlDroid = FileUrlDroid.Replace(".png","");
                    _texture2d = Resources.Load<Texture2D>(FileUrlDroid);
                }
                else{
                    FileUrlDroid = HSViewer.absExdir+"CusCCG_Ex_CardImg/BG/"+asset.m_noteMiniGuid+".png";
                }
            }
            _texture2d = Resources.Load<Texture2D>(FileUrlDroid);
        }
        if(asset.m_noteMiniGuid.Contains("FUS11_"))
        {
            _texture2d = ImageFromCode.Base64ToImg(ImageFromCode.GetBase64FromCardID(asset.m_noteMiniGuid));
        }
        else{

            string FileUrl = HSViewer.absExdir+"CusCCG_Ex_CardImg/"+asset.m_noteMiniGuid+".jpg";
            if(OneSceneManager.Instance.IsBgMode)
            {
                if(OneSceneManager.Instance.IsMyScene)
                {
                    
                    FileUrl = "Cards/FTBG/"+asset.m_noteMiniGuid+".png";
                    FileUrl = FileUrl.Replace("_G.png","");
                    FileUrl = FileUrl.Replace(".png","");
                    _texture2d = Resources.Load<Texture2D>(FileUrl);
                }
                else{
                    FileUrl = Application.streamingAssetsPath+"/Textures/"+asset.m_noteMiniGuid+".png";//HSViewer.absExdir+"CusCCG_Ex_CardImg/BG/"+asset.m_noteMiniGuid+".png";
                }
            }
            FileUrl = FileUrl.Replace("_G.png",".png");
            //WWW ReadFile = new WWW(FileUrl);
            //UnityEngine.Debug.Log(FileUrl);
            if(System.IO.File.Exists(FileUrl))
            {
                FileStream _fileStream = new FileStream(FileUrl,FileMode.Open,FileAccess.Read);
                byte[] _buffer = new byte[_fileStream.Length];
                _fileStream.Read(_buffer,0,_buffer.Length);
                _texture2d.LoadImage(_buffer);
            }
            else{
                Debug.Log("TextureNotFound"+FileUrl);
            }            
        }
        MyAssetsLoader.cardTexImageCache[asset.m_noteMiniGuid] = _texture2d;
        return _texture2d;
    }
/*
	private IEnumerator GetImage(string _path) {
    using (UnityWebRequest UWR_file = UnityWebRequestTexture.GetTexture("file://" + _path) {
        yield return UWR_file.SendWebRequest();
        
        if (UWR_file.isError) yield break;
        
        Texture2D _texture = DownloadHandlerTexture.GetContent(UWR_file);
        _image = Sprite.Create(_texture, new Rect(0, 0, _texture.width, _texture.height), Vector2.zero);
    }
    yield break;
	}
*/
	public void Awake()
	{
        MyAssetsLoader.Instance=this;
        CardDbf.LoadAllCardDbf();

        if(Application.isMobilePlatform)
        {
            
            //foreach(CardDbf c in CardDbf.AllCardDbf)
            //{
            //     string FileUrl = "Cards/"+CardDbf.AllSetNames[c.SetId]+"/"+CardDbf.AllClassNames[(int)c.Classes[0]]+"/"+c.ScriptName+".jpg";
            //     this.CopyFileToPersistentDataPath("/",FileUrl);
            //}
    
            this.CopyFileToPersistentDataPath("/","LoggedUserDbf.json");
            this.CopyFileToPersistentDataPath("/","AllDecks.json");
        }
        else{
            Scene nowScene = SceneManager.GetActiveScene();
            if(nowScene.name=="LogIn")
            {
                NowSceneName=nowScene.name;
                LogInBtnManager.LoadUserData();
                if(UserDbf.LoggedUser.IsLogged)
                {
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }
	}
	public static Dictionary<string,(AudioClip,AudioClip,AudioClip)> cardAudCahe = new Dictionary<string,(AudioClip,AudioClip,AudioClip)>();

    public void LoadCardAud(OneActorManager mgr)
    {
        if(NowSceneName=="BuildDeck" || NowSceneName=="OpenPack")
        {
            return;
        }
        //this.LoadCardAudSync(mgr);
        //StartCoroutine(LoadCardAudAsync(mgr,"D:\\DocFile\\Unity3dRef\\Assets\\CusCCG_Ex_CardAud\\"+CardDbf.AllSetNames[mgr.CardDbf.SetId]+"/"+CardDbf.AllClassNames[(int)mgr.CardDbf.Classes[0]]+"/"+mgr.CardDbf.ScriptName));
        if(mgr.CardDbf.m_noteMiniGuid.Contains("SZB_"))
        {
            StartCoroutine(LoadCardAudAsync(mgr,HSViewer.absExdir+"CusCCG_Ex_SV_CardAud\\"+mgr.CardDbf.m_noteMiniGuid.Split("_")[1]));
        }
        else if(mgr.CardDbf.m_noteMiniGuid.Contains("SGS_"))
        {
            StartCoroutine(LoadCardAudAsync(mgr,HSViewer.absExdir+"CusCCG_Ex_CardAud\\"+mgr.CardDbf.m_noteMiniGuid,format:".mp3"));
        }
        else{
           if(this.LoadCardAudSyncFromHSbundle(mgr))
           {

           }
           else{
                StartCoroutine(LoadCardAudAsync(mgr,HSViewer.absExdir+"CusCCG_Ex_CardAud\\"+mgr.CardDbf.m_noteMiniGuid,format:".mp3"));
           }
        }
        
    }
    public bool LoadCardAudSyncFromHSbundle(OneActorManager mgr)
    {
        if(mgr.CardDbf.m_noteMiniGuid.Contains("SZB_"))
        {
            StartCoroutine(LoadCardAudAsync(mgr,HSViewer.absExdir+"CusCCG_Ex_SV_CardAud\\"+mgr.CardDbf.m_noteMiniGuid.Split("_")[1]));
            return true;
        }
        else{
            (AudioClip audPlay, AudioClip audAttack, AudioClip audDeath, AudioClip audStinger)=HSViewer.GetHSCardAudClips(mgr.CardDbf.m_noteMiniGuid);
            if(audAttack!=null)
            {
                if(mgr.CustomAttackAudioSource!=null)
                    mgr.CustomAttackAudioSource.clip = audAttack;
            }
            else{
                //UnityEngine.Debug.Log("Aud No")
            }
            if(audPlay!=null)
            {
                if(mgr.CustomSummonAudioSource!=null)
                    mgr.CustomSummonAudioSource.clip = audPlay;
            }
            if(audDeath!=null)
            {
                if(mgr.CustomDeathAudioSource!=null)
                    mgr.CustomDeathAudioSource.clip = audDeath;
            }
            if(audStinger!=null)
            {
                if(mgr.CustomStingerAudioSource!=null)
                    mgr.CustomStingerAudioSource.clip = audStinger;            
            }
            if( audPlay==null && audAttack==null && audDeath ==null && audStinger==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public void LoadCardAudSync(OneActorManager mgr)
    {
        string BaseUrl = HSViewer.absExdir+"CusCCG_Ex_CardAud\\"+CardDbf.AllSetNames[mgr.CardDbf.SetId]+"/"+CardDbf.AllClassNames[(int)mgr.CardDbf.Classes[0]]+"/"+mgr.CardDbf.m_noteMiniGuid;
        AudioClip audAttack =null;
        AudioClip audPlay = null;
        AudioClip audDeath = null;
        if(cardAudCahe.ContainsKey(mgr.CardDbf.m_noteMiniGuid))
        {
            (audAttack,audPlay,audDeath) =  MyAssetsLoader.cardAudCahe[mgr.CardDbf.m_noteMiniGuid];
        }
        else{
            audAttack = this.LoadAudSync(BaseUrl+"_Attack.wav");
            audPlay = this.LoadAudSync(BaseUrl+"_Play.wav");           
            audDeath = this.LoadAudSync(BaseUrl+"_Death.wav");
            cardAudCahe[mgr.CardDbf.m_noteMiniGuid] = (audAttack,audPlay,audDeath);
        }
        if(audAttack!=null)
        {
            if(mgr.CustomAttackAudioSource!=null)
                mgr.CustomAttackAudioSource.clip = audAttack;
        }
        else{
        }
        if(audPlay!=null)
        {
            if(mgr.CustomSummonAudioSource!=null)
                mgr.CustomSummonAudioSource.clip = audPlay;
        }
        if(audDeath!=null)
        {
            if(mgr.CustomDeathAudioSource!=null)
                mgr.CustomDeathAudioSource.clip = audDeath;
        }  
    }
    public AudioClip LoadAudSync(string FileUrl)
    {
        if(System.IO.File.Exists(FileUrl))
        {
            FileStream _fileStream = new FileStream(FileUrl,FileMode.Open,FileAccess.Read);
            byte[] _buffer = new byte[_fileStream.Length];
            _fileStream.Read(_buffer,0,_buffer.Length);

            int SampleRate = 48000;
            AudioClip _audioClip = AudioClip.Create("audioClip", SampleRate * 600, 1, SampleRate, false); 
            float[] _clipData = new float[_buffer.Length / 2];
            for (int i = 0; i < _buffer.Length; i += 2)
            {
                _clipData[i / 2] = (short)((_buffer[i + 1] << 8) | _buffer[i]) / 32768.0f;
            }           
            _audioClip.SetData(_clipData, 0);
            return _audioClip;
        }
        return null;
    }

    IEnumerator LoadCardAudAsync(OneActorManager mgr,string BaseUrl,string format=".wav")
    {
        AudioType ty = AudioType.WAV;
        if(format==".mp3")
        {
            ty=AudioType.MPEG;
        }
        AudioClip audAttack =null;
        AudioClip audPlay = null;
        AudioClip audDeath = null;
        if(cardAudCahe.ContainsKey(mgr.CardDbf.m_noteMiniGuid))
        {
            (audAttack,audPlay,audDeath) =  MyAssetsLoader.cardAudCahe[mgr.CardDbf.m_noteMiniGuid];
        }
        else{
            UnityWebRequest UWR_file_Attack = UnityWebRequestMultimedia.GetAudioClip("file:///"+BaseUrl+"_Attack"+format,ty);
            if (File.Exists(BaseUrl+"_Attack"+format))
            {
                yield return UWR_file_Attack.SendWebRequest();
                audAttack = DownloadHandlerAudioClip.GetContent(UWR_file_Attack);
            }
            else{
                //UnityEngine.Debug.Log("AudNotExit"+BaseUrl+"_Attack.wav");
            }
            
            UnityWebRequest UWR_file_Play = UnityWebRequestMultimedia.GetAudioClip("file:///"+BaseUrl+"_Play"+format,ty);
            if (File.Exists(BaseUrl+"_Play"+format))
            {
                yield return UWR_file_Play.SendWebRequest();
                audPlay = DownloadHandlerAudioClip.GetContent(UWR_file_Play);           
            }

            UnityWebRequest UWR_file_Death = UnityWebRequestMultimedia.GetAudioClip("file:///"+BaseUrl+"_Death"+format,ty);
            if (File.Exists(BaseUrl+"_Death"+format))
            {
                yield return UWR_file_Death.SendWebRequest();
                audDeath = DownloadHandlerAudioClip.GetContent(UWR_file_Death);
          
            }

            cardAudCahe[mgr.CardDbf.m_noteMiniGuid] = (audAttack,audPlay,audDeath);
        }
        if(audAttack!=null)
        {
            if(mgr.CustomAttackAudioSource!=null)
            {
                mgr.CustomAttackAudioSource.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("ALoud")[0];
                mgr.CustomAttackAudioSource.clip = audAttack;
            }
        }
        else{
        }
        if(audPlay!=null)
        {
            if(mgr.CustomSummonAudioSource!=null)
            {
                mgr.CustomSummonAudioSource.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("ALoud")[0];
                mgr.CustomSummonAudioSource.clip = audPlay;
            }
        }
        if(audDeath!=null)
        {
            if(mgr.CustomDeathAudioSource!=null)
            {
                mgr.CustomDeathAudioSource.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("ALoud")[0];
                mgr.CustomDeathAudioSource.clip = audDeath;
            }
        }  

    }

    public void CopyFileToPersistentDataPath(string _pth, string fileName)
    {
        string per_path = Application.persistentDataPath;
        string str_path = Application.streamingAssetsPath;
        StartCoroutine(Copy(str_path + _pth, per_path + _pth, fileName));
        return;
    }
        // 将文件 _name 从 _frm 复制到 _to
    private IEnumerator Copy(string _frm, string _to, string _name)
    {
        // 若 persistentDataPath 下已包含该文件，返回
        if (File.Exists(_to + _name)) yield break;
        Directory.CreateDirectory(_to);

        UnityWebRequest UWR_file = UnityWebRequest.Get(_frm + _name);
        yield return UWR_file.SendWebRequest();

        if (UWR_file.error != null) yield break;
        if (UWR_file.isDone)
        {
            string fullName = _to + _name;
            FileStream newFile = File.Create(fullName);

            byte[] _data = UWR_file.downloadHandler.data;
            newFile.Write(_data, 0, _data.Length);

            newFile.Flush();
            newFile.Close();
        }

        UWR_file.Dispose();
        yield break;
    }
}