using magayaTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magayaTests
{
    [TestClass]
    public class BaseTest
    {
        protected static WindowsDriver<WindowsElement> AppSession;
        [TestInitialize]
        public void TestInitialize() {
            AppSession = DriverManager.GetDriver();
        }

        [TestCleanup()]
        public void Cleanup () {
            DriverManager.CloseDriver(AppSession);
        }
    }
}
