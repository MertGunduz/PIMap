
namespace PIMap.PIMap_UserControls
{
    partial class PIMap_HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RightMargin_Panel = new System.Windows.Forms.Panel();
            this.LeftMargin_Panel = new System.Windows.Forms.Panel();
            this.TopMargin_Panel = new System.Windows.Forms.Panel();
            this.BottomMargin_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.CalculatePIIndex_Button = new System.Windows.Forms.Button();
            this.SecondButtonMargin_Panel = new System.Windows.Forms.Panel();
            this.CalculationResult_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.CalculationResult_PictureBox = new System.Windows.Forms.PictureBox();
            this.FirstButtonMargin_Panel = new System.Windows.Forms.Panel();
            this.EnterNumber_TextBox = new System.Windows.Forms.RichTextBox();
            this.InnerBottomBorder_Panel = new System.Windows.Forms.Panel();
            this.InnerTopBorder_Panel = new System.Windows.Forms.Panel();
            this.InnerLeftBorder_Panel = new System.Windows.Forms.Panel();
            this.InnerRightBorder_Panel = new System.Windows.Forms.Panel();
            this.BottomBorder_Panel = new System.Windows.Forms.Panel();
            this.TopBorder_Panel = new System.Windows.Forms.Panel();
            this.LeftBorder_Panel = new System.Windows.Forms.Panel();
            this.RightBorder_Panel = new System.Windows.Forms.Panel();
            this.PIIndexCalculator_BackgroundWorkerINS = new System.ComponentModel.BackgroundWorker();
            this.Main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalculationResult_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RightMargin_Panel
            // 
            this.RightMargin_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMargin_Panel.Location = new System.Drawing.Point(452, 0);
            this.RightMargin_Panel.Name = "RightMargin_Panel";
            this.RightMargin_Panel.Size = new System.Drawing.Size(10, 551);
            this.RightMargin_Panel.TabIndex = 0;
            // 
            // LeftMargin_Panel
            // 
            this.LeftMargin_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMargin_Panel.Location = new System.Drawing.Point(0, 0);
            this.LeftMargin_Panel.Name = "LeftMargin_Panel";
            this.LeftMargin_Panel.Size = new System.Drawing.Size(10, 551);
            this.LeftMargin_Panel.TabIndex = 1;
            // 
            // TopMargin_Panel
            // 
            this.TopMargin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMargin_Panel.Location = new System.Drawing.Point(10, 0);
            this.TopMargin_Panel.Name = "TopMargin_Panel";
            this.TopMargin_Panel.Size = new System.Drawing.Size(442, 10);
            this.TopMargin_Panel.TabIndex = 2;
            // 
            // BottomMargin_Panel
            // 
            this.BottomMargin_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMargin_Panel.Location = new System.Drawing.Point(10, 541);
            this.BottomMargin_Panel.Name = "BottomMargin_Panel";
            this.BottomMargin_Panel.Size = new System.Drawing.Size(442, 10);
            this.BottomMargin_Panel.TabIndex = 3;
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Main_Panel.Controls.Add(this.CalculatePIIndex_Button);
            this.Main_Panel.Controls.Add(this.SecondButtonMargin_Panel);
            this.Main_Panel.Controls.Add(this.CalculationResult_RichTextBox);
            this.Main_Panel.Controls.Add(this.CalculationResult_PictureBox);
            this.Main_Panel.Controls.Add(this.FirstButtonMargin_Panel);
            this.Main_Panel.Controls.Add(this.EnterNumber_TextBox);
            this.Main_Panel.Controls.Add(this.InnerBottomBorder_Panel);
            this.Main_Panel.Controls.Add(this.InnerTopBorder_Panel);
            this.Main_Panel.Controls.Add(this.InnerLeftBorder_Panel);
            this.Main_Panel.Controls.Add(this.InnerRightBorder_Panel);
            this.Main_Panel.Controls.Add(this.BottomBorder_Panel);
            this.Main_Panel.Controls.Add(this.TopBorder_Panel);
            this.Main_Panel.Controls.Add(this.LeftBorder_Panel);
            this.Main_Panel.Controls.Add(this.RightBorder_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(10, 10);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(442, 531);
            this.Main_Panel.TabIndex = 4;
            // 
            // CalculatePIIndex_Button
            // 
            this.CalculatePIIndex_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CalculatePIIndex_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculatePIIndex_Button.FlatAppearance.BorderSize = 0;
            this.CalculatePIIndex_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatePIIndex_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculatePIIndex_Button.Image = global::PIMap.PIMap_Resources.PIMap_StartCalculationIcon;
            this.CalculatePIIndex_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalculatePIIndex_Button.Location = new System.Drawing.Point(12, 469);
            this.CalculatePIIndex_Button.Name = "CalculatePIIndex_Button";
            this.CalculatePIIndex_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.CalculatePIIndex_Button.Size = new System.Drawing.Size(418, 50);
            this.CalculatePIIndex_Button.TabIndex = 23;
            this.CalculatePIIndex_Button.Text = "Calculate PI Index";
            this.CalculatePIIndex_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculatePIIndex_Button.UseVisualStyleBackColor = false;
            this.CalculatePIIndex_Button.Click += new System.EventHandler(this.CalculatePIIndex_Button_Click);
            // 
            // SecondButtonMargin_Panel
            // 
            this.SecondButtonMargin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondButtonMargin_Panel.Location = new System.Drawing.Point(12, 459);
            this.SecondButtonMargin_Panel.Name = "SecondButtonMargin_Panel";
            this.SecondButtonMargin_Panel.Size = new System.Drawing.Size(418, 10);
            this.SecondButtonMargin_Panel.TabIndex = 22;
            // 
            // CalculationResult_RichTextBox
            // 
            this.CalculationResult_RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CalculationResult_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalculationResult_RichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalculationResult_RichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.CalculationResult_RichTextBox.Location = new System.Drawing.Point(12, 122);
            this.CalculationResult_RichTextBox.Name = "CalculationResult_RichTextBox";
            this.CalculationResult_RichTextBox.Size = new System.Drawing.Size(418, 337);
            this.CalculationResult_RichTextBox.TabIndex = 21;
            this.CalculationResult_RichTextBox.Text = "";
            // 
            // CalculationResult_PictureBox
            // 
            this.CalculationResult_PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CalculationResult_PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalculationResult_PictureBox.Image = global::PIMap.PIMap_Resources.PIMap_CalculationText;
            this.CalculationResult_PictureBox.Location = new System.Drawing.Point(12, 72);
            this.CalculationResult_PictureBox.Name = "CalculationResult_PictureBox";
            this.CalculationResult_PictureBox.Size = new System.Drawing.Size(418, 50);
            this.CalculationResult_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CalculationResult_PictureBox.TabIndex = 18;
            this.CalculationResult_PictureBox.TabStop = false;
            // 
            // FirstButtonMargin_Panel
            // 
            this.FirstButtonMargin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstButtonMargin_Panel.Location = new System.Drawing.Point(12, 62);
            this.FirstButtonMargin_Panel.Name = "FirstButtonMargin_Panel";
            this.FirstButtonMargin_Panel.Size = new System.Drawing.Size(418, 10);
            this.FirstButtonMargin_Panel.TabIndex = 13;
            // 
            // EnterNumber_TextBox
            // 
            this.EnterNumber_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.EnterNumber_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterNumber_TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnterNumber_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.EnterNumber_TextBox.Location = new System.Drawing.Point(12, 12);
            this.EnterNumber_TextBox.Name = "EnterNumber_TextBox";
            this.EnterNumber_TextBox.Size = new System.Drawing.Size(418, 50);
            this.EnterNumber_TextBox.TabIndex = 12;
            this.EnterNumber_TextBox.Text = "  Enter Number:";
            // 
            // InnerBottomBorder_Panel
            // 
            this.InnerBottomBorder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InnerBottomBorder_Panel.Location = new System.Drawing.Point(12, 519);
            this.InnerBottomBorder_Panel.Name = "InnerBottomBorder_Panel";
            this.InnerBottomBorder_Panel.Size = new System.Drawing.Size(418, 10);
            this.InnerBottomBorder_Panel.TabIndex = 11;
            // 
            // InnerTopBorder_Panel
            // 
            this.InnerTopBorder_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InnerTopBorder_Panel.Location = new System.Drawing.Point(12, 2);
            this.InnerTopBorder_Panel.Name = "InnerTopBorder_Panel";
            this.InnerTopBorder_Panel.Size = new System.Drawing.Size(418, 10);
            this.InnerTopBorder_Panel.TabIndex = 10;
            // 
            // InnerLeftBorder_Panel
            // 
            this.InnerLeftBorder_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InnerLeftBorder_Panel.Location = new System.Drawing.Point(2, 2);
            this.InnerLeftBorder_Panel.Name = "InnerLeftBorder_Panel";
            this.InnerLeftBorder_Panel.Size = new System.Drawing.Size(10, 527);
            this.InnerLeftBorder_Panel.TabIndex = 9;
            // 
            // InnerRightBorder_Panel
            // 
            this.InnerRightBorder_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.InnerRightBorder_Panel.Location = new System.Drawing.Point(430, 2);
            this.InnerRightBorder_Panel.Name = "InnerRightBorder_Panel";
            this.InnerRightBorder_Panel.Size = new System.Drawing.Size(10, 527);
            this.InnerRightBorder_Panel.TabIndex = 8;
            // 
            // BottomBorder_Panel
            // 
            this.BottomBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.BottomBorder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorder_Panel.Location = new System.Drawing.Point(2, 529);
            this.BottomBorder_Panel.Name = "BottomBorder_Panel";
            this.BottomBorder_Panel.Size = new System.Drawing.Size(438, 2);
            this.BottomBorder_Panel.TabIndex = 7;
            // 
            // TopBorder_Panel
            // 
            this.TopBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.TopBorder_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder_Panel.Location = new System.Drawing.Point(2, 0);
            this.TopBorder_Panel.Name = "TopBorder_Panel";
            this.TopBorder_Panel.Size = new System.Drawing.Size(438, 2);
            this.TopBorder_Panel.TabIndex = 6;
            // 
            // LeftBorder_Panel
            // 
            this.LeftBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.LeftBorder_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder_Panel.Location = new System.Drawing.Point(0, 0);
            this.LeftBorder_Panel.Name = "LeftBorder_Panel";
            this.LeftBorder_Panel.Size = new System.Drawing.Size(2, 531);
            this.LeftBorder_Panel.TabIndex = 5;
            // 
            // RightBorder_Panel
            // 
            this.RightBorder_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.RightBorder_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder_Panel.Location = new System.Drawing.Point(440, 0);
            this.RightBorder_Panel.Name = "RightBorder_Panel";
            this.RightBorder_Panel.Size = new System.Drawing.Size(2, 531);
            this.RightBorder_Panel.TabIndex = 4;
            // 
            // PIIndexCalculator_BackgroundWorkerINS
            // 
            this.PIIndexCalculator_BackgroundWorkerINS.WorkerReportsProgress = true;
            this.PIIndexCalculator_BackgroundWorkerINS.WorkerSupportsCancellation = true;
            // 
            // PIMap_HomeUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.BottomMargin_Panel);
            this.Controls.Add(this.TopMargin_Panel);
            this.Controls.Add(this.LeftMargin_Panel);
            this.Controls.Add(this.RightMargin_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.Name = "PIMap_HomeUserControl";
            this.Size = new System.Drawing.Size(462, 551);
            this.Main_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CalculationResult_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RightMargin_Panel;
        private System.Windows.Forms.Panel LeftMargin_Panel;
        private System.Windows.Forms.Panel TopMargin_Panel;
        private System.Windows.Forms.Panel BottomMargin_Panel;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel BottomBorder_Panel;
        private System.Windows.Forms.Panel TopBorder_Panel;
        private System.Windows.Forms.Panel LeftBorder_Panel;
        private System.Windows.Forms.Panel RightBorder_Panel;
        private System.Windows.Forms.Panel InnerBottomBorder_Panel;
        private System.Windows.Forms.Panel InnerTopBorder_Panel;
        private System.Windows.Forms.Panel InnerLeftBorder_Panel;
        private System.Windows.Forms.Panel InnerRightBorder_Panel;
        private System.Windows.Forms.RichTextBox EnterNumber_TextBox;
        private System.Windows.Forms.Panel FirstButtonMargin_Panel;
        private System.Windows.Forms.Button CalculatePIIndex_Button;
        private System.Windows.Forms.Panel SecondButtonMargin_Panel;
        private System.Windows.Forms.RichTextBox CalculationResult_RichTextBox;
        private System.Windows.Forms.PictureBox CalculationResult_PictureBox;
        private System.ComponentModel.BackgroundWorker PIIndexCalculator_BackgroundWorkerINS;
    }
}
