using magayaTests.Utils;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace magayaTests.Windows
{
    class DashboardWindow : BaseWindow
    {
        public WindowsElement WarehousingMenu => AppSession.FindElementByName("Warehousing");
        public WindowsElement TitleBar => AppSession.FindElementByAccessibilityId("TitleBar");
        public WindowsElement WarehouseReceiptListPanel => AppSession.FindElementByName("Warehouse Receipt List");

        public DashboardWindow(WindowsDriver<WindowsElement> Driver) : base(Driver) {
        }

        public Boolean AmILoggedIn() {
            return TitleBar.Text.Contains(Constants.DASHBOARD_TITLE);
        }

        public void ExpandMenu (string Menu) {
            switch (Menu) {
                case "Warehousing":
                    WarehousingMenu.Click();
                    break;
            }
        }

        private void GoToItem (string Menu, string ItemName) {
            ExpandMenu(Menu);
            DoubleClick(AppSession.FindElementByName(ItemName));
            Thread.Sleep(2000);
        }

        public void GoToWarehouseReceiptList () {
            GoToItem("Warehousing", "Warehouse Receipt List");
        }

        public Boolean IsWarehouseReceiptListOpened () {
            return WarehouseReceiptListPanel.Displayed;
        }
    }
}
