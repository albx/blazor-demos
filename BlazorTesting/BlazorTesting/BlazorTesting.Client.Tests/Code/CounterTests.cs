using BlazorTesting.Client.Pages;
using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BlazorTesting.Client.Tests.Code
{
    public class CounterTests : TestContext
    {
        [Fact]
        public void Counter_Component_Should_Initialize_With_Counter_Zero()
        {
            var component = RenderComponent<Counter>();
            
            var paragraph = component.Find("p");
            paragraph.MarkupMatches("<p>Current count: 0</p>");
        }

        [Fact]
        public void Counter_Component_Should_Increment_Current_Count_When_Button_Is_Clicked()
        {
            var component = RenderComponent<Counter>();
            
            var button = component.Find("button");
            button.Click();

            var paragraph = component.Find("p");
            paragraph.MarkupMatches("<p>Current count: 1</p>");
        }
    }
}
