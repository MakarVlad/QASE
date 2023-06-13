using Appium;
using AppiumTest;
using OpenQA.Selenium.Appium.Android;
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
            case_id = 1136;
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
                Thread.Sleep(3000);
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
            case_id = 1155;
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
                PinCodeKeyboard.BackPinCodeButton = driver.FindElementByXPath(PinCodeKeyboard.BackPinCodeXpath);
                PinCodeKeyboard.BackPinCodeButton.Click();
                QaseAPI.RunCaseResult(case_id, "passed", comment);
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
            case_id = 1156;
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
        [Test]
        [Order(4)]
        public void ActivEntranceWithBiometriaWithoutBiometricData()
        {
            case_id = 1158;
            try
            {
                BiometriaWindow = driver.FindElementByXPath(activateBiometriaWindowXpath);
                ActivBiometriaYesButton = driver.FindElementByXPath(activeBiometriaYesXpath);
                ActivBiometriaYesButton.Click();
                AddBiometricDataWindow = driver.FindElementByXPath(addBiometricDataXpath);
                BiometricDataGoToSettingsNoButton = driver.FindElementByXPath(biometricDataGoToSettingsNoButton);
                BiometricDataGoToSettingsNoButton.Click();
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

                QaseAPI.RunCaseResult(case_id, "passed", comment);
            }
            catch (Exception ex)
            {
                QaseAPI.RunCaseResult(case_id, "failed", ex.Message);
                Assert.Fail(ex.Message);
            }


        }
        [Test]
        [Order(5)]
        public void EntranceEsiaWithoutBiometria()
        {
            case_id = 1157;
            try
            {
                BiometriaWindow = driver.FindElementByXPath(activateBiometriaWindowXpath);
                ActivBiometriaNoButton = driver.FindElementByXPath(activeBiometriaNoXpath);
                ActivBiometriaNoButton.Click();
                MyOrdersButton = driver.FindElementByXPath(myOrdersXpath);
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
