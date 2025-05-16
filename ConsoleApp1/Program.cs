using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

internal class Program
{
    static TcpListener listener;
    static List<ClientHandler> clients = new List<ClientHandler>();
    static object lockObj = new object();

    static void Main()
    {
        listener = new TcpListener(IPAddress.Any, 5000);
        listener.Start();
        Console.WriteLine("SErver is started...");

        while (true)
        {
            TcpClient client = listener.AcceptTcpClient();
            ClientHandler handler = new ClientHandler(client);
            lock (lockObj)
            {
                clients.Add(handler);
            }
            new Thread(handler.Run).Start();
        }
    }

    public static void Broadcast(string message, ClientHandler sender)
    {
        byte[] buffer = Encoding.UTF8.GetBytes(message);
        lock (lockObj)
        {
            foreach (var client in clients)
            {
                if (client != sender)
                {
                    try
                    {
                        client.Stream.Write(buffer, 0, buffer.Length);
                    }
                    catch
                    {

                    }
                }
            }
        }
    }

    public static void RemoveClient(ClientHandler client)
    {
        lock (lockObj)
        {
            clients.Remove(client);
        }
    }
}

class ClientHandler
{
    public TcpClient TcpClient { get; }
    public NetworkStream Stream { get; private set; }
    string userName;

    public ClientHandler(TcpClient client)
    {
        TcpClient = client;
        Stream = client.GetStream();
    }

    public void Run()
    {
        try
        {

            byte[] buffer = new byte[1024];
            int bytesRead = Stream.Read(buffer, 0, buffer.Length);
            userName = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"{userName} connected.");
            Program.Broadcast($"[Server] {userName} connected to chat", this);

            while ((bytesRead = Stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string fullMessage = $"[{DateTime.Now:HH:mm:ss}] {userName}: {message}";
                Console.WriteLine(fullMessage);
                Program.Broadcast(fullMessage, this);
            }
        }
        catch
        {

        }
        finally
        {
            Console.WriteLine($"{userName} exit.");
            Program.Broadcast($"[Server] {userName} exit", this);
            Program.RemoveClient(this);
            TcpClient.Close();
        }
    }
}
