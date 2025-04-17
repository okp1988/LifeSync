using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSync_App
{
    public partial class NoticeListUserControl : UserControl
    {
        public Form1 inForm;
        private DateTime today = DateTime.Today;

        public NoticeListUserControl(Form1 paForm)
        {
            this.inForm = paForm;
            InitializeComponent();
            InitializeComponent_Custom();
            ClearInputs();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgTask.PopulateTaskList(false, true);
            lblDate.Text = $"Last refresh: {DateTime.Now.ToString("dd MMM yyyy HH:mm")}";
        }

        private void ClearInputs()
        {
            txtTime.Text = "";
        }

        private void LoadData()
        {
            lblDate.Text = $"Last refresh: {DateTime.Now.ToString("dd MMM yyyy HH:mm")}";
        }

        public void CheckRefresh()
        {
            if (today != DateTime.Today || this.inForm.isDirty)
            {
                dgTask.PopulateTaskList(false, true);
                today = DateTime.Today;
                lblDate.Text = $"Last refresh: {DateTime.Now.ToString("dd MMM yyyy HH:mm")}";
            }
        }
    }
}
