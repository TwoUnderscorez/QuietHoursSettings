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
    }
}
