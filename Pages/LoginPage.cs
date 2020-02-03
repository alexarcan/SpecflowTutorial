using System;
using System.Collections.Generic;
using static LoginProject.SeleniumHelper;

namespace LoginProject.Pages
{
    class LoginPage : BasePage
    {
        public void NavigateTo(string url)
        {
            Browser.Navigate().GoToUrl(url);
        }

        public void Login(string userName, string password)
        {
            EnterText("UserName", userName, "Name");
            EnterText("Password", password, "Name");
        }

        public void ClickLogin()
        {
             ClickElement("//input[contains(@type, 'submit')]", "Xpath");
        }
    }
}
