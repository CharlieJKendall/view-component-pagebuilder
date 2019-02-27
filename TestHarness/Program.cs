using System;
using System.Collections.Generic;
using ViewComponentsTest;
using ViewComponentsTest.Models.ViewComponents;
using ViewComponentsTest.Models.ViewComponents.Options;
using ViewComponentsTest.ViewComponents;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ViewComponentContainer> components = new List<ViewComponentContainer>()
            {
                new ViewComponentContainer(
                    nameof(CustomerDetails),
                    new List<ViewComponentContainer>()
                    {
                        new ViewComponentContainer(
                            nameof(CustomerNameDisplay),
                            new List<ViewComponentContainer>()
                            {
                                new ViewComponentContainer(nameof(BasicText), null, new BasicTextOptions("text-options","background-color:blue;"))
                            },
                            new CustomerNameDisplayOptions("customer-name-display", "background-color:red;", 50, nameof(CustomerNameDisplayOptions.Class)))
                    },
                    new CustomerDetailsOptions("customer-details", "background-color:black;color:red;", true))
            };

            var json = JsonSerlializer.SerializePageJson(components);
            var result = JsonSerlializer.DeserializePageJson(json);

            Console.ReadLine();
        }
    }
}
