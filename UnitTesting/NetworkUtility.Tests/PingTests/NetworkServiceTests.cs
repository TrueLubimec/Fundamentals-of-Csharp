namespace NetworkUtility.Tests;
public class NetworkServiceTests
{
    [Fact]
    public void NetworkService_SendPing_ReturnString()
    {
        //Arrange
        var pingService = new NetworkService();

        //Act
        var result = pingService.SendPing();

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
        var pingService = new NetworkService();

        //Act
        var result = pingService.PingTimeout(a, b);

        //Assert
        result.Should().Be(expected);
        result.Should().BeGreaterThanOrEqualTo(2);
        result.Should().NotBeInRange(-1, 0);

    }
}
