namespace _03_lists
{
    partial class FrmBinding
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
            cbxOne = new ComboBox();
            SuspendLayout();
            // 
            // cbxOne
            // 
            cbxOne.FormattingEnabled = true;
            cbxOne.Location = new Point(45, 45);
            cbxOne.Name = "cbxOne";
            cbxOne.Size = new Size(543, 58);
            cbxOne.TabIndex = 0;
            cbxOne.SelectedIndexChanged += cbxOne_SelectedIndexChanged;
            // 
            // FrmBinding
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 768);
            Controls.Add(cbxOne);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmBinding";
            Text = "FrmBinding";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbxOne;
    }
}