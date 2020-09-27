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
                .UseChrome()
                .UseBaseUrl("http://www.yesk.com.ua/")
                .Build()
                ;

                
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
