using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace UITest
{
    public class MyFirstProjectSession
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string CalculatorAppId = @"C:\Users\bohdan.hlyva\Documents\GitHub\Eleks\WPF\MyFirstProject\bin\Debug\MyFirstProject.exe";

        protected static WindowsDriver<WindowsElement> Session;

        public static void Setup(TestContext context)
        {
            if (Session == null)
            {
                AppiumOptions appCapabilities = new AppiumOptions();
                appCapabilities.AddAdditionalCapability("app", CalculatorAppId);
                appCapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
                Session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);

                Assert.IsNotNull(Session);

                Session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }
        }

        public static void TearDown()
        {
            // Close the application and delete the session
            if (Session != null)
            {
                Session.Quit();
                Session = null;
            }
        }
    }
}