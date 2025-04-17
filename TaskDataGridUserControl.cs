using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSync_App
{
    public partial class TaskDataGridUserControl : UserControl
    {
        private Form1 inForm;
        private string inTab; // notice, todolist
        private TextBox inTxtTimer;
        private bool all = true;
        private List<(string ColumnName, bool Ascending)> sortOrder = new();
        private Dictionary<string, string> dicHeader = new Dictionary<string, string>();
        IEnumerable<int> sorted;
        private List<string> lstCategory = new List<string>();
        private List<string> lstType = new List<string>();

        public TaskDataGridUserControl(Form1 paForm, string paTab, TextBox paTxt = null)
        {
            this.inForm = paForm;
            this.inTab = paTab;
            this.inTxtTimer = paTxt;

            if (this.inTab == "notice")
            {
                this.all = false;
            }
            else
            {
                this.all = true;
            }

            sortOrder.Add(("drCategory", true));
            sortOrder.Add(("drType", true));
            sortOrder.Add(("drTask", true));

            ApplySort();
            InitializeComponent();
            UpdateHeaderIndicators();
            PopulateTaskList(rePopulateDropDown: true); // FIRST LOAD
        }

        public void PopulateTaskList(bool withoutAlert = true, bool rePopulateDropDown = false)
        {
            dgTasks.Rows.Clear();

            if (rePopulateDropDown)
            {
                lstCategory.Clear();
                lstType.Clear();
            }

            int totalTask = 0;

            foreach (int tsk in sorted)
            {
                TaskInfo task = this.inForm.dicTasks[tsk];

                // ONLY POPULATE TASK THAT GONNA EXPIRED / NEAR DAY DIFF
                if (this.all || (DateTime.Now - task.DueDate()).TotalDays > -Form1.dayDiff)
                {
                    if (ddlCategory.SelectedIndex == 0 || ddlCategory.SelectedItem?.ToString() == task.Category)
                    {
                        if (ddlType.SelectedIndex == 0 || ddlType.SelectedItem?.ToString() == task.Type)
                        {
                            AddRow(task);
                        }

                        if (!lstType.Contains(task.Type)) {  lstType.Add(task.Type); }
                    }

                    if (!lstCategory.Contains(task.Category)) {  lstCategory.Add(task.Category); }

                    if (!task.IgnoreAlert)
                    {
                        totalTask++;
                    }
                }
            }

            if (rePopulateDropDown)
            {
                lstCategory.Insert(0, "All");
                ddlCategory.DataSource = lstCategory;
                lstType.Insert(0, "All");
                ddlType.DataSource = lstType;
            }

            if (!this.all && totalTask > 0 && !withoutAlert) { this.inForm.ShowAlert(); }
        }

        private void AddRow(TaskInfo task)
        {
            dgTasks.Rows.Add();
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drIndex"].Value = task.Index;
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drCategory"].Value = task.Category;
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drType"].Value = task.Type;
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drTask"].Value = task.Task;
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drDate"].Value = task.Date.Date.ToString("dd MMM yyyy") + (!string.IsNullOrWhiteSpace(task.Time) ? $" {task.Time}" : "");
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drExpired"].Value = task.DueDate().ToString("dd MMM yyyy");
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drDiff"].Value = (task.DateDiff() <= Form1.dayDiff ? task.DateDiff() : "-");
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drInterval"].Value = $"{task.Interval} {task.IntervalType}(s)";
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drRemark"].Value = task.Remark;

            if (task.Status() == "EXPIRED")
            {
                dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drExpired"].Style.BackColor = Color.Red;
                dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drExpired"].Style.ForeColor = Color.White;

                if (!task.IgnoreAlert)
                {
                    dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drDiff"].Style.BackColor = Color.Red;
                    dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drDiff"].Style.ForeColor = Color.White;
                }
            }
            else if (task.Status() == "TODAY")
            {
                dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drExpired"].Style.BackColor = Color.Pink;
            }
            else if (task.Status() == "SOON")
            {
                dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drExpired"].Style.BackColor = Color.Yellow;
            }
        }

        private void Update(int gridindex, TaskInfo task)
        {
            dgTasks.Rows[gridindex].Cells["drIndex"].Value = task.Index;
            dgTasks.Rows[gridindex].Cells["drCategory"].Value = task.Category;
            dgTasks.Rows[gridindex].Cells["drType"].Value = task.Type;
            dgTasks.Rows[gridindex].Cells["drTask"].Value = task.Task;
            dgTasks.Rows[gridindex].Cells["drDate"].Value = task.Date.Date.ToString("dd MMM yyyy") + (!string.IsNullOrWhiteSpace(task.Time) ? $" {task.Time}" : "");
            dgTasks.Rows[gridindex].Cells["drExpired"].Value = task.DueDate().ToString("dd MMM yyyy");
            dgTasks.Rows[gridindex].Cells["drDiff"].Value = (task.DateDiff() <= Form1.dayDiff ? task.DateDiff() : "-");
            dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drInterval"].Value = $"{task.Interval} {task.IntervalType}(s)";
            dgTasks.Rows[gridindex].Cells["drRemark"].Value = task.Remark;

            if (task.Status() == "EXPIRED")
            {
                dgTasks.Rows[gridindex].Cells["drExpired"].Style.BackColor = Color.Red;
                dgTasks.Rows[gridindex].Cells["drExpired"].Style.ForeColor = Color.White;

                if (!task.IgnoreAlert)
                {
                    dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drDiff"].Style.BackColor = Color.Red;
                    dgTasks.Rows[dgTasks.Rows.Count - 1].Cells["drDiff"].Style.ForeColor = Color.White;
                }
            }
            else if (task.Status() == "TODAY")
            {
                dgTasks.Rows[gridindex].Cells["drExpired"].Style.BackColor = Color.Pink;
            }
            else if (task.Status() == "SOON")
            {
                dgTasks.Rows[gridindex].Cells["drExpired"].Style.BackColor = Color.Yellow;
            }
            else
            {
                dgTasks.Rows[gridindex].Cells["drExpired"].Style.BackColor = Color.White;
                dgTasks.Rows[gridindex].Cells["drExpired"].Style.ForeColor = Color.Black;
            }
        }

        private void ApplySort()
        {
            IEnumerable<TaskInfo> sortedList = this.inForm.dicTasks.Values;

            for (int i = 0; i < sortOrder.Count; i++)
            {
                var sort = sortOrder[i];

                Func<TaskInfo, object> keySelector = tsk =>
                {
                    return sort.ColumnName switch
                    {
                        "drCategory" => tsk.Category,
                        "drType" => tsk.Type,
                        "drTask" => tsk.Task,
                        "drDate" => tsk.Date,
                        "drExpired" => tsk.DueDate(),
                        "drDiff" => tsk.DateDiff(),
                        "drInterval" => tsk.IntervalWeight(),
                        _ => null
                    };
                };

                if (i == 0)
                {
                    sortedList = sort.Ascending
                        ? sortedList.OrderBy(keySelector)
                        : sortedList.OrderByDescending(keySelector);
                }
                else
                {
                    sortedList = sort.Ascending
                        ? ((IOrderedEnumerable<TaskInfo>)sortedList).ThenBy(keySelector)
                        : ((IOrderedEnumerable<TaskInfo>)sortedList).ThenByDescending(keySelector);
                }
            }

            sorted = sortedList.Select(x => x.Index).ToList();
        }

        private void UpdateHeaderIndicators()
        {
            // Have sort mode then need start remember header
            if (dicHeader.Count <= 0)
            {
                foreach (DataGridViewColumn col in dgTasks.Columns)
                {
                    dicHeader.Add(col.Name, col.HeaderText);
                }
            }

            // Reset all headers
            foreach (var col in dgTasks.Columns.Cast<DataGridViewColumn>())
            {
                if (dicHeader.TryGetValue(col.Name, out var original))
                {
                    col.HeaderText = original;
                }
            }

            // Apply sort indicators (based on sortOrder list)
            for (int i = 0; i < sortOrder.Count; i++)
            {
                var (colName, ascending) = sortOrder[i];

                if (dicHeader.TryGetValue(colName, out var original))
                {
                    string arrow = ascending ? " ▲" : " ▼";
                    dgTasks.Columns[colName].HeaderText = original + arrow + (i + 1);
                }
            }
        }

        private void dgTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex == dgTasks.Columns["drRemark"].Index || e.ColumnIndex == dgTasks.Columns["drInterval"].Index)
            {
                // ADD TEXT BOX
                Rectangle cellRect = dgTasks.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                int idx = Convert.ToInt32(dgTasks.Rows[e.RowIndex].Cells["drIndex"].Value);
                this.inForm.dicTasks.TryGetValue(idx, out var task);

                TextBox txtBox = new TextBox
                {
                    Bounds = cellRect,
                    Multiline = false,
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = ((e.ColumnIndex == dgTasks.Columns["drInterval"].Index) ?
                        Convert.ToString(task.Interval)
                        :
                        Convert.ToString(dgTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)),
                    Tag = e.RowIndex // So we can find it later
                };

                txtBox.Leave += (s, ev) =>
                {
                    string value = txtBox.Text;

                    // Also update TaskInfo immediately if needed
                    int idx = Convert.ToInt32(dgTasks.Rows[e.RowIndex].Cells["drIndex"].Value);
                    if (this.inForm.dicTasks.TryGetValue(idx, out var task))
                    {
                        if (e.ColumnIndex == dgTasks.Columns["drInterval"].Index)
                        {
                            task.Interval = Convert.ToInt32(value);
                            value = $"{task.Interval} {task.IntervalType}(s)";
                        }
                        else
                        {
                            task.Remark = value;
                        }
                    }

                    dgTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
                    dgTasks.Controls.Remove(txtBox);
                };

                dgTasks.Controls.Add(txtBox);
                txtBox.Focus();
            }
        }

        private void dgTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex == dgTasks.Columns["drCheck"].Index) // Assuming "Done" is the checkbox column
            {
                if (MessageBox.Show("Proceed?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow dr = dgTasks.Rows[e.RowIndex];
                    int rowIndex = Convert.ToInt32(dr.Cells["drIndex"].Value);
                    TaskInfo tsk = this.inForm.dicTasks[rowIndex];

                    if (tsk.Time != "") // IF SET BEFORE
                    {
                        if (string.IsNullOrWhiteSpace(inTxtTimer.Text))
                        {
                            MessageBox.Show("Must set time for this task.");
                            return;
                        }
                        else if (!(int.TryParse(inTxtTimer.Text, out int time) && inTxtTimer.Text.Length == 4 && Regex.IsMatch(inTxtTimer.Text, "(2[0-3]|[0-1][0-9])[0-5][0-9]")))
                        {
                            MessageBox.Show("Time must be 4 digits number with leading zero (With 2359 format).");
                            return;
                        }
                    }

                    tsk.Date = DateTime.Now;
                    tsk.UpdatedDate = DateTime.Now;
                    tsk.Remark = Convert.ToString(dr.Cells["drRemark"].Value) ?? "";
                    this.inForm.isDirty = true;

                    if (tsk.KeepHistory)
                    {
                        // KEEP HISTORY
                    }

                    // RENEW CURRENT ROW
                    if (this.inTab == "notice")
                    {
                        dgTasks.Rows.RemoveAt(e.RowIndex); // NO MORE EXPIRED SO REMOVE
                    }
                    else
                    {
                        this.Update(e.RowIndex, tsk);
                    }
                }
            }
        }

        private void dgTasks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dgTasks.Columns[e.ColumnIndex].Name;

            // Check if column already exists in sortOrder
            int existingIndex = sortOrder.FindIndex(x => x.ColumnName == columnName);
            if (existingIndex >= 0)
            {
                if (existingIndex != sortOrder.Count - 1)
                {
                    // Clear and set again
                    sortOrder.Clear(); // .RemoveAt(0);
                    sortOrder.Add((columnName, true));
                }
                else
                {
                    // Toggle ascending/descending
                    var current = sortOrder[existingIndex];
                    sortOrder[existingIndex] = (columnName, !current.Ascending);
                }
            }
            else
            {
                // Add new sort, keep max 3
                sortOrder.Add((columnName, true));
                if (sortOrder.Count > Form1.sortOrderMaxCount)
                    sortOrder.RemoveAt(0);
            }

            UpdateHeaderIndicators();
            ApplySort();
            PopulateTaskList();
        }

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTaskList();
        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTaskList();
        }
    }
}
