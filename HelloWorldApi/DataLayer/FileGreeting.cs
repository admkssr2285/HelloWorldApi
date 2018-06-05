using System.Configuration;

namespace HelloWorldApi.DataLayer
{
    public class FileGreeting : IGreetingPersistence
    {
        /* 
          This class contains the logic for reading a simple text greeting from a file.  It will
          check the configuration for file settings like a location.  Currently it only returns the first line.
       */
        private string greetingFile;
        public FileGreeting()
        {
            string[] fileName = ConfigurationManager.AppSettings.GetValues("GreetingFile");

            if (fileName != null)
            {
                // Get the location of the file to read from the settings.    
                greetingFile = fileName[0];
            }
        }
        public string GetGreeting()
        {
            string message = "We're sorry.  We could not generate a friendly greeting at this time. Please try again soon.";

            // Read the file and display it line by line.  
            using (System.IO.StreamReader file = new System.IO.StreamReader(greetingFile))
            {
                message = file.ReadLine();
                file.Close();
            }
            return message;
        }
    }
}