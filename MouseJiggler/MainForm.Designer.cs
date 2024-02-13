
namespace Dj.MouseJiggler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            jiggleTimer = new System.Windows.Forms.Timer(components);
            flpLayout = new System.Windows.Forms.FlowLayoutPanel();
            panelBase = new System.Windows.Forms.Panel();
            cmdTrayify = new System.Windows.Forms.Button();
            cbSettings = new System.Windows.Forms.CheckBox();
            cbJiggling = new System.Windows.Forms.CheckBox();
            panelSettings = new System.Windows.Forms.Panel();
            lbPeriod = new System.Windows.Forms.Label();
            tbPeriod = new System.Windows.Forms.TrackBar();
            cbZen = new System.Windows.Forms.CheckBox();
            niTray = new System.Windows.Forms.NotifyIcon(components);
            inactivityTimer = new System.Windows.Forms.Timer(components);
            flpLayout.SuspendLayout();
            panelBase.SuspendLayout();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).BeginInit();
            SuspendLayout();
            // 
            // jiggleTimer
            // 
            jiggleTimer.Interval = 1000;
            jiggleTimer.Tick += jiggleTimer_Tick;
            // 
            // flpLayout
            // 
            flpLayout.AutoSize = true;
            flpLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpLayout.Controls.Add(panelBase);
            flpLayout.Controls.Add(panelSettings);
            flpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            flpLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpLayout.Location = new System.Drawing.Point(0, 0);
            flpLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            flpLayout.Name = "flpLayout";
            flpLayout.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            flpLayout.Size = new System.Drawing.Size(434, 267);
            flpLayout.TabIndex = 2;
            // 
            // panelBase
            // 
            panelBase.Controls.Add(cmdTrayify);
            panelBase.Controls.Add(cbSettings);
            panelBase.Controls.Add(cbJiggling);
            panelBase.Location = new System.Drawing.Point(11, 13);
            panelBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelBase.Name = "panelBase";
            panelBase.Size = new System.Drawing.Size(413, 46);
            panelBase.TabIndex = 3;
            // 
            // cmdTrayify
            // 
            cmdTrayify.Location = new System.Drawing.Point(349, 4);
            cmdTrayify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmdTrayify.Name = "cmdTrayify";
            cmdTrayify.Size = new System.Drawing.Size(57, 38);
            cmdTrayify.TabIndex = 3;
            cmdTrayify.Text = "🔽";
            cmdTrayify.UseVisualStyleBackColor = true;
            cmdTrayify.Click += cmdTrayify_Click;
            // 
            // cbSettings
            // 
            cbSettings.Location = new System.Drawing.Point(126, 8);
            cbSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbSettings.Name = "cbSettings";
            cbSettings.Size = new System.Drawing.Size(110, 32);
            cbSettings.TabIndex = 1;
            cbSettings.Text = "Settings...";
            cbSettings.UseVisualStyleBackColor = true;
            cbSettings.CheckedChanged += cbSettings_CheckedChanged;
            // 
            // cbJiggling
            // 
            cbJiggling.AutoSize = true;
            cbJiggling.Location = new System.Drawing.Point(14, 8);
            cbJiggling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbJiggling.Name = "cbJiggling";
            cbJiggling.Size = new System.Drawing.Size(107, 29);
            cbJiggling.TabIndex = 0;
            cbJiggling.Text = "Jiggling?";
            cbJiggling.UseVisualStyleBackColor = true;
            cbJiggling.CheckedChanged += cbJiggling_CheckedChanged;
            // 
            // panelSettings
            // 
            panelSettings.AutoSize = true;
            panelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelSettings.Controls.Add(lbPeriod);
            panelSettings.Controls.Add(tbPeriod);
            panelSettings.Controls.Add(cbZen);
            panelSettings.Location = new System.Drawing.Point(11, 69);
            panelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new System.Drawing.Size(413, 178);
            panelSettings.TabIndex = 2;
            panelSettings.Visible = false;
            // 
            // lbPeriod
            // 
            lbPeriod.AutoSize = true;
            lbPeriod.Location = new System.Drawing.Point(349, 68);
            lbPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPeriod.Name = "lbPeriod";
            lbPeriod.Size = new System.Drawing.Size(35, 25);
            lbPeriod.TabIndex = 3;
            lbPeriod.Text = "1 s";
            // 
            // tbPeriod
            // 
            tbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbPeriod.Location = new System.Drawing.Point(6, 104);
            tbPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbPeriod.Maximum = 60;
            tbPeriod.Minimum = 1;
            tbPeriod.Name = "tbPeriod";
            tbPeriod.Size = new System.Drawing.Size(401, 69);
            tbPeriod.TabIndex = 6;
            tbPeriod.TickFrequency = 2;
            tbPeriod.Value = 1;
            tbPeriod.ValueChanged += tbPeriod_ValueChanged;
            // 
            // cbZen
            // 
            cbZen.AutoSize = true;
            cbZen.Location = new System.Drawing.Point(14, 18);
            cbZen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbZen.Name = "cbZen";
            cbZen.Size = new System.Drawing.Size(123, 29);
            cbZen.TabIndex = 4;
            cbZen.Text = "Zen jiggle?";
            cbZen.UseVisualStyleBackColor = true;
            cbZen.CheckedChanged += cbZen_CheckedChanged;
            // 
            // niTray
            // 
            niTray.Icon = (System.Drawing.Icon)resources.GetObject("niTray.Icon");
            niTray.Text = "Mouse Jiggler";
            niTray.DoubleClick += niTray_DoubleClick;
            // 
            // inactivityTimer
            // 
            inactivityTimer.Interval = 30000;
            inactivityTimer.Tick += inactivityTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(434, 267);
            Controls.Add(flpLayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Mouse Jiggler";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            flpLayout.ResumeLayout(false);
            flpLayout.PerformLayout();
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer jiggleTimer;
        private System.Windows.Forms.FlowLayoutPanel flpLayout;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TrackBar tbPeriod;
        private System.Windows.Forms.CheckBox cbZen;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.CheckBox cbSettings;
        private System.Windows.Forms.CheckBox cbJiggling;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.Button cmdTrayify;
        private System.Windows.Forms.Timer inactivityTimer;
    }
}

