using Molder.Web.Models.PageObjects.Attributes;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Pages;
using PageObject.Elements.Blocks;

namespace PageObject.SubPages
{
    [Page(Name = "Enter Issue Page")]
    class EnterIssuePage : MantisHomePage
    {
        [Block(Name = "Enter Issue", Locator = "//*[@id=\"report_bug_form\"]/div")]
        EnterIssue enterIssue;
    }
}
