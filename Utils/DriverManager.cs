using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace magayaTests.Utils
{
    public static class DriverManager
    {

        public static WindowsDriver<WindowsElement> GetDriver () {
             WindowsDriver<WindowsElement> AppSession = null;
            try
            {
                var AppiumOptions = new OpenQA.Selenium.Appium.AppiumOptions();
                AppiumOptions.AddAdditionalCapability("app", Constants.APP);
                AppiumOptions.AddAdditionalCapability("deviceName", Constants.DEVICE_NAME);
                AppiumOptions.AddAdditionalCapability("platformName", Constants.SO);
                var Session = new WindowsDriver<WindowsElement>(new Uri(Constants.SERVER_URL), AppiumOptions);
            } catch (Exception) {
                var AppiumOptions = new OpenQA.Selenium.Appium.AppiumOptions();
                AppiumOptions.AddAdditionalCapability("app", Constants.ROOT_APP);
                var DesktopSession = new WindowsDriver<WindowsElement>(new Uri(Constants.SERVER_URL), AppiumOptions);
                var MagayaDialog = DesktopSession.FindElementByClassName("#32770");
                var MagayaTopLevelWindowHandle = MagayaDialog.GetAttribute("NativeWindowHandle");
                MagayaTopLevelWindowHandle = (int.Parse(MagayaTopLevelWindowHandle)).ToString("x");

                AppiumOptions = new OpenQA.Selenium.Appium.AppiumOptions();
                AppiumOptions.AddAdditionalCapability("appTopLevelWindow", MagayaTopLevelWindowHandle);
                AppSession = new WindowsDriver<WindowsElement>(new Uri(Constants.SERVER_URL), AppiumOptions);
            }
            AppSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.WAIT);
            return AppSession;
        }

        public static void CloseDriver (WindowsDriver<WindowsElement> AppSession) {
            if (AppSession != null) {
                AppSession.CloseApp();
                AppSession.Quit();
            }
        }
    }
}
