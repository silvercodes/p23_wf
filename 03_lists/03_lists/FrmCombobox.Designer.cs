namespace _03_lists
{
    partial class FrmCombobox
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mercury", "Venus", "Earth" });
            comboBox1.Location = new Point(96, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(460, 58);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Mercury", "Venus", "Earth" });
            comboBox2.Location = new Point(603, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(460, 58);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.Simple;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Mercury", "Venus", "Earth" });
            comboBox3.Location = new Point(1112, 91);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(460, 58);
            comboBox3.TabIndex = 2;
            // 
            // FrmCombobox
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 916);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmCombobox";
            Text = "FrmCombobox";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}