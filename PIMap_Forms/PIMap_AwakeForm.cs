using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PIMap.PIMap_Forms
{
    public partial class PIMap_AwakeForm : Form
    {
        // Variable Definitions
        int awakeTime = 0;

        // Permissions 
        public static bool permissionToWrite;

        // Language
        public enum Languages
        {
            English,
            Deutsch,
            Nederlands,
            Italiano,
            Turkish
        };

        public static Languages selectedLanguage;

        public PIMap_AwakeForm()
        {
            InitializeComponent();
        }

        private void PIMap_AwakeForm_Load(object sender, EventArgs e)
        {
            // Reads The Configuration File
            if (PIMap_Resources.Configuration_TEXT.Contains("WRITE_PERM_1"))
            {
                permissionToWrite = true;
            }
            else
            {
                permissionToWrite = false;
            }

            if (PIMap_Resources.Configuration_TEXT.Contains("English"))
            {
                selectedLanguage = Languages.English;
            }
            else if (PIMap_Resources.Configuration_TEXT.Contains("Deutsch"))
            {
                selectedLanguage = Languages.Deutsch;
            }
            else if (PIMap_Resources.Configuration_TEXT.Contains("Nederlands"))
            {
                selectedLanguage = Languages.Nederlands;
            }
            else if (PIMap_Resources.Configuration_TEXT.Contains("Italiano"))
            {
                selectedLanguage = Languages.Italiano;
            }
            else if (PIMap_Resources.Configuration_TEXT.Contains("Turkish"))
            {
                selectedLanguage = Languages.Turkish;
            }

            Awake_TimerINS.Start();
        }

        private void Awake_TimerINS_Tick(object sender, EventArgs e)
        {
            awakeTime++;

            if (awakeTime == 100)
            {
                Awake_TimerINS.Stop();

                PIMap_MainForm pIMap_MainForm = new PIMap_MainForm();
                this.Hide();
                pIMap_MainForm.Show();
            }
        }
    }
}