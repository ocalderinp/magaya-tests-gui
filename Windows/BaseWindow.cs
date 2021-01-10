using magayaTests.Utils;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magayaTests.Windows
{
    public class BaseWindow
    {
        protected WindowsDriver<WindowsElement> AppSession;

        public BaseWindow(WindowsDriver<WindowsElement> Driver) {
            AppSession = Driver;
        }

        protected void SwitchToFirstWindow () {
            DriverUtils.SwitchToFirstWindow(AppSession);
        }

        protected void DoubleClick(WindowsElement Element)
        {
            DriverUtils.DoubleClick(AppSession, Element);
        }
    }
}
