using Molder.Web.Models.PageObjects.Attributes;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Pages;

namespace PageObject
{
    [Page(Name = "Login Page", Url = "https://www.mantisbt.org/bugs/login_page.php")]
    class LoginPage:Page
    {
        [Element(Name = "LoginButton", Locator = "//*[@id=\"login-form\"]/fieldset/input[@type=\"submit\"]")]
        Button loginButton;

        [Element(Name = "UserName", Locator = "//*[@id=\"username\"]")]
        Input userName;
    }
}
