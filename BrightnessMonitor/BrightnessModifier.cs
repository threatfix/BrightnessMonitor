using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Configuration;


namespace WindowsFormsApplication2
{
    public partial class BrightnessModifier : Form
    {
        //Public variable - Timer variables, necessary to execute the gradual timer function (gradualChanger)
        int timerinc = 0;
        int gradualChange = 90;
        bool daytimer = false;
        bool nighttimer = false;

        // Public Variable - Registry key to be used as runkey
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        //Initalize application, generate form, fill in default values, overwrite with saved values.
        public BrightnessModifier()
        {
            InitializeComponent();
            ValueIntializer();
            PresetInitializer();
            defaultTimer.Start();
        }


        //*************************
        //       Initiazlier
        //*************************
        //Initalizer
        //Generate Initial Values
        private void ValueIntializer()
        {
            short value = (short)brightnessTrack.Value;
            Brightness.SetBrightness((byte)value);
            brightnessLabel.Text = value.ToString();
            systemTime.Text = DateTime.Now.ToString("hh:mm:ss tt");            
        }

        //Initalizer
        //Generate Saved Values
        private void PresetInitializer()
        {
            if (rkApp.GetValue("BrightnessModifier") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                startupCB.Checked = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                startupCB.Checked = true;
                this.WindowState = FormWindowState.Minimized;
            }

            var appSettings = ConfigurationManager.AppSettings;

            string savedBrightness = appSettings["SavedBrightness"];
            brightnessTrack.Value = Int32.Parse(savedBrightness);
            int inputInt = Int32.Parse(savedBrightness);
            short inputBright = (short)inputInt;
            Brightness.SetBrightness((byte)inputBright);
            brightnessLabel.Text = savedBrightness;

            if (appSettings["DayCheck"] == "Yes")
            {
                dayCheckB.Checked = true;
                if (appSettings["DayGradual"] == "Yes") dayGradual.Checked = true;
                else dayGradual.Checked = false;
                string savedDayBrightess = appSettings["DayBrightness"];
                dayTB.Value = Int32.Parse(savedDayBrightess);
                dayLbl.Text = savedDayBrightess;

                dtPickDay.Value = DateTime.Parse(appSettings["DayTime"]);

            }
            else dayCheckB.Checked = false;

            if (appSettings["NightCheck"] == "Yes")
            {
                nightCheckB.Checked = true;
                if (appSettings["NightGradual"] == "Yes") nightGradual.Checked = true;
                else nightGradual.Checked = false;
                string savedNightBrightess = appSettings["NightBrightness"];
                nightTB.Value = Int32.Parse(savedNightBrightess);
                nightLbl.Text = savedNightBrightess;

                dtPickNight.Value = DateTime.Parse(appSettings["NightTime"]);
            }
            else nightCheckB.Checked = false;

            if (appSettings["Tray"] == "Yes") trayBox.Checked = true;
            else trayBox.Checked = false;

        }


        //*************************
        //          Timer
        //*************************
        //Timer
        //Handles Gradual Brightness Increase + Time
        private void gradualChanger()
        {
            string nowTime = DateTime.Now.ToString("hh:mm:ss tt");
            systemTime.Text = nowTime;
            string dayStr = dtPickDay.Text;
            string nightStr = dtPickNight.Text;

            DateTime dayTime = dtPickDay.Value;
            DateTime dayGradualDifference = dayTime.Add(new TimeSpan(0, 0, -gradualChange));
            string dayDifference = dayGradualDifference.ToString("hh:mm:ss tt");

            DateTime nightTime = dtPickNight.Value;
            DateTime nightGradualDifference = nightTime.Add(new TimeSpan(0, 0, -gradualChange));
            string nightDifference = nightGradualDifference.ToString("hh:mm:ss tt");

            if (dayCheckB.Checked == true)
            {
                if (dayStr == nowTime)
                {
                    short value = (short)dayTB.Value;
                    Brightness.SetBrightness((byte)value);
                    brightnessTrack.Value = dayTB.Value;
                }
            }
            if (nightCheckB.Checked == true)
            {
                if (nightStr == nowTime)
                {
                    short value = (short)nightTB.Value;
                    Brightness.SetBrightness((byte)value);
                    brightnessTrack.Value = nightTB.Value;
                }
            }
            if (dayGradual.Checked == true)
            {
                if (dayDifference == nowTime)
                {
                    daytimer = true;
                }
            }
            if (daytimer == true)
            {
                if (timerinc < gradualChange)
                {
                    if (brightnessTrack.Value > dayTB.Value) brightnessTrack.Value -= 1;
                    if (brightnessTrack.Value < dayTB.Value) brightnessTrack.Value += 1;

                    timerinc++;
                    if (timerinc == gradualChange || brightnessTrack.Value == dayTB.Value)
                    {
                        timerinc = 0;
                        daytimer = false;
                    }
                }
            }
            if (nightGradual.Checked == true)
            {
                if (nightDifference == nowTime)
                {
                    nighttimer = true;
                }
            }
            if (nighttimer == true)
            {
                if (timerinc < gradualChange)
                {
                    if (brightnessTrack.Value > nightTB.Value) brightnessTrack.Value -= 1;
                    if (brightnessTrack.Value < nightTB.Value) brightnessTrack.Value += 1;

                    timerinc++;
                    if (timerinc == gradualChange || brightnessTrack.Value == nightTB.Value)
                    {
                        timerinc = 0;
                        nighttimer = false;
                    }
                }
            }
        }

        //Timer
        //Timer Function, calls gradualChanger on each tick, also saves current master brightness
        private void systemTimeTimer_Tick(object sender, EventArgs e)
        {
            gradualChanger();
            AddSettings("SavedBrightness", brightnessLabel.Text);
        }

        //Timer
        //Handles Main Day Checkbox (Enables or Disables saving depending on whether checkbox is checked.
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (dayGroupBox.Enabled == false)
            {
                dayGroupBox.Enabled = true;
                AddSettings("DayCheck", "Yes");
            }
            else
            {
                dayGroupBox.Enabled = false;
                dtPickDay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                dayGradual.Checked = false;
                dayTB.Value = 50;
                AddSettings("DayCheck", "No");
            }
        }

        //Timer
        //Handles Main Night Checkbox (Enables or Disables saving depending on whether checkbox is checked.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nightGroupBox.Enabled == false)
            {
                nightGroupBox.Enabled = true;
                AddSettings("NightCheck", "Yes");
            }
            else
            {
                nightGroupBox.Enabled = false;
                dtPickNight.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                nightGradual.Checked = false;
                nightTB.Value = 50;
                AddSettings("NightCheck", "No");
            }
        }

        //*************************
        //        Brightness
        //*************************
        //Brightness
        //Handles Master Brightness Trackbar
        private void brightnessTrack_ValueChanged(object sender, EventArgs e)
        {
            short value = (short)brightnessTrack.Value;
            string currentBrightness = value.ToString();
            Brightness.SetBrightness((byte)value);
            brightnessLabel.Text = currentBrightness;
            currentBrightnessLbl.Text = "Current Brightness: " + brightnessLabel.Text;
        }

        //Brightness
        //Handles Master Brightness Button +
        private void incBtn_Click(object sender, EventArgs e)
        {
            brightnessTrack.Value++;
        }

        //Brightness
        //Handles Master Brightness Button --
        private void decBtn_Click(object sender, EventArgs e)
        {
            brightnessTrack.Value--;
        }

        //Brightness
        //Handles Day Brightness Button ++
        private void incDay_Click(object sender, EventArgs e)
        {
            dayTB.Value++;
        }

        //Brightness
        //Handles Day Brightness Button --
        private void decDay_Click(object sender, EventArgs e)
        {
            dayTB.Value--;
        }

        //Brightness
        //Handles Night Brightness Button ++
        private void incNight_Click(object sender, EventArgs e)
        {
            nightTB.Value++;
        }

        //Brightness
        //Handles Night Brightness Button --
        private void decNight_Click(object sender, EventArgs e)
        {
            nightTB.Value--;
        }

        //Brightness
        //Handles Day Trackbar value changing, saves Day Trackbar brightness value
        private void dayTB_ValueChanged(object sender, EventArgs e)
        {
            short value = (short)dayTB.Value;
            dayLbl.Text = value.ToString();
            AddSettings("DayBrightness", dayLbl.Text);
        }

        //Brightness
        //Handles Night Trackbar value changing, saves Night Trackbar brightness value
        private void nightTB_ValueChanged(object sender, EventArgs e)
        {
            short value = (short)nightTB.Value;
            nightLbl.Text = value.ToString();
            AddSettings("NightBrightness", nightLbl.Text);
        }

        //Brightness
        //Handles Gradual Checkbox for Days
        private void dayGradual_CheckedChanged(object sender, EventArgs e)
        {
            if (dayGradual.Checked == true) AddSettings("DayGradual", "Yes");
            if (dayGradual.Checked == false) AddSettings("DayGradual", "No");
        }

        //Brightness
        //Handles Day Time Picker
        private void dtPickDay_ValueChanged(object sender, EventArgs e)
        {
            string dayTime = dtPickDay.Value.TimeOfDay.ToString();
            AddSettings("DayTime", dayTime);
        }

        //Brightness
        //Handles Night Time Picker
        private void dtPickNight_ValueChanged(object sender, EventArgs e)
        {
            string nightTime = dtPickNight.Value.TimeOfDay.ToString();
            AddSettings("NightTime", nightTime);
        }

        //Brightness
        //Handles Gradual Checkbox for Nights
        private void nightGradual_CheckedChanged(object sender, EventArgs e)
        {
            if (nightGradual.Checked == true) AddSettings("NightGradual", "Yes");
            if (nightGradual.Checked == false) AddSettings("NightGradual", "No");
        }

        //*************************
        //          Form
        //*************************
        //Form
        //Handles Master Brightness Resizer
        private void button6_Click(object sender, EventArgs e)
        {
            if (masterGroupBox.Height == 113)
            {
                masterGroupBox.Height = 32;
            }
            else masterGroupBox.Height = 113;
        }

        //Form
        //Handles Scheduler Resizer
        private void scheduleCollapseBtn_Click(object sender, EventArgs e)
        {
            if (dayCheckB.Checked == true)
            {
                dayBackLbl.Text = "Day Scheduler: On";
                dayBackTime.Text = "Scheduled Time: " + dtPickDay.Text;
                dayBackBrightness.Text = "Brightness: " + dayTB.Value.ToString();
                if (dayGradual.Checked == true) dayBackGradual.Text = "Gradual Change: Yes";
                else dayBackGradual.Text = "Gradual Change: No";
            }
            else
            {
                dayBackLbl.Text = "Day Scheduler: Off";
                dayBackTime.Text = "Scheduled Time: N/A";
                dayBackBrightness.Text = "Brightness: N/A";
                if (dayGradual.Checked == true) dayBackGradual.Text = "Gradual Change: Yes";
                else dayBackGradual.Text = "Gradual Change: N/A";
            }

            if (nightCheckB.Checked == true)
            {
                nightBackLbl.Text = "Night Scheduler: On";
                nightBackTime.Text = "Scheduled Time: " + dtPickNight.Text;
                nightBackBrightness.Text = "Brightness: " + nightTB.Value.ToString();
                if (nightGradual.Checked == true) nightBackGradual.Text = "Gradual Change: Yes";
                else nightBackGradual.Text = "Gradual Change: No";
            }
            else
            {
                nightBackLbl.Text = "Night Scheduler: Off";
                nightBackTime.Text = "Scheduled Time: N/A";
                nightBackBrightness.Text = "Brightness: N/A";
                if (nightGradual.Checked == true) nightBackGradual.Text = "Gradual Change: Yes";
                else nightBackGradual.Text = "Gradual Change: N/A";
            }

            if (schedulerGroupbBox.Height == 316)
            {
                schedulerGroupbBox.Height = 31;
                return;
            }
            else schedulerGroupbBox.Height = 316;
        }

        //Form
        //Handles Other Box Resizer
        private void otherCollapseBtn_Click(object sender, EventArgs e)
        {
            if (startupCB.Checked == true) startBackLbl.Text = "Startup: Yes";
            else startBackLbl.Text = "Startup: No";

            if (trayBox.Checked == true) trayBackLbl.Text = "Tray: Yes";
            else trayBackLbl.Text = "Tray: No";

            if (otherGroupBox.Height == 86)
            {
                otherGroupBox.Height = 28;
                return;
            }
            else otherGroupBox.Height = 86;
        }

        //Form
        //Function of Master Brightness Resizer
        private void masterCollapseBtn_MouseEnter(object sender, EventArgs e)
        {
            masterLbl.BackColor = Color.Gray;
        }

        //Form
        //Function of Master Brightness Resizer
        private void masterCollapseBtn_MouseLeave(object sender, EventArgs e)
        {
            masterLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        //Form
        //Function of Master Brightness Resizer
        private void masterCollapseBtn_MouseDown(object sender, MouseEventArgs e)
        {
            masterLbl.BackColor = Color.Silver;
        }

        //Form
        //Function of Master Brightness Resizer
        private void masterCollapseBtn_MouseUp(object sender, MouseEventArgs e)
        {
            masterLbl.BackColor = Color.Gray;
        }

        //Form
        //Function of Scheduler Resizer
        private void scheduleCollapseBtn_MouseEnter(object sender, EventArgs e)
        {
            schedulerLbl.BackColor = Color.Gray; 
        }

        //Form
        //Function of Scheduler Resizer
        private void scheduleCollapseBtn_MouseLeave(object sender, EventArgs e)
        {
            schedulerLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark; 
        }

        //Form
        //Function of Scheduler Resizer
        private void scheduleCollapseBtn_MouseDown(object sender, MouseEventArgs e)
        {
            schedulerLbl.BackColor = Color.Silver;
        }

        //Form
        //Function of Scheduler Resizer
        private void scheduleCollapseBtn_MouseUp(object sender, MouseEventArgs e)
        {
            schedulerLbl.BackColor = Color.Gray;
        }

        //Form
        //Function of Other Box Resizer
        private void otherCollapseBtn_MouseEnter(object sender, EventArgs e)
        {
            otherLbl.BackColor = Color.Gray;
        }

        //Form
        //Function of Other Box Resizer
        private void otherCollapseBtn_MouseLeave(object sender, EventArgs e)
        {
            otherLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark; 
        }

        //Form
        //Function of Other Box Resizer
        private void otherCollapseBtn_MouseUp(object sender, MouseEventArgs e)
        {
            otherLbl.BackColor = Color.Gray;
        }

        //Form
        //Function of Other Box Resizer
        private void otherCollapseBtn_MouseDown(object sender, MouseEventArgs e)
        {
            otherLbl.BackColor = Color.Silver;
        }

        //Form
        //Handles Minimization of Form
        private void BrightnessModifier_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized && (trayBox.Checked == true || startupCB.Checked == true))
            {
                this.Hide();
            }
        }

        //Form
        //Handles Renormalization of Form
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //Form
        //Handles Form Close Event
        private void BrightnessModifier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit Brightness Modifier?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                trayIcon.Dispose();
            }
            else
                e.Cancel = true;
        }

        //Form
        //Handles Form Closed Event (Garbarge)
        private void BrightnessModifier_FormClosed(object sender, FormClosedEventArgs e)
        {
            trayIcon.Dispose();
        }

        //*************************
        //          Other
        //*************************
        //Other Functions
        //Handles Registry Key Toggler
        private void startupCB_CheckedChanged(object sender, EventArgs e)
        {
            if (startupCB.Checked)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("BrightnessModifier", Application.ExecutablePath.ToString());
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("BrightnessModifier", false);
            }

            if (startupCB.Checked == false && trayBox.Checked == false)
            {
                this.WindowState = FormWindowState.Normal;
                this.Show();
            }
            else if (startupCB.Checked == true && trayBox.Checked == false)
            {
                this.WindowState = FormWindowState.Normal;
                this.Show();
            }

        }

        //Other Functions
        //Resets all values, clears values, sets brightness to 100
        private void disableBtn_Click(object sender, EventArgs e)
        {
            startupCB.Checked = false;
            trayIcon.Visible = false;
            trayBox.Checked = false;
            brightnessTrack.Value = 100;
            dayTB.Value = 50;
            nightTB.Value = 50;
            dayCheckB.Checked = false;
            nightCheckB.Checked = false;
        }

        //Other Functions
        //Handles Traybox Function Toggler
        private void trayBox_CheckedChanged(object sender, EventArgs e)
        {
            if (trayBox.Checked == false) trayIcon.Visible = false;
            else trayIcon.Visible = true;

            if (startupCB.Checked == true) trayIcon.Visible = true;

            if (trayBox.Checked == true) AddSettings("Tray", "Yes");
            if (trayBox.Checked == false) AddSettings("Tray", "No");

            if (startupCB.Checked == false && trayBox.Checked == false)
            {
                this.WindowState = FormWindowState.Normal;
                this.Show();
            }
            else if (startupCB.Checked == true && trayBox.Checked == false)
            {
                this.WindowState = FormWindowState.Normal;
                this.Show();
            }
        }

        //*************************
        //          Save
        //*************************
        //Save
        //Handles variable saving to App.Config
        static void AddSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                configFile.Save();
                configFile.AppSettings.SectionInformation.ForceSave = true;
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }

        }

        //*************************
        //          Links
        //*************************
        //Links
        //ThreatFix Link Clicked
        private void tFixLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.threatfix.com");
        }

        //Links
        //ThreatFix Graphic Click
        private void threatBox_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.threatfix.com");
        }

        private void defaultTimer_Tick(object sender, EventArgs e)
        {
            short value = (short)brightnessTrack.Value;
            string currentBrightness = value.ToString();
            Brightness.SetBrightness((byte)value);
            brightnessLabel.Text = currentBrightness;
            currentBrightnessLbl.Text = "Current Brightness: " + brightnessLabel.Text;
            
        }

    }
}
