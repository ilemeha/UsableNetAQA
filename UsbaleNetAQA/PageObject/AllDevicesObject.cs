using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsbaleNetAQA.PageObject
{
    public class AllDevicesObject
    {
        private IWebDriver _driver;

        public AllDevicesObject(IWebDriver driver)
        {
            _driver = driver;
        }
        //Login to your UsableNet account
        private IWebElement LoginInput => _driver.FindElement(By.Id("login-email"));
        private IWebElement PasswordInput => _driver.FindElement(By.Id("login-password"));
        private IWebElement ClickLogin => _driver.FindElement(By.XPath("*//form/fieldset[3]/button"));

        //Locate New Quick test Elements
        private IWebElement WhirlpoolBtn => _driver.FindElement(By.XPath("//a[contains(text(),'Whirlpool')]"));
        private IWebElement NewQuickTestBtn => _driver.FindElement(By.XPath("//a[contains(text(),'New quick test')]"));
        private IWebElement TypePageName => _driver.FindElement(By.Id("editor-basic-name"));
        private IWebElement TypePageURL => _driver.FindElement(By.XPath("//fieldset[2]/div[2]/input"));
        private IWebElement LocateToDropdown => _driver.FindElement(By.XPath("//fieldset[@class='magical-dropdown dropdown']"));
        private IWebElement CreateBbtn => _driver.FindElement(By.XPath("//button[@type='submit']"));
        private IWebElement ScanedPageName => _driver.FindElement(By.XPath("//a[@class='item-name-label']"));
        private IWebElement CloseRecentUrl => _driver.FindElement(By.XPath("//a[@title='Close editor']"));

        //Method to Login to your UsableNet account
        public void FillOutLoginData(string loginName, string loginPassw)
        {
            LoginInput.SendKeys(loginName);
            PasswordInput.SendKeys(loginPassw);

        }
        public void ClickLoginButton()
        {
            ClickLogin.Click();
        }

        //Methods for New Quick test Elements(what action to perform)
        public void ClickWhirpoolButton()
        {
            WhirlpoolBtn.Click();
        }

        public void ClickNewQuickTestButton()
        {
            NewQuickTestBtn.Click();
        }
        public void TypeProjectName(string project1)
        {
            TypePageName.SendKeys(project1);
        }

        public void TypeProjectURL(string projectURL)
        {
            TypePageURL.SendKeys(projectURL);
        }
        public void ClickDropdownButton()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-0")).Click();
        }
        public void ClickDropdownButton1()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-1")).Click();
        }

        public void ClickDropdownButton2()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-2")).Click();
        }
        public void ClickDropdownButton3()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-3")).Click();
        }
        public void ClickDropdownButton4()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-4")).Click();
        }
        //Mobile
        public void ClickDropdownButton5()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-5")).Click();
        }
        public void ClickDropdownButton6()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-6")).Click();
        }
        public void ClickDropdownButton7()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-7")).Click();
        }
        public void ClickDropdownButton8()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-8")).Click();
        }
        public void ClickDropdownButton9()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-9")).Click();
        }
        public void ClickDropdownButton10()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-10")).Click();
        }
        public void ClickDropdownButton12()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-12")).Click();
        }
        public void ClickDropdownButton13()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-13")).Click();
        }

        public void ClickDropdownButton14()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-14")).Click();
        }
        public void ClickCreateButton()
        {
            CreateBbtn.Click();
        }

        public void OpenScanedPageName()
        {
            ScanedPageName.Click();
            string url = _driver.Url;
            Console.WriteLine($" {url} ");
        }
        public void CloseScanedPage()
        {
            CloseRecentUrl.Click();
        }
    }
}
