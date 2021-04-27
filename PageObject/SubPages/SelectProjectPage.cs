using Molder.Web.Models.PageObjects.Attributes;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Pages;
using PageObject.Elements.Blocks;

namespace PageObject
{
    [Page(Name = "Select Project Page", Url = "https://www.mantisbt.org/bugs/login_select_proj_page.php?ref=bug_report_page.php")]
    class SelectProjectPage : MantisHomePage
    {
        [Block(Name = "Select Project", Locator = "//*[@id=\"select-project-form\"]")]
        SelectProject chooseProject;
    }
}
