using Atata;
using NUnit.Framework;


namespace AtataModule
{

   // using _ = Tests;
    [TestFixture]
    public class Tests : TestBase
    {

        [TestCase(TestName = "Load control check/Table elements verification")]
        [Category(Categories.C1)]
        public void AtataMod()
        {
            OpenSite().
                Dropdown.Click().
                NavigateTo_WebDriverCourcePage.ClickAndGo<WebDriverCoursePage>().
                NavigateTo_SearchElementsOnThePage.ClickAndGo<WebElementsPage>().
                NavigateTo_ControlsPage.ClickAndGo<ControlsPage>().
                CompanyTable.Rows[x=>x.Name =="Facebook" && x.Budget == "12300"].Should.Exist().
                TableToTest.Items[x => x.Name == "Facebook" && x.Budget == "12300"].Should.Exist()
              //NavigateToAboutMePage().
              //NavigateToContactsPage()
                ;
        }

        // first commit
    }
}
