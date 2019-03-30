using System;
using System.Drawing;
using System.Windows.Forms;

namespace IronMountainEx1.Utils.Components
{
    public static class ComponentsUtil
    {
        /// <summary>
        /// Utils for add content for components of type RichTextBox
        /// </summary>
        /// <param name="box"></param>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <param name="AddNewLine"></param>
        public static void AppendTextToRichTextBox(this RichTextBox box, string text, Color color, bool AddNewLine = false)
        {
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
            box.Refresh();
        }

        /// <summary>
        /// Used for set text message for specific label
        /// </summary>
        /// <param name="label"></param>
        /// <param name="invisible"></param>
        public static void SetTextMessageForLabel(Label label, string message, Color color, FontStyle style)
        {
            label.Font = new Font("Arial", 8, style);
            label.ForeColor = color;
            label.Text = message;
        }

        public static void SetButtonVisibility(Button button, bool invisible = false)
        {
            if (invisible) button.Hide();
            else button.Visible = true;
        }

        /// <summary>
        /// Util for hide or show a specific groupBox
        /// </summary>
        /// <param name="groupBox"></param>
        public static void SetGroupBoxVisibility(GroupBox groupBox, bool invisible = false)
        {
            if (invisible) groupBox.Hide();
            else groupBox.Visible = true;
        }

        /// <summary>
        /// Util for hide or show a specific Label
        /// </summary>
        /// <param name="groupBox"></param>
        public static void SetLabelVisibility(Label label, bool invisible = false)
        {
            if (invisible) label.Hide();
            else label.Visible = true;
        }


        public static void CreateNewTabToTabControl(TabControl tbCtrl, string tbName)
        {
            TabPage tab = new TabPage(tbName);
            tbCtrl.TabPages.Add(tab);
        }

        /// <summary>
        /// Util for hide or show a specific TabControl
        /// </summary>
        /// <param name="groupBox"></param>
        public static void SetTabControlVisibility(TabControl tbCtrl, bool invisible = false)
        {
            if (invisible) tbCtrl.Hide();
            else tbCtrl.Visible = true;
        }

        public static void DataGridViewAutoFit(DataGridView dgw, int indexToFit = 0)
        {
            for(int i =0; i < dgw.Rows.Count; i++)
            {
                if(i!= indexToFit)
                {
                    dgw.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                else
                {
                    dgw.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
