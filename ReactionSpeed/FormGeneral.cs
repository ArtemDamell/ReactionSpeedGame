using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ReactionSpeed
{
    public partial class FormGeneral : Form
    {
        int totalClicks = 10;
        int click_nr = -1;
        int reactTime_ms;
        int my_card_nr;
        int waiting;
        int min_waiting = 1;
        int max_waiting = 4;

        Stopwatch watch = new Stopwatch();

        static Random rnd = new Random();
        public FormGeneral()
        {
            InitializeComponent();
            progress.Maximum = totalClicks;
        }

        /// <summary>
        /// Show the card corresponding to the given number.
        /// </summary>
        /// <param name="nr">The number of the card to show.</param>
        private void ShowCard(int nr)
        {
            pictureBox_img1.Visible = nr == 1;
            pictureBox_img2.Visible = nr == 2;
            pictureBox_img3.Visible = nr == 3;
        }

        /// <summary>
        /// This method handles the timer tick event. It checks if the click_nr is less than 0 and if the waiting time is greater than 0. 
        /// If the waiting time is greater than 0, it decrements the waiting time and if the waiting time is 0, 
        /// it generates a random card number and shows the card. 
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (click_nr < 0)
                return;
            if (waiting > 0)
            {
                waiting--;
                if (waiting == 0)
                {
                    my_card_nr = rnd.Next(1, 4);
                    ShowCard(my_card_nr);
                    watch.Restart();
                }
            }
        }

        /// <summary>
        /// Handles the click event of the start button. Sets the maximum waiting time based on the trackbar value, 
        /// sets the click number and reaction time to 0, and calls the NextClick method.
        /// </summary>
        private void button_start_Click(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0: max_waiting = 4; break;
                case 1: max_waiting = 2; break;
                case 2: max_waiting = 1; break;
            }


            click_nr = 0;
            reactTime_ms = 0;

            button_start.Enabled = false;

            NextClick();
        }

        /// <summary>
        /// This method is responsible for showing the next card and setting the waiting time for the next card. 
        /// </summary>
        private void NextClick()
        {
            ShowCard(0);
            click_nr++;
            waiting = rnd.Next(min_waiting * 1000 / timer.Interval, max_waiting * 1000 / timer.Interval + 1);

        }

        /// <summary>
        /// Handles the click event of the pictureBox_img1 control. Increments the click_nr, updates the progress bar, 
        /// and calls the ShowResult() or NextClick() methods depending on the click_nr value.
        /// </summary>
        private void pictureBox_img1_Click(object sender, EventArgs e)
        {
            if (click_nr == -1)
                return;

            watch.Stop();
            reactTime_ms += (int)watch.ElapsedMilliseconds;
            progress.Value = click_nr;

            if (click_nr >= totalClicks)
                ShowResult();
            else
                NextClick();
        }

        /// <summary>
        /// Displays the average reaction time in a message box and enables the start button.
        /// </summary>
        private void ShowResult()
        {
            double sec = reactTime_ms / 1000.0 / totalClicks;
            MessageBox.Show($"Average reaction time: {sec.ToString("0.000")} seconds", "Result");
            button_start.Enabled = true;
            click_nr = -1;
        }
    }
}
