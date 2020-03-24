using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UsbaleNetAQA.Configuration;
using UsbaleNetAQA.PageObject;
using UsbaleNetAQA.WebDriver;

namespace UsbaleNetAQA.UTestToRun
{
    [TestFixture]
    public class AllDevicesAQArun
    {
        [Test]
        public void AllDevicesAQArunScript()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl(Config.GetUrl());

                var usableNetSite = new AllDevicesObject(driver);

                //Change here to your UsableNet credentailm, Project Name, Page URL
                var loginName = "kmilbourne@aislerocket.com";
                var loginPassw = "ars4LYFE";
                var pageName = "Test5-032320";
                var pageURL = "https://www.maytag.com/faux-stage/extra-power.html";


                usableNetSite.FillOutLoginData(loginName, loginPassw);
                usableNetSite.ClickLoginButton();

                //Desktop runs
                Console.WriteLine($"Desktop");
                //Console.WriteLine($"Chrome 78 (Windows)");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(3000);

                //Console.WriteLine($"Edge (Windows)");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton1();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(3000);

                //Console.WriteLine($"Firefox 53 (Windows)");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton2();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(3000);


                //Console.WriteLine($"Internet Explorer 11 (Windows)");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(2000);
                //usableNetSite.ClickDropdownButton3();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(5000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(5000);

                Console.WriteLine($"Safari 13(macOS))");
                usableNetSite.ClickNewQuickTestButton();
                usableNetSite.TypeProjectName(pageName);
                Thread.Sleep(1000);
                usableNetSite.TypeProjectURL(pageURL);
                Thread.Sleep(2000);
                usableNetSite.ClickDropdownButton4();
                Thread.Sleep(2000);
                usableNetSite.ClickCreateButton();
                Thread.Sleep(70000);
                usableNetSite.OpenScanedPageName();
                Thread.Sleep(5000);
                usableNetSite.CloseScanedPage();
                Thread.Sleep(5000);


                //Mobile and Ipads
                Console.WriteLine($"Mobile devices and iPads");
                Console.WriteLine($"Apple iPad 7th generation (iOS 13)");
                usableNetSite.ClickNewQuickTestButton();
                usableNetSite.TypeProjectName(pageName);
                Thread.Sleep(1000);
                usableNetSite.TypeProjectURL(pageURL);
                Thread.Sleep(1000);
                usableNetSite.ClickDropdownButton5();
                Thread.Sleep(2000);
                usableNetSite.ClickCreateButton();
                Thread.Sleep(70000);
                usableNetSite.OpenScanedPageName();
                Thread.Sleep(3000);
                usableNetSite.CloseScanedPage();
                Thread.Sleep(2000);

                //Console.WriteLine($"Apple iPad Pro 11 inches (iOS 13) ");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton6();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Apple iPhone 11 Pro (iOS 13) ");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton7();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Apple iPhone 11 Pro Max (iOS 13)");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton8();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Apple iPhone 8 (iOS 13)");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton9();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(3000);

                //Console.WriteLine($"Google Pixel 4");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton10();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Samsung A50");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton12();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Samsung Galaxy S10");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton13();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"UsableNet API HTTP Client");
                //usableNetSite.ClickNewQuickTestButton();
                //usableNetSite.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //usableNetSite.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //usableNetSite.ClickDropdownButton14();
                //Thread.Sleep(2000);
                //usableNetSite.ClickCreateButton();
                //Thread.Sleep(70000);
                //usableNetSite.OpenScanedPageName();
                //Thread.Sleep(3000);
                //usableNetSite.CloseScanedPage();
                //Thread.Sleep(2000);



            }
        }
    }
}

