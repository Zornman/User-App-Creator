using System;

namespace User_App_Creator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtShowDest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.txtShowDialog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.TabAdvanced = new System.Windows.Forms.TabPage();
            this.comboParkAntenna = new System.Windows.Forms.ComboBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblParkAntenna = new System.Windows.Forms.Label();
            this.txtReadDuration = new System.Windows.Forms.TextBox();
            this.lblReadDuration = new System.Windows.Forms.Label();
            this.txtReadPauseTimer = new System.Windows.Forms.TextBox();
            this.lblReadPauseTime = new System.Windows.Forms.Label();
            this.txtTransmitTimer = new System.Windows.Forms.TextBox();
            this.lblTransmitTimer = new System.Windows.Forms.Label();
            this.comboPcMode = new System.Windows.Forms.ComboBox();
            this.comboDebug = new System.Windows.Forms.ComboBox();
            this.comboFlatStorage = new System.Windows.Forms.ComboBox();
            this.comboDisableAntennaFaults = new System.Windows.Forms.ComboBox();
            this.lblPcMode = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblFlatStorage = new System.Windows.Forms.Label();
            this.txtPasswordRequired = new System.Windows.Forms.TextBox();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblDisableAntennaFaults = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.TabAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Folder to Compress:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtShowDest);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.txtShowDialog);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 87);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(463, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtShowDest
            // 
            this.txtShowDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowDest.Location = new System.Drawing.Point(273, 47);
            this.txtShowDest.Name = "txtShowDest";
            this.txtShowDest.Size = new System.Drawing.Size(188, 26);
            this.txtShowDest.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Destination For Zipped Files:";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(631, 21);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(110, 43);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Compress!";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // txtShowDialog
            // 
            this.txtShowDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowDialog.Location = new System.Drawing.Point(210, 13);
            this.txtShowDialog.Name = "txtShowDialog";
            this.txtShowDialog.Size = new System.Drawing.Size(251, 26);
            this.txtShowDialog.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEmailAddress);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.comboBox7);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.comboBox6);
            this.panel2.Controls.Add(this.comboBox5);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(20, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 503);
            this.panel2.TabIndex = 2;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(500, 337);
            this.txtEmailAddress.Multiline = true;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(241, 161);
            this.txtEmailAddress.TabIndex = 30;
            this.txtEmailAddress.Text = "service@sonraisystems.com, Alec.Zorn@sonraisystems.com";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(496, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "Email Addresses:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 379);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(232, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "If Enabled, Enter Tag List Here:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(15, 402);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(271, 84);
            this.textBox8.TabIndex = 27;
            this.textBox8.Text = "303A,1000,0100,0010,0001";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.comboBox7.Location = new System.Drawing.Point(135, 337);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(151, 28);
            this.comboBox7.TabIndex = 26;
            this.comboBox7.SelectedIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "Tag List:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(246, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "db";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(246, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "db";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(246, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "db";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(246, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "db";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(172, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 26);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "27";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(172, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 26);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "27";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(172, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 26);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "27";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(172, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 26);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "27";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.comboBox6.Location = new System.Drawing.Point(104, 282);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(62, 28);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.SelectedIndex = 1;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.comboBox5.Location = new System.Drawing.Point(104, 243);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(62, 28);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.SelectedIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.comboBox4.Location = new System.Drawing.Point(104, 204);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(62, 28);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.SelectedIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.comboBox3.Location = new System.Drawing.Point(104, 162);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(62, 28);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.SelectedIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Antenna 4:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Antenna 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Antenna 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Antenna 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Antennas:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(151, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enable Triggers?";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IF2",
            "IF61"});
            this.comboBox1.Location = new System.Drawing.Point(151, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reader Type:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(306, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type Program Code Here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Names of Folders Here:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(500, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 268);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "271532,271533,271534";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabHome);
            this.tabPage.Controls.Add(this.TabAdvanced);
            this.tabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.Location = new System.Drawing.Point(2, 1);
            this.tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(798, 632);
            this.tabPage.TabIndex = 3;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.panel1);
            this.tabHome.Controls.Add(this.panel2);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Margin = new System.Windows.Forms.Padding(2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(2);
            this.tabHome.Size = new System.Drawing.Size(790, 599);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // TabAdvanced
            // 
            this.TabAdvanced.Controls.Add(this.comboParkAntenna);
            this.TabAdvanced.Controls.Add(this.btnPassword);
            this.TabAdvanced.Controls.Add(this.btnRestore);
            this.TabAdvanced.Controls.Add(this.lblParkAntenna);
            this.TabAdvanced.Controls.Add(this.txtReadDuration);
            this.TabAdvanced.Controls.Add(this.lblReadDuration);
            this.TabAdvanced.Controls.Add(this.txtReadPauseTimer);
            this.TabAdvanced.Controls.Add(this.lblReadPauseTime);
            this.TabAdvanced.Controls.Add(this.txtTransmitTimer);
            this.TabAdvanced.Controls.Add(this.lblTransmitTimer);
            this.TabAdvanced.Controls.Add(this.comboPcMode);
            this.TabAdvanced.Controls.Add(this.comboDebug);
            this.TabAdvanced.Controls.Add(this.comboFlatStorage);
            this.TabAdvanced.Controls.Add(this.comboDisableAntennaFaults);
            this.TabAdvanced.Controls.Add(this.lblPcMode);
            this.TabAdvanced.Controls.Add(this.lblDebug);
            this.TabAdvanced.Controls.Add(this.lblFlatStorage);
            this.TabAdvanced.Controls.Add(this.txtPasswordRequired);
            this.TabAdvanced.Controls.Add(this.lblEnterPassword);
            this.TabAdvanced.Controls.Add(this.lblDisableAntennaFaults);
            this.TabAdvanced.Controls.Add(this.lblNote);
            this.TabAdvanced.Controls.Add(this.lblHeader);
            this.TabAdvanced.Location = new System.Drawing.Point(4, 29);
            this.TabAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.TabAdvanced.Name = "TabAdvanced";
            this.TabAdvanced.Padding = new System.Windows.Forms.Padding(2);
            this.TabAdvanced.Size = new System.Drawing.Size(790, 599);
            this.TabAdvanced.TabIndex = 1;
            this.TabAdvanced.Text = "Advanced";
            this.TabAdvanced.UseVisualStyleBackColor = true;
            // 
            // comboParkAntenna
            // 
            this.comboParkAntenna.FormattingEnabled = true;
            this.comboParkAntenna.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboParkAntenna.Location = new System.Drawing.Point(562, 443);
            this.comboParkAntenna.Margin = new System.Windows.Forms.Padding(2);
            this.comboParkAntenna.Name = "comboParkAntenna";
            this.comboParkAntenna.Size = new System.Drawing.Size(146, 28);
            this.comboParkAntenna.TabIndex = 22;
            this.comboParkAntenna.SelectedIndex = 3;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(556, 127);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(81, 32);
            this.btnPassword.TabIndex = 21;
            this.btnPassword.Text = "Submit";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(326, 527);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(151, 50);
            this.btnRestore.TabIndex = 20;
            this.btnRestore.Text = "Restore Defaults";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblParkAntenna
            // 
            this.lblParkAntenna.AutoSize = true;
            this.lblParkAntenna.Location = new System.Drawing.Point(444, 444);
            this.lblParkAntenna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParkAntenna.Name = "lblParkAntenna";
            this.lblParkAntenna.Size = new System.Drawing.Size(114, 20);
            this.lblParkAntenna.TabIndex = 18;
            this.lblParkAntenna.Text = "Park Antenna: ";
            // 
            // txtReadDuration
            // 
            this.txtReadDuration.Location = new System.Drawing.Point(562, 346);
            this.txtReadDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadDuration.Name = "txtReadDuration";
            this.txtReadDuration.Size = new System.Drawing.Size(146, 26);
            this.txtReadDuration.TabIndex = 17;
            this.txtReadDuration.Text = "1000";
            // 
            // lblReadDuration
            // 
            this.lblReadDuration.AutoSize = true;
            this.lblReadDuration.Location = new System.Drawing.Point(402, 348);
            this.lblReadDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReadDuration.Name = "lblReadDuration";
            this.lblReadDuration.Size = new System.Drawing.Size(156, 20);
            this.lblReadDuration.TabIndex = 16;
            this.lblReadDuration.Text = "Read Duration (ms): ";
            // 
            // txtReadPauseTimer
            // 
            this.txtReadPauseTimer.Location = new System.Drawing.Point(562, 254);
            this.txtReadPauseTimer.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadPauseTimer.Name = "txtReadPauseTimer";
            this.txtReadPauseTimer.Size = new System.Drawing.Size(146, 26);
            this.txtReadPauseTimer.TabIndex = 15;
            this.txtReadPauseTimer.Text = "2000";
            // 
            // lblReadPauseTime
            // 
            this.lblReadPauseTime.AutoSize = true;
            this.lblReadPauseTime.Location = new System.Drawing.Point(378, 255);
            this.lblReadPauseTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReadPauseTime.Name = "lblReadPauseTime";
            this.lblReadPauseTime.Size = new System.Drawing.Size(178, 20);
            this.lblReadPauseTime.TabIndex = 14;
            this.lblReadPauseTime.Text = "Read Pause Time (ms): ";
            // 
            // txtTransmitTimer
            // 
            this.txtTransmitTimer.Location = new System.Drawing.Point(562, 165);
            this.txtTransmitTimer.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransmitTimer.Name = "txtTransmitTimer";
            this.txtTransmitTimer.Size = new System.Drawing.Size(146, 26);
            this.txtTransmitTimer.TabIndex = 13;
            this.txtTransmitTimer.Text = "60000";
            // 
            // lblTransmitTimer
            // 
            this.lblTransmitTimer.AutoSize = true;
            this.lblTransmitTimer.Location = new System.Drawing.Point(396, 167);
            this.lblTransmitTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransmitTimer.Name = "lblTransmitTimer";
            this.lblTransmitTimer.Size = new System.Drawing.Size(156, 20);
            this.lblTransmitTimer.TabIndex = 12;
            this.lblTransmitTimer.Text = "Transmit Timer (ms): ";
            // 
            // comboPcMode
            // 
            this.comboPcMode.FormattingEnabled = true;
            this.comboPcMode.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboPcMode.Location = new System.Drawing.Point(200, 443);
            this.comboPcMode.Margin = new System.Windows.Forms.Padding(2);
            this.comboPcMode.Name = "comboPcMode";
            this.comboPcMode.Size = new System.Drawing.Size(146, 28);
            this.comboPcMode.TabIndex = 11;
            this.comboPcMode.SelectedIndex = 1;
            // 
            // comboDebug
            // 
            this.comboDebug.FormattingEnabled = true;
            this.comboDebug.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboDebug.Location = new System.Drawing.Point(200, 347);
            this.comboDebug.Margin = new System.Windows.Forms.Padding(2);
            this.comboDebug.Name = "comboDebug";
            this.comboDebug.Size = new System.Drawing.Size(146, 28);
            this.comboDebug.TabIndex = 10;
            this.comboDebug.SelectedIndex = 1;
            // 
            // comboFlatStorage
            // 
            this.comboFlatStorage.FormattingEnabled = true;
            this.comboFlatStorage.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboFlatStorage.Location = new System.Drawing.Point(200, 254);
            this.comboFlatStorage.Margin = new System.Windows.Forms.Padding(2);
            this.comboFlatStorage.Name = "comboFlatStorage";
            this.comboFlatStorage.Size = new System.Drawing.Size(146, 28);
            this.comboFlatStorage.TabIndex = 9;
            this.comboFlatStorage.SelectedIndex = 1;
            // 
            // comboDisableAntennaFaults
            // 
            this.comboDisableAntennaFaults.FormattingEnabled = true;
            this.comboDisableAntennaFaults.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboDisableAntennaFaults.Location = new System.Drawing.Point(200, 167);
            this.comboDisableAntennaFaults.Margin = new System.Windows.Forms.Padding(2);
            this.comboDisableAntennaFaults.Name = "comboDisableAntennaFaults";
            this.comboDisableAntennaFaults.Size = new System.Drawing.Size(146, 28);
            this.comboDisableAntennaFaults.TabIndex = 8;
            this.comboDisableAntennaFaults.SelectedIndex = 0;
            // 
            // lblPcMode
            // 
            this.lblPcMode.AutoSize = true;
            this.lblPcMode.Location = new System.Drawing.Point(59, 444);
            this.lblPcMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPcMode.Name = "lblPcMode";
            this.lblPcMode.Size = new System.Drawing.Size(136, 20);
            this.lblPcMode.TabIndex = 7;
            this.lblPcMode.Text = "Enable PC Mode: ";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(34, 348);
            this.lblDebug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(163, 20);
            this.lblDebug.TabIndex = 6;
            this.lblDebug.Text = "Enable Debug Mode: ";
            // 
            // lblFlatStorage
            // 
            this.lblFlatStorage.AutoSize = true;
            this.lblFlatStorage.Location = new System.Drawing.Point(8, 256);
            this.lblFlatStorage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlatStorage.Name = "lblFlatStorage";
            this.lblFlatStorage.Size = new System.Drawing.Size(188, 20);
            this.lblFlatStorage.TabIndex = 5;
            this.lblFlatStorage.Text = "Enable Flat File Storage: ";
            // 
            // txtPasswordRequired
            // 
            this.txtPasswordRequired.Location = new System.Drawing.Point(372, 129);
            this.txtPasswordRequired.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordRequired.Name = "txtPasswordRequired";
            this.txtPasswordRequired.PasswordChar = '*';
            this.txtPasswordRequired.Size = new System.Drawing.Size(167, 26);
            this.txtPasswordRequired.TabIndex = 4;
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Location = new System.Drawing.Point(156, 131);
            this.lblEnterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(211, 20);
            this.lblEnterPassword.TabIndex = 3;
            this.lblEnterPassword.Text = "Enter Password to Continue:";
            // 
            // lblDisableAntennaFaults
            // 
            this.lblDisableAntennaFaults.AutoSize = true;
            this.lblDisableAntennaFaults.Location = new System.Drawing.Point(18, 168);
            this.lblDisableAntennaFaults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisableAntennaFaults.Name = "lblDisableAntennaFaults";
            this.lblDisableAntennaFaults.Size = new System.Drawing.Size(179, 20);
            this.lblDisableAntennaFaults.TabIndex = 2;
            this.lblDisableAntennaFaults.Text = "Disable Antenna Faults:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(210, 50);
            this.lblNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(358, 45);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Note: Only mess with these if you have been given permission.\r\nWithout permission" +
    ", these settings should remain as their default\r\nvalues.";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(268, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(241, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Advanced Settings";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(804, 640);
            this.Controls.Add(this.tabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "User App Creator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.TabAdvanced.ResumeLayout(false);
            this.TabAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtShowDialog;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtShowDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage TabAdvanced;
        private System.Windows.Forms.Label lblDisableAntennaFaults;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtPasswordRequired;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblParkAntenna;
        private System.Windows.Forms.TextBox txtReadDuration;
        private System.Windows.Forms.Label lblReadDuration;
        private System.Windows.Forms.TextBox txtReadPauseTimer;
        private System.Windows.Forms.Label lblReadPauseTime;
        private System.Windows.Forms.TextBox txtTransmitTimer;
        private System.Windows.Forms.Label lblTransmitTimer;
        private System.Windows.Forms.ComboBox comboPcMode;
        private System.Windows.Forms.ComboBox comboDebug;
        private System.Windows.Forms.ComboBox comboFlatStorage;
        private System.Windows.Forms.ComboBox comboDisableAntennaFaults;
        private System.Windows.Forms.Label lblPcMode;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblFlatStorage;
        private System.Windows.Forms.ComboBox comboParkAntenna;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label18;

        public EventHandler txtShowDialog_TextChanged { get; private set; }
    }
}

