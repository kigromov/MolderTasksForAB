using Molder.Web.Models.PageObjects.Attributes;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Pages;
using PageObject.Elements.Blocks;

namespace PageObject
{
    [Page(Name = "MantisHomePage", Url = "https://www.mantisbt.org/bugs/my_view_page.php")]
    public class MantisHomePage : Page
    {

        [Block(Name = "Actions Sidebar", Locator = "//*[@id=\"sidebar\"]")]
        ActionsSidebar actionsSidebar;



    }
}
