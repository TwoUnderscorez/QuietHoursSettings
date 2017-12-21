namespace QuietHoursSettings
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.settings_tab = new MetroFramework.Controls.MetroTabPage();
            this.about_tab = new MetroFramework.Controls.MetroTabPage();
            this.about_txt = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.about_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.settings_tab);
            this.metroTabControl1.Controls.Add(this.about_tab);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(465, 237);
            this.metroTabControl1.TabIndex = 0;
            // 
            // settings_tab
            // 
            this.settings_tab.HorizontalScrollbarBarColor = true;
            this.settings_tab.Location = new System.Drawing.Point(4, 35);
            this.settings_tab.Name = "settings_tab";
            this.settings_tab.Size = new System.Drawing.Size(457, 198);
            this.settings_tab.TabIndex = 0;
            this.settings_tab.Text = "Settings";
            this.settings_tab.VerticalScrollbarBarColor = true;
            // 
            // about_tab
            // 
            this.about_tab.Controls.Add(this.about_txt);
            this.about_tab.HorizontalScrollbarBarColor = true;
            this.about_tab.Location = new System.Drawing.Point(4, 35);
            this.about_tab.Name = "about_tab";
            this.about_tab.Size = new System.Drawing.Size(457, 198);
            this.about_tab.TabIndex = 1;
            this.about_tab.Text = "About";
            this.about_tab.VerticalScrollbarBarColor = true;
            // 
            // about_txt
            // 
            this.about_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about_txt.Location = new System.Drawing.Point(0, 0);
            this.about_txt.Multiline = true;
            this.about_txt.Name = "about_txt";
            this.about_txt.ReadOnly = true;
            this.about_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.about_txt.Size = new System.Drawing.Size(457, 198);
            this.about_txt.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 317);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Text = "Quiet Hours Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.about_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage settings_tab;
        private MetroFramework.Controls.MetroTabPage about_tab;
        private MetroFramework.Controls.MetroTextBox about_txt;
    }
}

