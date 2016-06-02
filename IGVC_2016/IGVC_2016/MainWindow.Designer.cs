namespace IGVC_2016
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LidarSerialButton = new System.Windows.Forms.Button();
            this.LidarBaud = new System.Windows.Forms.TextBox();
            this.LidarCOM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LidarDisplay = new Emgu.CV.UI.ImageBox();
            this.Left_Display = new Emgu.CV.UI.ImageBox();
            this.Right_Display = new Emgu.CV.UI.ImageBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LidarChangeData = new Emgu.CV.UI.ImageBox();
            this.LidarScanData = new Emgu.CV.UI.ImageBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.UpdateUI = new System.Windows.Forms.Timer(this.components);
            this.AzLabel = new System.Windows.Forms.Label();
            this.AyLabel = new System.Windows.Forms.Label();
            this.AxLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.GzLabel = new System.Windows.Forms.Label();
            this.GyLabel = new System.Windows.Forms.Label();
            this.GxLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LidarDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LidarChangeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LidarScanData)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1386, 809);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.LidarDisplay);
            this.tabPage2.Controls.Add(this.Left_Display);
            this.tabPage2.Controls.Add(this.Right_Display);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1378, 776);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(10, 335);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(330, 69);
            this.trackBar1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LidarSerialButton);
            this.groupBox2.Controls.Add(this.LidarBaud);
            this.groupBox2.Controls.Add(this.LidarCOM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 237);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LIDAR";
            // 
            // LidarSerialButton
            // 
            this.LidarSerialButton.Location = new System.Drawing.Point(135, 171);
            this.LidarSerialButton.Name = "LidarSerialButton";
            this.LidarSerialButton.Size = new System.Drawing.Size(112, 48);
            this.LidarSerialButton.TabIndex = 4;
            this.LidarSerialButton.Text = "Open";
            this.LidarSerialButton.UseVisualStyleBackColor = true;
            this.LidarSerialButton.Click += new System.EventHandler(this.LidarSerialButton_Click);
            // 
            // LidarBaud
            // 
            this.LidarBaud.Location = new System.Drawing.Point(135, 95);
            this.LidarBaud.Name = "LidarBaud";
            this.LidarBaud.Size = new System.Drawing.Size(112, 35);
            this.LidarBaud.TabIndex = 3;
            // 
            // LidarCOM
            // 
            this.LidarCOM.Location = new System.Drawing.Point(136, 49);
            this.LidarCOM.Name = "LidarCOM";
            this.LidarCOM.Size = new System.Drawing.Size(112, 35);
            this.LidarCOM.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "COM Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1032, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "42° 28\' 26.8752\'\' N\r\n83° 14\' 57.246\'\' W\r\n";
            // 
            // LidarDisplay
            // 
            this.LidarDisplay.Location = new System.Drawing.Point(348, 5);
            this.LidarDisplay.Name = "LidarDisplay";
            this.LidarDisplay.Size = new System.Drawing.Size(676, 751);
            this.LidarDisplay.TabIndex = 6;
            this.LidarDisplay.TabStop = false;
            // 
            // Left_Display
            // 
            this.Left_Display.Location = new System.Drawing.Point(10, 5);
            this.Left_Display.Name = "Left_Display";
            this.Left_Display.Size = new System.Drawing.Size(330, 275);
            this.Left_Display.TabIndex = 5;
            this.Left_Display.TabStop = false;
            // 
            // Right_Display
            // 
            this.Right_Display.Location = new System.Drawing.Point(1030, 5);
            this.Right_Display.Name = "Right_Display";
            this.Right_Display.Size = new System.Drawing.Size(330, 275);
            this.Right_Display.TabIndex = 4;
            this.Right_Display.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LidarChangeData);
            this.tabPage1.Controls.Add(this.LidarScanData);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1378, 776);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LidarChangeData
            // 
            this.LidarChangeData.Location = new System.Drawing.Point(93, 385);
            this.LidarChangeData.Name = "LidarChangeData";
            this.LidarChangeData.Size = new System.Drawing.Size(1215, 375);
            this.LidarChangeData.TabIndex = 7;
            this.LidarChangeData.TabStop = false;
            // 
            // LidarScanData
            // 
            this.LidarScanData.Location = new System.Drawing.Point(93, 5);
            this.LidarScanData.Name = "LidarScanData";
            this.LidarScanData.Size = new System.Drawing.Size(1215, 375);
            this.LidarScanData.TabIndex = 6;
            this.LidarScanData.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1378, 776);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Connections";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1100, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 237);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Right Camera";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 35);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(136, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 35);
            this.textBox6.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Baudrate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "COM Port";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 237);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Left Camera";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 35);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 35);
            this.textBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Baudrate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "COM Port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1100, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 237);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GPS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 35);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 35);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Baudrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "COM Port";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.HeadingLabel);
            this.groupBox6.Controls.Add(this.GzLabel);
            this.groupBox6.Controls.Add(this.GyLabel);
            this.groupBox6.Controls.Add(this.GxLabel);
            this.groupBox6.Controls.Add(this.AzLabel);
            this.groupBox6.Controls.Add(this.AyLabel);
            this.groupBox6.Controls.Add(this.AxLabel);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1030, 420);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(330, 234);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "IMU";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 29);
            this.label10.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ax:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ay:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "Az:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(164, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 29);
            this.label14.TabIndex = 13;
            this.label14.Text = "Gz:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(164, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 29);
            this.label15.TabIndex = 12;
            this.label15.Text = "Gy:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(162, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 29);
            this.label16.TabIndex = 11;
            this.label16.Text = "Gx:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 29);
            this.label17.TabIndex = 14;
            this.label17.Text = "Heading:";
            // 
            // UpdateUI
            // 
            this.UpdateUI.Tick += new System.EventHandler(this.UpdateUI_Tick);
            // 
            // AzLabel
            // 
            this.AzLabel.AutoSize = true;
            this.AzLabel.Location = new System.Drawing.Point(71, 121);
            this.AzLabel.Name = "AzLabel";
            this.AzLabel.Size = new System.Drawing.Size(48, 29);
            this.AzLabel.TabIndex = 18;
            this.AzLabel.Text = "Az:";
            // 
            // AyLabel
            // 
            this.AyLabel.AutoSize = true;
            this.AyLabel.Location = new System.Drawing.Point(71, 84);
            this.AyLabel.Name = "AyLabel";
            this.AyLabel.Size = new System.Drawing.Size(48, 29);
            this.AyLabel.TabIndex = 17;
            this.AyLabel.Text = "Ay:";
            // 
            // AxLabel
            // 
            this.AxLabel.AutoSize = true;
            this.AxLabel.Location = new System.Drawing.Point(69, 48);
            this.AxLabel.Name = "AxLabel";
            this.AxLabel.Size = new System.Drawing.Size(48, 29);
            this.AxLabel.TabIndex = 16;
            this.AxLabel.Text = "Ax:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(104, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 29);
            this.label21.TabIndex = 15;
            // 
            // GzLabel
            // 
            this.GzLabel.AutoSize = true;
            this.GzLabel.Location = new System.Drawing.Point(221, 121);
            this.GzLabel.Name = "GzLabel";
            this.GzLabel.Size = new System.Drawing.Size(51, 29);
            this.GzLabel.TabIndex = 21;
            this.GzLabel.Text = "Gz:";
            // 
            // GyLabel
            // 
            this.GyLabel.AutoSize = true;
            this.GyLabel.Location = new System.Drawing.Point(221, 84);
            this.GyLabel.Name = "GyLabel";
            this.GyLabel.Size = new System.Drawing.Size(51, 29);
            this.GyLabel.TabIndex = 20;
            this.GyLabel.Text = "Gy:";
            // 
            // GxLabel
            // 
            this.GxLabel.AutoSize = true;
            this.GxLabel.Location = new System.Drawing.Point(219, 48);
            this.GxLabel.Name = "GxLabel";
            this.GxLabel.Size = new System.Drawing.Size(51, 29);
            this.GxLabel.TabIndex = 19;
            this.GxLabel.Text = "Gx:";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(141, 196);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(118, 29);
            this.HeadingLabel.TabIndex = 22;
            this.HeadingLabel.Text = "Heading:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 862);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LidarDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LidarChangeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LidarScanData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Emgu.CV.UI.ImageBox Left_Display;
        private Emgu.CV.UI.ImageBox Right_Display;
        private Emgu.CV.UI.ImageBox LidarDisplay;
        private System.Windows.Forms.TabPage tabPage3;
        private Emgu.CV.UI.ImageBox LidarScanData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LidarSerialButton;
        private System.Windows.Forms.TextBox LidarBaud;
        private System.Windows.Forms.TextBox LidarCOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private Emgu.CV.UI.ImageBox LidarChangeData;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer UpdateUI;
        private System.Windows.Forms.Label GzLabel;
        private System.Windows.Forms.Label GyLabel;
        private System.Windows.Forms.Label GxLabel;
        private System.Windows.Forms.Label AzLabel;
        private System.Windows.Forms.Label AyLabel;
        private System.Windows.Forms.Label AxLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label HeadingLabel;
    }
}

