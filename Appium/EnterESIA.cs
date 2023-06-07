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
using System;
using Appium;

namespace AppiumTest
{
    [TestFixture]
    public class EnterESIA: AndroidTestsInit
    {
        
        public EnterESIA() : base() { }

        string mainEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.widget.ScrollView/android.view.View[1]/android.view.View/android.widget.Button\r\n";
        string checkBoxPolicyXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[1]\r\n";
        string checkBoxMinCifraXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[2]\r\n";
        string enterEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.view.View[1]/android.widget.Button";
        string EsiaFormXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.ViewGroup";
        string exitXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View\r\n";
        string closeOnboardXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]\r\n";

        AndroidElement? mainEsiaButton;
        AndroidElement? checkBoxPolicy;
        AndroidElement? enterEsiaButton;
        AndroidElement? checkBoxMinCifra;
        AndroidElement? EsiaForm;
        AndroidElement? Exit;
        AndroidElement? CloseOnboard;
        AndroidElement? Test ;
        [Test]
        public void EntranceEsiaWithoutCheckbox()
        {
         
            Thread.Sleep(2000);
            CloseOnboard = driver.FindElementByXPath(closeOnboardXpath);
            CloseOnboard.Click();
            Thread.Sleep(500);
            touchAction.Tap(158.0, 740.0);//1
            touchAction.Perform();
            Thread.Sleep(150);
            touchAction.Tap(540.0, 500.0);//2
            touchAction.Perform();
            Thread.Sleep(150);
            touchAction.Tap(542.0, 651.0);//3
            touchAction.Perform();
            Thread.Sleep(150);
            touchAction.Tap(363.0, 1572.0);//4
            touchAction.Perform();
       
            Thread.Sleep(50);
            mainEsiaButton = driver.FindElementByXPath(mainEsiaButtonXpath);
            Thread.Sleep(50);
            mainEsiaButton.Click();
            Thread.Sleep(50);
            checkBoxPolicy = driver.FindElementByXPath(checkBoxPolicyXpath);
            checkBoxMinCifra = driver.FindElementByXPath(checkBoxMinCifraXpath);
            enterEsiaButton =  driver.FindElementByXPath(enterEsiaButtonXpath);
            checkBoxPolicy.Click();
            Thread.Sleep(50);
            enterEsiaButton.Click();
            Thread.Sleep(50);
            try
            {
             var EsiaForm = driver.FindElementByXPath(EsiaFormXpath);
            }
            catch
            {
                checkBoxMinCifra.Click();
                checkBoxPolicy.Click();
                enterEsiaButton.Click();
                try
                {
                   EsiaForm = driver.FindElementByXPath(EsiaFormXpath);
                }
                catch
                {
                    Exit = driver.FindElementByXPath(exitXpath);
                    Exit.Click();
                }

            }

        }
    }
}