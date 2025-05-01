using ClockPageAlgorithm;
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

namespace clockPagetest1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Make sure to attach the Paint event properly
            panelBg.Paint += panelBg_Paint;

            // Make sure the panel redraws when resized
            panelBg.Resize += (s, e) => panelBg.Invalidate();
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            clockPageForm clockPageForm = new clockPageForm();
            LoadingView loadingView = new LoadingView();
            loadingView.Show();
            await Task.Delay(500);
            clockPageForm.Show();
            loadingView.Hide();
            this.Close();

        }

        private void panelBg_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            // Define colors
            Color bottomColor = Color.FromArgb(28, 25, 77); // Dark purple
            Color midColor = Color.FromArgb(220, 225, 240);   // Intermediate color (optional)
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
                colorBlend.Positions = new float[] { 0f, 0.4f, 1f }; // 0% (bottom), 20%, 100% (top)
                colorBlend.Colors = new Color[] { bottomColor, midColor, topColor };

                brush.InterpolationColors = colorBlend;
                e.Graphics.FillRectangle(brush, panel.ClientRectangle);
            }
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            LoadingView loadingView = new LoadingView();
            loadingView.Show();
            await Task.Delay(500);
            informationForm.Show();
            loadingView.Hide();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        // Remove the empty panelBg_Paint_1 method completely
    }
}