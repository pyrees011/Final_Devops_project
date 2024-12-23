using Bunit;
using Xunit;

namespace TestProject;

[TestFixture]
public class TonyPageTest: Bunit.TestContext
{
    [Fact]
    public void TonyPage_Should_RenderCorrectly()
    {
        // Arrange & Act
        var component = RenderComponent<BlazorApp.Components.Pages.Tony>();

        // Assert
        component.MarkupMatches(@"          
            <h1>Hello, Tony</h1>
            Welcome to our blazor app.
        ");
    }
}