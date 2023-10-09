using System.Net.NetworkInformation;

namespace NetworkUtility;
public class NetworkService
{
    private readonly IDNS dNS;

    public NetworkService(IDNS dNS)
    {
        this.dNS = dNS;
    }
    public string SendPing()
    {
        var dnsSuccess = dNS.SendDNS();
        if (dnsSuccess)
        {
            return "Success: Ping Sent!";
        }
        else
        {
            return "Sus us";
        }
    }

    public int PingTimeout(int a, int b)
    {
        return a * b;
    }

    public DateTime LastPingDate()
    {
        return DateTime.Now;
    }

    public PingOptions GetPingOptions()
    {
        return new PingOptions()
        {
            DontFragment = true,
            Ttl = 1
        };
    }

    public IEnumerable<PingOptions> MostRecentPings()
    {
        IEnumerable<PingOptions> pingOptions = new[]
        {
            new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            },
            new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            },
            new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            }
        };
        return pingOptions;
    }
}
