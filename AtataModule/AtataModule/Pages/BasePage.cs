using Atata;
using AtataModule.Pages;

namespace AtataModule.Pages
{

    public abstract class BasePage<TOwner> : Page<TOwner>
        where TOwner : BasePage<TOwner>
    {
        public AboutMePage NavigateToAboutMePage()
        {
            return Go.To<AboutMePage>(url: "http://www.yesk.com.ua/705ea-about/");

        }

        public ContactsPage NavigateToContactsPage()
        {
            return Go.To<ContactsPage>(url: "http://www.yesk.com.ua/705ea-contact/");

        }

        public WebDriverCoursePage NavigateToWebDriverCourcePage()
        {
            return Go.To<WebDriverCoursePage>(url: "http://www.yesk.com.ua/705ea-contact/");

        }
    }
}
