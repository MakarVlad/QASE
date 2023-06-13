using Appium;
using AppiumTest;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium.Android
{
    [TestFixture]
    [Order(0)]
    internal class GoToLoginMethods : AndroidTestsInit
    {
        [Test]
        [Order(0)]
        public void GoToLoginMethodOnMainPage()
        {
            case_id = 1137;
            try
            {
                mainEsiaButton = driver.FindElementByXPath(mainEsiaButtonXpath);
                mainEsiaButton.Click();
                enterEsiaButton = driver.FindElementByXPath(enterEsiaButtonXpath);
                enterEsiaButton.Click();
                Exit = driver.FindElementByXPath(exitXpath);
                Exit.Click();
               
                QaseAPI.RunCaseResult(case_id, "passed", comment);
            }
            catch (Exception ex)
            {
                QaseAPI.RunCaseResult(case_id, "failed", ex.Message);
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        [Order(1)]
        public void GoToLoginMethodTapOnBell()
        {
            case_id = 1139;
            try
            {
                Bell = driver.FindElementByXPath(bellXpath);
                Bell.Click();
                BellEnterEsiaButton = driver.FindElementByXPath(bellEnterEsiaButtXpath);
                BellEnterEsiaButton.Click();
                enterEsiaButton = driver.FindElementByXPath(enterEsiaButtonXpath);
                enterEsiaButton.Click();
                Exit = driver.FindElementByXPath(exitXpath);
                Exit.Click();
                BellBackButton = driver.FindElementByXPath(notificatBackButtonXpath);
                BellBackButton.Click();
              
                QaseAPI.RunCaseResult(case_id, "passed", comment);
            }
            catch (Exception ex)
            {
                QaseAPI.RunCaseResult(case_id, "failed", ex.Message);
                Assert.Fail(ex.Message);
            }

        }
        [Test]
        [Order(2)]
        public void GoToLoginMethodInSideBar()
        {
            case_id = 1138;
            try
            {
                UserIcon = driver.FindElementByXPath(userIconXpath);
                UserIcon.Click();
                EnterButtonInSideBar = driver.FindElementByXPath(enterButtonInSideBarXpath);
                EnterButtonInSideBar.Click();
                enterEsiaButton = driver.FindElementByXPath(enterEsiaButtonXpath);
                enterEsiaButton.Click();
                Exit = driver.FindElementByXPath(exitXpath);
                Exit.Click();
             
                QaseAPI.RunCaseResult(case_id, "passed", comment);
            }
            catch (Exception ex)
            {
                QaseAPI.RunCaseResult(case_id, "failed", ex.Message);
                Assert.Fail(ex.Message);
            }

        }
    }
}
