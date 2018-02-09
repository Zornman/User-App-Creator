using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO.Compression;

namespace User_App_Creator
{
    public partial class Form1 : Form
    {
        string TranTimer = "60000";
        string antennaFaults = "0";
        string ffStorage = "0";
        string debugMode = "0";
        string pcMode = "0";
        string readPause = "2000";
        string readDuration = "1000";
        string parkAntenna = "4";

        public Form1()
        {
            InitializeComponent();
            tabPage.SelectedIndexChanged += new EventHandler(TabPage_SelectedIndexChanged);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderSelected = folderDialog.SelectedPath;

                    txtShowDialog.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderSelected = folderDialog.SelectedPath;

                    txtShowDest.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            //Checks if anything was left empty, if so will display an error message
            if (txtShowDialog.Text == null)
            {
                string message = "Please make sure to select the userapp folder to modify and compress!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (txtShowDest.Text == null)
            {
                string message = "Please make sure to select a destination for the zip files!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (comboBox1.SelectedText == null)
            {
                string message = "Please make sure to select a reader type!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (comboBox2.SelectedText == null)
            {
                string message = "Please make sure to select if triggers are enabled or not!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (comboBox3.SelectedText == null || comboBox4.SelectedText == null || comboBox5.SelectedText == null || comboBox6.SelectedText == null)
            {
                string message = "Please make sure to define ALL antennas before compressing, select ON or OFF for each one!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (textBox3.Text == null || textBox4.Text == null || textBox5.Text == null || textBox6.Text == null)
            {
                string message = "Please make sure to define antenna strength for ALL antennas!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (comboBox7.SelectedText == null)
            {
                string message = "Please make sure to define if a tag list is needed or not!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (textBox2.Text == null)
            {
                string message = "Please make sure type in a Program Code (Ex. PAFL)!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (textBox1.Text == null)
            {
                string message = "Please make sure type in truck number(s)!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            else if (txtEmailAddress.Text == null)
            {
                string message = "Please make sure type in email addresses for notifications (don't include service@sonraisystems.com)!";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
            //End of Checks, from here go on to modify the XML file and compress

            string[] truckCompress = textBox1.Text.Split(',');
            string destPath = txtShowDest.Text;
            string sourcePath = txtShowDialog.Text;
            string[] tagList = textBox8.Text.Split(',');
            XmlDocument xml = new XmlDocument();

            xml.Load(txtShowDialog.Text + "\\config.xml");
            XmlNodeList config = xml.SelectNodes("config");
            string antennasEnabled = "";

            // Check and set which antenna ports are on or off
            if (comboBox3.Text == "On" && comboBox5.Text == "On")
            {
                if (comboBox4.Text == "On" && comboBox6.Text == "On")
                {
                    antennasEnabled = antennasEnabled + "1,2,3,4";
                }
                else if (comboBox4.Text == "On" && comboBox6.Text == "Off")
                {
                    antennasEnabled = antennasEnabled + "1,2,3";
                }
                else if (comboBox4.Text == "Off" && comboBox6.Text == "On")
                {
                    antennasEnabled = antennasEnabled + "1,2,4";
                }
            }
            else if (comboBox3.Text == "On" && comboBox5.Text == "Off")
            {
                if (comboBox4.Text == "On")
                {
                    antennasEnabled = antennasEnabled + "1,2";
                }
                else
                {
                    antennasEnabled = antennasEnabled + "1";
                }
            }

            else if (comboBox3.Text == "Off" && comboBox5.Text == "On")
            {
                if (comboBox6.Text == "On")
                {
                    antennasEnabled = antennasEnabled + "3,4";
                }
                else
                {
                    antennasEnabled = antennasEnabled + "3";
                }
            }

            try
            {
                for (int i = 0; i <= truckCompress.Length - 1; i++)
                {
                    foreach (XmlElement element in config)
                    {
                        // Sets hardware ID to IF2+ or IF61
                        element.SelectSingleNode("hwid").InnerText = comboBox1.Text;

                        // Check if trigger is enabled or not
                        if (comboBox2.Text == "Yes")
                        {
                            element.SelectSingleNode("enable_trigger").InnerText = "1";
                        }
                        else
                        {
                            element.SelectSingleNode("enable_trigger").InnerText = "0";
                        }

                        // Sets antenna ports that are on or off
                        element.SelectSingleNode("ants").InnerText = antennasEnabled;

                        // Sets antenna power for all 4 ports
                        element.SelectSingleNode("ant1").InnerText = textBox3.Text + "DB";
                        element.SelectSingleNode("ant2").InnerText = textBox4.Text + "DB";
                        element.SelectSingleNode("ant3").InnerText = textBox5.Text + "DB";
                        element.SelectSingleNode("ant4").InnerText = textBox6.Text + "DB";

                        // Check if tag list is enabled or not
                        if (comboBox7.Text == "Enabled")
                        {
                            element.SelectSingleNode("enable_tag_list").InnerText = "1";
                            int tagListLoop = 0;

                            // Only create the tag_list nodes once
                            if (tagListLoop <= 0)
                            {
                                XmlNode selectConfig = xml.SelectSingleNode("//config");
                                XmlNode selectTagList = xml.SelectSingleNode("//enable_tag_list");

                                // If tag list is enabled, add each tag as a new element. 
                                for (int a = 0; a <= tagList.Length - 1; a++)
                                {
                                    XmlNode tag = xml.CreateNode(XmlNodeType.Element, "tag_list", null);
                                    tag.InnerText = tagList[a].ToString();
                                    selectConfig.InsertAfter(tag, selectTagList);
                                }

                                tagListLoop++;
                            }
                        }
                        else
                        {
                            element.SelectSingleNode("enable_tag_list").InnerText = "0";
                        }

                        // Sets transmit timer to default or to specified time
                        if (txtTransmitTimer.Text != "60000")
                        {
                            element.SelectSingleNode("transmit_timer").InnerText = txtTransmitTimer.Text;
                        }
                        else
                        {
                            element.SelectSingleNode("transmit_timer").InnerText = TranTimer;
                        }

                        // Sets disable antenna faults to true or false
                        if (comboDisableAntennaFaults.Text != "Yes")
                        {
                            element.SelectSingleNode("disable_antennafaults").InnerText = "0";
                        }
                        else
                        {
                            element.SelectSingleNode("disable_antennafaults").InnerText = "1";
                        }

                        // Sets flat file storage to true or false
                        if (comboFlatStorage.Text != "Yes")
                        {
                            element.SelectSingleNode("enable_flat_file_storage").InnerText = "0";
                        }
                        else
                        {
                            element.SelectSingleNode("enable_flat_file_storage").InnerText = "1";
                        }

                        // Sets debug mode to true or false
                        if (comboDebug.Text != "Yes")
                        {
                            element.SelectSingleNode("enable_debug").InnerText = "0";
                        }
                        else
                        {
                            element.SelectSingleNode("enable_debug").InnerText = "1";
                        }

                        // Sets PC mode to true or false
                        if (comboPcMode.Text != "Yes")
                        {
                            element.SelectSingleNode("enable_pcmode").InnerText = "0";
                        }
                        else
                        {
                            element.SelectSingleNode("enable_pcmode").InnerText = "1";
                        }

                        // Sets the read pause timer value
                        if (txtReadPauseTimer.Text != "2000")
                        {
                            element.SelectSingleNode("read_pause_time_ms").InnerText = txtReadPauseTimer.Text;
                        }
                        else
                        {
                            element.SelectSingleNode("read_pause_time_ms").InnerText = readPause;
                        }

                        // Sets the read duration timer value
                        if (txtReadDuration.Text != "1000")
                        {
                            element.SelectSingleNode("read_duration_ms").InnerText = txtReadDuration.Text;
                        }
                        else
                        {
                            element.SelectSingleNode("read_duration_ms").InnerText = readDuration;
                        }

                        // Sets the value to park the antenna when not reading
                        if (comboParkAntenna.Text != "4")
                        {
                            element.SelectSingleNode("park_antenna").InnerText = comboParkAntenna.Text;
                        }
                        else
                        {
                            element.SelectSingleNode("park_antenna").InnerText = parkAntenna;
                        }
                        


                        // Sets program name based on what was entered
                        element.SelectSingleNode("program_name").InnerText = textBox2.Text;

                        // Sets the truck number to what was entered
                        element.SelectSingleNode("truck").InnerText = truckCompress[i];

                        // Sets the emailAddressList to what was entered
                        element.SelectSingleNode("emailAddressList").InnerText = txtEmailAddress.Text;

                        // Saves the document back into the folder
                        xml.Save(sourcePath + "\\config.xml");
                    }

                    destPath = destPath + "\\" + textBox2.Text + truckCompress[i] + ".zip";

                    ZipFile.CreateFromDirectory(sourcePath, destPath);

                    destPath = txtShowDest.Text;
                }

                MessageBox.Show("Success! Your files are located in: " + destPath +
                "\n\nNOTE: Make sure you verify the config file is correct before installing the app on a truck.");
            }
            catch (Exception error)
            {
                string message = "The following error occurred - " + error;
                string title = "ERROR:";
                MessageBox.Show(message, title);
            }
        }

        private void TabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPage.SelectedTab == tabPage.TabPages["TabAdvanced"])
            {
                lblHeader.Visible = true;
                lblNote.Visible = true;
                lblEnterPassword.Visible = true;
                txtPasswordRequired.Visible = true;
                btnPassword.Visible = true;

                lblDisableAntennaFaults.Visible = false;
                comboDisableAntennaFaults.Visible = false;

                lblFlatStorage.Visible = false;
                comboFlatStorage.Visible = false;

                lblDebug.Visible = false;
                comboDebug.Visible = false;

                lblPcMode.Visible = false;
                comboPcMode.Visible = false;

                lblTransmitTimer.Visible = false;
                txtTransmitTimer.Visible = false;

                lblReadPauseTime.Visible = false;
                txtReadPauseTimer.Visible = false;

                lblReadDuration.Visible = false;
                txtReadDuration.Visible = false;

                lblParkAntenna.Visible = false;
                comboParkAntenna.Visible = false;

                btnRestore.Visible = false;
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string password = "Sonrai_Systems#100";

            if (txtPasswordRequired.Text != password)
            {
                MessageBox.Show("Incorrect password!\n\nHint: Ask Alec :)");
            }
            else
            {
                lblHeader.Visible = true;
                lblNote.Visible = true;
                lblEnterPassword.Visible = false;
                txtPasswordRequired.Visible = false;
                btnPassword.Visible = false;

                lblDisableAntennaFaults.Visible = true;
                comboDisableAntennaFaults.Visible = true;

                lblFlatStorage.Visible = true;
                comboFlatStorage.Visible = true;

                lblDebug.Visible = true;
                comboDebug.Visible = true;

                lblPcMode.Visible = true;
                comboPcMode.Visible = true;

                lblTransmitTimer.Visible = true;
                txtTransmitTimer.Visible = true;

                lblReadPauseTime.Visible = true;
                txtReadPauseTimer.Visible = true;

                lblReadDuration.Visible = true;
                txtReadDuration.Visible = true;

                lblParkAntenna.Visible = true;
                comboParkAntenna.Visible = true;

                btnRestore.Visible = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            comboDisableAntennaFaults.SelectedIndex = 1;
            comboFlatStorage.SelectedIndex = 1;
            comboDebug.SelectedIndex = 1;
            comboPcMode.SelectedIndex = 1;

            txtTransmitTimer.Text = TranTimer;
            txtReadPauseTimer.Text = readPause;
            txtReadDuration.Text = readDuration;
            comboParkAntenna.SelectedIndex = 3;
        }
    }
}
