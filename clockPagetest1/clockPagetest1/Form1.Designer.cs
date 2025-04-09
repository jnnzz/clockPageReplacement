namespace clockPagetest1
{
    partial class Form1
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
            panelColor = new Panel();
            formulasPanel = new Panel();
            label5 = new Label();
            label4 = new Label();
            failureResult = new Label();
            failureLabel = new Label();
            label3 = new Label();
            successResult = new Label();
            successLabel = new Label();
            label1 = new Label();
            panelDetails.SuspendLayout();
            formulasPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(295, 13);
            label2.Name = "label2";
            label2.Size = new Size(659, 38);
            label2.TabIndex = 6;
            label2.Text = "CLOCK PAGE REPLACEMENT POLICY";
            // 
            // startButton
            // 
            startButton.Location = new Point(79, 311);
            startButton.Name = "startButton";
            startButton.Size = new Size(111, 42);
            startButton.StateCommon.Back.Color1 = Color.SkyBlue;
            startButton.StateCommon.Back.Color2 = Color.SkyBlue;
            startButton.StateCommon.Border.Rounding = 10F;
            startButton.StateCommon.Content.ShortText.Color1 = Color.MidnightBlue;
            startButton.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            startButton.TabIndex = 7;
            startButton.Values.DropDownArrowColor = Color.Empty;
            startButton.Values.Text = "Start";
            // 
            // nextButton
            // 
            nextButton.Location = new Point(255, 311);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(111, 42);
            nextButton.StateCommon.Back.Color1 = Color.SkyBlue;
            nextButton.StateCommon.Back.Color2 = Color.SkyBlue;
            nextButton.StateCommon.Border.Rounding = 10F;
            nextButton.StateCommon.Content.ShortText.Color1 = Color.MidnightBlue;
            nextButton.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nextButton.TabIndex = 8;
            nextButton.Values.DropDownArrowColor = Color.Empty;
            nextButton.Values.Text = "Next Step";
            // 
            // labelReference
            // 
            labelReference.Location = new Point(6, 45);
            labelReference.Name = "labelReference";
            labelReference.Size = new Size(409, 31);
            labelReference.StateCommon.ShortText.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold);
            labelReference.TabIndex = 9;
            labelReference.Values.Text = "Enter page reference (comma-separated):";
            // 
            // frameLabel
            // 
            frameLabel.Location = new Point(13, 182);
            frameLabel.Name = "frameLabel";
            frameLabel.Size = new Size(188, 30);
            frameLabel.StateCommon.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frameLabel.TabIndex = 10;
            frameLabel.Values.Text = "Enter page Frames:";
            frameLabel.Click += kryptonLabel2_Click;
            // 
            // textReference
            // 
            textReference.CueHint.CueHintText = "Enter page request";
            textReference.Location = new Point(13, 92);
            textReference.Multiline = true;
            textReference.Name = "textReference";
            textReference.Size = new Size(385, 39);
            textReference.StateCommon.Border.Rounding = 5F;
            textReference.StateCommon.Content.Font = new Font("Segoe UI", 11.25F);
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
            textFrames.StateCommon.Content.Font = new Font("Segoe UI", 11.25F);
            textFrames.TabIndex = 13;
            textFrames.KeyDown += textFrames_KeyDown;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.LightBlue;
            panelDetails.Controls.Add(startButton);
            panelDetails.Controls.Add(nextButton);
            panelDetails.Controls.Add(labelReference);
            panelDetails.Controls.Add(textReference);
            panelDetails.Controls.Add(textFrames);
            panelDetails.Controls.Add(frameLabel);
            panelDetails.Location = new Point(404, 136);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(422, 394);
            panelDetails.TabIndex = 15;
            // 
            // panelColor
            // 
            panelColor.BackColor = Color.SkyBlue;
            panelColor.Location = new Point(544, 595);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(200, 47);
            panelColor.TabIndex = 16;
            panelColor.Visible = false;
            // 
            // formulasPanel
            // 
            formulasPanel.BackColor = Color.SteelBlue;
            formulasPanel.Controls.Add(label5);
            formulasPanel.Controls.Add(label4);
            formulasPanel.Controls.Add(failureResult);
            formulasPanel.Controls.Add(failureLabel);
            formulasPanel.Controls.Add(label3);
            formulasPanel.Controls.Add(successResult);
            formulasPanel.Controls.Add(successLabel);
            formulasPanel.Controls.Add(label1);
            formulasPanel.Location = new Point(12, 137);
            formulasPanel.Name = "formulasPanel";
            formulasPanel.Size = new Size(362, 515);
            formulasPanel.TabIndex = 17;
            formulasPanel.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(108, 205);
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
            label4.Location = new Point(100, 9);
            label4.Name = "label4";
            label4.Size = new Size(159, 32);
            label4.TabIndex = 6;
            label4.Text = "Success Rate";
            // 
            // failureResult
            // 
            failureResult.AutoSize = true;
            failureResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            failureResult.ForeColor = Color.White;
            failureResult.Location = new Point(92, 326);
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
            failureLabel.Location = new Point(131, 283);
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
            label3.Location = new Point(20, 249);
            label3.Name = "label3";
            label3.Size = new Size(317, 21);
            label3.TabIndex = 3;
            label3.Text = "= No. of interrupts/No. of Operation * 100";
            // 
            // successResult
            // 
            successResult.AutoSize = true;
            successResult.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            successResult.ForeColor = Color.White;
            successResult.Location = new Point(85, 150);
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
            successLabel.Location = new Point(128, 92);
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
            label1.Location = new Point(17, 57);
            label1.Name = "label1";
            label1.Size = new Size(318, 20);
            label1.TabIndex = 0;
            label1.Text = "= No. of no interrupts/No. of Operation * 100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1238, 663);
            Controls.Add(formulasPanel);
            Controls.Add(panelColor);
            Controls.Add(panelDetails);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load_1;
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            formulasPanel.ResumeLayout(false);
            formulasPanel.PerformLayout();
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
        private Panel panelColor;
        private Panel formulasPanel;
        private Label successLabel;
        private Label label1;
        private Label successResult;
        private Label failureResult;
        private Label failureLabel;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}
