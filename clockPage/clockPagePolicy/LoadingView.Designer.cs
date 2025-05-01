namespace clockPagetest1
{
    partial class LoadingView
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
            LoadingPanel = new Panel();
            LoadingPB = new Krypton.Toolkit.KryptonProgressBar();
            label1 = new Label();
            LoadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoadingPanel
            // 
            LoadingPanel.BackColor = Color.FromArgb(28, 25, 77);
            LoadingPanel.Controls.Add(LoadingPB);
            LoadingPanel.Controls.Add(label1);
            LoadingPanel.Location = new Point(0, 0);
            LoadingPanel.Name = "LoadingPanel";
            LoadingPanel.Size = new Size(683, 189);
            LoadingPanel.TabIndex = 74;
            // 
            // LoadingPB
            // 
            LoadingPB.Location = new Point(37, 98);
            LoadingPB.Name = "LoadingPB";
            LoadingPB.Size = new Size(597, 39);
            LoadingPB.StateCommon.Back.Color1 = Color.DodgerBlue;
            LoadingPB.StateCommon.Back.Color2 = Color.WhiteSmoke;
            LoadingPB.StateCommon.Border.Color1 = Color.FromArgb(0, 64, 64);
            LoadingPB.StateCommon.Border.Color2 = Color.White;
            LoadingPB.StateCommon.Border.Rounding = 1F;
            LoadingPB.StateCommon.Border.Width = 5;
            LoadingPB.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            LoadingPB.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            LoadingPB.Style = ProgressBarStyle.Marquee;
            LoadingPB.TabIndex = 3;
            LoadingPB.Values.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(262, 26);
            label1.Name = "label1";
            label1.Size = new Size(190, 60);
            label1.TabIndex = 2;
            label1.Text = "Loading...";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoadingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 189);
            Controls.Add(LoadingPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingView";
            LoadingPanel.ResumeLayout(false);
            LoadingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel LoadingPanel;
        private Label label1;
        private Krypton.Toolkit.KryptonProgressBar LoadingPB;
    }
}