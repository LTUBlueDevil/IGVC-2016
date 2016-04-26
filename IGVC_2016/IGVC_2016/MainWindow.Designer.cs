﻿namespace IGVC_2016
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ConvoNN_Image = new Emgu.CV.UI.ImageBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LidarDisplay = new Emgu.CV.UI.ImageBox();
            this.Left_Display = new Emgu.CV.UI.ImageBox();
            this.Right_Display = new Emgu.CV.UI.ImageBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConvoNN_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LidarDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(952, 562);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(229, 50);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(221, 21);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ConvoNN_Image);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(221, 21);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ConvoNN_Image
            // 
            this.ConvoNN_Image.Location = new System.Drawing.Point(6, 4);
            this.ConvoNN_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConvoNN_Image.Name = "ConvoNN_Image";
            this.ConvoNN_Image.Size = new System.Drawing.Size(305, 305);
            this.ConvoNN_Image.TabIndex = 6;
            this.ConvoNN_Image.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(221, 21);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Connections";
            // 
            // LidarDisplay
            // 
            this.LidarDisplay.Location = new System.Drawing.Point(312, 11);
            this.LidarDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LidarDisplay.Name = "LidarDisplay";
            this.LidarDisplay.Size = new System.Drawing.Size(601, 601);
            this.LidarDisplay.TabIndex = 6;
            this.LidarDisplay.TabStop = false;
            // 
            // Left_Display
            // 
            this.Left_Display.Location = new System.Drawing.Point(12, 11);
            this.Left_Display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Left_Display.Name = "Left_Display";
            this.Left_Display.Size = new System.Drawing.Size(294, 220);
            this.Left_Display.TabIndex = 5;
            this.Left_Display.TabStop = false;
            // 
            // Right_Display
            // 
            this.Right_Display.Location = new System.Drawing.Point(919, 11);
            this.Right_Display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Right_Display.Name = "Right_Display";
            this.Right_Display.Size = new System.Drawing.Size(294, 220);
            this.Right_Display.TabIndex = 4;
            this.Right_Display.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 623);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LidarDisplay);
            this.Controls.Add(this.Left_Display);
            this.Controls.Add(this.Right_Display);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConvoNN_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LidarDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Emgu.CV.UI.ImageBox Left_Display;
        private Emgu.CV.UI.ImageBox Right_Display;
        private Emgu.CV.UI.ImageBox LidarDisplay;
        private System.Windows.Forms.TabPage tabPage3;
        private Emgu.CV.UI.ImageBox ConvoNN_Image;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
    }
}

