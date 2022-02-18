
namespace PIMap.PIMap_Forms
{
    partial class PIMap_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIMap_MainForm));
            this.LeftMenu_Panel = new System.Windows.Forms.Panel();
            this.Navigation_PanelINS = new System.Windows.Forms.Panel();
            this.Settings_ButtonINS = new System.Windows.Forms.Button();
            this.Home_ButtonINS = new System.Windows.Forms.Button();
            this.TextLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.MainLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.UserControl_Panel = new System.Windows.Forms.Panel();
            this.piMap_HomeUserControl1 = new PIMap.PIMap_UserControls.PIMap_HomeUserControl();
            this.piMap_SettingsUserControl1 = new PIMap.PIMap_UserControls.PIMap_SettingsUserControl();
            this.WindowState_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.LeftMenu_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextLogo_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo_PictureBox)).BeginInit();
            this.UserControl_Panel.SuspendLayout();
            this.WindowState_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMenu_Panel
            // 
            this.LeftMenu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LeftMenu_Panel.Controls.Add(this.Navigation_PanelINS);
            this.LeftMenu_Panel.Controls.Add(this.Settings_ButtonINS);
            this.LeftMenu_Panel.Controls.Add(this.Home_ButtonINS);
            this.LeftMenu_Panel.Controls.Add(this.TextLogo_PictureBox);
            this.LeftMenu_Panel.Controls.Add(this.MainLogo_PictureBox);
            this.LeftMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu_Panel.Name = "LeftMenu_Panel";
            this.LeftMenu_Panel.Size = new System.Drawing.Size(160, 583);
            this.LeftMenu_Panel.TabIndex = 0;
            // 
            // Navigation_PanelINS
            // 
            this.Navigation_PanelINS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.Navigation_PanelINS.Location = new System.Drawing.Point(0, 150);
            this.Navigation_PanelINS.Name = "Navigation_PanelINS";
            this.Navigation_PanelINS.Size = new System.Drawing.Size(2, 50);
            this.Navigation_PanelINS.TabIndex = 0;
            // 
            // Settings_ButtonINS
            // 
            this.Settings_ButtonINS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Settings_ButtonINS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_ButtonINS.FlatAppearance.BorderSize = 0;
            this.Settings_ButtonINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_ButtonINS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Settings_ButtonINS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.Settings_ButtonINS.Image = global::PIMap.PIMap_Resources.PIMap_SettingsIcon;
            this.Settings_ButtonINS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_ButtonINS.Location = new System.Drawing.Point(0, 533);
            this.Settings_ButtonINS.Name = "Settings_ButtonINS";
            this.Settings_ButtonINS.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Settings_ButtonINS.Size = new System.Drawing.Size(160, 50);
            this.Settings_ButtonINS.TabIndex = 3;
            this.Settings_ButtonINS.Text = "Settings";
            this.Settings_ButtonINS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_ButtonINS.UseVisualStyleBackColor = false;
            this.Settings_ButtonINS.Click += new System.EventHandler(this.Settings_ButtonINS_Click);
            // 
            // Home_ButtonINS
            // 
            this.Home_ButtonINS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Home_ButtonINS.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_ButtonINS.FlatAppearance.BorderSize = 0;
            this.Home_ButtonINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_ButtonINS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home_ButtonINS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.Home_ButtonINS.Image = global::PIMap.PIMap_Resources.PIMap_HomeIcon;
            this.Home_ButtonINS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_ButtonINS.Location = new System.Drawing.Point(0, 150);
            this.Home_ButtonINS.Name = "Home_ButtonINS";
            this.Home_ButtonINS.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Home_ButtonINS.Size = new System.Drawing.Size(160, 50);
            this.Home_ButtonINS.TabIndex = 2;
            this.Home_ButtonINS.Text = "Home";
            this.Home_ButtonINS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_ButtonINS.UseVisualStyleBackColor = false;
            this.Home_ButtonINS.Click += new System.EventHandler(this.Home_ButtonINS_Click);
            // 
            // TextLogo_PictureBox
            // 
            this.TextLogo_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextLogo_PictureBox.Image = global::PIMap.PIMap_Resources.PIMap_SmallLogoText;
            this.TextLogo_PictureBox.Location = new System.Drawing.Point(0, 100);
            this.TextLogo_PictureBox.Name = "TextLogo_PictureBox";
            this.TextLogo_PictureBox.Size = new System.Drawing.Size(160, 50);
            this.TextLogo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TextLogo_PictureBox.TabIndex = 1;
            this.TextLogo_PictureBox.TabStop = false;
            // 
            // MainLogo_PictureBox
            // 
            this.MainLogo_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainLogo_PictureBox.Image = global::PIMap.PIMap_Resources.PIMap_MainSmallLogo;
            this.MainLogo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainLogo_PictureBox.Name = "MainLogo_PictureBox";
            this.MainLogo_PictureBox.Size = new System.Drawing.Size(160, 100);
            this.MainLogo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainLogo_PictureBox.TabIndex = 0;
            this.MainLogo_PictureBox.TabStop = false;
            // 
            // UserControl_Panel
            // 
            this.UserControl_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.UserControl_Panel.Controls.Add(this.piMap_HomeUserControl1);
            this.UserControl_Panel.Controls.Add(this.piMap_SettingsUserControl1);
            this.UserControl_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserControl_Panel.Location = new System.Drawing.Point(160, 32);
            this.UserControl_Panel.Name = "UserControl_Panel";
            this.UserControl_Panel.Size = new System.Drawing.Size(462, 551);
            this.UserControl_Panel.TabIndex = 1;
            // 
            // piMap_HomeUserControl1
            // 
            this.piMap_HomeUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.piMap_HomeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piMap_HomeUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.piMap_HomeUserControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.piMap_HomeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.piMap_HomeUserControl1.Name = "piMap_HomeUserControl1";
            this.piMap_HomeUserControl1.Size = new System.Drawing.Size(462, 551);
            this.piMap_HomeUserControl1.TabIndex = 4;
            // 
            // piMap_SettingsUserControl1
            // 
            this.piMap_SettingsUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.piMap_SettingsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piMap_SettingsUserControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.piMap_SettingsUserControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.piMap_SettingsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.piMap_SettingsUserControl1.Name = "piMap_SettingsUserControl1";
            this.piMap_SettingsUserControl1.Size = new System.Drawing.Size(462, 551);
            this.piMap_SettingsUserControl1.TabIndex = 0;
            // 
            // WindowState_Panel
            // 
            this.WindowState_Panel.Controls.Add(this.Minimize_Button);
            this.WindowState_Panel.Controls.Add(this.Exit_Button);
            this.WindowState_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowState_Panel.Location = new System.Drawing.Point(160, 0);
            this.WindowState_Panel.Name = "WindowState_Panel";
            this.WindowState_Panel.Size = new System.Drawing.Size(462, 32);
            this.WindowState_Panel.TabIndex = 2;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Image = global::PIMap.PIMap_Resources.PIMap_MinimizeIcon;
            this.Minimize_Button.Location = new System.Drawing.Point(390, 0);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(36, 32);
            this.Minimize_Button.TabIndex = 1;
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Image = global::PIMap.PIMap_Resources.PIMap_ExitIcon_png;
            this.Exit_Button.Location = new System.Drawing.Point(426, 0);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(36, 32);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // PIMap_MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(622, 583);
            this.Controls.Add(this.WindowState_Panel);
            this.Controls.Add(this.UserControl_Panel);
            this.Controls.Add(this.LeftMenu_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PIMap_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIMap";
            this.LeftMenu_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextLogo_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo_PictureBox)).EndInit();
            this.UserControl_Panel.ResumeLayout(false);
            this.WindowState_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenu_Panel;
        private System.Windows.Forms.Panel UserControl_Panel;
        private System.Windows.Forms.PictureBox MainLogo_PictureBox;
        private System.Windows.Forms.PictureBox TextLogo_PictureBox;
        private System.Windows.Forms.Button Home_ButtonINS;
        private System.Windows.Forms.Button Settings_ButtonINS;
        private System.Windows.Forms.Panel Navigation_PanelINS;
        private System.Windows.Forms.Panel WindowState_Panel;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private PIMap_UserControls.PIMap_HomeUserControl piMap_HomeUserControl1;
        private PIMap_UserControls.PIMap_SettingsUserControl piMap_SettingsUserControl1;
    }
}