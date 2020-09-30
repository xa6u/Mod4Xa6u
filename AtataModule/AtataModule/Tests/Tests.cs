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
                NavigateTo_ControlsPage.ClickAndGo<ControlsPage>()
            //NavigateToAboutMePage().
            //    NavigateToContactsPage()
                ;
        }

        // first commit
    }
}
