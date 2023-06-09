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
using System.Runtime.InteropServices;
using Appium.Android;

namespace AppiumTest
{
    //[TestFixture]  
    //[Order(0)]
    public class EnteranceInAppAndOnboard: AndroidTestsInit
    {
       // [Test]
        
        public void Onboard()
        {
            case_id = 1132;
            try
            { 
                try
                {
                    NotificationsOnboard = driver.FindElementByXPath(notificationsOnboardXpath);//если отключены уведы нажать Напомнить позже
                    NotificationsOnboard.Click();
                }
                catch { }
                CloseOnboard = driver.FindElementByXPath(closeOnboardXpath);
                CloseOnboard.Click();

                touchAction.Tap(158.0, 740.0);//1
                touchAction.Perform();

                touchAction.Tap(540.0, 500.0);//2
                touchAction.Perform();

                touchAction.Tap(542.0, 651.0);//3
                touchAction.Perform();
       
                touchAction.Tap(375.0, 1568.0);//4
                touchAction.Perform();

              
                QaseAPI.RunCaseResult(case_id, "passed", comment);
            }
            catch(Exception ex) 
            {
                
                QaseAPI.RunCaseResult(case_id, "failed", ex.Message);
                Assert.Fail(ex.Message);
            }
         
        }
    }
}