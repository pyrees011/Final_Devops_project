using Bunit;
using Xunit;

[TestFixture]
public class CounterPageTest: Bunit.TestContext
{
    [Fact]
    public void CounterPage_Should_Increment_When_Clicked()
    {
        // Arrange
        var component = RenderComponent<BlazorApp.Components.Pages.Counter>();

        // Act
        component.Find("button").Click(); // Simulates button click.

        // Assert
        Xunit.Assert.Contains("Current count: 1", component.Markup);
    }
}