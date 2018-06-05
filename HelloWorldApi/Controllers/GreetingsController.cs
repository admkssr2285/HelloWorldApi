using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorldApi.Models;
using HelloWorldApi.Application;


namespace HelloWorldApi.Controllers
{
    public class GreetingsController : ApiController
    {   

        public string Get(int? type)
        {
            LanguageGreeting greeter = new LanguageGreeting();

            return greeter.GetGreeting(type);
        }
        public string Post([FromBody]string type)
        {
            int newType=(int)GreetingType.Casual;
            // Convert type to constant
            if (type == null) newType = -1;
            switch (type)
            {
                case "Casual":
                    newType = (int)GreetingType.Casual;
                    break;
                case "French":
                    newType = (int)GreetingType.French;
                    break;
                case "Spanish":
                    newType = (int)GreetingType.Spanish;
                    break;
                case "Norwegian":
                    newType = (int)GreetingType.Norwegian;
                    break;
                default:
                    newType = -1;
                    break;
            }

            LanguageGreeting greeter = new LanguageGreeting();

            string hello = greeter.GetGreeting(newType);
            
            return hello;

        }
    }
}
