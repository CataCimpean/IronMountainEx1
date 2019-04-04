using IronMountainEx1.Controller;
using IronMountainEx1.DTO;
using IronMountainEx1.Utils.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IronMountainEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //USED IN Updating and Deleting Record
        int ID = 0;

        private void SetTabProperties(TabPage tab)
        {
            tab.BackColor = Color.White;
        }
        
        public RichTextBox GetTextBoxInfo()
        {
            return textBoxInfo;
        }
        public GroupBox GetAuthenticationGroupBox()
        {
            return AuthenticationGroupBox;
        }
        public Label GetWelcomeLabel()
        {
            return welcomeLabel;
        }
        public Button GetLogoutButton()
        {
            return logoutButton;
        }
        public TabControl GetTabControlInfo()
        {
            return tabControl1;
        }
        public TabControl GetTabControlMenu()
        {
            return tabControl2;
        }
        
        public DataGridView GetMenuDataGridView()
        {
            return dataGridView1;
        }

        public Button GetInsertButton()
        {
            return insertButton;
        }

        public Button GetUpdateButton()
        {
            return updateButton;
        }

        public Button GetDeleteButton()
        {
            return deleteButton;
        }
        
        public GroupBox GetGroupBoxOptions()
        {
            return OptionsGroupBox;
        } 

        public TextBox GetUsernameFromOption()
        {
            return usernameFromOption;
        }

        public ComboBox GetRoleFromOption()
        {
            return roleFromOption;
        }

        public TextBox GetpasswordFromOption()
        {
            return passwordFromOption;
        }

        public TextBox GetPasswordFromLogin()
        {
            return passwordTextbox;
        }

        public TextBox GetUsernameFromLogin()
        {
            return usernameTextBox;
        }


        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }
        

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        public void InsertButton_Click(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginController ctrlLogin = new LoginController((Form1)FindForm());
            UserDTO user = ctrlLogin.Login(usernameTextBox.Text, passwordTextbox.Text);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                new LogoutController((Form1)FindForm());
                ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), "Logout Succesfully!", Color.Green, true);
            }
            catch (Exception ex)
            {
                ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), String.Format("Error:{0}", ex.Message), Color.Red, true);
            }
        }

        public void InsertButtonAdmin_Click(object sender, EventArgs e)
        {
            if (usernameFromOption.Text != string.Empty && roleFromOption.SelectedIndex >= 0 && passwordFromOption.Text !=string.Empty)
            {
                try
                {
                    IronMountainEx1.Utils.Enum.Role role;
                    Enum.TryParse<IronMountainEx1.Utils.Enum.Role>(roleFromOption.SelectedItem.ToString(), out role);
                    int rowCount = AdminCRUDController.InsertUserByAdmin(new UserDTO(ID, usernameFromOption.Text, passwordFromOption.Text, role));
                    if(rowCount == 1) {
                        RefreshDataGridView();
                        ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), "Record inserted Succesfully", Color.Green, true);
                    }

                }
                catch (Exception ex)
                {
                    ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), String.Format("Error:{0}", ex.Message), Color.Red, true);
                }
            }
            else
            {
                ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), "Please add username and password", Color.Red, true);
            }
        }
        public void UpdateButtonAdmin_Click(object sender, EventArgs e)
        {
            if(usernameFromOption.Text != string.Empty && roleFromOption.SelectedIndex >= 0)
            {
                try
                {
                    IronMountainEx1.Utils.Enum.Role role;
                    Enum.TryParse<IronMountainEx1.Utils.Enum.Role>(roleFromOption.SelectedItem.ToString(), out role);
                    bool updated = AdminCRUDController.UpdateUserByAdmin(new UserDTO(ID, usernameFromOption.Text, passwordFromOption.Text, role));
                    if (updated)
                    {
                        passwordFromOption.Text = string.Empty;
                        RefreshDataGridView();
                        ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), "Record updated Succesfully", Color.Green, true);
                    }
                }
                catch (Exception ex)
                {
                    ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), String.Format("Error:{0}",ex.Message), Color.Red, true);
                }
            }
        }

        public void DeleteButtonAdmin_Click(object sender, EventArgs e)
        {
            if(ID != 0)
            {
                try
                {
                    IronMountainEx1.Utils.Enum.Role role;
                    Enum.TryParse<IronMountainEx1.Utils.Enum.Role>(roleFromOption.SelectedItem.ToString(), out role);
                    if (role == IronMountainEx1.Utils.Enum.Role.OWNER)
                    {
                        ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), "You aren't authorized to delete owner", Color.Red, true);
                        return;
                    }
                    bool deleted = AdminCRUDController.DeleteUserByAdmin(ID);
                    if (deleted)
                    {
                        RefreshDataGridView();
                        ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), "Record deleted Succesfully", Color.Green, true);
                    }
                }
                catch (Exception ex)
                {
                    ComponentsUtil.AppendTextToRichTextBox(GetTextBoxInfo(), String.Format("Error:{0}", ex.Message), Color.Red, true);
                }
            }
        }

        public void DataGridViewAdmin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            usernameFromOption.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            IronMountainEx1.Utils.Enum.Role role;
            Enum.TryParse<IronMountainEx1.Utils.Enum.Role>(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), out role);
            roleFromOption.SelectedItem = role;
        }

        private void usernameFromOption_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleFromOption_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void DataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
        
        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = AdminCRUDController.ReadDataAdmin();
            ComponentsUtil.DataGridViewAutoFit(dataGridView1, dataGridView1.Rows.Count - 1);
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
