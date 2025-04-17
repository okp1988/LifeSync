using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace LifeSync_App
{
    partial class TaskDataGridUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgTasks = new DataGridView();
            drIndex = new DataGridViewTextBoxColumn();
            drCategory = new DataGridViewTextBoxColumn();
            drType = new DataGridViewTextBoxColumn();
            drTask = new DataGridViewTextBoxColumn();
            drDate = new DataGridViewTextBoxColumn();
            drExpired = new DataGridViewTextBoxColumn();
            drDiff = new DataGridViewTextBoxColumn();
            drInterval = new DataGridViewTextBoxColumn();
            drCheck = new DataGridViewCheckBoxColumn();
            drRemark = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            ddlType = new ComboBox();
            label2 = new Label();
            ddlCategory = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dgTasks
            // 
            dgTasks.AllowUserToAddRows = false;
            dgTasks.AllowUserToDeleteRows = false;
            dgTasks.AllowUserToResizeColumns = false;
            dgTasks.AllowUserToResizeRows = false;
            dgTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTasks.Columns.AddRange(new DataGridViewColumn[] { drIndex, drCategory, drType, drTask, drDate, drExpired, drDiff, drInterval, drCheck, drRemark });
            dgTasks.Dock = DockStyle.Fill;
            dgTasks.Location = new Point(0, 0);
            dgTasks.MultiSelect = false;
            dgTasks.Name = "dgTasks";
            dgTasks.ReadOnly = true;
            dgTasks.RowHeadersVisible = false;
            dgTasks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTasks.Size = new Size(773, 549);
            dgTasks.TabIndex = 0;
            dgTasks.TabStop = false;
            dgTasks.CellClick += dgTasks_CellClick;
            dgTasks.CellContentClick += dgTasks_CellContentClick;
            dgTasks.ColumnHeaderMouseClick += dgTasks_ColumnHeaderMouseClick;
            // 
            // drIndex
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            drIndex.DefaultCellStyle = dataGridViewCellStyle1;
            drIndex.HeaderText = "Index";
            drIndex.Name = "drIndex";
            drIndex.ReadOnly = true;
            drIndex.Resizable = DataGridViewTriState.False;
            drIndex.SortMode = DataGridViewColumnSortMode.NotSortable;
            drIndex.Visible = false;
            // 
            // drCategory
            // 
            drCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            drCategory.DefaultCellStyle = dataGridViewCellStyle2;
            drCategory.FillWeight = 10F;
            drCategory.HeaderText = "Cateogry";
            drCategory.Name = "drCategory";
            drCategory.ReadOnly = true;
            drCategory.Resizable = DataGridViewTriState.False;
            drCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // drType
            // 
            drType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            drType.DefaultCellStyle = dataGridViewCellStyle3;
            drType.FillWeight = 10F;
            drType.HeaderText = "Type";
            drType.Name = "drType";
            drType.ReadOnly = true;
            drType.Resizable = DataGridViewTriState.False;
            drType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // drTask
            // 
            drTask.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            drTask.DefaultCellStyle = dataGridViewCellStyle4;
            drTask.FillWeight = 15F;
            drTask.HeaderText = "Task";
            drTask.Name = "drTask";
            drTask.ReadOnly = true;
            drTask.Resizable = DataGridViewTriState.False;
            drTask.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // drDate
            // 
            drDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            drDate.DefaultCellStyle = dataGridViewCellStyle5;
            drDate.FillWeight = 12F;
            drDate.HeaderText = "Date";
            drDate.Name = "drDate";
            drDate.ReadOnly = true;
            drDate.Resizable = DataGridViewTriState.False;
            drDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // drExpired
            // 
            drExpired.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            drExpired.DefaultCellStyle = dataGridViewCellStyle6;
            drExpired.FillWeight = 8F;
            drExpired.HeaderText = "Expired";
            drExpired.Name = "drExpired";
            drExpired.ReadOnly = true;
            drExpired.Resizable = DataGridViewTriState.False;
            drExpired.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // drDiff
            // 
            drDiff.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            drDiff.DefaultCellStyle = dataGridViewCellStyle7;
            drDiff.HeaderText = "Diff";
            drDiff.MinimumWidth = 40;
            drDiff.Name = "drDiff";
            drDiff.ReadOnly = true;
            drDiff.Resizable = DataGridViewTriState.False;
            drDiff.SortMode = DataGridViewColumnSortMode.NotSortable;
            drDiff.Width = 40;
            // 
            // drInterval
            // 
            drInterval.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight;
            drInterval.DefaultCellStyle = dataGridViewCellStyle8;
            drInterval.FillWeight = 8F;
            drInterval.HeaderText = "Interval";
            drInterval.Name = "drInterval";
            drInterval.ReadOnly = true;
            drInterval.Resizable = DataGridViewTriState.False;
            drInterval.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // drCheck
            // 
            drCheck.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            drCheck.HeaderText = "";
            drCheck.MinimumWidth = 40;
            drCheck.Name = "drCheck";
            drCheck.ReadOnly = true;
            drCheck.Resizable = DataGridViewTriState.False;
            drCheck.Width = 40;
            // 
            // drRemark
            // 
            drRemark.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            drRemark.DefaultCellStyle = dataGridViewCellStyle9;
            drRemark.FillWeight = 25F;
            drRemark.HeaderText = "Remark";
            drRemark.Name = "drRemark";
            drRemark.ReadOnly = true;
            drRemark.Resizable = DataGridViewTriState.False;
            drRemark.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            splitContainer1.Panel1.Controls.Add(ddlType);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(ddlCategory);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgTasks);
            splitContainer1.Size = new Size(773, 581);
            splitContainer1.SplitterDistance = 28;
            splitContainer1.TabIndex = 1;
            // 
            // ddlType
            // 
            ddlType.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlType.FormattingEnabled = true;
            ddlType.Items.AddRange(new object[] { "All" });
            ddlType.Location = new Point(260, 3);
            ddlType.Name = "ddlType";
            ddlType.Size = new Size(121, 23);
            ddlType.TabIndex = 3;
            ddlType.SelectedIndexChanged += ddlType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 6);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // ddlCategory
            // 
            ddlCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Items.AddRange(new object[] { "All" });
            ddlCategory.Location = new Point(64, 3);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(121, 23);
            ddlCategory.TabIndex = 1;
            ddlCategory.SelectedIndexChanged += ddlCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // TaskDataGridUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(splitContainer1);
            Name = "TaskDataGridUserControl";
            Size = new Size(773, 581);
            ((System.ComponentModel.ISupportInitialize)dgTasks).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgTasks;
        private DataGridViewTextBoxColumn drIndex;
        private DataGridViewTextBoxColumn drCategory;
        private DataGridViewTextBoxColumn drType;
        private DataGridViewTextBoxColumn drTask;
        private DataGridViewTextBoxColumn drDate;
        private DataGridViewTextBoxColumn drExpired;
        private DataGridViewTextBoxColumn drDiff;
        private DataGridViewTextBoxColumn drInterval;
        private DataGridViewCheckBoxColumn drCheck;
        private DataGridViewTextBoxColumn drRemark;
        private SplitContainer splitContainer1;
        private ComboBox ddlType;
        private Label label2;
        private ComboBox ddlCategory;
        private Label label1;
    }
}
