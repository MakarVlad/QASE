using Appium;
using AppiumTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appium.Android
{
    [TestFixture]
    [Order(1)]
    internal class LoginWithEsia : AndroidTestsInit
    {
        [Test]
        [Order(0)]
        public void EntranceEsiaWithoutCheckbox()
        {
            case_id = 1135;
            try
            {
                mainEsiaButton = driver.FindElementByXPath(mainEsiaButtonXpath);
                mainEsiaButton.Click();
                enterEsiaButton = driver.FindElementByXPath(enterEsiaButtonXpath);
                enterEsiaButton.Click();
                checkBoxPolicy = driver.FindElementByXPath(checkBoxPolicyXpath);
                checkBoxMinCifra = driver.FindElementByXPath(checkBoxMinCifraXpath);

                checkBoxPolicy.Click();
                enterEsiaButton.Click();
                checkBoxMinCifra.Click();
                checkBoxPolicy.Click();
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
        public void LoginWithEsiaTestUser()
        {
            try
            {
                mainEsiaButton = driver.FindElementByXPath(mainEsiaButtonXpath);
                mainEsiaButton.Click();
                checkBoxPolicy = driver.FindElementByXPath(checkBoxPolicyXpath);
                checkBoxPolicy.Click();
                checkBoxMinCifra = driver.FindElementByXPath(checkBoxMinCifraXpath);
                checkBoxMinCifra.Click();
                enterEsiaButton = driver.FindElementByXPath(enterEsiaButtonXpath);
                enterEsiaButton.Click();
                LoginTextBoxEsia = driver.FindElementByXPath(loginTextBoxEsiaXpath);
                LoginTextBoxEsia.SendKeys("00000060006");
                PasswordTextBoxEsia = driver.FindElementByXPath(passwordTextBoxEsiaXpath);
                PasswordTextBoxEsia.SendKeys("11111111");
                Enter = driver.FindElementByXPath(enterXpath);
                Enter.Click();
                Thread.Sleep(2000);
                PinCodeKeyboard.PinCodeView = driver.FindElementByXPath(PinCodeKeyboard.PinCodeViewXpath);
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
        public void EnterNotCorrectPinCode()
        {
            try 
            {
                for (int i = 0; i <= 1; i++)
                {
                    if(i == 1)
                    {
                        PinCodeKeyboard.OneButton = driver.FindElementByXPath(PinCodeKeyboard.OneXpath);
                        PinCodeKeyboard.OneButton.Click();
                        PinCodeKeyboard.NineButton = driver.FindElementByXPath(PinCodeKeyboard.NineXpath);
                        PinCodeKeyboard.NineButton.Click();
                        PinCodeKeyboard.ThreeButton = driver.FindElementByXPath(PinCodeKeyboard.ThreeXpath);
                        PinCodeKeyboard.ThreeButton.Click();
                        PinCodeKeyboard.FourButton = driver.FindElementByXPath(PinCodeKeyboard.FourXpath);
                        PinCodeKeyboard.FourButton.Click();
                        PinCodeKeyboard.FiveButton = driver.FindElementByXPath(PinCodeKeyboard.FiveXpath);
                        PinCodeKeyboard.FiveButton.Click();
                    }
                    else
                    {
                        PinCodeKeyboard.OneButton = driver.FindElementByXPath(PinCodeKeyboard.OneXpath);
                        PinCodeKeyboard.OneButton.Click();
                        PinCodeKeyboard.TwoButton = driver.FindElementByXPath(PinCodeKeyboard.TwoXpath);
                        PinCodeKeyboard.TwoButton.Click();
                        PinCodeKeyboard.ThreeButton = driver.FindElementByXPath(PinCodeKeyboard.ThreeXpath);
                        PinCodeKeyboard.ThreeButton.Click();
                        PinCodeKeyboard.FourButton = driver.FindElementByXPath(PinCodeKeyboard.FourXpath);
                        PinCodeKeyboard.FourButton.Click();
                        PinCodeKeyboard.FiveButton = driver.FindElementByXPath(PinCodeKeyboard.FiveXpath);
                        PinCodeKeyboard.FiveButton.Click();
                    }
                }

            }
            catch (Exception ex) 
            {
                QaseAPI.RunCaseResult(case_id, "failed", ex.Message);
                Assert.Fail(ex.Message);
            }
        }
        [Test]
        [Order(3)]
        public void EnterCorrectPinCode()
        {
            try
            {
                for(int i = 0;i <= 1; i++)
                {
                    PinCodeKeyboard.OneButton = driver.FindElementByXPath(PinCodeKeyboard.OneXpath);
                    PinCodeKeyboard.OneButton.Click();
                    PinCodeKeyboard.TwoButton = driver.FindElementByXPath(PinCodeKeyboard.TwoXpath);
                    PinCodeKeyboard.TwoButton.Click();
                    PinCodeKeyboard.ThreeButton = driver.FindElementByXPath(PinCodeKeyboard.ThreeXpath);
                    PinCodeKeyboard.ThreeButton.Click();
                    PinCodeKeyboard.FourButton = driver.FindElementByXPath(PinCodeKeyboard.FourXpath);
                    PinCodeKeyboard.FourButton.Click();
                    PinCodeKeyboard.FiveButton = driver.FindElementByXPath(PinCodeKeyboard.FiveXpath);
                    PinCodeKeyboard.FiveButton.Click();
                }
                BiometriaWindow = driver.FindElementByXPath(activateBiometriaWindowXpath);
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
