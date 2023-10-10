using FakeItEasy;
using FluentAssertions.Extensions;
using System.Net.NetworkInformation;

namespace NetworkUtility.Tests;
public class NetworkServiceTests
{
    private readonly IDNS _dns;
    private readonly NetworkService networkService;
    

    public NetworkServiceTests()
    {

        _dns = A.Fake<IDNS>();
        //SUT
        networkService = new NetworkService(_dns);
    }
    [Fact]
    public void NetworkService_SendPing_ReturnString()
    {
        //Arrange
        A.CallTo(() => _dns.SendDNS()).Returns(true);
        
        //Act
        var result = networkService.SendPing();

        //Assert
        result.Should().NotBeNullOrWhiteSpace();
        result.Should().Be("Success: Ping Sent!");
        result.Should().Contain("Success", Exactly.Once());

    }

    //Theory может принимать несколько значений
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(2, 2, 4)]
    public void Network_PingTimeout_ReturnInt(int a, int b, int expected)
    {
        //Arrange


        //Act
        var result = networkService.PingTimeout(a, b);

        //Assert
        result.Should().Be(expected);
        result.Should().BeGreaterThanOrEqualTo(2);
        result.Should().NotBeInRange(-1, 0);

    }

    [Fact]
    public void NetworkService_LastPingDate_ReturnDate()
    {
        //Arrange


        //Act
        var result = networkService.LastPingDate();

        //Assert
        result.Should().BeAfter(1.January(2010));
        result.Should().BeBefore(1.January(2030));
    }

    [Fact]
    public void NetworkService_GetPingOptions_ReturnsObject()
    {
        //Arrange
        var expected = new PingOptions()
        {
            DontFragment = true,
            Ttl = 1
        };

        //Act
        var result = networkService.GetPingOptions();

        //Assert
        result.Should().BeOfType<PingOptions>();
        result.Should().BeEquivalentTo(expected);
        result.Ttl.Should().Be(1);
    }

    [Fact]
    public void NetworkService_MostRecentPings_ReturnObjects()
    {
        //Arrange
        var expected = new PingOptions()
        {
            DontFragment = true,
            Ttl = 1
        };

        //Act
        var result = networkService.MostRecentPings();

        //Assert
        result.Should().BeAssignableTo<IEnumerable<PingOptions>>();
        result.Should().ContainEquivalentOf(expected);
        result.Should().Contain(x => x.DontFragment == true);

    }
}
