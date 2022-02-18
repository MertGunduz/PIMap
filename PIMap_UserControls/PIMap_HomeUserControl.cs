using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace PIMap.PIMap_UserControls
{
    public partial class PIMap_HomeUserControl : UserControl
    {
        // DATE STRINGS
        string userNumber;

        // Comparer String
        string userNumberComparer;

        public PIMap_HomeUserControl()
        {
            InitializeComponent();
        }

        private void CalculatePIIndex_Button_Click(object sender, EventArgs e)
        {
            // Sets The UserNumberComparer To Empty
            userNumberComparer = String.Empty;

            // Sets The String
            userNumber = EnterNumber_TextBox.Text;

            // Writes The Calculation Number
            CalculationResult_RichTextBox.Text = $"  Calculation Number: {userNumber}\n\n";

            // Reads The Estimated Value & Shows The Index
            for (int i = 0; i < PIMap_Resources.PI_TEXT.Length; i++)
            {
                userNumberComparer += PIMap_Resources.PI_TEXT[i];

                if (userNumberComparer.Length == userNumber.Length)
                {
                    if (userNumberComparer == userNumber)
                    {
                        // Write Result
                        CalculationResult_RichTextBox.Text += "  - Index Found (1.000.000 Million Digits) -\n\n";
                        CalculationResult_RichTextBox.Text += $"  - Index Of {userNumber}: {i}\n\n";

                        // Write Indexes
                        for (int j = 0; j < userNumber.Length; j++)
                        {
                            CalculationResult_RichTextBox.Text += $"  - Index Of {userNumber[j]}: {i + j} -\n";
                        }

                        // Stop The Loop
                        break;
                    }
                    else
                    {
                        if (i >= PIMap_Resources.PI_TEXT.Length - userNumber.Length - 8)
                        {
                            // Write Result & Break
                            CalculationResult_RichTextBox.Text += "  - Index Not Found (1.000.000 Million Digits) -";

                            break;
                        }

                        // Make String Empty
                        userNumberComparer = String.Empty;
                    }
                }
            }
        }

        private void EnterNumber_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (EnterNumber_TextBox.Text == "  Enter Number:")
            {
                EnterNumber_TextBox.Clear();
            }
        }
    }
}