using HelloWorldApi.DataLayer;
using System;

namespace HelloWorldApi.Application
{
    // This is a basic greeting class.  It will encapsulate the persistence layer so that classes that inherit it can be insulated 
    // from the data layer.  It calls a persistence factory to generate a IGreetingPersistence object.  This objec can be a db implementation
    // a file or s asimple message implementation.  Calling Get
    public class BasicGreeting
    {
        private IGreetingPersistence _persistence;
        public BasicGreeting()
        {
            _persistence = null;
        }

        protected void GetPersistenceLayer()
        {
            // Get the persistence layer
            _persistence = GreetingPersistenceFactory.CreatePersistenceLayer();           
        }
        protected string GetGeneratedGreeting()
        {
            // Default message if there is an error.
            string message = "We're sorry.  We could not generate a friendly greeting at this time. Please try again soon.";
            try
            { 
                GetPersistenceLayer();
                message = _persistence.GetGreeting();
            }
            catch (Exception ex)
            {
                // log the exception to note a failure, but default message is set. 
            }
            return message;
        }
    }
}