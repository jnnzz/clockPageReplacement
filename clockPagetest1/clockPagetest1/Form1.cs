using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using Krypton.Toolkit;

namespace clockPagetest1
{
    public partial class Form1 : Form
    {
        private List<int> frames;
        private List<bool> useBits;
        private int clockPointer;
        private int[] referenceString;
        private int currentReferenceIndex;
        private Label lblInfo, outputLabel, timeLabel, pageRefLabel, outputTest;
        private TextBox txtPages, txtFrames;
        private Button btnStart, btnNextStep;
        private Panel timePanel;
        private int pageFaultCount = 0;
        private bool pageFault;
        double noFault;
        double failureRate;


        public Form1()
        {
            InitializeComponent();
            InitializeUI();

        }

        private void InitializeUI()
        {

            // Existing UI initialization code remains unchanged...
            this.Text = "Clock Page Replacement";



            Label lblPages = new Label()
            {
                Text = "Enter Page References (comma-separated):",
                Location = new Point(365, 85),
                AutoSize = true
            };
            // this.Controls.Add(lblPages);

            txtPages = new TextBox()
            {
                Location = new Point(622, 82),
                Width = 300
            };
            //this.Controls.Add(txtPages);

            Label lblFrames = new Label()
            {
                Text = "Enter Number of Frames:",
                Location = new Point(365, 114),
                AutoSize = true
            };
            //this.Controls.Add(lblFrames);

            txtFrames = new TextBox()
            {
                Location = new Point(622, 125),
                Width = 300
            };
            //this.Controls.Add(txtFrames);

            btnStart = new Button()
            {
                Text = "Start Simulation",
                Location = new Point(10, 100)
            };
            startButton.Click += async (s, e) => await StartSimulationWithAnimation(); // Updated to async
                                                                                       //this.Controls.Add(btnStart);

            btnNextStep = new Button()
            {
                Text = "Next Step",
                Location = new Point(130, 100),
                Enabled = false
            };
            nextButton.Click += (s, e) => ProcessNextReference();
            //this.Controls.Add(btnNextStep);

            lblInfo = new Label()
            {
                Text = "",
                Location = new Point(750, 65),
                Font = new Font("Verdana", 13),
                AutoSize = true
            };
            this.Controls.Add(lblInfo);

            outputLabel = new Label()
            {
                AutoSize = false,
                Size = new Size(680, 380),
                Location = new Point(300, 280),
                Font = new Font("Verdana", 12),
                BackColor = Color.Bisque,
                BorderStyle = BorderStyle.FixedSingle

            };
            //this.Controls.Add(outputLabel);




        }

        private async Task StartSimulationWithAnimation()
        {
            try
            {
                pageFaultCount = 0;
                //btnStart.Enabled = false;
                // Parse input
                string[] pagesInput = textReference.Text.Split(',');
                referenceString = Array.ConvertAll(pagesInput, int.Parse);
                int frameCount = int.Parse(textFrames.Text);

                frames = new List<int>(new int[frameCount]);
                useBits = new List<bool>(new bool[frameCount]);
                clockPointer = 0;
                currentReferenceIndex = 0;

                for (int i = 0; i < frameCount; i++) frames[i] = -1;

                outputLabel.Text = "";
                lblInfo.Text = "Initializing...";



                // Animate the timeLabel into position
                await StartParallelAnimation();
                //await AnimateLabelIntro();
                await AnimateTimeLabel();
                RowFrames(pageFault);
                //DisplayRowFrames();




                // Print table header after animation completes
                lblInfo.Text = "Press 'Next Step' to proceed.";
                nextButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter correct values.");
            }
        }
        private async Task AnimateLabelAsync(Panel panel, int targetX, int targetY, int duration)
        {
            int startX = panel.Left;
            int startY = panel.Top;

            var stopwatch = Stopwatch.StartNew();
            while (stopwatch.ElapsedMilliseconds < duration)
            {
                double progress = (double)stopwatch.ElapsedMilliseconds / duration;
                progress = Math.Min(progress, 1.0);
                progress = EaseOutQuint(progress); // Use easing for smoothness

                int newX = startX + (int)((targetX - startX) * progress);
                int newY = startY + (int)((targetY - startY) * progress);

                // Thread-safe UI update
                if (panel.InvokeRequired)
                {
                    panel.Invoke((MethodInvoker)(() => { panel.Left = newX; panel.Top = newY; }));
                }
                else
                {
                    panel.Left = newX;
                    panel.Top = newY;
                }
                await Task.Delay(16); // ~60 FPS
            }
            panel.Left = targetX; // Ensure final position is exact
            panel.Top = targetY;
        }

        private async Task StartParallelAnimation()
        {
            Task animation1 = AnimateLabelAsync(panelDetails, 30, 109, 2000);
            //Task animation2 = AnimateLabelAsync(textReference, 300, 200);
            // Task animation3 = AnimateLabelAsync(frameLabel, 300, 300);

            await Task.WhenAll(animation1); // Run concurrently
        }

        // Easing function (same as before)
        private double EaseOutQuint(double progress) => 1 - Math.Pow(1 - progress, 5);
        private async Task AnimateLabelIntro()
        {
            int startX = labelReference.Left; // Original X position
            int startY = labelReference.Top;  // Original Y position
            int targetX = 300;           // Target X position (adjust as needed)
            int targetY = 400;           // Target Y position (adjust as needed)
            int duration = 1000;         // Animation duration in milliseconds
            int steps = 50;              // Number of animation steps
            int delay = duration / steps; // Delay between steps

            for (int i = 0; i <= steps; i++)
            {
                // Calculate new X and Y positions (linear interpolation)
                int newX = startX + (int)((targetX - startX) * ((double)i / steps));
                int newY = startY + (int)((targetY - startY) * ((double)i / steps));

                labelReference.Left = newX;
                labelReference.Top = newY;
                await Task.Delay(delay);
            }
        }
        //  private async Task AnimatePanelTest()
        // {
        //    int startHeight = panelTest.Height;
        //     int duration = 1000;
        //     int steps = 50;
        //     int delay = duration / steps;
        //     int initialTop = panelTest.Top;

        //    for (int i = 0; i <= steps; i++)
        //    {
        //         int newHeight = startHeight - (startHeight * i) / steps;
        //         int newTop = initialTop + (startHeight - newHeight); // Adjust top position
        //
        //         panelTest.Height = newHeight;
        //         panelTest.Top = newTop;
        //        await Task.Delay(delay);
        //    }
        // }

        private async Task AnimateTimeLabel()
        {
            outputTest = new Label()
            {
                AutoSize = false,
                Size = new Size(680, 380),
                Location = new Point(500, 160),
                Font = new Font("Consolas", 13),
                ForeColor = Color.White,
                BackColor = Color.SteelBlue,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(outputTest);
            outputTest.BringToFront();
            // Create and position the timeLabel initially off-screen
            timeLabel = new Label()
            {
                Location = new Point(500, 100), // Start off-screen
                Size = new Size(680, 30),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 13),
                ForeColor = Color.Black,
                BackColor = Color.Beige,
                TextAlign = ContentAlignment.MiddleLeft // Align text to the left
            };
            this.Controls.Add(timeLabel);
            // timeLabel.Controls.Add(timePanel);
            // timeLabel.BringToFront();

            // Create and position the pageRefLabel initially off-screen
            pageRefLabel = new Label()
            {
                Location = new Point(500, 130), // Start below the timeLabel
                Size = new Size(680, 30),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 13),
                BackColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft // Align text to the left
            };
            this.Controls.Add(pageRefLabel);
            pageRefLabel.BringToFront();

            int startWidth = 0; // Starting width
            int targetWidth = 680; // Target width
            int duration = 1000; // Total animation duration in milliseconds
            int steps = 50; // Number of animation steps
            int delay = duration / steps; // Delay between steps

            // Build the timer and page ref text (remains unchanged)
            string timerText = "Time     :  ";
            for (int i = 0; i < referenceString.Length; i++)
                timerText += $"{i + 1,-5}";

            string pageRefText = "Page Ref :  ";
            for (int i = 0; i < referenceString.Length; i++)
                pageRefText += $"{referenceString[i],-5}";

            // Update labels before animation
            timeLabel.Text = timerText;
            pageRefLabel.Text = pageRefText;

            // Animate the width
            for (int i = 0; i <= steps; i++)
            {
                int newWidth = startWidth + (targetWidth - startWidth) * i / steps;
                timeLabel.Width = newWidth;
                pageRefLabel.Width = newWidth; // Animate both labels simultaneously
                await Task.Delay(delay);
            }
        }

        private void ProcessNextReference()
        {
            if (currentReferenceIndex >= referenceString.Length)
            {
                lblInfo.Text = "Simulation Finished";
                SuccessRate();
                FailureRate();
                nextButton.Enabled = false;
                panelColor.Visible = true;

                return;
            }

            int page = referenceString[currentReferenceIndex++];
            pageFault = true;

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
                pageFaultCount++;
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
            RowFrames(pageFault); // Pass pageFault to RowFrames method
        }
        //Pang display after start, then mawala na if next button is pressed
        /*private void DisplayRowFrames()
        {
            string[] lines = outputLabel.Text.Split('\n');
            string allFrameRows = "";

            for (int i = 0; i < frames.Count; i++)
            {
                string frameLine = lines.Length > i + 3 ? lines[i + 3] : $"Frame # testdaw{i + 1,-3}: ";
                allFrameRows += frameLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }

            outputTest.Text = allFrameRows;
        }*/

        // only display if ma press ang next button
        private void RowFrames(bool pageFault) // Add pageFault parameter
        {
            string[] lines = outputLabel.Text.Split('\n');
            string allFrameRows = "";

            for (int i = 0; i < frames.Count; i++)
            {
                string frameLine = lines.Length > i + 3 ? lines[i + 3] : $"Frame #{i + 1} :";
                allFrameRows += frameLine + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
            string pageFaultRow = lines.Length > frames.Count + 3 ? lines[frames.Count + 3] : "Page Fault: ";
            pageFaultRow += (pageFault ? $"{' ',-1}" : "    ");
            allFrameRows += pageFaultRow + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            outputTest.Text = $"{allFrameRows} ";
            // outputTest.Text = $"{pageFault} ";
        }

        private void PrintTableRow(bool pageFault)
        {
            string[] lines = outputLabel.Text.Split('\n');
            // string pageRefRow = lines.Length > 1 ? lines[1] : "Page Ref (test only):  ";

            List<string> frameRows = new List<string>();


            for (int i = 0; i < frames.Count; i++)
            {
                string existingLine = lines.Length > i + 3 ? lines[i + 3] : $"Frame #{i + 1} :";

                string frameValue = (frames[i] == -1 ? " " : frames[i].ToString());
                string useBitMarker = useBits[i] ? "*" : "";
                frameRows.Add(existingLine.PadRight(12) + $"{frameValue}{useBitMarker,-4}");
            }


            string pageFaultRow = lines.Length > frames.Count + 3 ? lines[frames.Count + 3] : "Page Fault: ";
            pageFaultRow += (pageFault ? $"{'X',-5}" : "     ");

            outputLabel.Text = $"\n\n\n{string.Join("\n", frameRows)}\n{pageFaultRow}";
        }
        private void SuccessRate()
        {
            formulasPanel.Visible = true;
            noFault = referenceString.Length - pageFaultCount;
            successLabel.Text = "= "+noFault+"/" + referenceString.Length + " * 100";
          

            double successRate = (double)noFault / referenceString.Length * 100;
            successRate = Math.Round(successRate, 2);
            successResult.Text = "Success Rate: "+successRate + "%";
           // MessageBox.Show($"Success Rate: " + successRate);
        }
        private void FailureRate()
        {
            failureLabel.Text = "= "+pageFaultCount + "/" + referenceString.Length + " * 100";

            failureRate = (double)pageFaultCount / referenceString.Length * 100;
            failureRate = Math.Round(failureRate, 2);
            failureResult.Text = "Failure Rate: "+failureRate + "%";
            //MessageBox.Show($"Failure Rate: " + failureRate);
        }

        private void displayResult()
        {
            Thread thread = new Thread(() =>
            {


            });

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelTest_Paint(object sender, PaintEventArgs e)
        {
            //

        }
        // private async void continueButton_Click(object sender, EventArgs e)
        // {
        //    await AnimatePanelTest();
        //}

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound
                if (textReference.Text != "")
                {
                    textFrames.Focus(); // Move focus to the next TextBox
                }
            }
        }



        private void textFrames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound
                if (textReference.Text != "")
                {
                    startButton.PerformClick(); // Move focus to the next TextBox
                }
            }
        }

        private void successLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
}