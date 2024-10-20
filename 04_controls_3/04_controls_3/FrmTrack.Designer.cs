namespace _04_controls_3
{
    partial class FrmTrack
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
            components = new System.ComponentModel.Container();
            trackBar1 = new TrackBar();
            progressBar1 = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(54, 85);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(624, 90);
            trackBar1.TabIndex = 0;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(64, 316);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(614, 79);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 30;
            // 
            // FrmTrack
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 703);
            Controls.Add(progressBar1);
            Controls.Add(trackBar1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmTrack";
            Text = "FrmTrack";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer;
    }
}