using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void CreateBaseElement()
        {
            Session.FindElementByAccessibilityId("AddPresentation").Click();
            Session.FindElementByAccessibilityId("AddQue").Click();
            Session.FindElementByAccessibilityId("AddSlide").Click();
            Session.FindElementByAccessibilityId("AddTextElement").Click();
            Session.FindElementByAccessibilityId("AddShapeMenu").Click();
            Session.FindElementByAccessibilityId("AddTriangleElement").Click();
            Session.FindElementByAccessibilityId("AddShapeMenu").Click();
            Session.FindElementByAccessibilityId("AddCircleElement").Click();
            Session.FindElementByAccessibilityId("AddShapeMenu").Click();
            Session.FindElementByAccessibilityId("AddRectangleElement").Click();

            //Session.FindElementByName("Effects").Click();
            //Session.FindElementByName("Blur").Click();
            //Session.FindElementByAccessibilityId("BlurEffectRadius").Clear();
            //Session.FindElementByAccessibilityId("BlurEffectRadius").SendKeys("100");

            //Thread.Sleep(5000);
            //Session.FindElementByAccessibilityId("AddTextElement").Click();

            //Session.FindElementByName("Add Text").Click();

            
            //Assert.AreEqual("8", GetCalculatorResultText());
        }

        [TestMethod]
        public void SetBlurRadius_WhenElementIsCreated_100()
        {
            //Arrange
            var expected = "100";

            Session.FindElementByAccessibilityId("AddPresentation").Click();
            Session.FindElementByAccessibilityId("AddQue").Click();
            Session.FindElementByAccessibilityId("AddSlide").Click();
            Session.FindElementByAccessibilityId("AddTextElement").Click();
            Session.FindElementByAccessibilityId("EffectsItem").Click();
            Session.FindElementByAccessibilityId("Blur").Click();
            Session.FindElementByAccessibilityId("BlurEffectRadius").Clear();
            Session.FindElementByAccessibilityId("BlurEffectRadius").SendKeys("100");

            Thread.Sleep(3000);

            //Act
            var actual = Session.FindElementByAccessibilityId("BlurEffectRadius").Text;

            Assert.AreEqual(expected, actual);
        }

    [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }
    }
}