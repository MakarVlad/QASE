using AppiumTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium.Android
{
    [TestFixture]
    [Order(2)]
    internal class SideBar:AndroidTestsInit
    {
        [Test]
        [Order(0)]
        public void SideBarElementsAfterAuthorization()
        {
            case_id = 1166;
            try
            {
                UserIcon = driver.FindElementByXPath(userIconXpath);
                UserIcon.Click();
                ExitAccountButton = driver.FindElementByXPath(exitAccountXpath);
                FeedBackInSideBar = driver.FindElementByXPath(feedBackXpath);
                SettingsInSideBar = driver.FindElementByXPath(settingsInSideBarXpath);
                PersonalDataInSideBar = driver.FindElementByXPath(personalDataBlockInSideBarXpath);
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
        public void LinkInPersonalData()
        {
            case_id = 1167;
            try
            {
                PersonalDataInSideBar = driver.FindElementByXPath(personalDataBlockInSideBarXpath);
                PersonalDataInSideBar.Click();
                BlockWithLinkInPersonalData = driver.FindElementByXPath(blockWithLinkInPersonalDataXpath);
            }
            catch(Exception ex) 
            {
                QaseAPI.RunCaseResult(case_id, "failed", ex.Message);
                Assert.Fail(ex.Message);
            }
        }


    }
}
