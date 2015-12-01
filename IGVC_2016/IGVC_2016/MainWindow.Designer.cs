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
<<<<<<< HEAD
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Right_Display = new Emgu.CV.UI.ImageBox();
            this.Left_Display = new Emgu.CV.UI.ImageBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).BeginInit();
=======
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
>>>>>>> parent of 289b635... Created IO Manager
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 583);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
<<<<<<< HEAD
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 550);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Raw Data";
            this.tabPage2.UseVisualStyleBackColor = true;
=======
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 570);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Raw Data";
            this.tabPage3.UseVisualStyleBackColor = true;
>>>>>>> parent of 289b635... Created IO Manager
            // 
            // tabPage1
            // 
<<<<<<< HEAD
            this.tabPage1.Controls.Add(this.Right_Display);
            this.tabPage1.Controls.Add(this.Left_Display);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 550);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Visualizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Right_Display
            // 
            this.Right_Display.Location = new System.Drawing.Point(524, 6);
            this.Right_Display.Name = "Right_Display";
            this.Right_Display.Size = new System.Drawing.Size(352, 325);
            this.Right_Display.TabIndex = 3;
            this.Right_Display.TabStop = false;
            // 
            // Left_Display
            // 
            this.Left_Display.Location = new System.Drawing.Point(6, 6);
            this.Left_Display.Name = "Left_Display";
            this.Left_Display.Size = new System.Drawing.Size(352, 325);
            this.Left_Display.TabIndex = 2;
            this.Left_Display.TabStop = false;
=======
            this.tabPage4.Controls.Add(this.imageBox3);
            this.tabPage4.Controls.Add(this.imageBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(882, 550);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Visualizer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(524, 6);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(352, 325);
            this.imageBox3.TabIndex = 3;
            this.imageBox3.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.Location = new System.Drawing.Point(6, 6);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(352, 325);
            this.imageBox4.TabIndex = 2;
            this.imageBox4.TabStop = false;
>>>>>>> parent of 289b635... Created IO Manager
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Main Window";
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).EndInit();
=======
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
>>>>>>> parent of 289b635... Created IO Manager
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Emgu.CV.UI.ImageBox Right_Display;
        private Emgu.CV.UI.ImageBox Left_Display;
=======
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox4;
>>>>>>> parent of 289b635... Created IO Manager

    }
}

