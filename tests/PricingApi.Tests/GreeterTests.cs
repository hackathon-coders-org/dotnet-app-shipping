using Xunit;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsHello()
    {
        Assert.Equal("Hello, pricing!", Greeter.Greet("pricing"));
    }
}
