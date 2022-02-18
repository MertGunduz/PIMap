using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIMap.PIMap_Forms
{
    public partial class PIMap_MainForm : Form
    {
        public PIMap_MainForm()
        {
            InitializeComponent();
        }

        private void Home_ButtonINS_Click(object sender, EventArgs e)
        {
            ButtonUIChange(Home_ButtonINS, Settings_ButtonINS, Navigation_PanelINS, piMap_HomeUserControl1);
        }

        private void Settings_ButtonINS_Click(object sender, EventArgs e)
        {
            ButtonUIChange(Settings_ButtonINS, Home_ButtonINS, Navigation_PanelINS, piMap_SettingsUserControl1);
        }

        private void ButtonUIChange(Button clickedButton, Button otherButton, Panel navigationPanel, UserControl selectedUserControl)
        {
            // Sets The Clicked Button Color
            clickedButton.BackColor = Color.FromArgb(46, 51, 73);

            // Navigation Panel Location Set
            navigationPanel.Top = clickedButton.Top;
            navigationPanel.Height = clickedButton.Height;

            // Sets The Other Button Color
            otherButton.BackColor = Color.FromArgb(24, 30, 54);

            // Brings The Selected UserControl To Front
            selectedUserControl.BringToFront();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
