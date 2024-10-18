namespace _03_lists
{
    partial class FrmListBox
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
            lbxLeft = new ListBox();
            lbxRight = new ListBox();
            btnToRight = new Button();
            btnToLeft = new Button();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // lbxLeft
            // 
            lbxLeft.FormattingEnabled = true;
            lbxLeft.ItemHeight = 50;
            lbxLeft.Location = new Point(34, 38);
            lbxLeft.Name = "lbxLeft";
            lbxLeft.Size = new Size(283, 454);
            lbxLeft.TabIndex = 0;
            // 
            // lbxRight
            // 
            lbxRight.FormattingEnabled = true;
            lbxRight.ItemHeight = 50;
            lbxRight.Location = new Point(587, 38);
            lbxRight.Name = "lbxRight";
            lbxRight.Size = new Size(283, 454);
            lbxRight.TabIndex = 1;
            // 
            // btnToRight
            // 
            btnToRight.Location = new Point(377, 94);
            btnToRight.Name = "btnToRight";
            btnToRight.Size = new Size(150, 70);
            btnToRight.TabIndex = 2;
            btnToRight.Tag = "toRight";
            btnToRight.Text = ">>>";
            btnToRight.UseVisualStyleBackColor = true;
            btnToRight.Click += SwapHandler;
            // 
            // btnToLeft
            // 
            btnToLeft.Location = new Point(377, 202);
            btnToLeft.Name = "btnToLeft";
            btnToLeft.Size = new Size(150, 70);
            btnToLeft.TabIndex = 3;
            btnToLeft.Tag = "toLeft";
            btnToLeft.Text = "<<<";
            btnToLeft.UseVisualStyleBackColor = true;
            btnToLeft.Click += SwapHandler;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(36, 526);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(270, 68);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // FrmListBox
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 703);
            Controls.Add(btnGenerate);
            Controls.Add(btnToLeft);
            Controls.Add(btnToRight);
            Controls.Add(lbxRight);
            Controls.Add(lbxLeft);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmListBox";
            Text = "FrmListBox";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxLeft;
        private ListBox lbxRight;
        private Button btnToRight;
        private Button btnToLeft;
        private Button btnGenerate;
    }
}