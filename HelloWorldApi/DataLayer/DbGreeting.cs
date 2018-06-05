using System;
using System.Configuration;
namespace HelloWorldApi.DataLayer
{
    /* 
       This class contains the logic for generating a simple text greeting from a database.  It will
       check the configuration for db settings like a connection string...
    */
    public class DbGreeting : IGreetingPersistence
    {
        public DbGreeting()
        {
            string[] connectionString = ConfigurationManager.AppSettings.GetValues("ConnectionString");

            if (connectionString != null)
            {
                // Parse the settings to establish the connection.
            }
        }
        public string GetGreeting()
        {
            throw new System.NotImplementedException();
        }
    }
}