using static LoginProject.SeleniumHelper;

namespace LoginProject.Pages
{
    class UserForm : BasePage
    {
        public void EnterUserDetails(string title, string firstName, string initial)
        {
            SelectDropdown("TitleId", title, "Id");
            EnterText("Initial", initial, "Id");
            EnterText("FirstName", firstName, "Id");
        }
    }
}
