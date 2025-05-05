namespace ClockPageAlgorithm
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            exit = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panelBg = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelBg.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 25, 77);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 36);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.circular_alarm_clock_tool;
            pictureBox1.Location = new Point(15, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.Cursor = Cursors.Hand;
            exit.Image = Properties.Resources.close;
            exit.Location = new Point(1198, 10);
            exit.Name = "exit";
            exit.Size = new Size(24, 16);
            exit.SizeMode = PictureBoxSizeMode.Zoom;
            exit.TabIndex = 27;
            exit.TabStop = false;
            exit.Click += pictureBox5_Click;
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
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(33, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(1153, 422);
            panel3.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(732, 83);
            label14.Name = "label14";
            label14.Size = new Size(155, 28);
            label14.TabIndex = 29;
            label14.Text = " X = page fault";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label15.ForeColor = Color.Navy;
            label15.Location = new Point(745, 55);
            label15.Name = "label15";
            label15.Size = new Size(306, 28);
            label15.TabIndex = 28;
            label15.Text = "  = 0 use bit (not recently used)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label16.ForeColor = Color.Navy;
            label16.Location = new Point(742, 27);
            label16.Name = "label16";
            label16.Size = new Size(271, 28);
            label16.TabIndex = 27;
            label16.Text = "* = 1 use bit (recently used)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label12.Location = new Point(1101, 320);
            label12.Name = "label12";
            label12.Size = new Size(28, 21);
            label12.TabIndex = 31;
            label12.Text = " X ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(1000, 320);
            label11.Name = "label11";
            label11.Size = new Size(28, 21);
            label11.TabIndex = 30;
            label11.Text = " X ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(897, 320);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 29;
            label10.Text = " X ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(797, 320);
            label9.Name = "label9";
            label9.Size = new Size(28, 21);
            label9.TabIndex = 28;
            label9.Text = " X ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(692, 320);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 27;
            label5.Text = " X ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(29, 72);
            label4.Name = "label4";
            label4.Size = new Size(503, 326);
            label4.TabIndex = 0;
            label4.Text = resources.GetString("label4.Text");
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.df9eafaf_7120_4b25_9de5_b4a840d70983;
            pictureBox5.Location = new Point(569, 136);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(581, 176);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click_1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(28, 25, 77);
            label3.Location = new Point(125, 12);
            label3.Name = "label3";
            label3.Size = new Size(285, 43);
            label3.TabIndex = 24;
            label3.Text = "How it Works?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.manual;
            pictureBox2.Location = new Point(55, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 28);
            label1.Name = "label1";
            label1.Size = new Size(1112, 150);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.next;
            pictureBox4.Location = new Point(1192, 325);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panelBg
            // 
            panelBg.Controls.Add(label1);
            panelBg.Controls.Add(panel3);
            panelBg.Location = new Point(0, 34);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(1238, 632);
            panelBg.TabIndex = 27;
            panelBg.Paint += panelBg_Paint;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 240);
            ClientSize = new Size(1238, 663);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(panelBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelBg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox exit;
        private Panel panelBg;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}