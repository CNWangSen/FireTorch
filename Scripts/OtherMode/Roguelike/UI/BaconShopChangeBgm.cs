using UnityEngine;
using UnityEngine.Audio;
using System.IO;
using System.Collections.Generic;

public class BaconShopChangeBgm:MonoBehaviour
{
	public List<AudioClip> m_possibleBGMclip;
	public List<AudioClip> m_possibleBGMclipRecruit;
	public AudioSource m_AudSrc;
	private List<int> m_possibleBGMindex;
	private List<string> m_possibleBGMname;
	public static BaconShopChangeBgm Instance;
	private bool Loaded = false;
	public void Update()
	{
		CheckLoadAud();
	}

	public void CheckLoadAud()
	{
		if(Loaded)
		{
			return;
		}

		if(Game.NowGame.m_Mode==GameMode.BattleGround)
		{
			if(m_possibleBGMclip.Count==0)
			{
				m_possibleBGMname = new List<string>(){"MasterDuel1.wav","MasterDuel2.wav","MasterDuel3.wav","MasterDuel4.wav",
				"MasterDuel5.wav","MasterDuel6.wav","MasterDuel7.wav","MasterDuel8.wav","MasterDuel9.wav"};

				foreach(string s in m_possibleBGMname)
				{
					m_possibleBGMclip.Add(LoadAudSync("D:/DocFile/Unity3dRef/Assets/CusCCG_Ex_BGM/"+s));
				}				
			}

			BaconShopChangeBgm.Instance = this;
			m_possibleBGMindex = new List<int>();
			for(int i = 0;i<m_possibleBGMclip.Count;i++)
			{
				m_possibleBGMindex.Add(i);
			}
			Loaded=true;
		}

	}

	public void Change(bool IsRecruitPhase=false)
	{
		UnityEngine.Debug.Log("Changing------------------------------------");
		if(IsRecruitPhase)
		{
			if(m_possibleBGMclipRecruit.Count>0)
			{
				int Chosen = UnityEngine.Random.Range(0,m_possibleBGMclipRecruit.Count);
				m_AudSrc.clip=m_possibleBGMclipRecruit[Chosen];//[m_possibleBGMindex[Chosen]];
				//m_possibleBGMindex.RemoveAt(Chosen);
				m_AudSrc.Play();
			}
		}
		else{
			if(m_possibleBGMclip.Count>0)
			{
				int Chosen = UnityEngine.Random.Range(0,m_possibleBGMindex.Count);
				m_AudSrc.clip=m_possibleBGMclip[Chosen];//[m_possibleBGMindex[Chosen]];
				//m_possibleBGMindex.RemoveAt(Chosen);
				m_AudSrc.Play();			
			}			
		}


		Command.CommandExecutionComplete();
	}

    public AudioClip LoadAudSync(string FileUrl)
    {
        if(System.IO.File.Exists(FileUrl))
        {
            FileStream _fileStream = new FileStream(FileUrl,FileMode.Open,FileAccess.Read);
            byte[] _buffer = new byte[_fileStream.Length];
            _fileStream.Read(_buffer,0,_buffer.Length);

            int SampleRate = 96000;//48000;
            AudioClip _audioClip = AudioClip.Create("audioClip", SampleRate * 600, 1, SampleRate, false); 
            float[] _clipData = new float[_buffer.Length / 2];
            int RandomStart = UnityEngine.Random.Range(0,_buffer.Length/5);
            for (int i = 0; i < _buffer.Length; i += 2)
            {
                _clipData[i / 2] = (short)((_buffer[i + 1] << 8) | _buffer[i]) / 32768.0f;
            }
            float[] _clipDataCrop = new float[_buffer.Length / 2 - RandomStart];
            System.Array.ConstrainedCopy(_clipData, RandomStart, _clipDataCrop, 0, _buffer.Length / 2 - RandomStart);
            _audioClip.SetData(_clipDataCrop, 0);
            return _audioClip;
        }
        return null;
    }
}