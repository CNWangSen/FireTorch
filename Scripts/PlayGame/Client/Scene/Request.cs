using System.Collections;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
//attachedTo OneSceneManager
public class Request : MonoBehaviour
{
    private static Socket CilentSocket;
    private static bool Connected = true;
    private static bool Listening = false;
    private static Thread ListeningThread;
    private static Thread KeepThread;
    // Use Request for initialization
    void Start()
    {     
        if (Connected)
        {
            return;
        }
        Response.Start();
        //创建socket
        Request.CilentSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //连接服务器
        IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),8080);
        //这里防止连接失败报错，SocketException能提供错误代码
        try
        {
            Request.CilentSocket.Connect(endpoint);
            Request.Connected = true;
        }
        catch (SocketException e)
        {
            Debug.Log("[C]Failed To Connect Server:"+e.ErrorCode);//10061是服务器拒绝连接        
        }
        Request.KeepThread = new Thread(Request.KeepListen);
        Request.KeepThread.Start();
        //收发消息
        //收消息
        /*
        byte[] msg = new byte[1024];
        int msgLength = CilentSocket.Receive(msg);
        Debug.Log("收到服务器发送的消息："+Encoding.UTF8.GetString(msg,0,msgLength));
        */
    }
    public static void CilentShutDown()
    {
        //释放连接
        Request.CilentSocket.Shutdown(SocketShutdown.Both);
        Request.CilentSocket.Close();
        Request.Connected = false;
        Request.ListeningThread.Abort();
        Request.KeepThread.Abort();
    }
    public static void CilentSend(string msg)
    {
        //return;
        //UnityEngine.Debug.Log("CilentRequest: "+msg);
        if (Request.Connected == false)
        {
            return;
        }
        //发消息
        //Request.CilentSocket.Send(Encoding.UTF8.GetBytes(msg));
    }
    public static void CilentReceive()
    {
        Request.Listening = true;
        byte[] msg = new byte[1024];
        int msgLength = CilentSocket.Receive(msg);
        Debug.Log("[C]GetCommand" + Encoding.UTF8.GetString(msg, 0, msgLength));
        Request.ListeningThread.Abort();
        Request.Listening = false;
    }
    public static void KeepListen()
    {
        while (true)
        {
            if (Request.Connected && (!Listening))
            {
                Request.ListeningThread = new Thread(Request.CilentReceive);
                Request.ListeningThread.Start();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Response.ServerSend("AddToQueue");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Request.CilentSend("CommandComplete");
        }

    }

}