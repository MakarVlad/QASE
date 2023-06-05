using NUnit.Framework.Constraints;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.UiAutomator;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Threading;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AppiumTest
{


    [TestFixture]
    public class EnterESIA
    {
     
       // private AndroidDriver<AndroidElement> _driver;
        private RemoteWebDriver _driver;  
        string mainEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.widget.ScrollView/android.view.View[1]/android.view.View/android.widget.Button\r\n";
        string checkBoxPolicyXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[1]\r\n";
        string checkBoxMinCifraXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[2]\r\n";
        string enterEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.view.View[1]/android.widget.Button";
        string EsiaFormXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.ViewGroup";
        string exitXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View\r\n";
       // AndroidElement? mainEsiaButton;
       // AndroidElement? checkBoxPolicy;
       // AndroidElement? enterEsiaButton;
       // AndroidElement? checkBoxMinCifra;
       // AndroidElement? EsiaForm;
       ///* AndroidElement?*/ Exit;

        [SetUp]
        public void Setup()
        {
            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, /*"4  WVGA (Nexus S)"*/"Pixel 2");
           // _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), driverOption);
            _driver = new RemoteWebDriver(new Uri("http://localhost:4723/wd/hub"), driverOption);
        }

        [Test]
        public void EntranceEsiaWithoutCheckbox()
        {
            int case_id = 1132;
            //QaseApi.RunsInfo();
            Thread.Sleep(50);
            var mainEsiaButton = _driver.FindElementByXPath(mainEsiaButtonXpath);
            Thread.Sleep(50);
            mainEsiaButton.Click();
            Thread.Sleep(50);
            var checkBoxPolicy = _driver.FindElementByXPath(checkBoxPolicyXpath);
           var  checkBoxMinCifra = _driver.FindElementByXPath(checkBoxMinCifraXpath);
            var enterEsiaButton = _driver.FindElementByXPath(enterEsiaButtonXpath);
            checkBoxPolicy.Click();
            Thread.Sleep(50);
            enterEsiaButton.Click();
            Thread.Sleep(50);
            try
            {
               var EsiaForm = _driver.FindElementByXPath(EsiaFormXpath);
            }
            catch
            {
                checkBoxMinCifra.Click();
                checkBoxPolicy.Click();
                enterEsiaButton.Click();
                try
                {
                    var EsiaForm = _driver.FindElementByXPath(EsiaFormXpath);
                }
                catch
                {
                   var Exit = _driver.FindElementByXPath(exitXpath);
                    Exit.Click();
                    //QaseApi.RunCaseResult(case_id, "passed");
                    //Assert.Pass();
                }

            }

        }
    }
}