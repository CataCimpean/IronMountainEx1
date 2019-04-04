using IronMountainEx;
using IronMountainEx1.DTO;
using IronMountainEx1.Utils.Components;
using System;
using System.Windows.Forms;

namespace IronMountainEx1.Controller
{
    public class AppController
    {
        private UserDTO user;
        private Form1 form1;

        public AppController(UserDTO user, Form1 form1)
        {
            this.user = user;
            this.form1 = form1;
            GenerateTab();
        }

        public void GenerateTab()
        {
            switch (user.rolUser)
            {
                case Utils.Enum.Role.ADMIN:
                    {
                        GenerateTabAdmin();
                        break;
                    }
                case Utils.Enum.Role.OWNER:
                    {
                        //not implemented
                        break;
                    }
                case Utils.Enum.Role.USER:
                    {
                        //not implemented
                        break;
                    }
                default: break;
            }
        }

        public void GenerateTabAdmin()
        {
            //Populate DataGridView from Database
            DataGridView dataGridViewAdmin = form1.GetMenuDataGridView();
            dataGridViewAdmin.DataSource = AdminCRUDController.ReadDataAdmin();
            ComponentsUtil.DataGridViewAutoFit(dataGridViewAdmin, dataGridViewAdmin.Rows.Count - 1);

            //remove previous Handler from buttons (INSERT, UPDATE, DELETE)
            ClearEvents();

            //add new EventHandler on buttons (INSERT,UPDATE,DELETE)
            Button insert = form1.GetInsertButton();
            insert.Click += new EventHandler(form1.InsertButtonAdmin_Click);

            Button update = form1.GetUpdateButton();
            update.Click += new EventHandler(form1.UpdateButtonAdmin_Click);

            Button delete = form1.GetDeleteButton();
            delete.Click += new EventHandler(form1.DeleteButtonAdmin_Click);

            //add new EventHandler on datagridview
            DataGridView dgw = form1.GetMenuDataGridView();
            dgw.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(form1.DataGridViewAdmin_RowHeaderMouseClick);

            //UpdateComponents
            UpdateComponents();

        }
        private void UpdateComponents()
        {
            ComponentsUtil.SetTabControlVisibility(form1.GetTabControlMenu());
            ComponentsUtil.SetButtonVisibility(form1.GetInsertButton());
            ComponentsUtil.SetButtonVisibility(form1.GetUpdateButton());
            ComponentsUtil.SetButtonVisibility(form1.GetDeleteButton());
        }

        //Remove previous events from button
        private void ClearEvents()
        {
            form1.GetInsertButton().Click -= new EventHandler(form1.InsertButton_Click);
            form1.GetUpdateButton().Click -= new EventHandler(form1.UpdateButton_Click);
            form1.GetDeleteButton().Click -= new EventHandler(form1.DeleteButton_Click);
        }
    }
}
