namespace _01_controls
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
            btnDialog = new Button();
            btnEvents = new Button();
            btnControls = new Button();
            btnTimer = new Button();
            SuspendLayout();
            // 
            // btnDialog
            // 
            btnDialog.Location = new Point(77, 43);
            btnDialog.Name = "btnDialog";
            btnDialog.Size = new Size(488, 67);
            btnDialog.TabIndex = 0;
            btnDialog.Text = "Open dialog";
            btnDialog.UseVisualStyleBackColor = true;
            btnDialog.Click += btnDialog_Click;
            // 
            // btnEvents
            // 
            btnEvents.Location = new Point(77, 154);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(488, 67);
            btnEvents.TabIndex = 1;
            btnEvents.Text = "Open form Events";
            btnEvents.UseVisualStyleBackColor = true;
            btnEvents.Click += btnEvents_Click;
            // 
            // btnControls
            // 
            btnControls.Location = new Point(77, 264);
            btnControls.Name = "btnControls";
            btnControls.Size = new Size(488, 67);
            btnControls.TabIndex = 2;
            btnControls.Text = "Open form Controls";
            btnControls.UseVisualStyleBackColor = true;
            btnControls.Click += btnControls_Click;
            // 
            // btnTimer
            // 
            btnTimer.Location = new Point(77, 373);
            btnTimer.Name = "btnTimer";
            btnTimer.Size = new Size(488, 67);
            btnTimer.TabIndex = 3;
            btnTimer.Text = "Open form Timer";
            btnTimer.UseVisualStyleBackColor = true;
            btnTimer.Click += btnTimer_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1231, 703);
            Controls.Add(btnTimer);
            Controls.Add(btnControls);
            Controls.Add(btnEvents);
            Controls.Add(btnDialog);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FrmMain";
            Text = "MAIN";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDialog;
        private Button btnEvents;
        private Button btnControls;
        private Button btnTimer;
    }
}
