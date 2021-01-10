using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace magayaTests.Windows
{
    class LoginWindow : BaseWindow
    {
        public WindowsElement EmployeeDropdown => AppSession.FindElementByClassName("ComboBox");
        public WindowsElement PasswordInput => AppSession.FindElementByClassName("Edit");
        public WindowsElement LoginButton => AppSession.FindElementByAccessibilityId("1");
        public LoginWindow (WindowsDriver<WindowsElement> Driver) : base(Driver) {
        }

        public DashboardWindow Login () {
            SelectUserName();
            PasswordInput.SendKeys(Utils.Config.GetPassword());
            LoginButton.Click();
            Thread.Sleep(3000);
            SwitchToFirstWindow();            
            return new DashboardWindow(AppSession);
        }

        private void SelectUserName () {
            EmployeeDropdown.Click();
            EmployeeDropdown.SendKeys(Keys.Down);
            EmployeeDropdown.SendKeys(Keys.Enter);
        }
    }
}
