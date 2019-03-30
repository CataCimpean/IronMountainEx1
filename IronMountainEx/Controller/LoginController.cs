using IronMountainEx;
using IronMountainEx1.DAL;
using IronMountainEx1.DTO;
using IronMountainEx1.Utils.Components;
using IronMountainEx1.Utils.RegExr;
using System;
using System.Drawing;

namespace IronMountainEx1.Controller
{
    public class LoginController
    {
        private UserDTO userLogged;
        private Form1 form1;

        public LoginController(Form1 form1)
        {
            this.form1 = form1;
        }

        public UserDTO Login(string username, string password)
        {
            try
            {
                if (!RegexCheck(username,password)) return userLogged;
                userLogged = UserDAL.Login(username, password);
                var test = form1.GetTextBoxInfo();
                if (userLogged != null)
                {
                    ComponentsUtil.AppendTextToRichTextBox(form1.GetTextBoxInfo(), "LoggedIn Succesfully", Color.Green, true);
                    UpdateComponents();
                    new AppController(userLogged, form1);
                }
                else
                {
                    ComponentsUtil.AppendTextToRichTextBox(form1.GetTextBoxInfo(), "Failed Login(Check username/password)", Color.Red, true);
                }
                return userLogged;
            }
            catch (Exception ex)
            {
                ComponentsUtil.AppendTextToRichTextBox(form1.GetTextBoxInfo(), String.Format("Application {0}", ex.Message), Color.Red, true);
                return null;
            }
        }

        private void UpdateComponents()
        {
            string username = userLogged.username.Substring(0, userLogged.username.IndexOf(@"@"));
            string welcomeMessage = String.Format(form1.GetWelcomeLabel().Text, username);
            ComponentsUtil.SetTextMessageForLabel(form1.GetWelcomeLabel(), welcomeMessage, Color.ForestGreen, FontStyle.Bold);
            ComponentsUtil.SetGroupBoxVisibility(form1.GetAuthenticationGroupBox(), true);
            ComponentsUtil.SetGroupBoxVisibility(form1.GetGroupBoxOptions());
            ComponentsUtil.SetButtonVisibility(form1.GetLogoutButton());
            ComponentsUtil.SetLabelVisibility(form1.GetWelcomeLabel());
        }
        
        private bool RegexCheck(string username,string password)
        {
            bool ok = false;
            if(username == null || password == null || username == string.Empty || password == string.Empty)
            {
                ComponentsUtil.AppendTextToRichTextBox(form1.GetTextBoxInfo(), "Please add username & password", Color.Red, true);
            }
            else 
            {
                if (!RegexUtil.CheckMatchRegexEmail(username))
                    ComponentsUtil.AppendTextToRichTextBox(form1.GetTextBoxInfo(), "Incorrect username (only emails)!", Color.Red, true);
                else ok = true;
            }
            return ok;
        }
    }
}
