namespace Calculator
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
            txbVal1 = new TextBox();
            txbVal2 = new TextBox();
            btnCalc = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txbVal1
            // 
            txbVal1.Location = new Point(102, 91);
            txbVal1.Margin = new Padding(5);
            txbVal1.Name = "txbVal1";
            txbVal1.Size = new Size(504, 57);
            txbVal1.TabIndex = 0;
            // 
            // txbVal2
            // 
            txbVal2.Location = new Point(105, 225);
            txbVal2.Margin = new Padding(5);
            txbVal2.Name = "txbVal2";
            txbVal2.Size = new Size(501, 57);
            txbVal2.TabIndex = 1;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.Red;
            btnCalc.Location = new Point(229, 381);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(377, 80);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Claculate";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 35);
            label1.Name = "label1";
            label1.Size = new Size(140, 50);
            label1.TabIndex = 3;
            label1.Text = "Value 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 170);
            label2.Name = "label2";
            label2.Size = new Size(140, 50);
            label2.TabIndex = 4;
            label2.Text = "Value 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(708, 554);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalc);
            Controls.Add(txbVal2);
            Controls.Add(txbVal1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbVal1;
        private TextBox txbVal2;
        private Button btnCalc;
        private Label label1;
        private Label label2;
    }
}
