using Atata;


namespace AtataModule
{
    using _ = MainPage;
    public class MainPage : BasePage<_>
    {

        [FindByXPath("//nav[@class='header--row header-main hide-on-mobile hide-on-tablet layout-full-contained nv-navbar header--row']//following-sibling::div/span[@class='caret']"), ControlDefinition]
        public Button<_, _> Dropdown { get; private set; }

        [FindByXPath("//a[contains(text(), 'Курс: WebDriver, C#')]"), ControlDefinition]
        public Link<WebDriverCoursePage, _> NavigateTo_WebDriverCourcePage { get; private set; }



    }
}
