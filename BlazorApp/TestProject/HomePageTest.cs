using Bunit;
using Xunit;

public class HomePageTests : Bunit.TestContext
{
    [Fact]
    public void HomePage_Should_RenderCorrectly()
    {
        // Arrange & Act
        var component = RenderComponent<BlazorApp.Components.Pages.Home>();

        // Assert
        component.MarkupMatches(@"
            <h1>Hello, world!</h1>
            Welcome to your new app.
        ");
    }
}