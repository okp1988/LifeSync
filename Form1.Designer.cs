using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSync_App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabToDo;
        private System.Windows.Forms.TabPage tabNotice;

        // Note: The UserControls (ToDoListUserControl, FinanceUserControl, DiaryUserControl)
        // are assumed to be defined in their own files.
        private ToDoListUserControl todoControl;
        private NoticeListUserControl noticeControl;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                trayIcon?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabNotice = new TabPage();
            tabToDo = new TabPage();
            timerAction = new System.Windows.Forms.Timer(components);
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabNotice);
            tabControl.Controls.Add(tabToDo);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1000, 700);
            tabControl.TabIndex = 0;
            tabControl.TabStop = false;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabNotice
            // 
            tabNotice.Location = new Point(4, 24);
            tabNotice.Name = "tabNotice";
            tabNotice.Size = new Size(992, 672);
            tabNotice.TabIndex = 0;
            tabNotice.Text = "Notice List";
            tabNotice.UseVisualStyleBackColor = true;
            // 
            // tabToDo
            // 
            tabToDo.Location = new Point(4, 24);
            tabToDo.Name = "tabToDo";
            tabToDo.Padding = new Padding(3);
            tabToDo.Size = new Size(992, 672);
            tabToDo.TabIndex = 0;
            tabToDo.Text = "To-Do List";
            tabToDo.UseVisualStyleBackColor = true;
            // 
            // timerAction
            // 
            timerAction.Enabled = true;
            timerAction.Interval = 300000;
            timerAction.Tick += timerAction_Tick;
            // 
            // Form1
            // 
            ClientSize = new Size(1000, 700);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "LifeSync_App";
            FormClosing += MainForm_FormClosing;
            Resize += MainForm_Resize;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }
        private void InitializeComponent_Custom()
        {
            todoControl = new ToDoListUserControl(this);
            todoControl.Dock = DockStyle.Fill;
            tabToDo.Controls.Add(todoControl);

            noticeControl = new NoticeListUserControl(this);
            noticeControl.Dock = DockStyle.Fill;
            tabNotice.Controls.Add(noticeControl);
        }
        #endregion

        private System.Windows.Forms.Timer timerAction;
    }
}
