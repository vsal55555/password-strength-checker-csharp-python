namespace PasswordStrengthChecker
{
    partial class frmPasswordChecker
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
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnCheck = new Button();
            chkShowPassword = new CheckBox();
            pbStrength = new ProgressBar();
            lblStrength = new Label();
            lstChecks = new ListBox();
            lblSuggestion = new Label();
            txtSuggestion = new TextBox();
            btnGenerate = new Button();
            btnCopy = new Button();
            Strength = new Label();
            lblScore = new Label();
            lblSuggestions = new Label();
            lstSuggestions = new ListBox();
            lblWarning = new Label();
            picQrCode = new PictureBox();
            btnSaveQR = new Button();
            ((System.ComponentModel.ISupportInitialize)picQrCode).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(43, 28);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Enter Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 63);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(350, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(43, 109);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check Strength";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(412, 63);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // pbStrength
            // 
            pbStrength.Location = new Point(249, 109);
            pbStrength.Name = "pbStrength";
            pbStrength.Size = new Size(100, 23);
            pbStrength.TabIndex = 4;
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Location = new Point(43, 156);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(76, 15);
            lblStrength.TabIndex = 5;
            lblStrength.Text = "Not Checked";
            // 
            // lstChecks
            // 
            lstChecks.FormattingEnabled = true;
            lstChecks.Location = new Point(173, 156);
            lstChecks.Name = "lstChecks";
            lstChecks.Size = new Size(264, 94);
            lstChecks.TabIndex = 6;
            // 
            // lblSuggestion
            // 
            lblSuggestion.AutoSize = true;
            lblSuggestion.Location = new Point(43, 465);
            lblSuggestion.Name = "lblSuggestion";
            lblSuggestion.Size = new Size(153, 15);
            lblSuggestion.TabIndex = 7;
            lblSuggestion.Text = "Suggested Strong Password";
            // 
            // txtSuggestion
            // 
            txtSuggestion.Location = new Point(221, 457);
            txtSuggestion.Name = "txtSuggestion";
            txtSuggestion.ReadOnly = true;
            txtSuggestion.Size = new Size(216, 23);
            txtSuggestion.TabIndex = 8;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(43, 345);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(140, 23);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(329, 505);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(108, 23);
            btnCopy.TabIndex = 10;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // Strength
            // 
            Strength.AutoSize = true;
            Strength.Location = new Point(173, 113);
            Strength.Name = "Strength";
            Strength.Size = new Size(52, 15);
            Strength.TabIndex = 11;
            Strength.Text = "Strength";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(366, 113);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(71, 15);
            lblScore.TabIndex = 12;
            lblScore.Text = "Score: 0/100";
            // 
            // lblSuggestions
            // 
            lblSuggestions.AutoSize = true;
            lblSuggestions.Location = new Point(43, 313);
            lblSuggestions.Name = "lblSuggestions";
            lblSuggestions.Size = new Size(71, 15);
            lblSuggestions.TabIndex = 14;
            lblSuggestions.Text = "Suggestions";
            // 
            // lstSuggestions
            // 
            lstSuggestions.FormattingEnabled = true;
            lstSuggestions.Location = new Point(189, 333);
            lstSuggestions.Name = "lstSuggestions";
            lstSuggestions.Size = new Size(248, 94);
            lstSuggestions.TabIndex = 15;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Location = new Point(43, 274);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 15);
            lblWarning.TabIndex = 16;
            // 
            // picQrCode
            // 
            picQrCode.BorderStyle = BorderStyle.FixedSingle;
            picQrCode.Location = new Point(515, 156);
            picQrCode.Name = "picQrCode";
            picQrCode.Size = new Size(297, 276);
            picQrCode.SizeMode = PictureBoxSizeMode.Zoom;
            picQrCode.TabIndex = 17;
            picQrCode.TabStop = false;
            // 
            // btnSaveQR
            // 
            btnSaveQR.Location = new Point(636, 438);
            btnSaveQR.Name = "btnSaveQR";
            btnSaveQR.Size = new Size(75, 23);
            btnSaveQR.TabIndex = 18;
            btnSaveQR.Text = "Save QR";
            btnSaveQR.UseVisualStyleBackColor = true;
            btnSaveQR.Click += btnSaveQR_Click_1;
            // 
            // frmPasswordChecker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 561);
            Controls.Add(btnSaveQR);
            Controls.Add(picQrCode);
            Controls.Add(lblWarning);
            Controls.Add(lstSuggestions);
            Controls.Add(lblSuggestions);
            Controls.Add(lblScore);
            Controls.Add(Strength);
            Controls.Add(btnCopy);
            Controls.Add(btnGenerate);
            Controls.Add(txtSuggestion);
            Controls.Add(lblSuggestion);
            Controls.Add(lstChecks);
            Controls.Add(lblStrength);
            Controls.Add(pbStrength);
            Controls.Add(chkShowPassword);
            Controls.Add(btnCheck);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Name = "frmPasswordChecker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Strength Checker";
            ((System.ComponentModel.ISupportInitialize)picQrCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnCheck;
        private CheckBox chkShowPassword;
        private ProgressBar pbStrength;
        private Label lblStrength;
        private ListBox lstChecks;
        private Label lblSuggestion;
        private TextBox txtSuggestion;
        private Button btnGenerate;
        private Button btnCopy;
        private Label Strength;
        private Label lblScore;
        private Label lblSuggestions;
        private ListBox lstSuggestions;
        private Label lblWarning;
        private PictureBox picQrCode;
        private Button btnSaveQR;
    }
}
