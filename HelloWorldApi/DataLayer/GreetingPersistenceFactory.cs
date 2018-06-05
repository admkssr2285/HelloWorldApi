using System.Configuration;

namespace HelloWorldApi.DataLayer
{
    /* 
        This class is a static factory class.  It follows the basic factory pattern and generates classes based on the settings
        in the app.config file.  If a database connection is specified a DbGreeting class will be returned, if a file is specified in 
        a FileGreeting setting then the greeting would be read from the file specified.  If no configuration is specified it will
        throw an exception.  You could also use dependency injection for this.
     */
    public static class GreetingPersistenceFactory
    {
        public static IGreetingPersistence CreatePersistenceLayer()
        {
            // Read the appConfig file for db settings.
            string[] serviceSetting = ConfigurationManager.AppSettings.GetValues("GreetingSource");
            string persistenceType = "SqlServer";

            if (serviceSetting != null && serviceSetting.Length == 1)
            {
                persistenceType = serviceSetting[0];
            }
            if (persistenceType == "FileGreeting")
            {
                return new FileGreeting();
            }
            if (persistenceType == "SqlServer")
            {
                return new DbGreeting();
            }
            if (persistenceType == "InMemory")
            { 
                return new TextGreeting();
            }
            throw new System.Exception("A persistence layer is not configured");
        }
    }
}