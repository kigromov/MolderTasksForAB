using Molder.Web.Models.PageObjects.Blocks;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Attributes;

namespace PageObject.Elements.Blocks
{
    class EnterIssue : Block
    {
        public EnterIssue(string name, string locator, bool optional) : base(name, locator, optional) { }

        [Element(Name = "Summary", Locator = "//*[@id=\"summary\"]")]
        Input summary;

        [Element(Name = "Description", Locator = "//*[@id=\"description\"]")]
        Input description;

        [Element(Name = "Submit Issue", Locator = "//input[@type=\"submit\"]")]
        Button submitIssue;


        [Element(Name = "Description Title", Locator = "//label[@for=\"description\"]")]
        Input description1;
        


    }
}
