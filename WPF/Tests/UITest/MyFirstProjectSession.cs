using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;


namespace UITest
{
    public class MyFirstProjectSession 
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string CalculatorAppId = @"C:\Users\bohdan.hlyva\Documents\GitHub\Eleks\WPF\MyFirstProject\bin\Debug\MyFirstProject.exe";

        protected static WindowsDriver<WindowsElement> Session;

        public static void Setup(TestContext context)
        {
            // Launch Calculator application if it is not yet launched
            if (Session == null)
            {
                // Create a new session to bring up an instance of the Calculator application
                // Note: Multiple calculator windows (instances) share the same process Id
                AppiumOptions appCapabilities = new AppiumOptions();
                appCapabilities.AddAdditionalCapability("app", CalculatorAppId);
                appCapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
                Session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
                Assert.IsNotNull(Session);



                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
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
