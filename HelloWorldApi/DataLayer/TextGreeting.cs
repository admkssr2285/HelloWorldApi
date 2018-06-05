using System;
using System.Configuration;

namespace HelloWorldApi.DataLayer
{
    public class TextGreeting : IGreetingPersistence
    {
        /* 
           This class contains the logic for generating a simple text greeting from a database.  It will
           check the configuration for db settings like a connection string...
        */
        private string message { get; set; }
        public TextGreeting()
        {
            string[] configuration = ConfigurationManager.AppSettings.GetValues("DefaultGreeting");

            try
            {
                // Get your configuration
                if (configuration == null)
                    message = "Hello World";
                else
                {
                    // Get the message from the settings
                    message = configuration[0];
                }
            }
            catch (Exception)
            {
                message = "We're sorry.  We could not generate a friendly greeting at this time. Please try again soon.";
            }
        }
        public string GetGreeting()
        {
            return message;
        }
    }
}