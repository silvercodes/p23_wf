namespace _03_lists
{
    partial class FrmMain
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
            btnListBox = new Button();
            btnComboBox = new Button();
            btnBinding = new Button();
            SuspendLayout();
            // 
            // btnListBox
            // 
            btnListBox.Location = new Point(63, 119);
            btnListBox.Name = "btnListBox";
            btnListBox.Size = new Size(610, 78);
            btnListBox.TabIndex = 0;
            btnListBox.Text = "ListBox";
            btnListBox.UseVisualStyleBackColor = true;
            btnListBox.Click += btnListBox_Click;
            // 
            // btnComboBox
            // 
            btnComboBox.Location = new Point(63, 263);
            btnComboBox.Name = "btnComboBox";
            btnComboBox.Size = new Size(610, 78);
            btnComboBox.TabIndex = 1;
            btnComboBox.Text = "Combobox";
            btnComboBox.UseVisualStyleBackColor = true;
            btnComboBox.Click += btnCombobox_Click;
            // 
            // btnBinding
            // 
            btnBinding.Location = new Point(63, 414);
            btnBinding.Name = "btnBinding";
            btnBinding.Size = new Size(610, 78);
            btnBinding.TabIndex = 2;
            btnBinding.Text = "Binding";
            btnBinding.UseVisualStyleBackColor = true;
            btnBinding.Click += this.btnBinding_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 739);
            Controls.Add(btnBinding);
            Controls.Add(btnComboBox);
            Controls.Add(btnListBox);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "MAIN";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListBox;
        private Button btnComboBox;
        private Button btnBinding;
    }
}
