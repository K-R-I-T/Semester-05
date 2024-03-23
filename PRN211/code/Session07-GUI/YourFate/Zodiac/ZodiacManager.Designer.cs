namespace Zodiac
{
    partial class ZodiacManager
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
            lblWelcome = new Label();
            btnShowImage = new Button();
            picImage = new PictureBox();
            pnlImage = new Panel();
            btnCheck = new Button();
            btnExit = new Button();
            lblDay = new Label();
            lblMonth = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            lblZodiac = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.LightBlue;
            lblWelcome.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = SystemColors.HotTrack;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(699, 106);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Zodiac Calculator";
            // 
            // btnShowImage
            // 
            btnShowImage.BackColor = Color.SkyBlue;
            btnShowImage.FlatStyle = FlatStyle.Flat;
            btnShowImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowImage.ForeColor = SystemColors.MenuHighlight;
            btnShowImage.Location = new Point(732, 41);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(150, 45);
            btnShowImage.TabIndex = 2;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = false;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.DarkTurquoise;
            picImage.Location = new Point(3, 6);
            picImage.Name = "picImage";
            picImage.Size = new Size(431, 302);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            picImage.Click += picImage_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = SystemColors.ActiveCaption;
            pnlImage.Controls.Add(picImage);
            pnlImage.Location = new Point(382, 137);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(486, 231);
            pnlImage.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.SkyBlue;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheck.ForeColor = SystemColors.MenuHighlight;
            btnCheck.Location = new Point(12, 301);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(150, 45);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Check Zodiac";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SkyBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.MenuHighlight;
            btnExit.Location = new Point(190, 301);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "Quit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.LightBlue;
            lblDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.ForeColor = SystemColors.HotTrack;
            lblDay.Location = new Point(15, 143);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(147, 28);
            lblDay.TabIndex = 6;
            lblDay.Text = "Your birth day";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BackColor = Color.LightBlue;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonth.ForeColor = SystemColors.HotTrack;
            lblMonth.Location = new Point(15, 225);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(175, 28);
            lblMonth.TabIndex = 7;
            lblMonth.Text = "Your birth month";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(215, 147);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(125, 27);
            txtDay.TabIndex = 0;
            txtDay.TextChanged += txtDay_TextChanged;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(215, 226);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(125, 27);
            txtMonth.TabIndex = 1;
            // 
            // lblZodiac
            // 
            lblZodiac.AutoSize = true;
            lblZodiac.BackColor = Color.LightBlue;
            lblZodiac.FlatStyle = FlatStyle.Flat;
            lblZodiac.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblZodiac.ForeColor = SystemColors.HotTrack;
            lblZodiac.Location = new Point(12, 373);
            lblZodiac.Name = "lblZodiac";
            lblZodiac.Size = new Size(224, 50);
            lblZodiac.TabIndex = 10;
            lblZodiac.Text = "Your zodiac";
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(894, 470);
            Controls.Add(lblZodiac);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblMonth);
            Controls.Add(lblDay);
            Controls.Add(btnExit);
            Controls.Add(btnCheck);
            Controls.Add(pnlImage);
            Controls.Add(btnShowImage);
            Controls.Add(lblWelcome);
            Name = "ZodiacManager";
            Text = "Welcome to Zodiac Calculator";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShowImage;
        private PictureBox picImage;
        private Panel pnlImage;
        private Button btnCheck;
        private Button btnExit;
        private Label lblDay;
        private Label lblMonth;
        private TextBox txtDay;
        private TextBox txtMonth;
        private Label lblZodiac;
    }
}
