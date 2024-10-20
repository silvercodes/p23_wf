namespace _04_controls_3
{
    partial class FrmMain
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
            btnPicBox = new Button();
            btnTrack = new Button();
            btnScroll = new Button();
            SuspendLayout();
            // 
            // btnPicBox
            // 
            btnPicBox.Location = new Point(96, 53);
            btnPicBox.Name = "btnPicBox";
            btnPicBox.Size = new Size(632, 88);
            btnPicBox.TabIndex = 0;
            btnPicBox.Text = "PictureBox";
            btnPicBox.UseVisualStyleBackColor = true;
            btnPicBox.Click += btnPicBox_Click;
            // 
            // btnTrack
            // 
            btnTrack.Location = new Point(96, 229);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(632, 88);
            btnTrack.TabIndex = 1;
            btnTrack.Text = "Track";
            btnTrack.UseVisualStyleBackColor = true;
            btnTrack.Click += btnTrack_Click;
            // 
            // btnScroll
            // 
            btnScroll.Location = new Point(96, 399);
            btnScroll.Name = "btnScroll";
            btnScroll.Size = new Size(632, 88);
            btnScroll.TabIndex = 2;
            btnScroll.Text = "Scroll";
            btnScroll.UseVisualStyleBackColor = true;
            btnScroll.Click += btnScroll_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 703);
            Controls.Add(btnScroll);
            Controls.Add(btnTrack);
            Controls.Add(btnPicBox);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "FrmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPicBox;
        private Button btnTrack;
        private Button btnScroll;
    }
}