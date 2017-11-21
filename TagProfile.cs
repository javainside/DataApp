using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Data_Generator
{
    public partial class TagProfile : UserControl
    {
        //-- variable declaration
        //dropdown for string data
        ComboBox dd_string;
        string strServerName;
        string strTagType;
        string strTagName;
        bool stop;

        //-- Variables related to Data 
        bool data_random;
        int dataLowerLimit;
        int dataUpperLimit;
        double float_data;
        string string_data;
        double current_float_data;
        string current_string_data;

        //-- Variables related to Deviation Frequency
        bool devFrequency_random;
        int devFrequency;
        int devFrequencyLowerLimit;
        int devFrequencyUpperLimit;

        //-- Variables related to Deviation Percentage
        bool devPercentage_random;
        double devPercentage;
        int devPercLowerLimit;
        int devPercUpperLimit;

        //-- Variables related to Frequency Time
        bool time_random;
        int total_frequency_seconds;
        int total_frequency_seconds_random;

        static Thread thr;
        static StreamWriter writer;
        DataGenerator main;
        public TagProfile(DataGenerator obj)
        {
            InitializeComponent();
            
            main = obj;
        
            strServerName = strTagType = strTagName = "";
            stop = false;
            current_float_data = float_data = Decimal.ToDouble(num_fixed.Value);
            string_data = "";
            btnStop.Hide();

            dataLowerLimit = 0;
            dataUpperLimit = 0;

            devFrequency = 0;
            devFrequencyLowerLimit = 0;
            devFrequencyUpperLimit = 0;

            devPercentage = 0.0;
            devPercLowerLimit = 0;
            devPercUpperLimit = 0;

            total_frequency_seconds = 0;
            total_frequency_seconds_random = 0;

            //-- uncheck the random frequency box on start
            chkboxTimeRandom.Checked = time_random = false;
            //-- Disable Random Requency Time Controls
            showRandomFrequencyControls(false);
            data_random = false;   // set data mode true if data is fixed
            //-- Hide the upper number range control if value is fixed
            //numDataUpperLimit.Hide();

            numDataUpperLimit.Enabled = false;
            numDevFrequencyUpperLimit.Enabled = false;
            numDevPercUpperLimit.Enabled = false;

            //-- Drop down for string tag data and Hide on start
            dd_string = new ComboBox();
            grbboxTagData.Controls.Add(dd_string);
            dd_string.Location = new Point(122, 30);
            dd_string.Text = "Select Data";
            dd_string.Items.Add("ON");
            dd_string.Items.Add("OFF");
            dd_string.Hide();
        }

        public TagProfile(TagProfile parent, DataGenerator obj)
        {
            InitializeComponent();

            main = obj;

            strServerName = strTagType = strTagName = "";
            stop = false;
            float_data = 0.0;
            string_data = "";
            btnStop.Hide();

            dataLowerLimit = 0;
            dataUpperLimit = 0;

            devFrequency = 0;
            devFrequencyLowerLimit = 0;
            devFrequencyUpperLimit = 0;

            devPercentage = 0.0;
            devPercLowerLimit = 0;
            devPercUpperLimit = 0;

            total_frequency_seconds = 0;
            total_frequency_seconds_random = 0;

            //-- uncheck the random frequency box on start
            chkboxTimeRandom.Checked = time_random = false;
            //-- Disable Random Requency Time Controls
            showRandomFrequencyControls(false);
            data_random = false;   // set data mode true if data is fixed
            //-- Hide the upper number range control if value is fixed
            //numDataUpperLimit.Hide();

            numDataUpperLimit.Enabled = false;
            numDevFrequencyUpperLimit.Enabled = false;
            numDevPercUpperLimit.Enabled = false;

            //-- Drop down for string tag data and Hide on start
            dd_string = new ComboBox();
            grbboxTagData.Controls.Add(dd_string);
            dd_string.Location = new Point(122, 30);
            dd_string.Items.Add("ON");
            dd_string.Items.Add("OFF");
            dd_string.Hide();

            this.comboxServerName.SelectedIndex = parent.comboxServerName.SelectedIndex;
            this.comboxTagType.SelectedIndex = parent.comboxTagType.SelectedIndex;
            this.txtboxTagName.Text = parent.txtboxTagName.Text;
            //-- Data
            this.num_fixed.Value = parent.num_fixed.Value;
            this.chkboxDataRandom.Checked = parent.chkboxDataRandom.Checked;
            this.numDataUpperLimit.Value = parent.numDataUpperLimit.Value;
            this.dd_string.SelectedIndex = parent.dd_string.SelectedIndex;
            //-- Deviation Frequency
            this.numDevFrequency.Value = parent.numDevFrequency.Value;
            this.numDevFrequencyUpperLimit.Value = parent.numDevFrequencyUpperLimit.Value;
            this.chkboxDevFrequencyRandom.Checked = parent.chkboxDevFrequencyRandom.Checked;
            //-- Deviation Percentage
            this.numDevPerc.Value = parent.numDevPerc.Value;
            this.numDevPercUpperLimit.Value = parent.numDevPercUpperLimit.Value;
            this.chkboxDevPercRandom.Checked = parent.chkboxDevPercRandom.Checked;
            //-- Time Frequency
            this.numTimeStartHr.Value = parent.numTimeStartHr.Value;
            this.numTimeStartMin.Value = parent.numTimeStartMin.Value;
            this.numTimeStartSec.Value = parent.numTimeStartSec.Value;
            this.numTimeEndHr.Value = parent.numTimeEndHr.Value;
            this.numTimeEndMin.Value = parent.numTimeEndMin.Value;
            this.numTimeEndSec.Value = parent.numTimeEndSec.Value;
            this.chkboxTimeRandom.Checked = parent.chkboxTimeRandom.Checked;

        }

        //-- This method will enable or disable random frequency controls
        private void showRandomFrequencyControls(bool show)
        {
            if (show)   //if checkbox is checked
            {
                numTimeEndHr.Enabled = true;
                numTimeEndMin.Enabled = true;
                numTimeEndSec.Enabled = true;
            }
            else
            {
                numTimeEndHr.Enabled = false;
                numTimeEndMin.Enabled = false;
                numTimeEndSec.Enabled = false;
            }
        }

        //-- When start button will be clicked
        private void btnStart_Click(object sender, EventArgs e)
        {
        	System.Diagnostics.Debug.WriteLine("MANNY------btnStart_Click--------START");
            //If button text is start
            if (btnStart.Text.Equals("Start"))
            {
                if (Fetch_Form_Data())
                {
                    stop = false;

                    if (strTagType.Equals("String"))
                    {
                        //create a thread instance and if tag type is string then assign the generateStringData method to thread
                        thr = new Thread(() =>
                        {
                            generateStringData(this.strTagType, total_frequency_seconds, total_frequency_seconds_random, devFrequency, devPercentage);
                        });
                    }
                    else
                    {
                        //create a thread instance and if tag type is float then assign the generateFloatData method to thread
                        thr = new Thread(() =>
                        {
                            generateFloatData(this.strTagType, total_frequency_seconds, total_frequency_seconds_random, devFrequency, devPercentage);
                        });
                    }
                    //-- set button text to stop
                    btnStart.Text = "Stop";
                    //-- start the thread which call the method
                    thr.Start();
                }

            }
            else
            {
                //--If button text is start

                //-- Set the button text to "Start"
                btnStart.Text = "Start";
                stop = true;
                //-- Stop the thread
                thr.Abort();
            }
			System.Diagnostics.Debug.WriteLine("MANNY------btnStart_Click--------END");
			System.Diagnostics.Debug.WriteLine("MANNY--------------------------------------------------------");
        }

        private bool Fetch_Form_Data()
        {
            //-- Get server and tag info
            strServerName = comboxServerName.GetItemText(comboxServerName.SelectedItem);
            strTagType = comboxTagType.GetItemText(comboxTagType.SelectedItem);
            strTagName = txtboxTagName.Text;

            //-- Get data info
            if (!strTagType.Equals("String"))
            {
                //-- Get data
                //-- Get deviation frequency
                //-- Get Deviation Percentage
                //-- Get Time
                if (!(Fetch_Float_Data() && Fetch_Deviation_Frequency() && Fetch_Deviation_Percentage() && Fetch_Time()))
                {
                    return false;
                }
            }
            else
            {
                //-- when tag type is string call fetch string data function
                //-- Get data
                //-- Get Time
                if (!(Fetch_String_Data() && Fetch_Time()))
                {
                    return false;
                }
            }
            return true;
        }

        private bool Fetch_Float_Data()
        {
            if (!chkboxDataRandom.Checked)      //-- when data mode is fixed
            {
                float_data = Decimal.ToDouble(num_fixed.Value);
            }
            else                //-- when data mode is random
            {
                //-- GET lower and upper range and generate the random random within that range
                dataLowerLimit = Decimal.ToInt32(num_fixed.Value);
                dataUpperLimit = Decimal.ToInt32(numDataUpperLimit.Value);
                if (dataUpperLimit <= dataLowerLimit)
                {
                    MessageBox.Show("Data Upper Limit must be greater than lower");
                    return false;
                }
            }
            return true;
        }

        private bool Fetch_String_Data()
        {
            if (chkboxDataRandom.Checked)
            {
                string_data = "random";
            }
            else
            {
                string_data = dd_string.GetItemText(dd_string.SelectedItem);
            }
            return true;
        }

        private bool Fetch_Deviation_Frequency()
        {
            if (!chkboxDevFrequencyRandom.Checked)
            {
                devFrequency = Decimal.ToInt32(numDevFrequency.Value);
            }
            else
            {
                devFrequencyLowerLimit = Decimal.ToInt32(numDevFrequency.Value);
                devFrequencyUpperLimit = Decimal.ToInt32(numDevFrequencyUpperLimit.Value);
                if (devFrequencyUpperLimit <= devFrequencyLowerLimit)
                {
                    MessageBox.Show("Deviation Frequency Upper Limit must be greater than Lower");
                    return false;
                }
            }
            return true;
        }

        private bool Fetch_Deviation_Percentage()
        {
            if (!chkboxDevPercRandom.Checked)
            {
                devPercentage = Decimal.ToDouble(numDevPerc.Value) / 100;
            }
            else
            {
                devPercLowerLimit = Decimal.ToInt32(numDevPerc.Value);
                devPercUpperLimit = Decimal.ToInt32(numDevPercUpperLimit.Value);
                if (devPercUpperLimit <= devPercLowerLimit)
                {
                    MessageBox.Show("Deviation Percentage Upper Limit must be greater than Lower Limit");
                    return false;
                }
            }
            return true;
        }

        private bool Fetch_Time()
        {
            //-- Get Frequency
            int hours = Decimal.ToInt32(numTimeStartHr.Value);
            int minutes = Decimal.ToInt32(numTimeStartMin.Value);
            int seconds = Decimal.ToInt32(numTimeStartSec.Value);

            //-- If Frequency is invalid
            if ((hours == 0) && (minutes == 0) && (seconds == 0))
            {
                MessageBox.Show("Invalid Frequency Time");
                return false;
            }

            //Converting frequenc time to seconds
            int total_minutes = (hours * 60) + minutes;
            total_frequency_seconds = (total_minutes * 60) + seconds;


            if (chkboxTimeRandom.Checked)
            {
                //-- Variables if random frequency is "ON"
                int rand_hours = 0;
                int rand_minutes = 0;
                int rand_seconds = 0;

                //-- Get random frequency info
                rand_hours = Decimal.ToInt32(numTimeEndHr.Value);
                rand_minutes = Decimal.ToInt32(numTimeEndMin.Value);
                rand_seconds = Decimal.ToInt32(numTimeEndSec.Value);

                int total_minutes_rand = (rand_hours * 60) + rand_minutes;
                total_frequency_seconds_random = (total_minutes_rand * 60) + rand_seconds;

                //comparing the random time with normal time
                if (total_frequency_seconds_random < total_frequency_seconds)
                {
                    total_frequency_seconds_random = 0;
                    MessageBox.Show("Random Frquency Time must be greater then Normal Time");
                    return false;
                }
            }
            return true;
        }

        private void generateFloatData(string strTagType, int total_seconds, int total_seconds_rand, int changeAfter, double changeBy)
        {
            //-- create  the instance of Random to generate random number
            Random rand = new Random();
            double data = float_data;
            if (this.data_random)
            {
                data = rand.Next(this.dataLowerLimit, this.dataUpperLimit + 1);
            }

            //-- Get the change value to be added or subtracted
            double change = float_data * changeBy;
            if (this.devFrequency_random)
            {
                changeAfter = rand.Next(this.devFrequencyLowerLimit, this.devFrequencyUpperLimit + 1);
            }

            //set the counter to 0 for value change
            int counter = 0;
            //-- loop will run untill stop is not clicked
            while (!stop)
            {
                //-- Open the file in append mode
                // writer = new StreamWriter(@"\dumy.txt", true);


                //-- Open the file in append mode
                string strDriveLetter = Path.GetPathRoot(Environment.CurrentDirectory);
                string strFilePath = strDriveLetter + @"\Hugh\DataApp\DataApp\Data Generator\output\Float-" + strTagName + ".txt";
                //string strFilePath = "F:\test.txt";
                //StreamWriter sw = new StreamWriter(path);


                writer = new StreamWriter(strFilePath, true);

                //-- increment counter
                counter++;
                //-- if counter is greater then or equal to changeAfter
                if (counter >= changeAfter)
                {

                    if (this.devFrequency_random)
                    {
                        changeAfter = rand.Next(this.devFrequencyLowerLimit, this.devFrequencyUpperLimit + 1);
                    }
                    if (this.devPercentage_random)
                    {
                        changeBy = rand.Next(this.devPercLowerLimit, this.devPercUpperLimit + 1);
                    }
                    change = data * changeBy;
                    //-- generate and check the random number between 0 and 1, if its equal to 0 then add the deviation value otherwise subtract
                    if (rand.Next(0, 2) == 0)
                    {
                        data += change;
                    }
                    else
                    {
                        data -= change;
                    }
                    //-- update value
                    main.updateValue(strTagName, data, this);
                    //-- write the data to file
                    writer.WriteLine(DateTime.Now.ToString() + "\t\t" + data);
                    //-- set data back to original data
                    data = float_data;
                    //-- set counter to 0
                    counter = 0;
                    if (this.data_random)
                    {
                        data = rand.Next(this.dataLowerLimit, this.dataUpperLimit + 1);
                    }
                }
                else
                {
                    main.updateValue(strTagName, data, this);
                    //-- write the data to file
                    writer.WriteLine(DateTime.Now.ToString() + "\t\t" + data);
                }
                //-- close the file to save the data
                writer.Close();

                //-- wait for time frequency time
                Thread.Sleep(total_seconds * 1000);
                //-- check if random frequecy time is valid
                if (total_seconds_rand > 0)
                {
                    //-- get the difference of random and normal frequency seconds
                    int seconds = total_seconds_rand - total_seconds;
                    //-- generate the random number for random frequency wait
                    int random_seconds = rand.Next(0, seconds);
                    //-- wait for random frequency
                    Thread.Sleep(random_seconds * 1000);
                }
            }
            return;

        }

        private void generateStringData(string strTagType, int total_seconds, int total_seconds_rand, int changeAfter, double changeBy)
        {
            string data = string_data;
            Random rand = new Random();
            while (!stop)
            {
                if (data_random)
                {
                    //-- if data is random
                    //-- Select data using random number
                    if (rand.Next(0, 2) == 0)
                    {
                        data = "ON";
                    }
                    else
                    {
                        data = "OFF";
                    }
                }
                main.updateValue(strTagName, data, this);
                string strDriveLetter = Path.GetPathRoot(Environment.CurrentDirectory);
                string strFilePath = strDriveLetter + @"\Data Generator\output\String-"+strTagName+".txt";
                writer = new StreamWriter(strFilePath, true);
                writer.WriteLine(DateTime.Now.ToString() + "\t\t" + data);
                writer.Close();

                Thread.Sleep(total_seconds * 1000);
                if (total_seconds_rand > 0)
                {
                    int seconds = total_seconds_rand - total_seconds;
                    int random_seconds = rand.Next(0, seconds);
                    Thread.Sleep(random_seconds * 1000);
                }

            }
            return;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;


        }

        //--when value of tag type control changes
        private void comboxTagType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-- get the selected tag type
            strTagType = comboxTagType.GetItemText(comboxTagType.SelectedItem);
            if (strTagType.Equals("String"))
            {
                //-- If tag type is string then hide then number dropdowns and show string dropdown for ON and OFF values

                num_fixed.Hide();
                numDataUpperLimit.Hide();
                dd_string.Show();

                //-- Disable deviation if tag type is string
                grpBoxDeviation.Enabled = false;
                numDevFrequency.Enabled = false;
                numDevPerc.Enabled = false;
            }
            else
            {
                //-- if tag type is not string or float
                //-- Hide string data dropdown
                dd_string.Hide();
                //-- show float data number controls
                num_fixed.Show();

                //-- Enable deviation if tag type is not string
                grpBoxDeviation.Enabled = true;
                numDevFrequency.Enabled = true;
                numDevPerc.Enabled = true;
                numDataUpperLimit.Show();
                numDataUpperLimit.Enabled = false;

                if (chkboxDataRandom.Checked)
                {
                    numDataUpperLimit.Enabled = true;
                }
            }
        }

        //when change happens to random radio button for Data 
        private void chkboxDataRandom_CheckedChanged(object sender, EventArgs e)
        {
            data_random = chkboxDataRandom.Checked;
            //-- If tag type is not string then if random is "ON" then show upper range control otherwise hide it
            if (!strTagType.Equals("String"))
            {
                if (chkboxDataRandom.Checked)
                {
                    numDataUpperLimit.Enabled = true;
                }
                else
                {
                    numDataUpperLimit.Enabled = false;
                }
            }
        }

        private void chkboxTimeRandom_CheckedChanged(object sender, EventArgs e)
        {
            //-- enable or disable random frequency controls based on the selection of checkbox
            showRandomFrequencyControls(chkboxTimeRandom.Checked);
            time_random = chkboxTimeRandom.Checked;
        }

        private void chkboxDevFrequencyRandom_CheckedChanged(object sender, EventArgs e)
        {
            devFrequency_random = chkboxDevFrequencyRandom.Checked;
            if (chkboxDevFrequencyRandom.Checked)
            {
                numDevFrequencyUpperLimit.Enabled = true;
            }
            else
            {
                numDevFrequencyUpperLimit.Enabled = false;
            }
        }

        private void chkboxDevPercRandom_CheckedChanged(object sender, EventArgs e)
        {
            devPercentage_random = chkboxDevPercRandom.Checked;
            if (chkboxDevPercRandom.Checked)
            {
                numDevPercUpperLimit.Enabled = true;
            }
            else
            {
                numDevPercUpperLimit.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strServerName = comboxServerName.GetItemText(comboxServerName.SelectedItem);
            if (strServerName == "")
            {
              // dialog box with message to select a server;
            }

            string tagName = strServerName + "/" +txtboxTagName.Text;
            double data = float_data;
            main.createTag(tagName, data, this);
        }

        private void txtboxTagName_TextChanged(object sender, EventArgs e)
        {
            main.updateTagName(txtboxTagName.Text);
        }

        private void grpboxServerTagInfo_Enter(object sender, EventArgs e)
        {

        }

        private void TagProfile_Load(object sender, EventArgs e)
        {

        }

        private void grpBoxTagProfile_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
