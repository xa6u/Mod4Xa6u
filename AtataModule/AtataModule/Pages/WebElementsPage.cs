using Atata;


namespace AtataModule.Pages
{
    using _ = WebElementsPage;
    public class WebElementsPage : BasePage<_>
    {
        [FindByXPath("//*[@id='post-484']/div[3]/div/div/div/section[4]/div/div/div/div/div/div/div/div/h3/a"), ControlDefinition]
        public Link<ControlsPage> ControlsPage { get; private set; }
    }
}
