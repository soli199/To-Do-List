using System;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Replace the usage of Microsoft.VisualBasic.Interaction.InputBox with a custom input dialog using a simple Form.

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (Form inputForm = new Form())
            {
                inputForm.Width = 300;
                inputForm.Height = 150;
                inputForm.Text = "Add Task";

                Label lblPrompt = new Label() { Left = 10, Top = 10, Text = "Enter new task:", AutoSize = true };
                TextBox txtInput = new TextBox() { Left = 10, Top = 35, Width = 260 };
                Button btnOk = new Button() { Text = "OK", Left = 110, Width = 80, Top = 70, DialogResult = DialogResult.OK };

                inputForm.Controls.Add(lblPrompt);
                inputForm.Controls.Add(txtInput);
                inputForm.Controls.Add(btnOk);
                inputForm.AcceptButton = btnOk;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string input = txtInput.Text;
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        checkedListBoxTasks.Items.Add(input, false);
                    }
                }
            }
        }

        // Delete the selected (checked) tasks
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBoxTasks.CheckedItems.Count - 1; i >= 0; i--)
            {
                checkedListBoxTasks.Items.Remove(checkedListBoxTasks.CheckedItems[i]);
            }
        }

        // Delete all tasks
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            checkedListBoxTasks.Items.Clear();
        }

        // Select/Deselect all tasks
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool check = chkSelectAll.Checked;
            for (int i = 0; i < checkedListBoxTasks.Items.Count; i++)
            {
                checkedListBoxTasks.SetItemChecked(i, check);
            }
        }
    }
}
