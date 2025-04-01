using System;
using System.Collections.Generic;
using System.Drawing;
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
        private TextBox txtPages, txtFrames;
        private Button btnStart, btnNextStep;
        private Panel panel1;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Clock Page Replacement";

            this.DoubleBuffered = true;

            Label lblPages = new Label()
            {
                Text = "Enter Page References (comma-separated):",
                Location = new Point(78, 24),
                AutoSize = true
            };
            this.Controls.Add(lblPages);

            txtPages = new TextBox()
            {
                Location = new Point(51, 63),
                Width = 300
            };
            this.Controls.Add(txtPages);

            Label lblFrames = new Label()
            {
                Text = "Enter Number of Frames:",
                Location = new Point(524, 23),
                AutoSize = true
            };
            this.Controls.Add(lblFrames);

            txtFrames = new TextBox()
            {
                Location = new Point(544, 63),
                Width = 50
            };
            this.Controls.Add(txtFrames);

            btnStart = new Button()
            {
                Text = "Start Simulation",
                Location = new Point(10, 70)
            };
            startButton.Click += (s, e) => StartSimulation(); // changed button
            //this.Controls.Add(btnStart);

            btnNextStep = new Button()
            {
                Text = "Next Step",
                Location = new Point(130, 70),
                Enabled = false
            };
            nextButton.Click += (s, e) => ProcessNextReference(); //changed button
            //this.Controls.Add(btnNextStep);

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
                Size = new Size(680, 380),
                Location = new Point(10, 10),
                Font = new Font("Courier New", 10),
                BorderStyle = BorderStyle.FixedSingle
            };
            //this.Controls.Add(outputLabel);

            panel1 = new Panel()
            {
                Location = new Point(120, 160),
                Size = new Size(700, 400),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightBlue
            };
            this.Controls.Add(panel1);
            panel1.Controls.Add(outputLabel);


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
                lblInfo.Text = "Press 'Next Step' to proceed.";

                btnNextStep.Enabled = true;
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
                lblInfo.Text = "Simulation Finished";
                btnNextStep.Enabled = false;
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

            PrintTableRow(pageFault);
        }

        private void PrintTableHeader()
        {
            outputLabel.Text = "Time:       ";
            for (int i = 0; i < referenceString.Length; i++)
                outputLabel.Text += $"{i + 1,-4}";

            outputLabel.Text += "\nPage Ref:   ";
            for (int i = 0; i < referenceString.Length; i++)
                outputLabel.Text += $"{referenceString[i],-4}";

            outputLabel.Text += "\n";
        }

        private void PrintTableRow(bool pageFault)
        {
            string[] lines = outputLabel.Text.Split('\n');
            string pageRefRow = lines.Length > 1 ? lines[1] : "Page Ref:  ";

            List<string> frameRows = new List<string>();
            for (int i = 0; i < frames.Count; i++)
            {
                string existingLine = lines.Length > i + 3 ? lines[i + 3] : $"Frame #{i + 1}: ";
                string frameValue = (frames[i] == -1 ? " " : frames[i].ToString());
                string useBitMarker = useBits[i] ? "*" : "";
                frameRows.Add(existingLine.PadRight(12) + $"{frameValue}{useBitMarker,-3}");
            }

            string pageFaultRow = lines.Length > frames.Count + 3 ? lines[frames.Count + 3] : "Page Fault: ";
            pageFaultRow += (pageFault ? $"{'X',-4}" : "    ");

            outputLabel.Text = $"{lines[0]}\n{pageRefRow}\n\n{string.Join("\n", frameRows)}\n{pageFaultRow}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Controls.Add(start);
        }
    }
}