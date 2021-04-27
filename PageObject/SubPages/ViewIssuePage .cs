using Molder.Web.Models.PageObjects.Attributes;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Pages;
using PageObject.Elements.Blocks;

namespace PageObject.SubPages
{
    [Page(Name = "View Issue Page", Url = "https://www.mantisbt.org/bugs/view.php?id=28361")]
    class ViewIssuePage : MantisHomePage
    {
        [Block(Name = "View Issue", Locator = "//*[@id=\"main-container\"]/div[2]/div[2]")]
        ViewIssue viewIssue;
    }
}
