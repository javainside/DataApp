using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Generator
{
    public partial class Form1 : Form
    {
        static bool randomFrequency;
        static bool stop = false;
        static Thread thr;
        static StreamWriter writer = new StreamWriter("dumy.txt");
        public Form1()
        {
            InitializeComponent();
            //System.IO.File.CreateText(@"F:\dumy.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_freq_random.Checked = randomFrequency = false;
            showRandomFrequencyControls(false);
            rb_fixed.Checked = true;
            num_rand.Hide();
        }

        private void cb_serverName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showRandomFrequencyControls(cb_freq_random.Checked);
        }

        private void showRandomFrequencyControls(bool show)
        {
            if (show)
            {
                num_freq_rand_hr.Enabled = true;
                num_freq_rand_min.Enabled = true;
                num_freq_rand_sec.Enabled = true;
            }
            else
            {
                num_freq_rand_hr.Enabled = false;
                num_freq_rand_min.Enabled = false;
                num_freq_rand_sec.Enabled = false;
            }
        }

        private void rb_random_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("change");
            if(rb_fixed.Checked)
            {
                num_rand.Hide();
            }
            else
            {
                num_rand.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bt_start.Text.Equals("Start"))
            {
                stop = false;
                //-- Get server and tag info
                string serverName = dd_serverName.GetItemText(dd_serverName.SelectedItem);
                string tagType = dd_tagType.GetItemText(dd_tagType.SelectedItem);
                string tagName = tb_tagName.Text;

                //-- Get Frequency
                int hours = Decimal.ToInt32(num_freq_hr.Value);
                int minutes = Decimal.ToInt32(num_freq_min.Value);
                int seconds = Decimal.ToInt32(num_freq_sec.Value);
                int rand_hours = 0;
                int rand_minutes = 0;
                int rand_seconds = 0;
                if (randomFrequency)
                {
                    rand_hours = Decimal.ToInt32(num_freq_hr.Value);
                    rand_minutes = Decimal.ToInt32(num_freq_min.Value);
                    rand_seconds = Decimal.ToInt32(num_freq_sec.Value);
                }

                //-- Get data info
                int data = Decimal.ToInt32(num_fixed.Value);

                //-- Get deviation info
                int deviationValue = Decimal.ToInt32(num_change.Value);
                double changeBy = Decimal.ToDouble(num_percentage.Value) / 100;


                //-- Generating Data
                int total_minutes = (hours * 60) + minutes;
                int total_seconds = (total_minutes * 60) + seconds;

                int total_minutes_rand = (rand_hours * 60) + rand_minutes;
                int total_seconds_rand = (total_minutes_rand * 60) + rand_seconds;
                if(total_seconds_rand < total_seconds)
                {
                    total_seconds_rand = 0;
                }

                thr = new Thread(() =>
                {
                    generateData(serverName, tagType, tagName, total_seconds, total_seconds_rand, data, deviationValue, changeBy);
                });
                bt_start.Text = "Stop";
                thr.Start();
                
            }
            else
            {
                bt_start.Text = "Start";
                stop = true;
                thr.Abort();
            }

        }

        private void generateData(string serverName, string tagType, string tagName, int total_seconds, int total_seconds_rand, int data, int changeAfter, double changeBy)
        {
            double dt = (double)data;
            Random rand = new Random();
            int counter = 0;
            while (!stop)
            {
                counter++;
                if(counter >= changeAfter)
                {
                    if(rand.Next(0, 2) == 0)
                    {
                        dt += changeBy;
                    }
                    else
                    {
                        dt -= changeBy;
                    }
                    //counter = -1;
                }
                writer = new StreamWriter(@"F:\dumy.txt", true);
                writer.WriteLine(DateTime.Now.ToString() + "\t\t" + dt);
                
                Thread.Sleep(total_seconds * 1000);
                if(total_seconds_rand > 0)
                {
                    int seconds = total_seconds_rand - total_seconds;
                    int random_seconds = rand.Next(0, seconds);
                    Thread.Sleep(random_seconds * 1000);
                    writer.WriteLine(DateTime.Now.ToString() + "\t\t" + dt);
                    //counter++;
                }
                writer.Close();
            }
            return;

        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
