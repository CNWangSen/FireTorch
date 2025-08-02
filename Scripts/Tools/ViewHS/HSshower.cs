using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;

public class HSshower:MonoBehaviour
{
	public GameObject plane;
	public GameObject p2;
	public GameObject p3;
	public AudioSource Play1;
	public AudioSource Play2;
	public List<CardDbf> ShowingCards;
	public int ShowingIndex=0;
	public int Timetick=0;
	public bool StartShowing=false;
	public int TotalShow=0;
	public GameObject FrontIm;
	public GameObject BackIm;
	public int OneCardShowFrames=4*50;
	public Text CardName;
	public Text ClassName;
	public Text DescName;
	public List<Color> ClassHinter;
	public AudioSource BGM;
	private bool BGMstarted=false;

	void Start()
	{
		List<string> Banned = new List<string>(){"阿尔福斯"};
		List<string> ToFindList = new List<string>(){"神","棍"};
		Dictionary<string,bool> Valid=new Dictionary<string,bool>(){};

		Application.targetFrameRate=30;
		ShowingCards=new List<CardDbf>();
		//CardDbf.CaheUnCollectibleCard=true;
		CardDbf.LoadAllCardDbf();
		List<string> NoRepeat = new List<string>();
		//UnityEngine.Debug.Log(miniHearthJsonDef.allSetTags.IndexOf("ShadowVerse"));
		//UnityEngine.Debug.Log(miniHearthJsonDef.allSetTags.IndexOf("SanGuoSha"));
		foreach(CardDbf db in CardDbf.AllCardDbf)
		{

			int HasName=0;
			foreach(string s in ToFindList)
			{
				if(db.CnName.Contains(s))
				{
					HasName+=1;
					Valid[s]=true;
					break;
				}
			}
			if(HasName>0)//miniHearthJsonDef.allSetTags.IndexOf("ALTERAC_VALLEY"))
			{
				if(true)//db.RareType==RareType.Rare)
				{
					bool ret=HSViewer.SetHSMat(plane,db.m_noteMiniGuid);
					if(ret)
					{
						if(NoRepeat.Contains(db.CnName) || Banned.Contains(db.CnName))
						{

						}
						else{
							NoRepeat.Add(db.CnName);
							ShowingCards.Add(db);
							(AudioClip a1,AudioClip a2, AudioClip a3, AudioClip a4) = HSViewer.GetHSCardAudClips(db.m_noteMiniGuid);
						}
						
					}
					//UberShaderController ani =  plane.GetComponent<UberShaderController>();
					//if(ani!=null)
					//{
					//	Destroy(ani);
					//}
				}
			}
		}
		foreach(string s in ToFindList)
		{
			if(!Valid.ContainsKey(s))
			{
				UnityEngine.Debug.Log(s);
			}
		}
		TotalShow=ShowingCards.Count;
		UnityEngine.Debug.Log(TotalShow);
		if(TotalShow==0)
		{
			return;
		}
		HSViewer.SetHSMat(plane,ShowingCards[0].m_noteMiniGuid);
		HSViewer.SetHSMat(p2,ShowingCards[0].m_noteMiniGuid);
		HSViewer.SetHSMat(p3,ShowingCards[0].m_noteMiniGuid);
		CardName.text=ShowingCards[0].CnName;
		ClassName.text=CardDbf.ClassTypeName[(int)ShowingCards[0].Classes[0]];
		//CardName.text=ShowingCards[0].CnName;
		Color hinter=  ClassHinter[(int)ShowingCards[0].Classes[0]];
		CardName.color=hinter;
		ClassName.color=hinter;
		Time.timeScale=UnityEngine.Random.Range(1.618f,2.33f);
	
	}
	void FixedUpdate()
	{
		if(Input.GetKeyDown(KeyCode.H))
		{
			CardName.enabled=false;
			ClassName.enabled=false;
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			CardName.enabled=true;
			ClassName.enabled=false;
		}
		if(Input.GetKeyDown(KeyCode.Q))
		{
			if(StartShowing==false)
			{
				StartShowing=true;
				Timetick=-1;
				ShowingIndex=-1;
			}
		}
		if(StartShowing)
		{

			Timetick+=1;
			FrontIm.GetComponent<RectTransform>().sizeDelta=new Vector2(((float)(Timetick%OneCardShowFrames)/(float)OneCardShowFrames)*1920f,70);
			if(Timetick%OneCardShowFrames==0)
			{
				ShowingIndex+=1;
				if(ShowingIndex<TotalShow)
				{
					Time.timeScale=UnityEngine.Random.Range(1.618f,2.33f);

					//UberShaderController ani =  plane.GetComponent<UberShaderController>();
					//if(ani!=null)
					//{
					//	Destroy(ani);
					//}
					Color hinter=  ClassHinter[(int)ShowingCards[ShowingIndex].Classes[0]];
					string Showing=ShowingCards[ShowingIndex].m_noteMiniGuid;
					CardName.text=ShowingCards[ShowingIndex].CnName;
					HSViewer.SetHSMat(plane,Showing);
					HSViewer.SetHSMat(p2,Showing);
					HSViewer.SetHSMat(p3,Showing);
					ClassName.text=CardDbf.ClassTypeName[(int)ShowingCards[ShowingIndex].Classes[0]];

					CardDbf db = ShowingCards[ShowingIndex];

			        string dst="";
			        for(int i=0; i < db.Description.Length;i++)
			        {
			            if(db.Description[i]!='$' && db.Description[i]!='@' && db.Description[i]!='d')
			            {
			                dst+=db.Description[i];
			                if(i%1==0 && db.Description[i]!='<' && db.Description[i]!='>' && db.Description[i]!='/' && db.Description[i]!='b' && db.Description[i]!='i')
			                {
			                    dst+=" ";
			                }
			            }
			        }

			        DescName.color = hinter;
			        CardName.color = hinter;
			        ClassName.color = hinter;
			        DescName.text=dst;
			        float DurS=0;
					(AudioClip a1,AudioClip a2, AudioClip a3, AudioClip a4) = HSViewer.GetHSCardAudClips(Showing);
					//a4 = null;
					if(a1!=null)
					{
						DurS=a1.length;
						Play1.clip=a1;
						Play1.Play();
					}
					if(a4!=null)
					{
						BGM.volume=0f;
						Play2.clip=a4;
						Play2.Play();
						if(a4.length>DurS)
						{
							DurS=a4.length;
						}
					}
					else{
						BGM.volume=1f;
						if(!BGMstarted)
						{
							BGM.Play();
							BGMstarted=true;
						}
					}

					if(ShowingCards[ShowingIndex].RareType==RareType.Legendary)
					{
						if(DurS<4)
						{
							DurS=4;
						}
						OneCardShowFrames=(int)((((int)DurS)*50+25)*Time.timeScale);
						Timetick=0;
					}
					else{
						if(DurS<2)
						{
							DurS=2;
						}
						OneCardShowFrames=(int)((((int)DurS)*50+25)*Time.timeScale);
						Timetick=0;
					}			
				}
				else
				{
					Application.Quit();
				}
			
			}
		
		}

	}
}