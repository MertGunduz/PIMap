using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Media;
using System.IO;
using System.Windows.Forms;

namespace PIMap.PIMap_UserControls
{
    public partial class PIMap_SettingsUserControl : UserControl
    {
        public PIMap_SettingsUserControl()
        {
            InitializeComponent();
        }

        private void PIMap_SettingsUserControl_Load(object sender, EventArgs e)
        {
            // Sets The Button Icon
            if (PIMap_Forms.PIMap_AwakeForm.permissionToWrite)
            {
                WriteDataFile_Button.Image = PIMap_Resources.PIMap_CheckedIcon;
            }
            else
            {
                WriteDataFile_Button.Image = PIMap_Resources.PIMap_UncheckedIcon;
            }
        }

        private void WriteDataFile_Button_Click(object sender, EventArgs e)
        {
            if (PIMap_Forms.PIMap_AwakeForm.permissionToWrite)
            {
                // Sets The Permission To False
                PIMap_Forms.PIMap_AwakeForm.permissionToWrite = false;
                WriteDataFile_Button.Image = PIMap_Resources.PIMap_UncheckedIcon;

                // Changing The Permission To Write_PERM_0
                
            }
            else
            {
                // Sets The Permission To True
                PIMap_Forms.PIMap_AwakeForm.permissionToWrite = true;
                WriteDataFile_Button.Image = PIMap_Resources.PIMap_CheckedIcon;

                // Changing The Permission To Write_PERM_1
            }
        }
    }
}