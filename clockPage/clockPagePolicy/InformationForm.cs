using clockPagetest1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockPageAlgorithm
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
            // Make sure to attach the Paint event properly
            panelBg.Paint += panelBg_Paint;

            // Make sure the panel redraws when resized
            panelBg.Resize += (s, e) => panelBg.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Size = new Size(400, 100); // Set your desired width and height
            label1.Text = "The Clock algorithm balances performance and simplicity\n"
                        + "by simulating a circular queue (like the hands of a clock)\n"
                        + "to track pages in memory.\n"
                        + "Each page has a 'use bit' to determine recent usage.";

        }

        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            // Show loading screen
            LoadingView loadingView = new LoadingView();
            loadingView.Show();

            // Simulate loading delay
            await Task.Delay(800);

            // Create and show the main form
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Hide loading screen
            loadingView.Hide();

            // Close the current form (without keeping the app running in the background)

            this.Hide();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.ExitThread();  // Terminates all forms and exits the application
        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
                Panel panel = sender as Panel;

                // Define colors
                Color bottomColor = Color.FromArgb(28, 25, 77); // Dark purple
                Color midColor = Color.White;   // Intermediate color (optional)
                Color topColor = Color.White;                   // Fade to white

                // Create a gradient brush
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    new Point(0, panel.Height),
                    new Point(0, 0),
                    bottomColor,
                    topColor))
                {
                    // Configure gradient stops (20% from bottom starts fading to white)
                    ColorBlend colorBlend = new ColorBlend();
                    colorBlend.Positions = new float[] { 0f, 0.3f, 1f }; // 0% (bottom), 20%, 100% (top)
                    colorBlend.Colors = new Color[] { bottomColor, midColor, topColor };

                    brush.InterpolationColors = colorBlend;
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle);
                }
            }
    }
}
