using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;


namespace Appium
{
    public class AndroidTestsInit
    {
        protected AndroidDriver<AndroidElement> driver;
        protected ITouchAction touchAction;
        public AndroidTestsInit() { }

        [SetUp]
        public void Init()
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, "MSP_v.1.2.0(344-release).apk");
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 2");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "10.0");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            appiumOptions.AddAdditionalCapability("uiautomator2ServerInstallTimeout",60000);
            //appiumOptions.AddAdditionalCapability(["uiautomator2ServerInstallTimeout"] = 60000);

            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            touchAction = new TouchAction(driver);
        }

        //[TearDown]
        //public void Cleanup()
        //{
        //    driver.Quit();
        //}
    }
}

