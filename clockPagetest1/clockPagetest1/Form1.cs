using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clockPagetest1
{
    public partial class Form1 : Form
    {
        private List<int> frames;
        private List<bool> useBits;
        private int clockPointer;
        private int[] referenceString;
        private int currentReferenceIndex;
        private Label lblInfo, outputLabel;
        private System.Windows.Forms.Timer animationTimer;
        private TextBox txtPages, txtFrames;
        private Button btnStart;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Clock Page Replacement";
            this.Size = new Size(600, 500);
            this.DoubleBuffered = true;

            Label lblPages = new Label()
            {
                Text = "Enter Page References (comma-separated):",
                Location = new Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(lblPages);

            txtPages = new TextBox()
            {
                Location = new Point(250, 10),
                Width = 300
            };
            this.Controls.Add(txtPages);

            Label lblFrames = new Label()
            {
                Text = "Enter Number of Frames:",
                Location = new Point(10, 40),
                AutoSize = true
            };
            this.Controls.Add(lblFrames);

            txtFrames = new TextBox()
            {
                Location = new Point(250, 40),
                Width = 50
            };
            this.Controls.Add(txtFrames);

            btnStart = new Button()
            {
                Text = "Start Simulation",
                Location = new Point(10, 70)
            };
            btnStart.Click += (s, e) => StartSimulation();
            this.Controls.Add(btnStart);

            lblInfo = new Label()
            {
                Text = "",
                Location = new Point(10, 100),
                AutoSize = true
            };
            this.Controls.Add(lblInfo);

            outputLabel = new Label()
            {
                AutoSize = false,
                Size = new Size(580, 300),
                Location = new Point(10, 130),
                Font = new Font("Courier New", 10),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(outputLabel);

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 1000;
            animationTimer.Tick += (s, e) => ProcessNextReference();
        } 

        private void StartSimulation()
        {
            try
            {
                string[] pagesInput = txtPages.Text.Split(',');
                referenceString = Array.ConvertAll(pagesInput, int.Parse);
                int frameCount = int.Parse(txtFrames.Text);

                frames = new List<int>(new int[frameCount]);
                useBits = new List<bool>(new bool[frameCount]);
                clockPointer = 0;
                currentReferenceIndex = 0;
                for (int i = 0; i < frameCount; i++) frames[i] = -1;

                outputLabel.Text = "";
                PrintTableHeader();
                animationTimer.Start();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter correct values.");
            }
        }

        private void ProcessNextReference()
        {
            if (currentReferenceIndex >= referenceString.Length)
            {
                animationTimer.Stop();
                lblInfo.Text = "Simulation Finished";
                return;
            }

            int page = referenceString[currentReferenceIndex++];
            bool pageFault = true;

            for (int i = 0; i < frames.Count; i++)
            {
                if (frames[i] == page)
                {
                    useBits[i] = true;
                    pageFault = false;
                    break;
                }
            }

            if (pageFault)
            {
                while (true)
                {
                    if (!useBits[clockPointer])
                    {
                        frames[clockPointer] = page;
                        useBits[clockPointer] = true;
                        clockPointer = (clockPointer + 1) % frames.Count;
                        break;
                    }
                    else
                    {
                        useBits[clockPointer] = false;
                        clockPointer = (clockPointer + 1) % frames.Count;
                    }
                }
            }

            PrintTableRow(page, pageFault);
        }

        private void PrintTableHeader()
        {
            string header = $"{"Time",-5} {"Page",-5} | ";
            for (int i = 0; i < frames.Count; i++)
            {
                header += $"Frame {i + 1} | ";
            }
            header += "Page Fault?\n";
            header += new string('-', 60) + "\n";
            outputLabel.Text = header;
        }

        private void PrintTableRow(int page, bool pageFault)
        {
            string row = $"{currentReferenceIndex,-5} {page,-5} | ";
            for (int i = 0; i < frames.Count; i++)
            {
                row += (frames[i] == -1 ? " " : frames[i].ToString()) + "      | ";
            }
            row += (pageFault ? "Yes" : "No");
            outputLabel.Text += row + "\n";
        }
    }
}
