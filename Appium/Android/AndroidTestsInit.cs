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
using OpenQA.Selenium.Appium.Service;
using AppiumTest;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using OpenQA.Selenium;

namespace Appium.Android
{

    public class AndroidTestsInit
    {
        public AndroidDriver<AndroidElement> driver;
        public ITouchAction touchAction;
        public IAlert? alert;
        public int case_id;
        public string comment = "OK";
        public string mainEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.widget.ScrollView/android.view.View[1]/android.view.View/android.widget.Button\r\n";
        public string checkBoxPolicyXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[1]\r\n";
        public string checkBoxMinCifraXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.CheckBox[2]\r\n";
        public string enterEsiaButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.view.View[1]/android.widget.Button";
        public string EsiaFormXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.ViewGroup";
        public string exitXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View\r\n";
        public string closeOnboardXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]\r\n";
        public string notificationsOnboardXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.widget.TextView\r\n";
        public string bellXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View/android.view.View[4]\r\n";
        public string bellEnterEsiaButtXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.widget.Button\r\n";
        public string notificatBackButtonXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.Button\r\n";
        public string userIconXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View/android.view.View[1]\r\n";
        public string enterButtonInSideBarXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[1]/android.widget.Button";
        public string loginTextBoxEsiaXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.ViewGroup/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.view.View[2]/android.view.View[1]/android.widget.EditText\r\n";
        public string passwordTextBoxEsiaXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.ViewGroup/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.widget.EditText\r\n";
        public string enterXpath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.compose.ui.platform.ComposeView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.ViewGroup/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.view.View/android.view.View[2]/android.view.View[3]/android.widget.Button\r\n";
        public string activateBiometriaWindowXpath = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.View/android.view.View/android.view.View\r\n";
        public AndroidElement? mainEsiaButton;
        public AndroidElement? checkBoxPolicy;
        public AndroidElement? enterEsiaButton;
        public AndroidElement? checkBoxMinCifra;
        public AndroidElement? EsiaForm;
        public AndroidElement? Exit;
        public AndroidElement? CloseOnboard;
        public AndroidElement? NotificationsOnboard;
        public AndroidElement? Bell;
        public AndroidElement? BellEnterEsiaButton;
        public AndroidElement? BellBackButton;
        public AndroidElement? UserIcon;
        public AndroidElement? EnterButtonInSideBar;
        public AndroidElement? LoginTextBoxEsia;
        public AndroidElement? PasswordTextBoxEsia;
        public AndroidElement? Enter;
        public AndroidElement? BiometriaWindow;

        public AndroidTestsInit() { }

        [SetUp]

        public void Init()
        {
            AppiumOptions appiumOptions = new AppiumOptions();
            string appPath = Path.Combine(Environment.CurrentDirectory, "MSP_v.1.2.0.apk");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 3");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13.0");


            ///////ВКЛЮЧИТЬ ДЛЯ УСТАНОВКИ APK (БЕДА С ОНБОРДИНГОМ)
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, appPath); 
            //appiumOptions.AddAdditionalCapability("uiautomator2ServerInstallTimeout", 600000);
            //appiumOptions.AddAdditionalCapability("androidInstallTimeout", 600000);
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.NoReset, true);

            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.FullReset, false);
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appiumOptions, TimeSpan.FromMinutes(5));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            touchAction = new TouchAction(driver);
            QaseAPI.RunsInfo();


        }
        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}

