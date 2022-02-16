using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIMap.PIMap_Forms
{
    public partial class PIMap_AwakeForm : Form
    {
        // Variable Definitions
        int awakeTime = 0;

        public PIMap_AwakeForm()
        {
            InitializeComponent();
        }

        private void PIMap_AwakeForm_Load(object sender, EventArgs e)
        {
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