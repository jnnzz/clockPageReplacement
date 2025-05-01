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
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panelBg = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(99, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 389);
            panel3.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(479, 254);
            label4.TabIndex = 0;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(28, 25, 77);
            label3.Location = new Point(126, 16);
            label3.Name = "label3";
            label3.Size = new Size(285, 43);
            label3.TabIndex = 24;
            label3.Text = "How it Works?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.manual;
            pictureBox2.Location = new Point(33, 20);
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
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(646, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 389);
            panel2.TabIndex = 25;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(37, 267);
            label8.Name = "label8";
            label8.Size = new Size(396, 92);
            label8.TabIndex = 3;
            label8.Text = "-Low overhead, high performance\nOffers performance close to LRU with much less system resource usage.";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(37, 174);
            label7.Name = "label7";
            label7.Size = new Size(445, 93);
            label7.TabIndex = 2;
            label7.Text = "-Simpler than LRU\nIt uses a \"use bit\" and circular pointer instead of complex tracking, making it easier to implement.";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(37, 74);
            label6.Name = "label6";
            label6.Size = new Size(435, 81);
            label6.TabIndex = 0;
            label6.Text = "-Efficient memory management\nIt reduces page faults by retaining frequently accessed pages in memory.";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.star1;
            pictureBox3.Location = new Point(81, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(28, 25, 77);
            label5.Location = new Point(146, 16);
            label5.Name = "label5";
            label5.Size = new Size(265, 45);
            label5.TabIndex = 0;
            label5.Text = "How important?";
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
            panelBg.Controls.Add(panel2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Panel panel2;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox exit;
        private Panel panelBg;
    }
}