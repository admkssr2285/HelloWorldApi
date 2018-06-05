using System;
using System.Collections.Generic;
using HelloWorldApi.Models;


namespace HelloWorldApi.Application
{
    public class GreetingHelp
    {
        public List<GreetingModel> GetSupportedGreetings()
        {
            List<GreetingModel> AllGreetings = new List<GreetingModel>();

            LanguageGreeting greeter = new LanguageGreeting();

            foreach (GreetingType generatedType in Enum.GetValues(typeof(GreetingType)))
            {
                string generatedGreeting = greeter.GetGreeting((int)generatedType);
                AllGreetings.Add(new GreetingModel()
                    {
                        Id = (int)generatedType,
                        GeneratedGreeting = generatedGreeting
                });
            }

            return AllGreetings;
        }
    }
}