using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.Audio;

public class DragMinionBuySell : DraggingActions
{
    private OneActorManager Actor;
    public void Update()
    {
        if (tag.Contains("Top"))//sell
        {
            if(Actor==null)
            {
                Actor=GetComponentInParent<OneActorManager>();
            }
            Actor.SetBaconHighLight();
        }        
    }
    public override bool CanDrag
    {
        get
        {

            return true;
        }
    }

    private float nowPx=0f;
    private float nowPz=0f;
    public override void OnStartDrag()
    {
        GetComponentInParent<OneActorManager>().IsActing = true;
        // manager.CardFaceGlowImage.color = Color.blue;
    }

    public override void OnDraggingInUpdate(Vector3 Position)
    {
        float velx = Position.x - nowPx;
        float velz = Position.z - nowPz;
        if (velx > 1f)
        {
            velx = 1f;
        }
        if (velx < -1f)
        {
            velx = -1f;
        }
        if (velz > 1f)
        {
            velz = 1f;
        }
        if (velz < -1f)
        {
            velz = -1f;
        }

        nowPx = Position.x;
        nowPz = Position.z;
        transform.parent.rotation = Quaternion.Euler(new Vector3(velz * 100f,0f, -velx * 100f));
        transform.parent.position = Position;
    }

    public override void OnEndDrag()
    {
        Player owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
        int cardId=GetComponentInParent<IDHolder>().UniqueID;
        GetComponentInParent<OneActorManager>().IsActing = false;
        if (DragSuccessful())
        {
            if(transform.parent.position.z>0.96)
            {
                if (tag.Contains("Low"))//sell
                {
                    if(OneSceneManager.Instance.BaconSell!=null)
                    {
                        //UnityEngine.Debug.Log("Selling!");
                        OneSceneManager.Instance.BaconSell.Play();
                    }
                    new EffectBaconshopSell(owner,cardId).Resolve();
                }
            }
            else if(transform.parent.position.z<-0.96)
            {
                if (tag.Contains("Top"))//buy
                {
                    if(OneSceneManager.Instance.BaconBuy!=null)
                    {
                        //UnityEngine.Debug.Log("Buying!");
                        OneSceneManager.Instance.BaconBuy.Play();
                    }
                    new EffectBaconshopBuy(owner,cardId).Resolve();
                }
                else{
                    new EffectBaconshopReturn(owner,cardId).Resolve();
                }
            }
            else if(transform.parent.position.z<0 && transform.parent.position.z>-1)
            {
                if (tag.Contains("Low"))
                {
                    Request.CilentSend("BaconShopBuySell");
                    float x = transform.parent.position.x;
                    int tablePos=-1;
                    List<float> AllX = OneSceneManager.Instance.StageDictByPlayerId[playerOwner.GetTag(GameTag.PlayerID)].GetAllXForZone(ZoneType.Board);
                    if(AllX.Count==0)
                    {
                        tablePos=0;
                    }
                    else if(x<=AllX[0])
                    {
                        tablePos=0;
                    }
                    else if(x>AllX.Last())
                    {
                        tablePos=-1;
                    }
                    else
                    {
                        int rawPos=OneSceneManager.Instance.StageDictByPlayerId[playerOwner.GetTag(GameTag.PlayerID)].GetIndexForActor(cardId,ZoneType.Board);
                        for(int i=0;i<AllX.Count-1;i++)
                        {
                            if(x>AllX[i] && x<=AllX[i+1])
                            {
                                if(rawPos>=i+1)
                                {
                                    tablePos=i+1;
                                }
                                else
                                {
                                    tablePos=i;
                                }
                            }
                        }
                    }
                    new EffectChangeIndex(owner,cardId,tablePos).Resolve();
                }
            }
        }
        else
        {
        }
    }

    protected override bool DragSuccessful()
    {
        bool TableNotFull = (playerOwner.board.Count < 7);

        return true;//TableVisual.CursorOverSomeTable && TableNotFull;
    }


}
