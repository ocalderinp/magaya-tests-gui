using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magayaTests.Utils
{
    public static class DriverUtils
    {
        private static Actions Actions;

        public static void DoubleClick (WindowsDriver<WindowsElement> Session, WindowsElement Element) {
            Actions = new Actions(Session);
            Actions.MoveToElement(Element).DoubleClick().Build().Perform();
        }

        public static void SwitchToFirstWindow (WindowsDriver<WindowsElement> Session) {
            Session.SwitchTo().Window(Session.WindowHandles.First());
        }

    }
}
