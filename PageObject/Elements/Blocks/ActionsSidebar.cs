using Molder.Web.Models.PageObjects.Blocks;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Attributes;


namespace PageObject.Elements.Blocks
{
    class ActionsSidebar : Block
    {
        public ActionsSidebar(string name, string locator, bool optional) : base(name, locator, optional) { }

        [Element(Name = "View Issue", Locator = "//span[contains(text(),'Список задач') or contains(text(),'View Issue')]")]
        Button viewButton;

        [Element(Name = "Report Issue", Locator = "//span[contains(text(),'Создать задачу') or contains(text(),'Report Issue')]")]
        Button reportButton;

        
    }
}
