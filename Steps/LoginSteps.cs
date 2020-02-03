using System;
using LoginProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace LoginProject.Steps
{
    [Binding]
    public class LoginSteps : TechTalk.SpecFlow.Steps
    {
        private LoginPage loginPage = new LoginPage();
        private UserForm userForm = new UserForm();

        [Given(@"I login into the application")]
        public void GivenILoginIntoTheApplication(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.NavigateTo("http://executeautomation.com/demosite/Login.html");
            loginPage.Login(data.UserName, data.Password);
            loginPage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            userForm.EnterUserDetails(data.Title, data.FirstName, data.Initial);
        }

        /*************************RE-USING EXISTING STEPS********************************/
        [Given(@"I login and enter user details")]
        public void GivenILoginAndEnterUserDetails()
        {
            //Create a column header
            string[] colHeader = { "UserName", "Password" };
            string[] row = { "admin", "admin" };

            var table = new Table(colHeader);
            table.AddRow(row);

            //Call another step method from the class
            Given("I login into the application", table);

            string[] colHeaderForUserForm = {"Title", "Initial", "FirstName" };
            string[] rowForUserForm = {"Mr.", "A", "Alex"};
            table = new Table(colHeaderForUserForm);
            table.AddRow(rowForUserForm);
            Given("I enter the following details", table);

        }

        [Then(@"I click save button")]
        public void ThenIClickSaveButton()
        {

        }

    }
}
