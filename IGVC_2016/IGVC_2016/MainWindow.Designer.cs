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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Left_Display = new Emgu.CV.UI.ImageBox();
            this.Right_Display = new Emgu.CV.UI.ImageBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Left_Display);
            this.tabPage2.Controls.Add(this.Right_Display);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Left_Display
            // 
            this.Left_Display.Location = new System.Drawing.Point(26, 23);
            this.Left_Display.Name = "Left_Display";
            this.Left_Display.Size = new System.Drawing.Size(331, 275);
            this.Left_Display.TabIndex = 5;
            this.Left_Display.TabStop = false;
            // 
            // Right_Display
            // 
            this.Right_Display.Location = new System.Drawing.Point(403, 23);
            this.Right_Display.Name = "Right_Display";
            this.Right_Display.Size = new System.Drawing.Size(331, 275);
            this.Right_Display.TabIndex = 4;
            this.Right_Display.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Left_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Emgu.CV.UI.ImageBox Left_Display;
        private Emgu.CV.UI.ImageBox Right_Display;
    }
}

