﻿namespace DiztinGUIsh
{
    partial class ImportROMDialog
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
            this.detectMessage = new System.Windows.Forms.Label();
            this.checkData = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mapmode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.okay = new System.Windows.Forms.Button();
            this.romspeed = new System.Windows.Forms.Label();
            this.romtitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkboxEmuIRQ = new System.Windows.Forms.CheckBox();
            this.checkboxEmuRESET = new System.Windows.Forms.CheckBox();
            this.checkboxEmuNMI = new System.Windows.Forms.CheckBox();
            this.checkboxEmuABORT = new System.Windows.Forms.CheckBox();
            this.checkboxEmuBRK = new System.Windows.Forms.CheckBox();
            this.checkboxEmuCOP = new System.Windows.Forms.CheckBox();
            this.checkboxNativeIRQ = new System.Windows.Forms.CheckBox();
            this.checkboxNativeRESET = new System.Windows.Forms.CheckBox();
            this.checkboxNativeNMI = new System.Windows.Forms.CheckBox();
            this.checkboxNativeABORT = new System.Windows.Forms.CheckBox();
            this.checkboxNativeBRK = new System.Windows.Forms.CheckBox();
            this.checkboxNativeCOP = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textEmuIRQ = new System.Windows.Forms.TextBox();
            this.textEmuRESET = new System.Windows.Forms.TextBox();
            this.textEmuNMI = new System.Windows.Forms.TextBox();
            this.textEmuABORT = new System.Windows.Forms.TextBox();
            this.textEmuBRK = new System.Windows.Forms.TextBox();
            this.textEmuCOP = new System.Windows.Forms.TextBox();
            this.textNativeIRQ = new System.Windows.Forms.TextBox();
            this.textNativeRESET = new System.Windows.Forms.TextBox();
            this.textNativeNMI = new System.Windows.Forms.TextBox();
            this.textNativeABORT = new System.Windows.Forms.TextBox();
            this.textNativeBRK = new System.Windows.Forms.TextBox();
            this.textNativeCOP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkHeader = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // detectMessage
            // 
            this.detectMessage.AutoSize = true;
            this.detectMessage.Location = new System.Drawing.Point(36, 7);
            this.detectMessage.Name = "detectMessage";
            this.detectMessage.Size = new System.Drawing.Size(187, 13);
            this.detectMessage.TabIndex = 0;
            this.detectMessage.Text = "Couldn\'t auto detect ROM Map Mode!";
            this.detectMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkData
            // 
            this.checkData.AutoSize = true;
            this.checkData.Location = new System.Drawing.Point(39, 23);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(179, 13);
            this.checkData.TabIndex = 1;
            this.checkData.Text = "Does the following info look correct?";
            this.checkData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(0) LoROM",
            "(1) HiROM",
            "(2) Super MMC",
            "(3) SA-1 ROM",
            "(3) SA-1 ROM (FuSoYa\'s 8MB mapper)",
            "(4) SuperFX",
            "(5) ExHiROM",
            "(6) ExLoROM"});
            this.comboBox1.Location = new System.Drawing.Point(103, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mapmode
            // 
            this.mapmode.AutoSize = true;
            this.mapmode.Location = new System.Drawing.Point(11, 21);
            this.mapmode.Name = "mapmode";
            this.mapmode.Size = new System.Drawing.Size(89, 13);
            this.mapmode.TabIndex = 0;
            this.mapmode.Text = "ROM Map Mode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ROM Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ROM Name:";
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(12, 388);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.TabStop = false;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(172, 388);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(75, 23);
            this.okay.TabIndex = 7;
            this.okay.Text = "OK";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // romspeed
            // 
            this.romspeed.AutoSize = true;
            this.romspeed.Location = new System.Drawing.Point(103, 44);
            this.romspeed.Name = "romspeed";
            this.romspeed.Size = new System.Drawing.Size(55, 13);
            this.romspeed.TabIndex = 3;
            this.romspeed.Text = "SlowROM";
            // 
            // romtitle
            // 
            this.romtitle.AutoSize = true;
            this.romtitle.Location = new System.Drawing.Point(103, 66);
            this.romtitle.Name = "romtitle";
            this.romtitle.Size = new System.Drawing.Size(27, 13);
            this.romtitle.TabIndex = 5;
            this.romtitle.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "If not, try changing the ROM Map Mode.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "This cannot be changed once the project is created.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mapmode);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.romtitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.romspeed);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROM Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.checkboxEmuIRQ);
            this.groupBox2.Controls.Add(this.checkboxEmuRESET);
            this.groupBox2.Controls.Add(this.checkboxEmuNMI);
            this.groupBox2.Controls.Add(this.checkboxEmuABORT);
            this.groupBox2.Controls.Add(this.checkboxEmuBRK);
            this.groupBox2.Controls.Add(this.checkboxEmuCOP);
            this.groupBox2.Controls.Add(this.checkboxNativeIRQ);
            this.groupBox2.Controls.Add(this.checkboxNativeRESET);
            this.groupBox2.Controls.Add(this.checkboxNativeNMI);
            this.groupBox2.Controls.Add(this.checkboxNativeABORT);
            this.groupBox2.Controls.Add(this.checkboxNativeBRK);
            this.groupBox2.Controls.Add(this.checkboxNativeCOP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textEmuIRQ);
            this.groupBox2.Controls.Add(this.textEmuRESET);
            this.groupBox2.Controls.Add(this.textEmuNMI);
            this.groupBox2.Controls.Add(this.textEmuABORT);
            this.groupBox2.Controls.Add(this.textEmuBRK);
            this.groupBox2.Controls.Add(this.textEmuCOP);
            this.groupBox2.Controls.Add(this.textNativeIRQ);
            this.groupBox2.Controls.Add(this.textNativeRESET);
            this.groupBox2.Controls.Add(this.textNativeNMI);
            this.groupBox2.Controls.Add(this.textNativeABORT);
            this.groupBox2.Controls.Add(this.textNativeBRK);
            this.groupBox2.Controls.Add(this.textNativeCOP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 189);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vectors @ $00FFE0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Select vectors to generate automatic labels.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkboxEmuIRQ
            // 
            this.checkboxEmuIRQ.AutoSize = true;
            this.checkboxEmuIRQ.Location = new System.Drawing.Point(197, 146);
            this.checkboxEmuIRQ.Name = "checkboxEmuIRQ";
            this.checkboxEmuIRQ.Size = new System.Drawing.Size(15, 14);
            this.checkboxEmuIRQ.TabIndex = 31;
            this.checkboxEmuIRQ.UseVisualStyleBackColor = true;
            // 
            // checkboxEmuRESET
            // 
            this.checkboxEmuRESET.AutoSize = true;
            this.checkboxEmuRESET.Checked = true;
            this.checkboxEmuRESET.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxEmuRESET.Location = new System.Drawing.Point(197, 124);
            this.checkboxEmuRESET.Name = "checkboxEmuRESET";
            this.checkboxEmuRESET.Size = new System.Drawing.Size(15, 14);
            this.checkboxEmuRESET.TabIndex = 29;
            this.checkboxEmuRESET.UseVisualStyleBackColor = true;
            // 
            // checkboxEmuNMI
            // 
            this.checkboxEmuNMI.AutoSize = true;
            this.checkboxEmuNMI.Location = new System.Drawing.Point(197, 102);
            this.checkboxEmuNMI.Name = "checkboxEmuNMI";
            this.checkboxEmuNMI.Size = new System.Drawing.Size(15, 14);
            this.checkboxEmuNMI.TabIndex = 27;
            this.checkboxEmuNMI.UseVisualStyleBackColor = true;
            // 
            // checkboxEmuABORT
            // 
            this.checkboxEmuABORT.AutoSize = true;
            this.checkboxEmuABORT.Location = new System.Drawing.Point(197, 80);
            this.checkboxEmuABORT.Name = "checkboxEmuABORT";
            this.checkboxEmuABORT.Size = new System.Drawing.Size(15, 14);
            this.checkboxEmuABORT.TabIndex = 25;
            this.checkboxEmuABORT.UseVisualStyleBackColor = true;
            // 
            // checkboxEmuBRK
            // 
            this.checkboxEmuBRK.AutoSize = true;
            this.checkboxEmuBRK.Location = new System.Drawing.Point(197, 58);
            this.checkboxEmuBRK.Name = "checkboxEmuBRK";
            this.checkboxEmuBRK.Size = new System.Drawing.Size(15, 14);
            this.checkboxEmuBRK.TabIndex = 23;
            this.checkboxEmuBRK.UseVisualStyleBackColor = true;
            // 
            // checkboxEmuCOP
            // 
            this.checkboxEmuCOP.AutoSize = true;
            this.checkboxEmuCOP.Location = new System.Drawing.Point(197, 36);
            this.checkboxEmuCOP.Name = "checkboxEmuCOP";
            this.checkboxEmuCOP.Size = new System.Drawing.Size(15, 14);
            this.checkboxEmuCOP.TabIndex = 21;
            this.checkboxEmuCOP.UseVisualStyleBackColor = true;
            // 
            // checkboxNativeIRQ
            // 
            this.checkboxNativeIRQ.AutoSize = true;
            this.checkboxNativeIRQ.Checked = true;
            this.checkboxNativeIRQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxNativeIRQ.Location = new System.Drawing.Point(120, 146);
            this.checkboxNativeIRQ.Name = "checkboxNativeIRQ";
            this.checkboxNativeIRQ.Size = new System.Drawing.Size(15, 14);
            this.checkboxNativeIRQ.TabIndex = 19;
            this.checkboxNativeIRQ.UseVisualStyleBackColor = true;
            // 
            // checkboxNativeRESET
            // 
            this.checkboxNativeRESET.AutoSize = true;
            this.checkboxNativeRESET.Location = new System.Drawing.Point(120, 124);
            this.checkboxNativeRESET.Name = "checkboxNativeRESET";
            this.checkboxNativeRESET.Size = new System.Drawing.Size(15, 14);
            this.checkboxNativeRESET.TabIndex = 17;
            this.checkboxNativeRESET.UseVisualStyleBackColor = true;
            // 
            // checkboxNativeNMI
            // 
            this.checkboxNativeNMI.AutoSize = true;
            this.checkboxNativeNMI.Checked = true;
            this.checkboxNativeNMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxNativeNMI.Location = new System.Drawing.Point(120, 102);
            this.checkboxNativeNMI.Name = "checkboxNativeNMI";
            this.checkboxNativeNMI.Size = new System.Drawing.Size(15, 14);
            this.checkboxNativeNMI.TabIndex = 15;
            this.checkboxNativeNMI.UseVisualStyleBackColor = true;
            // 
            // checkboxNativeABORT
            // 
            this.checkboxNativeABORT.AutoSize = true;
            this.checkboxNativeABORT.Location = new System.Drawing.Point(120, 80);
            this.checkboxNativeABORT.Name = "checkboxNativeABORT";
            this.checkboxNativeABORT.Size = new System.Drawing.Size(15, 14);
            this.checkboxNativeABORT.TabIndex = 13;
            this.checkboxNativeABORT.UseVisualStyleBackColor = true;
            // 
            // checkboxNativeBRK
            // 
            this.checkboxNativeBRK.AutoSize = true;
            this.checkboxNativeBRK.Checked = true;
            this.checkboxNativeBRK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxNativeBRK.Location = new System.Drawing.Point(120, 58);
            this.checkboxNativeBRK.Name = "checkboxNativeBRK";
            this.checkboxNativeBRK.Size = new System.Drawing.Size(15, 14);
            this.checkboxNativeBRK.TabIndex = 11;
            this.checkboxNativeBRK.UseVisualStyleBackColor = true;
            // 
            // checkboxNativeCOP
            // 
            this.checkboxNativeCOP.AutoSize = true;
            this.checkboxNativeCOP.Checked = true;
            this.checkboxNativeCOP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxNativeCOP.Location = new System.Drawing.Point(120, 36);
            this.checkboxNativeCOP.Name = "checkboxNativeCOP";
            this.checkboxNativeCOP.Size = new System.Drawing.Size(15, 14);
            this.checkboxNativeCOP.TabIndex = 9;
            this.checkboxNativeCOP.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Emulation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Native";
            // 
            // textEmuIRQ
            // 
            this.textEmuIRQ.Location = new System.Drawing.Point(156, 143);
            this.textEmuIRQ.MaxLength = 4;
            this.textEmuIRQ.Name = "textEmuIRQ";
            this.textEmuIRQ.ReadOnly = true;
            this.textEmuIRQ.Size = new System.Drawing.Size(34, 20);
            this.textEmuIRQ.TabIndex = 30;
            this.textEmuIRQ.TabStop = false;
            this.textEmuIRQ.Text = "FFFF";
            // 
            // textEmuRESET
            // 
            this.textEmuRESET.Location = new System.Drawing.Point(156, 121);
            this.textEmuRESET.MaxLength = 4;
            this.textEmuRESET.Name = "textEmuRESET";
            this.textEmuRESET.ReadOnly = true;
            this.textEmuRESET.Size = new System.Drawing.Size(34, 20);
            this.textEmuRESET.TabIndex = 28;
            this.textEmuRESET.TabStop = false;
            this.textEmuRESET.Text = "FFFF";
            // 
            // textEmuNMI
            // 
            this.textEmuNMI.Location = new System.Drawing.Point(156, 99);
            this.textEmuNMI.MaxLength = 4;
            this.textEmuNMI.Name = "textEmuNMI";
            this.textEmuNMI.ReadOnly = true;
            this.textEmuNMI.Size = new System.Drawing.Size(34, 20);
            this.textEmuNMI.TabIndex = 26;
            this.textEmuNMI.TabStop = false;
            this.textEmuNMI.Text = "FFFF";
            // 
            // textEmuABORT
            // 
            this.textEmuABORT.Location = new System.Drawing.Point(156, 77);
            this.textEmuABORT.MaxLength = 4;
            this.textEmuABORT.Name = "textEmuABORT";
            this.textEmuABORT.ReadOnly = true;
            this.textEmuABORT.Size = new System.Drawing.Size(34, 20);
            this.textEmuABORT.TabIndex = 24;
            this.textEmuABORT.TabStop = false;
            this.textEmuABORT.Text = "FFFF";
            // 
            // textEmuBRK
            // 
            this.textEmuBRK.Location = new System.Drawing.Point(156, 55);
            this.textEmuBRK.MaxLength = 4;
            this.textEmuBRK.Name = "textEmuBRK";
            this.textEmuBRK.ReadOnly = true;
            this.textEmuBRK.Size = new System.Drawing.Size(34, 20);
            this.textEmuBRK.TabIndex = 22;
            this.textEmuBRK.TabStop = false;
            this.textEmuBRK.Text = "FFFF";
            // 
            // textEmuCOP
            // 
            this.textEmuCOP.Location = new System.Drawing.Point(156, 33);
            this.textEmuCOP.MaxLength = 4;
            this.textEmuCOP.Name = "textEmuCOP";
            this.textEmuCOP.ReadOnly = true;
            this.textEmuCOP.Size = new System.Drawing.Size(34, 20);
            this.textEmuCOP.TabIndex = 20;
            this.textEmuCOP.TabStop = false;
            this.textEmuCOP.Text = "FFFF";
            // 
            // textNativeIRQ
            // 
            this.textNativeIRQ.Location = new System.Drawing.Point(79, 143);
            this.textNativeIRQ.MaxLength = 4;
            this.textNativeIRQ.Name = "textNativeIRQ";
            this.textNativeIRQ.ReadOnly = true;
            this.textNativeIRQ.Size = new System.Drawing.Size(34, 20);
            this.textNativeIRQ.TabIndex = 18;
            this.textNativeIRQ.TabStop = false;
            this.textNativeIRQ.Text = "FFFF";
            // 
            // textNativeRESET
            // 
            this.textNativeRESET.Location = new System.Drawing.Point(79, 121);
            this.textNativeRESET.MaxLength = 4;
            this.textNativeRESET.Name = "textNativeRESET";
            this.textNativeRESET.ReadOnly = true;
            this.textNativeRESET.Size = new System.Drawing.Size(34, 20);
            this.textNativeRESET.TabIndex = 16;
            this.textNativeRESET.TabStop = false;
            this.textNativeRESET.Text = "FFFF";
            // 
            // textNativeNMI
            // 
            this.textNativeNMI.Location = new System.Drawing.Point(79, 99);
            this.textNativeNMI.MaxLength = 4;
            this.textNativeNMI.Name = "textNativeNMI";
            this.textNativeNMI.ReadOnly = true;
            this.textNativeNMI.Size = new System.Drawing.Size(34, 20);
            this.textNativeNMI.TabIndex = 14;
            this.textNativeNMI.TabStop = false;
            this.textNativeNMI.Text = "FFFF";
            // 
            // textNativeABORT
            // 
            this.textNativeABORT.Location = new System.Drawing.Point(79, 77);
            this.textNativeABORT.MaxLength = 4;
            this.textNativeABORT.Name = "textNativeABORT";
            this.textNativeABORT.ReadOnly = true;
            this.textNativeABORT.Size = new System.Drawing.Size(34, 20);
            this.textNativeABORT.TabIndex = 12;
            this.textNativeABORT.TabStop = false;
            this.textNativeABORT.Text = "FFFF";
            // 
            // textNativeBRK
            // 
            this.textNativeBRK.Location = new System.Drawing.Point(79, 55);
            this.textNativeBRK.MaxLength = 4;
            this.textNativeBRK.Name = "textNativeBRK";
            this.textNativeBRK.ReadOnly = true;
            this.textNativeBRK.Size = new System.Drawing.Size(34, 20);
            this.textNativeBRK.TabIndex = 10;
            this.textNativeBRK.TabStop = false;
            this.textNativeBRK.Text = "FFFF";
            // 
            // textNativeCOP
            // 
            this.textNativeCOP.Location = new System.Drawing.Point(79, 33);
            this.textNativeCOP.MaxLength = 4;
            this.textNativeCOP.Name = "textNativeCOP";
            this.textNativeCOP.ReadOnly = true;
            this.textNativeCOP.Size = new System.Drawing.Size(34, 20);
            this.textNativeCOP.TabIndex = 8;
            this.textNativeCOP.TabStop = false;
            this.textNativeCOP.Text = "FFFF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "IRQ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "RESET";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "NMI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ABORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BRK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COP";
            // 
            // checkHeader
            // 
            this.checkHeader.AutoSize = true;
            this.checkHeader.Checked = true;
            this.checkHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHeader.Location = new System.Drawing.Point(12, 365);
            this.checkHeader.Name = "checkHeader";
            this.checkHeader.Size = new System.Drawing.Size(237, 17);
            this.checkHeader.TabIndex = 6;
            this.checkHeader.Text = "Auto generate flags for Internal ROM Header";
            this.checkHeader.UseVisualStyleBackColor = true;
            // 
            // ImportROMDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(261, 424);
            this.Controls.Add(this.checkHeader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.checkData);
            this.Controls.Add(this.detectMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportROMDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.Load += new System.EventHandler(this.ImportROMDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detectMessage;
        private System.Windows.Forms.Label checkData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label mapmode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Label romspeed;
        private System.Windows.Forms.Label romtitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkboxEmuIRQ;
        private System.Windows.Forms.CheckBox checkboxEmuRESET;
        private System.Windows.Forms.CheckBox checkboxEmuNMI;
        private System.Windows.Forms.CheckBox checkboxEmuABORT;
        private System.Windows.Forms.CheckBox checkboxEmuBRK;
        private System.Windows.Forms.CheckBox checkboxEmuCOP;
        private System.Windows.Forms.CheckBox checkboxNativeIRQ;
        private System.Windows.Forms.CheckBox checkboxNativeRESET;
        private System.Windows.Forms.CheckBox checkboxNativeNMI;
        private System.Windows.Forms.CheckBox checkboxNativeABORT;
        private System.Windows.Forms.CheckBox checkboxNativeBRK;
        private System.Windows.Forms.CheckBox checkboxNativeCOP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textEmuIRQ;
        private System.Windows.Forms.TextBox textEmuRESET;
        private System.Windows.Forms.TextBox textEmuNMI;
        private System.Windows.Forms.TextBox textEmuABORT;
        private System.Windows.Forms.TextBox textEmuBRK;
        private System.Windows.Forms.TextBox textEmuCOP;
        private System.Windows.Forms.TextBox textNativeIRQ;
        private System.Windows.Forms.TextBox textNativeRESET;
        private System.Windows.Forms.TextBox textNativeNMI;
        private System.Windows.Forms.TextBox textNativeABORT;
        private System.Windows.Forms.TextBox textNativeBRK;
        private System.Windows.Forms.TextBox textNativeCOP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkHeader;
    }
}