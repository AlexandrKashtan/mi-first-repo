using Xunit;

public class GreeterTests
{
    [Fact]
    public void GetGreeting_ReturnsGreetingWithName()
    {
        string result = Greeter.GetGreeting("Александр");

        Assert.Equal("Здравствуй, Александр! Добро пожаловать в DevOps.", result);
    }
}
