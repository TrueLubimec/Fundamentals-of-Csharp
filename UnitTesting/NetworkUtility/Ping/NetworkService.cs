namespace NetworkUtility;
public class NetworkService
{
    public string SendPing()
    {
        //DNS Search();
        //BuildPacket();
        return "Success: Ping Sent!";
    }

    public int PingTimeout(int a, int b)
    {
        return a * b;
    }
}
