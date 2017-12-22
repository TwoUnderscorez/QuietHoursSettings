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

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if(!IsDigitsOnly(txt.Text))
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
    }
}
