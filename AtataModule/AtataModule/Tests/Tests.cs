using NUnit.Framework;


namespace AtataModule.Tests
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
                WebDriverCourcePage.Click().
                SearchElementsOnThePage.Click().
                ControlsPage.Click().
                NavigateToAboutMePage()
                //NavigateToContactsPage()
                ;
        }

        // first commit
    }
}
