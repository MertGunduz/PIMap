using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace PIMap.PIMap_UserControls
{
    public partial class PIMap_HomeUserControl : UserControl
    {
        // DATE STRINGS
        string userNumber;

        // PI String
        string piDigits;

        public PIMap_HomeUserControl()
        {
            InitializeComponent();
        }

        private void CalculatePIIndex_Button_Click(object sender, EventArgs e)
        {
            // Sets The String
            userNumber = EnterNumber_TextBox.Text;

            // Sets PI
            piDigits = PIMap_Resources.PI_TEXT;

            // Reads The Estimated Value & Shows The Index
            for (int i = 0; i < piDigits.Length; i++)
            {

            }
        }
    }
}
