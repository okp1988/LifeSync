using System.Threading.Tasks;

namespace LifeSync_App
{
    partial class ToDoListUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            txtRemark = new TextBox();
            btnLoad = new Button();
            txtTask = new TextBox();
            label8 = new Label();
            chkHistory = new CheckBox();
            label7 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            label6 = new Label();
            ddlType = new ComboBox();
            txtInterval = new TextBox();
            label5 = new Label();
            txtTime = new TextBox();
            label4 = new Label();
            dtPicker = new DateTimePicker();
            label3 = new Label();
            txtType = new TextBox();
            label2 = new Label();
            txtCategory = new TextBox();
            label1 = new Label();
            chkIgnore = new CheckBox();
            label9 = new Label();
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
            splitContainer1.Panel1.Controls.Add(chkIgnore);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(txtRemark);
            splitContainer1.Panel1.Controls.Add(btnLoad);
            splitContainer1.Panel1.Controls.Add(txtTask);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(chkHistory);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(btnSave);
            splitContainer1.Panel1.Controls.Add(btnClear);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(ddlType);
            splitContainer1.Panel1.Controls.Add(txtInterval);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(txtTime);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(dtPicker);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtType);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtCategory);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Size = new Size(773, 581);
            splitContainer1.SplitterDistance = 152;
            splitContainer1.TabIndex = 0;
            splitContainer1.TabStop = false;
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(79, 98);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(461, 23);
            txtRemark.TabIndex = 1001;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(465, 127);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1000;
            btnLoad.TabStop = false;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Visible = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(79, 69);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(154, 23);
            txtTask.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 72);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 18;
            label8.Text = "Task";
            // 
            // chkHistory
            // 
            chkHistory.AutoSize = true;
            chkHistory.Location = new Point(98, 132);
            chkHistory.Name = "chkHistory";
            chkHistory.Size = new Size(15, 14);
            chkHistory.TabIndex = 6;
            chkHistory.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 131);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 16;
            label7.Text = "Keep History";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(384, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.TabStop = false;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(303, 127);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.TabStop = false;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(222, 127);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 101);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Remark";
            // 
            // ddlType
            // 
            ddlType.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlType.FormattingEnabled = true;
            ddlType.Items.AddRange(new object[] { "Day", "Month", "Year" });
            ddlType.Location = new Point(333, 40);
            ddlType.Name = "ddlType";
            ddlType.Size = new Size(64, 23);
            ddlType.TabIndex = 5;
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(291, 40);
            txtInterval.MaxLength = 3;
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(36, 23);
            txtInterval.TabIndex = 4;
            txtInterval.Text = "1";
            txtInterval.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 43);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Interval";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(504, 11);
            txtTime.MaxLength = 4;
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(36, 23);
            txtTime.TabIndex = 998;
            txtTime.TabStop = false;
            txtTime.Text = "0000";
            txtTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 14);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "Time (Optional)";
            // 
            // dtPicker
            // 
            dtPicker.CustomFormat = "dd MMM yyyy";
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.ImeMode = ImeMode.Off;
            dtPicker.Location = new Point(291, 11);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(110, 23);
            dtPicker.TabIndex = 999;
            dtPicker.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 14);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Date";
            // 
            // txtType
            // 
            txtType.Location = new Point(79, 40);
            txtType.Name = "txtType";
            txtType.Size = new Size(154, 23);
            txtType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(79, 11);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(154, 23);
            txtCategory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // chkIgnore
            // 
            chkIgnore.AutoSize = true;
            chkIgnore.Location = new Point(194, 132);
            chkIgnore.Name = "chkIgnore";
            chkIgnore.Size = new Size(15, 14);
            chkIgnore.TabIndex = 1002;
            chkIgnore.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(119, 131);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 1003;
            label9.Text = "Ignore Alert";
            // 
            // ToDoListUserControl
            // 
            AutoSize = true;
            Controls.Add(splitContainer1);
            Name = "ToDoListUserControl";
            Size = new Size(773, 581);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void InitializeComponent_Custom()
        {
            dgTask = new TaskDataGridUserControl(this.inForm, "todolist", txtTime);
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
        private TextBox txtCategory;
        private Label label1;
        private DateTimePicker dtPicker;
        private Label label3;
        private TextBox txtType;
        private Label label2;
        private TextBox txtTime;
        private Label label4;
        private TextBox txtInterval;
        private Label label5;
        private ComboBox ddlType;
        private Label label6;
        private Button btnClear;
        private Button btnAdd;
        private Button btnSave;
        private TextBox txtTask;
        private Label label8;
        private CheckBox chkHistory;
        private Label label7;
        private TaskDataGridUserControl dgTask;
        private Button btnLoad;
        private TextBox txtRemark;
        private CheckBox chkIgnore;
        private Label label9;
    }
}
