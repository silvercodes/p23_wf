namespace _04_controls_3
{
    partial class FrmPicBox
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
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic4 = new PictureBox();
            pic5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            SuspendLayout();
            // 
            // pic1
            // 
            pic1.ImageLocation = "https://static.toiimg.com/photo/msid-67586673/67586673.jpg?3918697";
            pic1.Location = new Point(59, 67);
            pic1.Name = "pic1";
            pic1.Size = new Size(398, 393);
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.ImageLocation = "https://static.toiimg.com/photo/msid-67586673/67586673.jpg?3918697";
            pic2.Location = new Point(517, 67);
            pic2.Name = "pic2";
            pic2.Size = new Size(398, 393);
            pic2.TabIndex = 1;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.ImageLocation = "https://static.toiimg.com/photo/msid-67586673/67586673.jpg?3918697";
            pic3.Location = new Point(998, 67);
            pic3.Name = "pic3";
            pic3.Size = new Size(398, 393);
            pic3.TabIndex = 2;
            pic3.TabStop = false;
            // 
            // pic4
            // 
            pic4.ImageLocation = "https://static.toiimg.com/photo/msid-67586673/67586673.jpg?3918697";
            pic4.Location = new Point(59, 564);
            pic4.Name = "pic4";
            pic4.Size = new Size(398, 393);
            pic4.TabIndex = 3;
            pic4.TabStop = false;
            // 
            // pic5
            // 
            pic5.ImageLocation = "https://static.toiimg.com/photo/msid-67586673/67586673.jpg?3918697";
            pic5.Location = new Point(526, 564);
            pic5.Name = "pic5";
            pic5.Size = new Size(398, 393);
            pic5.TabIndex = 4;
            pic5.TabStop = false;
            // 
            // FrmPicBox
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 1464);
            Controls.Add(pic5);
            Controls.Add(pic4);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmPicBox";
            Text = "FrmPicBox";
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic4;
        private PictureBox pic5;
    }
}