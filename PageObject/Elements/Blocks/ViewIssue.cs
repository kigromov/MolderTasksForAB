using Molder.Web.Models.PageObjects.Blocks;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Attributes;

namespace PageObject.Elements.Blocks
{
    class ViewIssue : Block
    {
        public ViewIssue(string name, string locator, bool optional) : base(name, locator, optional) { }

        [Element(Name = "Summary", Locator = "//td[contains(@class, 'bug-summary')]")]
        Element summary;

        [Element(Name = "Description", Locator = "//td[contains(@class, 'bug-description')]/p")]
        Element description;


    }
}
