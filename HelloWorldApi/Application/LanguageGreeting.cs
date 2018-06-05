namespace HelloWorldApi.Application
{
    public class LanguageGreeting : BasicGreeting
    {
        // This will provide a hello world translation from the basic hello world greeting.
         public string GetGreeting(int? language)
        {
            string greeting = GetGeneratedGreeting();
            if (language == null) return greeting;
            if (greeting.Contains("Hello"))
            {
                switch (language.Value)
                {
                    case (int)GreetingType.French:
                        return greeting.Replace("Hello", "Bonjour");
                    case (int)GreetingType.Norwegian:
                        return greeting.Replace("Hello", "Hallo");
                    case (int)GreetingType.Spanish:
                        return greeting.Replace("Hello", "Hola");
                    case (int)GreetingType.Casual:
                        return greeting.Replace("Hello", "Hi");
                    default:
                        break;
                }
            }
            return greeting;
        }
    }
}