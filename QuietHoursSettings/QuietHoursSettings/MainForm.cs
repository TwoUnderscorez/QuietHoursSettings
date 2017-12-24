using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;


namespace QuietHoursSettings
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            about_txt.Text = Properties.Settings.Default.aboutdata;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuietHoursKey();
            LoadHoursData();
        }
        /// <summary>
        /// Use GetHoursData() to update the text boxes
        /// </summary>
        void LoadHoursData()
        {
            int[] a = GetHoursData();
            start_hours_txt.Text = (a[0] / 60).ToString();
            start_min_txt.Text = (a[0] % 60).ToString();
            end_hours_txt.Text = (a[1] / 60).ToString();
            end_min_txt.Text = (a[1] % 60).ToString();
        }
        private void txts_TextChanged(object sender, EventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (!IsDigitsOnly(txt.Text))
            {
                MessageBox.Show("Please use numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Text = "";
            }
        }

        /// <summary>
        /// Checks whether a string contains only numbers
        /// </summary>
        /// <param name="str">String to check</param>
        /// <returns></returns>
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
                if (c < '0' || c > '9')
                    return false;
            return true;
        }
        /// <summary>
        /// Make sure the QuietHours key exists, if not, creates it
        /// </summary>
        private void QuietHoursKey()
        {
            var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Policies\Microsoft\Windows\CurrentVersion");
            if (!key.GetSubKeyNames().Contains("QuietHours"))
            {
                key.CreateSubKey("QuietHours");
            }
        }
        /// <summary>
        /// Sets the values for EntryTime and ExitTime
        /// </summary>
        /// <param name="start">EntryTime in minutes from midnight</param>
        /// <param name="end">ExitTime in minutes from midnight</param>
        private void SetHoursData(int start, int end)
        {
            var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Policies\Microsoft\Windows\CurrentVersion\QuietHours", true);
            key.SetValue("EntryTime", start, Microsoft.Win32.RegistryValueKind.DWord);
            key.SetValue("ExitTime", end, Microsoft.Win32.RegistryValueKind.DWord);
        }
        /// <summary>
        /// Get EntryTime and ExitTime from the registry. If they don't exist, returns 0, 0
        /// </summary>
        /// <returns></returns>
        private int[] GetHoursData()
        {
            var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Policies\Microsoft\Windows\CurrentVersion\QuietHours", true);
            Console.WriteLine(key.GetValue("asdf"));
            if (key.GetValue("EntryTime") == null || key.GetValue("ExitTime") == null)
                return new int[] { 0, 0 };
            return new int[] { int.Parse(key.GetValue("EntryTime").ToString()), int.Parse(key.GetValue("ExitTime").ToString()) };
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            QuietHoursKey();
            SetHoursData(int.Parse(start_hours_txt.Text)*60 + int.Parse(start_min_txt.Text),
                int.Parse(end_hours_txt.Text)*60 + int.Parse(end_min_txt.Text));
            LoadHoursData();
        }
    }
}
