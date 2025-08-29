namespace To_Do_List

{
   

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.CheckedListBox checkedListBoxTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label lblSelectAll;
        private System.Windows.Forms.Label lblDeselectAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.checkedListBoxTasks = new System.Windows.Forms.CheckedListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblSelectAll = new System.Windows.Forms.Label();
            this.lblDeselectAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 25);
            this.lblTitle.Text = "Task Tasks";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(320, 40);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(15, 14);
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblSelectAll
            // 
            this.lblSelectAll.AutoSize = true;
            this.lblSelectAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectAll.Location = new System.Drawing.Point(340, 35);
            this.lblSelectAll.Name = "lblSelectAll";
            this.lblSelectAll.Size = new System.Drawing.Size(110, 19);
            this.lblSelectAll.Text = "Select All Tasks";
            // 
            // lblDeselectAll
            // 
            this.lblDeselectAll.AutoSize = true;
            this.lblDeselectAll.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDeselectAll.ForeColor = System.Drawing.Color.Gray;
            this.lblDeselectAll.Location = new System.Drawing.Point(340, 54);
            this.lblDeselectAll.Name = "lblDeselectAll";
            this.lblDeselectAll.Size = new System.Drawing.Size(97, 13);
            this.lblDeselectAll.Text = "Deselect All Tasks";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTasks.Location = new System.Drawing.Point(30, 70);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(44, 19);
            this.lblTasks.Text = "Tasks";
            // 
            // checkedListBoxTasks
            // 
            this.checkedListBoxTasks.FormattingEnabled = true;
            this.checkedListBoxTasks.Location = new System.Drawing.Point(30, 95);
            this.checkedListBoxTasks.Name = "checkedListBoxTasks";
            this.checkedListBoxTasks.Size = new System.Drawing.Size(300, 184);
            this.checkedListBoxTasks.CheckOnClick = true;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(350, 95);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(150, 40);
            this.btnAddTask.Text = "Add a task";
            this.btnAddTask.BackColor = System.Drawing.Color.White;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(350, 145);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteTask.Text = "Delete a task";
            this.btnDeleteTask.BackColor = System.Drawing.Color.Honeydew;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(350, 195);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteAll.Text = "Delete all tasks";
            this.btnDeleteAll.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.lblSelectAll);
            this.Controls.Add(this.lblDeselectAll);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.checkedListBoxTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnDeleteAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "To-Do List";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

