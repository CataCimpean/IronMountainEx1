using IronMountainEx;
using IronMountainEx1.Utils.Components;

namespace IronMountainEx1.Controller
{
    public class LogoutController
    {
        private Form1 form1;

        public LogoutController(Form1 form1)
        {
            this.form1 = form1;
            Logout();
        }

        private void Logout()
        {
            UpdateComponents();
        }
    
        private void UpdateComponents()
        {
            form1.GetUsernameFromLogin().Text = string.Empty;
            form1.GetPasswordFromLogin().Text = string.Empty;
            form1.GetTextBoxInfo().Text = string.Empty;
            ComponentsUtil.SetGroupBoxVisibility(form1.GetAuthenticationGroupBox());
            ComponentsUtil.SetGroupBoxVisibility(form1.GetGroupBoxOptions(),true);
            ComponentsUtil.SetButtonVisibility(form1.GetLogoutButton(),true);
            ComponentsUtil.SetLabelVisibility(form1.GetWelcomeLabel(),true);
            ComponentsUtil.SetTabControlVisibility(form1.GetTabControlMenu(),true);
        }
    }
}
