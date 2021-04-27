using Molder.Web.Models.PageObjects.Attributes;
using Molder.Web.Models.PageObjects.Elements;
using Molder.Web.Models.PageObjects.Pages;

namespace PageObject
{
    [Page(Name = "LoginPasswordPage", Url = "https://www.mantisbt.org/bugs/login_password_page.php")]
    class LoginPasswordPage:Page
    {
        [Element(Name = "LoginButton", Locator = "//*[@id=\"login-form\"]/fieldset/input[@type=\"submit\"]")]
        Button loginButton;

        [Element(Name = "Password", Locator = "//*[@id=\"password\"]")]
        Input password;
    }
}
