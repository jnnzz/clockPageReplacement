namespace clockPagetest1
{
    partial class clockPageForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            label2 = new Label();
            startButton = new Krypton.Toolkit.KryptonButton();
            nextButton = new Krypton.Toolkit.KryptonButton();
            labelReference = new Krypton.Toolkit.KryptonLabel();
            frameLabel = new Krypton.Toolkit.KryptonLabel();
            textReference = new Krypton.Toolkit.KryptonTextBox();
            textFrames = new Krypton.Toolkit.KryptonTextBox();
            panelDetails = new Panel();
            frameError = new Label();
            reqError = new Label();
            legendPanel = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            legendLabel = new Label();
            formulasPanel = new Panel();
            newReqBTN = new Krypton.Toolkit.KryptonButton();
            label5 = new Label();
            label4 = new Label();
            failureResult = new Label();
            failureLabel = new Label();
            label3 = new Label();
            successResult = new Label();
            successLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            exit = new PictureBox();
            lblInfo = new Label();
            showButton = new Krypton.Toolkit.KryptonButton();
            progressBar = new Krypton.Toolkit.KryptonProgressBar();
            marqueeBar = new Krypton.Toolkit.KryptonProgressBar();
            totalFaultsLabel = new Label();
            totalFaultsPanel = new Panel();
            pictureBox2 = new PictureBox();
            panelDetails.SuspendLayout();
            legendPanel.SuspendLayout();
            formulasPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            totalFaultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18.25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.LightSkyBlue;
            label2.Location = new Point(383, -1);
            label2.Name = "label2";
            label2.Size = new Size(463, 35);
            label2.TabIndex = 6;
            label2.Text = "CLOCK PAGE REPLACEMENT POLICY";
            // 
            // startButton
            // 
            startButton.Cursor = Cursors.Hand;
            startButton.Location = new Point(53, 346);
            startButton.Name = "startButton";
            startButton.OverrideDefault.Back.Color1 = Color.FromArgb(100, 210, 255);
            startButton.OverrideDefault.Back.Color2 = Color.FromArgb(100, 210, 255);
            startButton.Size = new Size(136, 42);
            startButton.StateCommon.Back.Color1 = Color.FromArgb(100, 210, 255);
            startButton.StateCommon.Back.Color2 = Color.FromArgb(100, 210, 255);
            startButton.StateCommon.Border.Rounding = 10F;
            startButton.StateCommon.Content.ShortText.Color1 = Color.MidnightBlue;
            startButton.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            startButton.TabIndex = 7;
            startButton.Values.DropDownArrowColor = Color.Empty;
            startButton.Values.Text = "Start";
            startButton.Click += startButton_Click_1;
            // 
            // nextButton
            // 
            nextButton.Cursor = Cursors.Hand;
            nextButton.Enabled = false;
            nextButton.Location = new Point(218, 346);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(136, 42);
            nextButton.StateCommon.Back.Color1 = Color.FromArgb(100, 210, 255);
            nextButton.StateCommon.Back.Color2 = Color.FromArgb(100, 210, 255);
            nextButton.StateCommon.Border.Rounding = 10F;
            nextButton.StateCommon.Content.ShortText.Color1 = Color.MidnightBlue;
            nextButton.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            nextButton.TabIndex = 8;
            nextButton.Values.DropDownArrowColor = Color.Empty;
            nextButton.Values.Text = "Next Step";
            nextButton.Click += nextButton_Click;
            // 
            // labelReference
            // 
            labelReference.Location = new Point(8, 46);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(391, 31);
            labelReference.StateCommon.ShortText.Color1 = Color.White;
            labelReference.StateCommon.ShortText.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            labelReference.TabIndex = 9;
            labelReference.Values.Text = "Enter page request (comma-separated):";
            // 
            // frameLabel
            // 
            frameLabel.Location = new Point(13, 182);
            frameLabel.Name = "frameLabel";
            frameLabel.Size = new Size(188, 30);
            frameLabel.StateCommon.ShortText.Color1 = Color.White;
            frameLabel.StateCommon.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frameLabel.TabIndex = 10;
            frameLabel.Values.Text = "Enter page Frames:";
            // 
            // textReference
            // 
            textReference.CueHint.CueHintText = "Enter page request";
            textReference.Location = new Point(13, 92);
            textReference.Multiline = true;
            textReference.Name = "textReference";
            textReference.Size = new Size(385, 39);
            textReference.StateCommon.Border.Rounding = 5F;
            textReference.StateCommon.Content.Font = new Font("Segoe UI", 12.25F);
            textReference.TabIndex = 12;
            textReference.KeyDown += textReference_KeyDown;
            // 
            // textFrames
            // 
            textFrames.CueHint.CueHintText = "Enter page frames";
            textFrames.Location = new Point(13, 228);
            textFrames.Multiline = true;
            textFrames.Name = "textFrames";
            textFrames.Size = new Size(385, 39);
            textFrames.StateCommon.Border.Rounding = 5F;
            textFrames.StateCommon.Content.Font = new Font("Segoe UI", 12.25F);
            textFrames.TabIndex = 13;
            textFrames.KeyDown += textFrames_KeyDown;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.FromArgb(28, 25, 77);
            panelDetails.Controls.Add(frameError);
            panelDetails.Controls.Add(reqError);
            panelDetails.Controls.Add(startButton);
            panelDetails.Controls.Add(nextButton);
            panelDetails.Controls.Add(labelReference);
            panelDetails.Controls.Add(textReference);
            panelDetails.Controls.Add(textFrames);
            panelDetails.Controls.Add(frameLabel);
            panelDetails.Location = new Point(406, 100);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(422, 443);
            panelDetails.TabIndex = 15;
            // 
            // frameError
            // 
            frameError.AutoSize = true;
            frameError.ForeColor = Color.Red;
            frameError.Location = new Point(13, 270);
            frameError.Name = "frameError";
            frameError.Size = new Size(0, 15);
            frameError.TabIndex = 15;
            // 
            // reqError
            // 
            reqError.AutoSize = true;
            reqError.ForeColor = Color.Red;
            reqError.Location = new Point(13, 134);
            reqError.Name = "reqError";
            reqError.Size = new Size(0, 15);
            reqError.TabIndex = 14;
            // 
            // legendPanel
            // 
            legendPanel.BackColor = Color.SkyBlue;
            legendPanel.Controls.Add(label8);
            legendPanel.Controls.Add(label7);
            legendPanel.Controls.Add(label6);
            legendPanel.Controls.Add(legendLabel);
            legendPanel.Location = new Point(670, 549);
            legendPanel.Name = "legendPanel";
            legendPanel.Size = new Size(284, 102);
            legendPanel.TabIndex = 16;
            legendPanel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(14, 4);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 26;
            label8.Text = "Legend:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(23, 66);
            label7.Name = "label7";
            label7.Size = new Size(118, 21);
            label7.TabIndex = 25;
            label7.Text = " X = page fault";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(33, 45);
            label6.Name = "label6";
            label6.Size = new Size(237, 21);
            label6.TabIndex = 24;
            label6.Text = "  = 0 use bit (not recently used)";
            // 
            // legendLabel
            // 
            legendLabel.AutoSize = true;
            legendLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            legendLabel.Location = new Point(30, 25);
            legendLabel.Name = "legendLabel";
            legendLabel.Size = new Size(211, 21);
            legendLabel.TabIndex = 23;
            legendLabel.Text = "* = 1 use bit (recently used)";
            // 
            // formulasPanel
            // 
            formulasPanel.BackColor = Color.FromArgb(0, 0, 64);
            formulasPanel.Controls.Add(newReqBTN);
            formulasPanel.Controls.Add(label5);
            formulasPanel.Controls.Add(label4);
            formulasPanel.Controls.Add(failureResult);
            formulasPanel.Controls.Add(failureLabel);
            formulasPanel.Controls.Add(label3);
            formulasPanel.Controls.Add(successResult);
            formulasPanel.Controls.Add(successLabel);
            formulasPanel.Controls.Add(label1);
            formulasPanel.Location = new Point(50, 100);
            formulasPanel.Name = "formulasPanel";
            formulasPanel.Size = new Size(422, 443);
            formulasPanel.TabIndex = 17;
            formulasPanel.Visible = false;
            // 
            // newReqBTN
            // 
            newReqBTN.Cursor = Cursors.Hand;
            newReqBTN.Location = new Point(117, 376);
            newReqBTN.Name = "newReqBTN";
            newReqBTN.Size = new Size(191, 38);
            newReqBTN.StateCommon.Back.Color1 = Color.FromArgb(100, 210, 255);
            newReqBTN.StateCommon.Back.Color2 = Color.FromArgb(100, 210, 255);
            newReqBTN.StateCommon.Border.Rounding = 5F;
            newReqBTN.StateCommon.Content.ShortText.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newReqBTN.TabIndex = 8;
            newReqBTN.Values.DropDownArrowColor = Color.Empty;
            newReqBTN.Values.Text = "New Page Request";
            newReqBTN.Click += kryptonButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(140, 205);
            label5.Name = "label5";
            label5.Size = new Size(148, 32);
            label5.TabIndex = 7;
            label5.Text = "Failure Rate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(132, 9);
            label4.Name = "label4";
            label4.Size = new Size(159, 32);
            label4.TabIndex = 6;
            label4.Text = "Success Rate";
            // 
            // failureResult
            // 
            failureResult.AutoSize = true;
            failureResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            failureResult.ForeColor = Color.DarkOrange;
            failureResult.Location = new Point(124, 326);
            failureResult.Name = "failureResult";
            failureResult.Size = new Size(65, 25);
            failureResult.TabIndex = 5;
            failureResult.Text = "label4";
            // 
            // failureLabel
            // 
            failureLabel.AutoSize = true;
            failureLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            failureLabel.ForeColor = Color.White;
            failureLabel.Location = new Point(163, 283);
            failureLabel.Name = "failureLabel";
            failureLabel.Size = new Size(70, 21);
            failureLabel.TabIndex = 4;
            failureLabel.Text = "= label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 249);
            label3.Name = "label3";
            label3.Size = new Size(317, 21);
            label3.TabIndex = 3;
            label3.Text = "= No. of interrupts/No. of Operation * 100";
            // 
            // successResult
            // 
            successResult.AutoSize = true;
            successResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            successResult.ForeColor = Color.Lime;
            successResult.Location = new Point(117, 150);
            successResult.Name = "successResult";
            successResult.Size = new Size(60, 25);
            successResult.TabIndex = 2;
            successResult.Text = "result";
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            successLabel.ForeColor = Color.White;
            successLabel.Location = new Point(160, 92);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(38, 25);
            successLabel.TabIndex = 1;
            successLabel.Text = "= 1";
            successLabel.Click += successLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 57);
            label1.Name = "label1";
            label1.Size = new Size(318, 20);
            label1.TabIndex = 0;
            label1.Text = "= No. of no interrupts/No. of Operation * 100";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 25, 77);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 36);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ClockPageAlgorithm.Properties.Resources.circular_alarm_clock_tool;
            pictureBox1.Location = new Point(15, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.Cursor = Cursors.Hand;
            exit.Image = ClockPageAlgorithm.Properties.Resources.close;
            exit.Location = new Point(1198, 10);
            exit.Name = "exit";
            exit.Size = new Size(24, 16);
            exit.SizeMode = PictureBoxSizeMode.Zoom;
            exit.TabIndex = 28;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInfo.ForeColor = Color.FromArgb(28, 25, 77);
            lblInfo.Location = new Point(531, 65);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 21);
            lblInfo.TabIndex = 21;
            // 
            // showButton
            // 
            showButton.Cursor = Cursors.Hand;
            showButton.Location = new Point(106, 574);
            showButton.Name = "showButton";
            showButton.Size = new Size(284, 47);
            showButton.StateCommon.Back.Color1 = Color.FromArgb(100, 210, 255);
            showButton.StateCommon.Back.Color2 = Color.FromArgb(100, 210, 255);
            showButton.StateCommon.Border.Rounding = 10F;
            showButton.StateCommon.Content.Padding = new Padding(4);
            showButton.StateCommon.Content.ShortText.Color1 = Color.FromArgb(28, 25, 77);
            showButton.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            showButton.TabIndex = 19;
            showButton.Values.DropDownArrowColor = Color.Empty;
            showButton.Values.Text = "Show Success/Failure Rates";
            showButton.Visible = false;
            showButton.Click += showButton_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(-4, 35);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1242, 20);
            progressBar.StateCommon.Back.Color1 = Color.RoyalBlue;
            progressBar.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progressBar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progressBar.TabIndex = 20;
            progressBar.Values.Text = "";
            // 
            // marqueeBar
            // 
            marqueeBar.Location = new Point(0, 35);
            marqueeBar.Name = "marqueeBar";
            marqueeBar.Size = new Size(1242, 20);
            marqueeBar.StateCommon.Back.Color1 = Color.RoyalBlue;
            marqueeBar.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            marqueeBar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            marqueeBar.Style = ProgressBarStyle.Marquee;
            marqueeBar.TabIndex = 22;
            marqueeBar.Values.Text = "";
            marqueeBar.Visible = false;
            // 
            // totalFaultsLabel
            // 
            totalFaultsLabel.AutoSize = true;
            totalFaultsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalFaultsLabel.Location = new Point(16, 7);
            totalFaultsLabel.Name = "totalFaultsLabel";
            totalFaultsLabel.Size = new Size(162, 25);
            totalFaultsLabel.TabIndex = 23;
            totalFaultsLabel.Text = "Total Page Fault: ";
            // 
            // totalFaultsPanel
            // 
            totalFaultsPanel.BackColor = Color.SkyBlue;
            totalFaultsPanel.Controls.Add(totalFaultsLabel);
            totalFaultsPanel.Location = new Point(860, 581);
            totalFaultsPanel.Name = "totalFaultsPanel";
            totalFaultsPanel.Size = new Size(228, 40);
            totalFaultsPanel.TabIndex = 24;
            totalFaultsPanel.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = ClockPageAlgorithm.Properties.Resources.previous;
            pictureBox2.Location = new Point(12, 301);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // clockPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 240);
            ClientSize = new Size(1238, 663);
            Controls.Add(pictureBox2);
            Controls.Add(showButton);
            Controls.Add(totalFaultsPanel);
            Controls.Add(marqueeBar);
            Controls.Add(lblInfo);
            Controls.Add(panel1);
            Controls.Add(formulasPanel);
            Controls.Add(legendPanel);
            Controls.Add(panelDetails);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clockPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            legendPanel.ResumeLayout(false);
            legendPanel.PerformLayout();
            formulasPanel.ResumeLayout(false);
            formulasPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            totalFaultsPanel.ResumeLayout(false);
            totalFaultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Krypton.Toolkit.KryptonButton startButton;
        private Krypton.Toolkit.KryptonButton nextButton;
        private Krypton.Toolkit.KryptonLabel labelReference;
        private Krypton.Toolkit.KryptonLabel frameLabel;
        private Krypton.Toolkit.KryptonTextBox textReference;
        private Krypton.Toolkit.KryptonTextBox textFrames;
        private Panel panelDetails;
        private Panel legendPanel;
        private Panel formulasPanel;
        private Label successLabel;
        private Label label1;
        private Label successResult;
        private Label failureResult;
        private Label failureLabel;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label reqError;
        private Label frameError;
        private Panel panel1;
        private Krypton.Toolkit.KryptonButton showButton;
        private Krypton.Toolkit.KryptonProgressBar progressBar;
        private Krypton.Toolkit.KryptonButton newReqBTN;
        private Label lblInfo;
        private Krypton.Toolkit.KryptonProgressBar marqueeBar;
        private Label legendLabel;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label totalFaultsLabel;
        private Panel totalFaultsPanel;
        private PictureBox exit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
