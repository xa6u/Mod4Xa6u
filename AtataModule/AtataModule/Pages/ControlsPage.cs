using Atata;

namespace AtataModule
{
    using _ = ControlsPage;

    //[WaitForElement(WaitBy.XPath, "//span[text()='100']"), WaitFor(Until.Visible)]
    public class ControlsPage : BasePage<_>
    {

        //[FindByValue("//span[text()='100']")]
        //[WaitFor(Until.Visible)]
        //public Control<_> Looper { get; private set; }



        [FindByXPath("//div[@class='elementor-widget-container']//table/tbody/tr")]
        public Table<CompanyTableRow, _> CompanyTable { get; private set; }

        public class CompanyTableRow : TableRow<_>
        {
            [FindByXPath(".//td[1]")]
            public Text<_> Name { get; private set; }

            [FindByXPath(".//td[2]")]
            public Text<_> Budget { get; private set; }

        }


        [FindByXPath("//div[@class='elementor-widget-container']//table/tbody/tr")]
        public ItemsControl<ItProjectsItems, _> TableToTest { get; private set; }

        public class ItProjectsItems : Control<_>
        {
            [FindByXPath(".//td[1]")]
            public Text<_> Name { get; private set; }

            [FindByXPath(".//td[2]")]
            public Text<_> Budget { get; private set; }

        }

    }

}
