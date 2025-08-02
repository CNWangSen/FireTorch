using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class Response
{
    private static Socket ServerSocket;
    private static Socket ClientSocket;
    private static bool Connected = false;
    private static bool Listening =false;
    private static Thread ListeningThread;
    private static Thread StartThread;
    private static Thread KeepThread;
    public static void Start()
    {
        Response.StartThread = new Thread(Response.StartServer);
        Response.StartThread.Start();

        Response.KeepThread = new Thread(Response.Update);
        Response.KeepThread.Start();

    }
    public static void StartServer()
    {
        Response.ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //绑定IP地址和端口
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
        Response.ServerSocket.Bind(iPEndPoint);
        //Debug.Log("[Server]Success Bind IP...");
        //设置监听客户端数量
        Response.ServerSocket.Listen(1024);
        //等待客户端链接
        //Debug.Log("[Server]Waiting For Cilent...");
        //阻塞主线程，有客户端连入才会往下执行，否则一直在等待
        Response.ClientSocket = Response.ServerSocket.Accept();
        Response.Connected = true;
        Response.StartThread.Abort();
    }
    public static void ServerSend(string msg)
    {
        //return;
        //UnityEngine.Debug.Log("ServerResponse: "+msg);
        if (Response.Connected==false)
        {
            return;
        }
        //给客户端发送消息
        //Response.ClientSocket.Send(Encoding.UTF8.GetBytes(msg));
    }
    public static void ServerReceive()
    {
        Response.Listening = true;
        //接受客户端发来的消息
        byte[] msgBytes = new byte[1024];
        int msgLength = Response.ClientSocket.Receive(msgBytes);
        //解析客户端发来的消息
        Debug.Log(("[S]GetComplete" + Encoding.UTF8.GetString(msgBytes, 0, msgLength)));
        Response.ListeningThread.Abort();
        Response.Listening = false;
    }
    public static void Update()
    {
        while (true)
        {
            if (Response.Connected && (!Listening))
            {
                Response.ListeningThread = new Thread(Response.ServerReceive);
                Response.ListeningThread.Start();
            }
        }
    }

    public static void ShutDownServer()
    {         
        //通信完成释放连接
        Response.ClientSocket.Shutdown(SocketShutdown.Both);
        Response.ClientSocket.Close();
        Response.ListeningThread.Abort();
        Response.KeepThread.Abort();
        //Debug.Log("[Server]Shut Down");
    }
}