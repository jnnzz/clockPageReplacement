namespace clockPagetest1
{
    partial class MainForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            exit = new PictureBox();
            label2 = new Label();
            panelBg = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            continueBtn = new Krypton.Toolkit.KryptonButton();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 19;
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
            exit.Location = new Point(1199, 10);
            exit.Name = "exit";
            exit.Size = new Size(24, 16);
            exit.SizeMode = PictureBoxSizeMode.Zoom;
            exit.TabIndex = 28;
            exit.TabStop = false;
            exit.Click += exit_Click;
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
            // panelBg
            // 
            panelBg.Controls.Add(pictureBox2);
            panelBg.Controls.Add(panel3);
            panelBg.Controls.Add(kryptonLabel3);
            panelBg.Controls.Add(continueBtn);
            panelBg.Controls.Add(kryptonLabel2);
            panelBg.Controls.Add(kryptonLabel1);
            panelBg.Location = new Point(0, 35);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(1238, 628);
            panelBg.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = ClockPageAlgorithm.Properties.Resources.previous;
            pictureBox2.Location = new Point(14, 266);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(kryptonLabel6);
            panel3.Controls.Add(kryptonLabel7);
            panel3.Controls.Add(kryptonLabel4);
            panel3.Controls.Add(kryptonLabel5);
            panel3.Location = new Point(218, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 232);
            panel3.TabIndex = 8;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(299, 125);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(287, 45);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.FromArgb(28, 25, 77);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            kryptonLabel6.TabIndex = 6;
            kryptonLabel6.Values.Text = "Ricardo Y. Baje Jr.";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(299, 179);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(261, 45);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.FromArgb(28, 25, 77);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            kryptonLabel7.TabIndex = 7;
            kryptonLabel7.Values.Text = "Niv Euric B. Tiba";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(67, 15);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(649, 45);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(28, 25, 77);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            kryptonLabel4.TabIndex = 4;
            kryptonLabel4.Values.Text = "Leader: Kenneth Christian Duane G.  Abilar";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(132, 70);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(484, 45);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(28, 25, 77);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            kryptonLabel5.TabIndex = 5;
            kryptonLabel5.Values.Text = "Members:  Jan Lorenz L. Laroco";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(438, 188);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(340, 45);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.Navy;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 3;
            kryptonLabel3.Values.Text = "Developed By: Group 6";
            // 
            // continueBtn
            // 
            continueBtn.Cursor = Cursors.Hand;
            continueBtn.Location = new Point(526, 541);
            continueBtn.Name = "continueBtn";
            continueBtn.OverrideDefault.Back.Color1 = Color.FromArgb(100, 210, 255);
            continueBtn.OverrideDefault.Back.Color2 = Color.FromArgb(100, 210, 255);
            continueBtn.Size = new Size(155, 39);
            continueBtn.StateCommon.Back.Color1 = Color.FromArgb(100, 210, 255);
            continueBtn.StateCommon.Back.Color2 = Color.FromArgb(100, 210, 255);
            continueBtn.StateCommon.Border.Rounding = 7F;
            continueBtn.StateCommon.Content.ShortText.Color1 = Color.Navy;
            continueBtn.StateCommon.Content.ShortText.Color2 = Color.Navy;
            continueBtn.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueBtn.TabIndex = 2;
            continueBtn.Values.DropDownArrowColor = Color.Empty;
            continueBtn.Values.Text = "Continue";
            continueBtn.Click += kryptonButton1_Click;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(182, 67);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(864, 72);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Navy;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "CLOCK PAGE REPLACEMENT POLICY";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(277, 3);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(669, 72);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Navy;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "SIMULATOR PROGRAM FOR";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 240);
            ClientSize = new Size(1238, 663);
            Controls.Add(panelBg);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panelBg;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton continueBtn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Panel panel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private PictureBox exit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}