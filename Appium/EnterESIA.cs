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

namespace AppiumTest
{


    [TestFixture]
    public class EnterESIA
    {
        private AppiumDriver<AndroidElement> _driver;
        string mainEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.widget.ScrollView/android.view.View[1]/android.view.View/android.widget.Button\r\n";
        string checkBoxPolicyXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[1]\r\n";
        string checkBoxMinCifraXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[2]\r\n";
        string enterEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.view.View[1]/android.widget.Button";
        string EsiaFormXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.ViewGroup";
        string exitXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View\r\n";
        AndroidElement? mainEsiaButton;
        AndroidElement? checkBoxPolicy;
        AndroidElement? enterEsiaButton;
        AndroidElement? checkBoxMinCifra;
        AndroidElement? EsiaForm;
        AndroidElement? Exit;

        [SetUp]
        public void Setup()
        {
            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, /*"4  WVGA (Nexus S)"*/"Pixel 2");
            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOption);
        }

        [Test]
        public void EntranceEsiaWithoutCheckbox()
        {
            int case_id = 1132;
            //QaseApi.RunsInfo();
            Thread.Sleep(50);
            mainEsiaButton = _driver.FindElementByXPath(mainEsiaButtonXpath);
            Thread.Sleep(50);
            mainEsiaButton.Click();
            Thread.Sleep(50);
            checkBoxPolicy = _driver.FindElementByXPath(checkBoxPolicyXpath);
            checkBoxMinCifra = _driver.FindElementByXPath(checkBoxMinCifraXpath);
            enterEsiaButton = _driver.FindElementByXPath(enterEsiaButtonXpath);
            checkBoxPolicy.Click();
            Thread.Sleep(50);
            enterEsiaButton.Click();
            Thread.Sleep(50);
            try
            {
                EsiaForm = _driver.FindElementByXPath(EsiaFormXpath);
            }
            catch
            {
                checkBoxMinCifra.Click();
                checkBoxPolicy.Click();
                enterEsiaButton.Click();
                try
                {
                    EsiaForm = _driver.FindElementByXPath(EsiaFormXpath);
                }
                catch
                {
                    Exit = _driver.FindElementByXPath(exitXpath);
                    Exit.Click();
                    //QaseApi.RunCaseResult(case_id, "passed");
                    //Assert.Pass();
                }

            }

        }
    }
}