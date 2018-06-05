using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApi.DataLayer
{
    public interface IGreetingPersistence 
    {
         string GetGreeting();
    }
}
