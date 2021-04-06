using System.Drawing;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UITest
{
    [TestClass]
    public class CreatePresentationScenario : MyFirstProjectSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Create session to launch a Calculator window
            Setup(context);


        }
        //[TestInitialize]
        //public void TesInitialize()
        //{

        //}
        [TestMethod]
        public void Division()
        {
            //// Find the buttons by their accessibility ids and click them in sequence to perform 88 / 11 = 8
            Session.FindElementByName("Add Presentation").Click();
            Session.FindElementByName("Add Que").Click();
            Session.FindElementByName("Add Slide").Click();
            Session.FindElementByName("Add Text").Click();
            Session.FindElementByName("Add Shape").Click();
            Session.FindElementByName("Add Triangle").Click();
            Session.FindElementByName("Add Shape").Click();
            Session.FindElementByName("Add Circle").Click();
            Session.FindElementByName("Add Shape").Click();
            Session.FindElementByName("Add Rectangle").Click();

            Session.FindElementByName("Effects").Click();
            Session.FindElementByName("Blur").Click();

            //Session.FindElementByName("Add Text").Click();



            //Session.FindElementByAccessibilityId("Add Presentation").Click();
            //Session.FindElementByAccessibilityId("Add Presentation").Click();
            //session.FindElementByAccessibilityId("num8Button").Click();
            //session.FindElementByAccessibilityId("divideButton").Click();
            //session.FindElementByAccessibilityId("num1Button").Click();
            //session.FindElementByAccessibilityId("num1Button").Click();
            //session.FindElementByAccessibilityId("equalButton").Click();
            //Assert.AreEqual("8", GetCalculatorResultText());
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }
    }
}
