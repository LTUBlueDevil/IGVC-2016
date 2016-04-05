namespace IGVC_Controller.Code.Modules.Visualizer.LIDAR
{
    partial class LIDAR_Visualizer_Form
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
            this.ForwardDistanceLabel = new System.Windows.Forms.Label();
            this.LIDAR_Image = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.LIDAR_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // ForwardDistanceLabel
            // 
            this.ForwardDistanceLabel.AutoSize = true;
            this.ForwardDistanceLabel.Location = new System.Drawing.Point(14, 12);
            this.ForwardDistanceLabel.Name = "ForwardDistanceLabel";
            this.ForwardDistanceLabel.Size = new System.Drawing.Size(142, 20);
            this.ForwardDistanceLabel.TabIndex = 0;
            this.ForwardDistanceLabel.Text = "Forward Distance: ";
            // 
            // LIDAR_Image
            // 
            this.LIDAR_Image.Location = new System.Drawing.Point(12, 48);
            this.LIDAR_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LIDAR_Image.Name = "LIDAR_Image";
            this.LIDAR_Image.Size = new System.Drawing.Size(676, 751);
            this.LIDAR_Image.TabIndex = 2;
            this.LIDAR_Image.TabStop = false;
            // 
            // LIDAR_Visualizer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 808);
            this.ControlBox = false;
            this.Controls.Add(this.LIDAR_Image);
            this.Controls.Add(this.ForwardDistanceLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LIDAR_Visualizer_Form";
            this.Text = "LIDAR_Visualizer_Form";
            this.Load += new System.EventHandler(this.LIDAR_Visualizer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LIDAR_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ForwardDistanceLabel;
        private Emgu.CV.UI.ImageBox LIDAR_Image;
    }
}