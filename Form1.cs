using Microsoft.Win32;
using System.Text.Json;

namespace LifeSync_App
{
    public partial class Form1 : Form
    {
        public Dictionary<int, TaskInfo> dicTasks = new Dictionary<int, TaskInfo>();
        public static string tasksFile = "data/todo_tasks.json";
        public static int dayDiff = 1;
        public static int sortOrderMaxCount = 3;
        public bool isDirty = false;

        public Form1()
        {
            SetupTrayIcon();
            SetupAutoStart();
            LoadTasks();
            InitializeComponent();
            InitializeComponent_Custom();
        }

        // ----- Custom Code (Event Handlers, Tray Icon, AutoStart, etc.) -----

        private NotifyIcon trayIcon;

        private void SetupTrayIcon()
        {
            trayIcon = new NotifyIcon
            {
                Icon = System.Drawing.SystemIcons.Application,
                Text = "LifeSync",
                Visible = true
            };
            trayIcon.DoubleClick += (s, e) => ShowMainForm();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                //trayIcon.Visible = true;
                //trayIcon.ShowBalloonTip(1000, "LifeSync", "App minimized to tray.", ToolTipIcon.Info);
            }
        }

        private void ShowMainForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.tabControl_SelectedIndexChanged(null, null);
            //trayIcon.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty) { SaveTasks(); }
            trayIcon.Dispose();
        }

        private void SetupAutoStart()
        {
            try
            {
                string runKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
                RegistryKey startupKey = Registry.CurrentUser.OpenSubKey(runKey, true);
                string exePath = Application.ExecutablePath;
                startupKey.SetValue("LifeSync_App", exePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting auto-start: " + ex.Message);
            }
        }

        public void ShowAlert()
        {
            if (this.WindowState == FormWindowState.Minimized || !this.ContainsFocus)
            {
                trayIcon.ShowBalloonTip(1000, "LifeSync", "Task alert!", ToolTipIcon.Info);
            }
        }

        private void timerAction_Tick(object sender, EventArgs e)
        {
            // ALWAYS START 
            if (isDirty)
            {
                // DO SAVE FILE
                SaveTasks();
            }

            noticeControl.CheckRefresh();
            todoControl.CheckRefresh();
        }

        private void SaveTasks()
        {
            try
            {
                string json = JsonSerializer.Serialize(this.dicTasks, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(Form1.tasksFile, json);
                isDirty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving tasks: " + ex.Message);
            }
        }

        private void LoadTasks()
        {
            try
            {
                if (File.Exists(Form1.tasksFile))
                {
                    string json = File.ReadAllText(Form1.tasksFile);
                    this.dicTasks = JsonSerializer.Deserialize<Dictionary<int, TaskInfo>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tasks: " + ex.Message);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabNotice")
            {
                noticeControl.CheckRefresh();
            }
            else if (tabControl.SelectedTab.Name == "tabToDo")
            {
                todoControl.CheckRefresh();
            }
        }
    }
}
