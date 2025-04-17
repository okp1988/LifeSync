using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace LifeSync_App
{
    partial class NoticeListUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            txtTime = new TextBox();
            lblDate = new Label();
            btnRefresh = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtTime);
            splitContainer1.Panel1.Controls.Add(lblDate);
            splitContainer1.Panel1.Controls.Add(btnRefresh);
            splitContainer1.Size = new Size(773, 581);
            splitContainer1.SplitterDistance = 62;
            splitContainer1.TabIndex = 0;
            splitContainer1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 4;
            label1.Text = "Time (Optional)";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(100, 32);
            txtTime.MaxLength = 4;
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(36, 23);
            txtTime.TabIndex = 998;
            txtTime.TabStop = false;
            txtTime.Text = "0000";
            txtTime.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(84, 7);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "label1";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(3, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // NoticeListUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(splitContainer1);
            Name = "NoticeListUserControl";
            Size = new Size(773, 581);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void InitializeComponent_Custom()
        {
            dgTask = new TaskDataGridUserControl(this.inForm, "notice", txtTime);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgTask);
            // 
            // dgTask
            // 
            dgTask.AutoSize = true;
            dgTask.Dock = DockStyle.Fill;
            dgTask.Location = new Point(0, 0);
            dgTask.Name = "dgTask";
            dgTask.Size = new Size(773, 455);
            dgTask.TabIndex = 0;
            dgTask.TabStop = false;
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txtTime;
        private Label lblDate;
        private Button btnRefresh;
        private TaskDataGridUserControl dgTask;
        private ContextMenuStrip contextMenuStrip1;
    }
}
