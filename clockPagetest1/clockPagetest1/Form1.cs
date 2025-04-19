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
        private Label lblInfo2, outputLabel, timeLabel, pageRefLabel, allFrames;
        private TextBox txtPages, txtFrames;
        private Button btnStart, btnNextStep;
        private Panel timePanel;
        private int pageFaultCount = 0;
        private bool pageFault;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private int progressTarget = 0;
        private int clickCount = 0;

        double noFault;
        double failureRate;


        public Form1()
        {
            InitializeComponent();
            InitializeUI();
            InitializeTimer();

        }

        private void InitializeUI()
        {

            // Existing UI initialization code remains unchanged...
            this.Text = "Clock Page Replacement";



            Label lblPages = new Label()
            {
                Text = "Enter Page Requests (comma-separated):",
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
        
            lblInfo2 = new Label()
            {
                Text = "",
                Location = new Point(550, 69),
                Font = new Font("Verdana", 13),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true
            };
            this.Controls.Add(lblInfo);

            outputLabel = new Label()
            {
                AutoSize = false,
                Size = new Size(680, 380),
                Location = new Point(300, 280),
                Font = new Font("Verdana", 12, FontStyle.Bold),
                BackColor = Color.Bisque,
                BorderStyle = BorderStyle.FixedSingle

            };
            Controls.SetChildIndex(marqueeBar, 0); // 0 = Topmost
            Controls.SetChildIndex(progressBar, 1);
            //this.Controls.Add(outputLabel);




        }
        public void InitializeTimer()
        {

            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }
        private async Task StartSimulationWithAnimation()
        {
            marqueeBar.MarqueeAnimationSpeed = 10;
            // Step 1: Validate page request input
            string[] pagesInput = textReference.Text.Split(',');

            if (pagesInput.Length > 10)
            {
                reqError.Text = "Maximum of 10 page requests allowed.";
                textReference.Text = "";
                return;
            }

            foreach (string item in pagesInput)
            {
                if (!int.TryParse(item.Trim(), out _))
                {
                    reqError.Text = "Invalid input. Only numbers separated by commas are allowed.";

                    //MessageBox.Show("Invalid input. Only numbers separated by commas are allowed.");
                    textReference.Text = "";
                    // errorMessage.Text = "Invalid input. Only numbers separated by commas are allowed.";

                    return;
                }
            }

            // Step 2: Validate frame count
            if (!int.TryParse(textFrames.Text, out int frameCount))
            {
                frameError.Text = "Invalid number of frames. Please enter a valid number.";
                // MessageBox.Show("Invalid number of frames. Please enter a valid number.");
                textFrames.Text = "";
                return;
            }
            if (frameCount > 5)
            {
                frameError.Text = "Maximum of 5 frames allowed.";
                textFrames.Text = "";
                return;
            }
            try

            {
                reqError.Text = "";
                frameError.Text = "";
                pageFaultCount = 0;

                referenceString = Array.ConvertAll(pagesInput, int.Parse);

                frames = new List<int>(new int[frameCount]);
                useBits = new List<bool>(new bool[frameCount]);
                clockPointer = 0;
                currentReferenceIndex = 0;

                for (int i = 0; i < frameCount; i++) frames[i] = -1;

                outputLabel.Text = "";
                lblInfo.Text = "Initializing...";
                marqueeBar.Visible = true;

                // Animate the timeLabel into position
                await StartParallelAnimation();
                await AnimateTimeLabel();
                RowFrames(pageFault);

                lblInfo.Text = "Tap 'Next' to proceed.";
                marqueeBar.Visible = false;
                nextButton.Enabled = true;
                startButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }
        private void ProcessNextReference()
        {
            if (currentReferenceIndex >= referenceString.Length)
            {
                lblInfo.Text = "Simulation Finished";
              
                
                StartLegendAnimation();
                AnimateTotalFault();
            

                nextButton.Enabled = false;
                showButton.Visible = true;
                //panelColor.Visible = true;

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
            Task animation1 = AnimateLabelAsync(panelDetails, 30, 100, 2000);
            //Task animation2 = AnimateLabelAsync(textReference, 300, 200);
            // Task animation3 = AnimateLabelAsync(frameLabel, 300, 300);

            await Task.WhenAll(animation1); // Run concurrently
        }
        private async Task StartLegendAnimation()
        {
            Task animation1 = AnimateLabelAsync(legendPanel, 560, 549, 2000);


            await Task.WhenAll(animation1); // Run concurrently
        }
        private async Task StartNewRequest()
        {
            Task animation1 = AnimateLabelAsync(panelDetails, 424, 100, 2000);
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

        private async Task AnimateTimeLabel()
        {
            AnimatePanelLegend();
            allFrames = new Label()
            {
                Size = new Size(680, 380),
                Location = new Point(500, 160),
                Font = new Font("Consolas", 13, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(70, 65, 117),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(allFrames);
            allFrames.BringToFront();
            // Create and position the timeLabel initially off-screen
            timeLabel = new Label()
            {
                Location = new Point(500, 100), // Start off-screen
                Size = new Size(680, 30),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 13, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(28, 25, 77),
                TextAlign = ContentAlignment.MiddleLeft // Align text to the left
            };
            this.Controls.Add(timeLabel);
            // timeLabel.Controls.Add(timePanel);
             timeLabel.BringToFront();

            // Create and position the pageRefLabel initially off-screen
            pageRefLabel = new Label()
            {
                Location = new Point(500, 130), // Start below the timeLabel
                Size = new Size(680, 30),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(28, 25, 77),
                BackColor = Color.FromArgb(100, 210, 255),
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

            string pageRefText = "Page Req :  ";
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
                pageRefLabel.Width = newWidth;
                allFrames.Width = newWidth; // Adjust outputLabel width as well

                // Animate both labels simultaneously
                await Task.Delay(delay);
            }

        }


        private async Task AnimatePanelLegend()
        {
            legendPanel.Visible = true;
            int startWidth = 0; // Starting width
            int targetWidth = 284; // Target width
            int duration = 1000; // Total animation duration in milliseconds
            int steps = 50; // Number of animation steps
            int delay = duration / steps; // Delay between steps
            for (int i = 0; i <= steps; i++)
            {
                int newWidth = startWidth + (targetWidth - startWidth) * i / steps;
                legendPanel.Width = newWidth;
                // Adjust outputLabel width as well

                // Animate both labels simultaneously
                await Task.Delay(delay);
            }
        }
        private async Task AnimateTotalFault()
        {
            AnimateButtonRates();
            totalFaultsLabel.Text = "Total Page Faults: " + pageFaultCount;
            totalFaultsPanel.Visible = true;
            int startWidth = 0; // Starting width
            int targetWidth = 228; // Target width
            int duration = 1000; // Total animation duration in milliseconds
            int steps = 50; // Number of animation steps
            int delay = duration / steps; // Delay between steps
            for (int i = 0; i <= steps; i++)
            {
                int newWidth = startWidth + (targetWidth - startWidth) * i / steps;
                totalFaultsPanel.Width = newWidth;
                // Adjust outputLabel width as well

                // Animate both labels simultaneously
                await Task.Delay(delay);
            }
        }



        private async Task AnimatePanelFormula()
        {

            formulasPanel.BringToFront();
            formulasPanel.Visible = true;
            int startHeight = 0; // Start collapsed (height = 0)
            int targetHeight = 443;/* Your desired expanded height */;
            int duration = 1000;
            int steps = 50;
            int delay = duration / steps;
            int initialTop = formulasPanel.Top; // Keep original top position

            formulasPanel.Height = startHeight; // Start with 0 height

            for (int i = 0; i <= steps; i++)
            {
                int newHeight = startHeight + (targetHeight * i) / steps;
                formulasPanel.Height = newHeight; // Increase height downward
                await Task.Delay(delay);
            }
            MessageBox.Show("Formulas Panel Expanded");
        }
        private async Task AnimateButtonRates()
        {
            SuccessRate();
            FailureRate();
            showButton.Visible = true;
            int startHeight = 0; // Start collapsed (height = 0)
            int targetHeight = showButton.Height;/* Your desired expanded height */;
            int duration = 1000;
            int steps = 50;
            int delay = duration / steps;
            int initialTop = showButton.Top; // Keep original top position

            showButton.Height = startHeight; // Start with 0 height

            for (int i = 0; i <= steps; i++)
            {
                int newHeight = startHeight + (targetHeight * i) / steps;
                showButton.Height = newHeight; // Increase height downward
                await Task.Delay(delay);
            }
        }

        private async Task AnimatePanelFormulaClosing()
        {
            int startHeight = 443; // Current height
            int targetHeight = 0; // Collapse to 0
            int duration = 1000;
            int steps = 50;
            int delay = duration / steps;

            // We need to DECREASE the height, so we calculate from startHeight down to 0
            for (int i = 0; i <= steps; i++)
            {
                // Calculate the remaining progress (steps - i) to go from startHeight to 0
                int newHeight = startHeight - (startHeight * i) / steps;
                formulasPanel.Height = newHeight;
                await Task.Delay(delay);
            }

            formulasPanel.Visible = false; // Hide after animation completes
        }
        private async Task AnimateTotalFaultClosing()
        {

            int startWidth = totalFaultsPanel.Width; // Starting width
            int targetWidth = 0; // Target width
            int duration = 1000; // Total animation duration in milliseconds
            int steps = 50; // Number of animation steps
            int delay = duration / steps; // Delay between steps
            for (int i = 0; i <= steps; i++)
            {
                int newWidth = startWidth + (targetWidth - startWidth) * i / steps;
                totalFaultsPanel.Width = newWidth;
                // Adjust outputLabel width as well

                // Animate both labels simultaneously
                await Task.Delay(delay);
            }
            totalFaultsPanel.Visible = false; // Hide after animation completes
        }

        private async Task AnimatePanelLegendClosing()
        {
            int startWidth = legendPanel.Width; // Starting width
            int targetWidth = 0;// Target width
            int duration = 1000; // Total animation duration in milliseconds
            int steps = 50; // Number of animation steps
            int delay = duration / steps; // Delay between steps
            for (int i = 0; i <= steps; i++)
            {
                int newWidth = startWidth + (targetWidth - startWidth) * i / steps;
                legendPanel.Width = newWidth;
                // Adjust outputLabel width as well

                // Animate both labels simultaneously
                await Task.Delay(delay);
            }
            legendPanel.Visible = false;
        }
        private async Task AnimateTimeLabelClosing()
        {
            int startWidth = timeLabel.Width; // Starting width
            int targetWidth = 0; // Target width
            int duration = 1000; // Total animation duration in milliseconds
            int steps = 50; // Number of animation steps
            int delay = duration / steps; // Delay between steps



            // Animate the width
            for (int i = 0; i <= steps; i++)
            {
                int newWidth = startWidth + (targetWidth - startWidth) * i / steps;
                timeLabel.Width = newWidth;
                pageRefLabel.Width = newWidth;
                allFrames.Width = newWidth; // Adjust outputLabel width as well

                // Animate both labels simultaneously
                await Task.Delay(delay);
            }
            timeLabel.Visible = false; // Hide after animation completes
            pageRefLabel.Visible = false; // Hide after animation completes
            allFrames.Visible = false; // Hide after animation completes


        }
        private async Task AnimateButtonRatesClosing()
        {
            int startHeight = showButton.Height; // Current height
            int targetHeight = 0; // Collapse to 0
            int duration = 1000;
            int steps = 50;
            int delay = duration / steps;

            // We need to DECREASE the height, so we calculate from startHeight down to 0
            for (int i = 0; i <= steps; i++)
            {
                // Calculate the remaining progress (steps - i) to go from startHeight to 0
                int newHeight = startHeight - (startHeight * i) / steps;
                showButton.Height = newHeight;
                await Task.Delay(delay);
            }

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

            allFrames.Text = $"{allFrameRows} ";
            // outputTest.Text = $"{pageFault} ";
        }

        private void PrintTableRow(bool pageFault)
        {
            string[] lines = outputLabel.Text.Split('\n');

            List<string> frameRows = new List<string>();


            for (int i = 0; i < frames.Count; i++)
            {
                string existingLine = lines.Length > i + 3 ? lines[i + 3] : $"Frame #{i + 1} :";

                string frameValue = (frames[i] == -1 ? " " : frames[i].ToString());
                string useBitMarker = useBits[i] ? "*" : "";
                frameRows.Add(existingLine.PadRight(12) + $"{frameValue}{useBitMarker,-4}");

                Label frameLabel = new Label();
                frameLabel.AutoSize = true;
                frameLabel.Font = new Font("Consolas", 10);
                frameLabel.BackColor = Color.LightYellow;
                frameLabel.Text = $"Frame #{i + 1}: {frameValue}{useBitMarker}";
                frameLabel.Margin = new Padding(3);


                outputLabel.Controls.Add(frameLabel);
                frameLabel.BringToFront();
            }


            string pageFaultRow = lines.Length > frames.Count + 3 ? lines[frames.Count + 3] : "Page Fault: ";
            pageFaultRow += (pageFault ? $"{'X',-5}" : "     ");

            outputLabel.Text = $"\n\n\n{string.Join("\n", frameRows)}\n{pageFaultRow}";
        }
        private void SuccessRate()
        {

            noFault = referenceString.Length - pageFaultCount;
            successLabel.Text = "= " + noFault + "/" + referenceString.Length + " * 100";


            double successRate = (double)noFault / referenceString.Length * 100;
            successRate = Math.Round(successRate, 2);
            successResult.Text = "Success Rate: " + successRate + "%";
            // MessageBox.Show($"Success Rate: " + successRate);
        }
        private void FailureRate()
        {
            failureLabel.Text = "= " + pageFaultCount + "/" + referenceString.Length + " * 100";

            failureRate = (double)pageFaultCount / referenceString.Length * 100;
            failureRate = Math.Round(failureRate, 2);
            failureResult.Text = "Failure Rate: " + failureRate + "%";
            //MessageBox.Show($"Failure Rate: " + failureRate);
        }

        public void SmoothProgress(int targetValue)
        {
            progressTarget = targetValue; // Set the target value

            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (progressBar.Value < progressTarget)
                progressBar.Value++;
            else if (progressBar.Value > progressTarget)
                progressBar.Value--;
            else
                timer.Stop();

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


        }


        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // errorMessage.Text = "Invalid input. Only numbers separated by commas are allowed.";
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            int newLength = referenceString.Length + 1;

            if (clickCount < newLength)
            {
                clickCount++;
                int newTarget = (progressBar.Maximum * clickCount) / newLength;

                // Call the smoothed progress with calculated target
                SmoothProgress(newTarget);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            AnimatePanelFormula();

        }
        // LAST EDIT KAY DIRI NGA PART, WHICH IS ANG PAG RESTART TANAN LIKE SA VALUES POD NILA NEED I RESTART OR RESET PARA MO WORK BALIK [FIXED NA]
        // LATEST EDIT: 04/20/25, NEED NALANG ANG PAG RESET SA PROGRESS BAR. [FIXED NA]
        // LAST EDIT: 04/20/25, NEED NALANG ANG PAG ANIMATION CLOSING
        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
           timer.Stop();
            int newLength = referenceString.Length + 1;

            int startValue = progressBar.Value;
            int duration = 500; // Animation duration in ms
            int steps = 50;

            for (int i = 0; i <= steps; i++)
            {
                progressBar.Value = startValue - (startValue * i / steps);
                await Task.Delay(duration / steps);
            }

            clickCount = 0;
            await AnimatePanelFormulaClosing();

            lblInfo.Text = "";
            textReference.Text = "";
            textFrames.Text = "";
            outputLabel.Text = "";
            startButton.Enabled = true;


        }

        private void startButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}