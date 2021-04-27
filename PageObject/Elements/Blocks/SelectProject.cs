using Molder.Web.Models.PageObjects.Blocks;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Attributes;

namespace PageObject.Elements.Blocks
{
    class SelectProject : Block
    {
        public SelectProject(string name, string locator, bool optional) : base(name, locator, optional) { }

        [Element(Name = "Dropdown List", Locator = "//*[@id=\"select-project-id\"]")]
        Dropdown dropdownList;

        [Element(Name = "Submit", Locator = "//input[@type=\"submit\"]")]
        Button submitButton;
        
    }
}
