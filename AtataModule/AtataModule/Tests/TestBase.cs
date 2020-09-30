using Atata;
using NUnit.Framework;

namespace AtataModule
{
    public abstract class TestBase
    {
        [SetUp]
        public void SetUo()
        {
            AtataContext.Configure()
                .UseChrome().WithArguments("start-maximized")
                //.UseBaseUrl("http://www.yesk.com.ua/")
                .Build()
                ;                            
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }

        public MainPage OpenSite()
        {
            return Go.To<MainPage>(url: "http://www.yesk.com.ua/");

        }
    }
}
