using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSync_App
{
    public partial class ToDoListUserControl : UserControl
    {
        public Form1 inForm;
        private DateTime today = DateTime.Today;

        public ToDoListUserControl(Form1 paForm)
        {
            this.inForm = paForm;
            InitializeComponent();
            InitializeComponent_Custom();
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                TaskInfo item = new TaskInfo()
                {
                    Index = this.inForm.dicTasks.Count > 0 ? (this.inForm.dicTasks.Values.Max(t => t.Index) + 1) : 0, // START WITH 0
                    Category = txtCategory.Text.Trim(),
                    Type = txtType.Text.Trim(),
                    Task = txtTask.Text.Trim(),
                    Interval = Convert.ToInt16(txtInterval.Text.Trim()),
                    IntervalType = ddlType.Text.Trim(),
                    Date = dtPicker.Value,
                    Time = txtTime.Text.Trim(),
                    Remark = txtRemark.Text.Trim(),
                    KeepHistory = chkHistory.Checked,
                    IgnoreAlert = chkHistory.Checked,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                };

                this.inForm.dicTasks.Add(item.Index, item);
                this.inForm.isDirty = true;
                dgTask.PopulateTaskList(rePopulateDropDown: true);
                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtCategory.Text = txtType.Text = txtTask.Text = txtRemark.Text = txtTime.Text = string.Empty;
            dtPicker.Value = DateTime.Now;
            dtPicker.MinDate = DateTime.Now.AddYears(-1);
            dtPicker.MaxDate = DateTime.Now.AddDays(10);
            chkHistory.Checked = chkIgnore.Checked = false;
            txtInterval.Text = "1";
            ddlType.SelectedIndex = 0;
        }

        private bool ValidateInput()
        {
            if (!string.IsNullOrWhiteSpace(txtTime.Text) && !(int.TryParse(txtTime.Text, out int time) && txtTime.Text.Length == 4 && Regex.IsMatch(txtTime.Text, "(2[0-3]|[0-1][0-9])[0-5][0-9]")))
            {
                MessageBox.Show("Time must be 4 digits number with leading zero (With 2359 format).");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtType.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtTask.Text))
            {
                MessageBox.Show("Please enter Category, Type and Task.");
                return false;
            }
            if (!(!string.IsNullOrWhiteSpace(txtInterval.Text) && int.TryParse(txtInterval.Text, out int interval)))
            {
                MessageBox.Show("Interval must be a number.");
                return false;
            }

            return true;
        }

        private void SaveTasks()
        {
            try
            {
                string json = JsonSerializer.Serialize(this.inForm.dicTasks, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(Form1.tasksFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving tasks: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTasks();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgTask.PopulateTaskList();
        }

        public void CheckRefresh()
        {
            if (today != DateTime.Today || this.inForm.isDirty)
            {
                dgTask.PopulateTaskList();
                today = DateTime.Today;
            }
        }
    }
}
