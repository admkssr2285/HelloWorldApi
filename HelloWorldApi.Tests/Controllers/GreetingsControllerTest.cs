using HelloWorldApi.Controllers;
using HelloWorldApi.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApi.Models;
using System.Collections.Generic;

namespace HelloWorldApi.Tests.Controllers
{
    [TestClass]
    public class GreetingsControllerTest
    {
        [TestMethod]
        public void SayCasualHello()
        {
            // Arrange
            GreetingsController controller = new GreetingsController();

            // Casual
            string result = controller.Get((int)GreetingType.Casual);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hi World", result);
        }
        [TestMethod]
        public void SayFrenchHello()
        {
            // Arrange
            GreetingsController controller = new GreetingsController();

            // French
            string result = controller.Get((int)GreetingType.French);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Bonjour World", result);
        }
        [TestMethod]
        public void SaySpanishHello()
        {
            // Arrange
            GreetingsController controller = new GreetingsController();

            // Spanish
            string result = controller.Get((int)GreetingType.Spanish);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hola World", result);
        }
        [TestMethod]
        public void SayNorwegianHello()
        {
            // Arrange
            GreetingsController controller = new GreetingsController();

            // Norwegian
            string result = controller.Get((int)GreetingType.Norwegian);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hallo World", result);
        }
        [TestMethod]
        public void GetSupportedGreetings()
        {
            // Arrange
            GreetingHelp helper = new GreetingHelp();

            // Casual
            List<GreetingModel> allGreetings= helper.GetSupportedGreetings();
            // Assert
            Assert.IsNotNull(allGreetings);
        }
        [TestMethod]
        public void PostTest()
        {

            GreetingsController controller = new GreetingsController();

            // Act
            string result =controller.Post("Casual");

            Assert.IsNotNull(result);
            Assert.AreEqual("Hi World", result);
        }
    }
}
