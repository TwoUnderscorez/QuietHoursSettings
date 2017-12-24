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
            this.end_min_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.end_hours_txt = new MetroFramework.Controls.MetroTextBox();
            this.start_min_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.start_hours_txt = new MetroFramework.Controls.MetroTextBox();
            this.exit_btn = new MetroFramework.Controls.MetroButton();
            this.apply_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.about_tab = new MetroFramework.Controls.MetroTabPage();
            this.about_txt = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.settings_tab.SuspendLayout();
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
            this.settings_tab.Controls.Add(this.end_min_txt);
            this.settings_tab.Controls.Add(this.metroLabel4);
            this.settings_tab.Controls.Add(this.end_hours_txt);
            this.settings_tab.Controls.Add(this.start_min_txt);
            this.settings_tab.Controls.Add(this.metroLabel3);
            this.settings_tab.Controls.Add(this.start_hours_txt);
            this.settings_tab.Controls.Add(this.exit_btn);
            this.settings_tab.Controls.Add(this.apply_btn);
            this.settings_tab.Controls.Add(this.metroLabel2);
            this.settings_tab.Controls.Add(this.metroLabel1);
            this.settings_tab.HorizontalScrollbarBarColor = true;
            this.settings_tab.Location = new System.Drawing.Point(4, 35);
            this.settings_tab.Name = "settings_tab";
            this.settings_tab.Size = new System.Drawing.Size(457, 198);
            this.settings_tab.TabIndex = 0;
            this.settings_tab.Text = "Settings";
            this.settings_tab.VerticalScrollbarBarColor = true;
            // 
            // end_min_txt
            // 
            this.end_min_txt.Location = new System.Drawing.Point(122, 35);
            this.end_min_txt.Name = "end_min_txt";
            this.end_min_txt.Size = new System.Drawing.Size(26, 23);
            this.end_min_txt.TabIndex = 11;
            this.end_min_txt.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(110, 35);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(12, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = ":";
            // 
            // end_hours_txt
            // 
            this.end_hours_txt.Location = new System.Drawing.Point(83, 35);
            this.end_hours_txt.Name = "end_hours_txt";
            this.end_hours_txt.Size = new System.Drawing.Size(26, 23);
            this.end_hours_txt.TabIndex = 9;
            this.end_hours_txt.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // start_min_txt
            // 
            this.start_min_txt.Location = new System.Drawing.Point(122, 4);
            this.start_min_txt.Name = "start_min_txt";
            this.start_min_txt.Size = new System.Drawing.Size(26, 23);
            this.start_min_txt.TabIndex = 8;
            this.start_min_txt.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(110, 4);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(12, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = ":";
            // 
            // start_hours_txt
            // 
            this.start_hours_txt.Location = new System.Drawing.Point(83, 4);
            this.start_hours_txt.Name = "start_hours_txt";
            this.start_hours_txt.Size = new System.Drawing.Size(26, 23);
            this.start_hours_txt.TabIndex = 6;
            this.start_hours_txt.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(301, 172);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            // 
            // apply_btn
            // 
            this.apply_btn.Highlight = true;
            this.apply_btn.Location = new System.Drawing.Point(382, 172);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.apply_btn.TabIndex = 4;
            this.apply_btn.Text = "Apply";
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "End Time";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Start Time:";
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
            this.settings_tab.ResumeLayout(false);
            this.settings_tab.PerformLayout();
            this.about_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage settings_tab;
        private MetroFramework.Controls.MetroTabPage about_tab;
        private MetroFramework.Controls.MetroTextBox about_txt;
        private MetroFramework.Controls.MetroTextBox end_min_txt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox end_hours_txt;
        private MetroFramework.Controls.MetroTextBox start_min_txt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox start_hours_txt;
        private MetroFramework.Controls.MetroButton exit_btn;
        private MetroFramework.Controls.MetroButton apply_btn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

