using magayaTests.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace magayaTests
{
    [TestClass]
    public class DashboardTests : BaseTest
    {
        LoginWindow LoginWindow;
        DashboardWindow DashboardWindow;

        [TestMethod]
        public void IsWarehouseReceiptListAccessibleTest () {
            LoginWindow = new LoginWindow(AppSession);
            DashboardWindow = LoginWindow.Login();
            Assert.IsTrue(DashboardWindow.AmILoggedIn(), "I SHOULD BE LOGGED IN");
            DashboardWindow.GoToWarehouseReceiptList();
            Assert.IsTrue(DashboardWindow.IsWarehouseReceiptListOpened(), "THE WAREHOUSE RECEIPT LIST SHOULD BE OPENED");
        }
    }
}
