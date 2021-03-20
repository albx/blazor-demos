using BlazorTesting.App.Pages;
using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlazorTesting.GettingStarted.Test
{
    public class HelloWorldTest : TestContext
    {
        [Fact]
        public void HelloWorld_Component_Should_Render_Correctly()
        {
            // Act
            var component = RenderComponent<HelloWorld>();
            component.SetParametersAndRender(
                ComponentParameter.CreateParameter(nameof(HelloWorld.Name), "Twitch"));

            // Assert
            component.MarkupMatches("<h1>Hello world from Twitch!</h1>");
        }
    }
}
