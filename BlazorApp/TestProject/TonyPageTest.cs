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
            <h1>Welcome to Tony's Page</h1>
            <p>Here is an embedded video:</p>
            <div style=""position:relative; padding-bottom:56.25%; height:0; overflow:hidden;"">
                <iframe 
                    width=""560"" 
                    height=""315"" 
                    src=""https://www.youtube.com/embed/aAkMkVFwAoo?si=JFRDnFiIjHkynbRY"" 
                    title=""YouTube video player"" 
                    frameborder=""0"" 
                    style=""position:absolute; top:0; left:0; width:100%; height:100%;"" 
                    allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" 
                    referrerpolicy=""strict-origin-when-cross-origin"" 
                    allowfullscreen>
                </iframe>
            </div>
        ");
    }
}