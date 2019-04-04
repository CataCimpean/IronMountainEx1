using System;
using System.Windows.Forms;

namespace IronMountainEx
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logoutButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.AuthenticationGroupBox = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordFromOption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleFromOption = new System.Windows.Forms.ComboBox();
            this.usernameFromOption = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.MenuTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.AuthenticationGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.MenuTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.welcomeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.AuthenticationGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.OptionsGroupBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(838, 517);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(731, 118);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(728, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(84, 13);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome,{0}!";
            this.welcomeLabel.Visible = false;
            this.welcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // AuthenticationGroupBox
            // 
            this.AuthenticationGroupBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AuthenticationGroupBox.Controls.Add(this.loginButton);
            this.AuthenticationGroupBox.Controls.Add(this.label2);
            this.AuthenticationGroupBox.Controls.Add(this.label1);
            this.AuthenticationGroupBox.Controls.Add(this.passwordTextbox);
            this.AuthenticationGroupBox.Controls.Add(this.usernameTextBox);
            this.AuthenticationGroupBox.Location = new System.Drawing.Point(284, 12);
            this.AuthenticationGroupBox.Name = "AuthenticationGroupBox";
            this.AuthenticationGroupBox.Size = new System.Drawing.Size(295, 135);
            this.AuthenticationGroupBox.TabIndex = 0;
            this.AuthenticationGroupBox.TabStop = false;
            this.AuthenticationGroupBox.Text = "Authentication";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(143, 89);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(117, 56);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(131, 20);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(117, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(131, 20);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.label5);
            this.OptionsGroupBox.Controls.Add(this.passwordFromOption);
            this.OptionsGroupBox.Controls.Add(this.label4);
            this.OptionsGroupBox.Controls.Add(this.label3);
            this.OptionsGroupBox.Controls.Add(this.roleFromOption);
            this.OptionsGroupBox.Controls.Add(this.usernameFromOption);
            this.OptionsGroupBox.Controls.Add(this.deleteButton);
            this.OptionsGroupBox.Controls.Add(this.insertButton);
            this.OptionsGroupBox.Controls.Add(this.updateButton);
            this.OptionsGroupBox.Location = new System.Drawing.Point(12, 9);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(266, 138);
            this.OptionsGroupBox.TabIndex = 4;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            this.OptionsGroupBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // passwordFromOption
            // 
            this.passwordFromOption.Location = new System.Drawing.Point(121, 111);
            this.passwordFromOption.Name = "passwordFromOption";
            this.passwordFromOption.PasswordChar = '•';
            this.passwordFromOption.Size = new System.Drawing.Size(121, 20);
            this.passwordFromOption.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // roleFromOption
            // 
            this.roleFromOption.DataSource = new IronMountainEx1.Utils.Enum.Role[] {
        IronMountainEx1.Utils.Enum.Role.OWNER,
        IronMountainEx1.Utils.Enum.Role.ADMIN,
        IronMountainEx1.Utils.Enum.Role.USER};
            this.roleFromOption.FormattingEnabled = true;
            this.roleFromOption.Location = new System.Drawing.Point(121, 73);
            this.roleFromOption.Name = "roleFromOption";
            this.roleFromOption.Size = new System.Drawing.Size(119, 21);
            this.roleFromOption.TabIndex = 6;
            this.roleFromOption.SelectedIndexChanged += new System.EventHandler(this.roleFromOption_SelectedIndexChanged);
            // 
            // usernameFromOption
            // 
            this.usernameFromOption.Location = new System.Drawing.Point(5, 73);
            this.usernameFromOption.Name = "usernameFromOption";
            this.usernameFromOption.Size = new System.Drawing.Size(110, 20);
            this.usernameFromOption.TabIndex = 4;
            this.usernameFromOption.TextChanged += new System.EventHandler(this.usernameFromOption_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(167, 15);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(5, 15);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(86, 15);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.textBoxInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.MenuTab);
            this.tabControl2.Location = new System.Drawing.Point(7, 95);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(792, 193);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.Visible = false;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.dataGridView1);
            this.MenuTab.Location = new System.Drawing.Point(4, 22);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.MenuTab.Size = new System.Drawing.Size(784, 167);
            this.MenuTab.TabIndex = 0;
            this.MenuTab.Text = "Menu";
            this.MenuTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_RowHeaderMouseClick);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(6, 16);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(789, 73);
            this.textBoxInfo.TabIndex = 0;
            this.textBoxInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 517);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IronMountainAppCRUD";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AuthenticationGroupBox.ResumeLayout(false);
            this.AuthenticationGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.MenuTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox AuthenticationGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.RichTextBox textBoxInfo;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage MenuTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleFromOption;
        private System.Windows.Forms.TextBox usernameFromOption;
        private Label label5;
        private TextBox passwordFromOption;
    }
}

