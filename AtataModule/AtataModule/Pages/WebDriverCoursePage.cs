using Atata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataModule
{
    using _ = WebDriverCoursePage;
    public class WebDriverCoursePage : BasePage<_>
    {
        [FindByXPath("//a[text()='Поиск элементов на странице']"), ControlDefinition]
        public Control<_> NavigateTo_SearchElementsOnThePage { get; private set; }


    }
}
