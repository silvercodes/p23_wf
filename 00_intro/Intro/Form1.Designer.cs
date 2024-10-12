namespace Intro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(213, 34);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 46);
            btn1.TabIndex = 0;
            btn1.Tag = "one";
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += BtnClick;
            // 
            // btn2
            // 
            btn2.Location = new Point(421, 34);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 46);
            btn2.TabIndex = 1;
            btn2.Tag = "two";
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += BtnClick;
            // 
            // btn3
            // 
            btn3.Location = new Point(635, 34);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 46);
            btn3.TabIndex = 2;
            btn3.Tag = "three";
            btn3.Text = "button3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += BtnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 777);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "APPLICATION";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}
