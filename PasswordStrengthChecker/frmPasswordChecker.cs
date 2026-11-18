using System.Diagnostics;

namespace PasswordStrengthChecker
{
    public partial class frmPasswordChecker : Form
    {
        public frmPasswordChecker()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar =
            chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string password =
                GenerateStrongPassword();

            txtSuggestion.Text =
                password;

            GenerateQrCodePython(
                password
            );

            LoadQrImage();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSuggestion.Text);

            MessageBox.Show(
                "Password copied successfully."
            );
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string password =
                txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter a password."
                );
                return;
            }

            CheckPasswordStrength(password);
        }


        private void CheckPasswordStrength(string password)
        {
            lstChecks.Items.Clear();

            int score = 0;

            bool hasLength = password.Length >= 12;
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));
            bool isCommon = IsCommonPassword(password);

            lstChecks.Items.Add(
                hasLength
                    ? "✓ Minimum 12 Characters"
                    : "✗ Minimum 12 Characters"
            );

            lstChecks.Items.Add(
                hasUpper
                    ? "✓ Uppercase Letter"
                    : "✗ Uppercase Letter"
            );

            lstChecks.Items.Add(
                hasLower
                    ? "✓ Lowercase Letter"
                    : "✗ Lowercase Letter"
            );

            lstChecks.Items.Add(
                hasDigit
                    ? "✓ Number"
                    : "✗ Number"
            );

            lstChecks.Items.Add(
                hasSpecial
                    ? "✓ Special Character"
                    : "✗ Special Character"
            );

            lstChecks.Items.Add(!isCommon ? "✓ Not a Common Password" : "✗ Common Password");

            if (hasLength) score++;
            if (hasUpper) score++;
            if (hasLower) score++;
            if (hasDigit) score++;
            if (hasSpecial) score++;

            DisplayStrength(score);
            GenerateSuggestions(hasLength, hasUpper, hasLower, hasDigit, hasSpecial, isCommon);

        }

        private void DisplayStrength(int score)
        {
            pbStrength.Maximum = 5;
            pbStrength.Value = score;

            switch (score)
            {
                case 0:
                case 1:
                case 2:

                    lblStrength.Text = "Weak";
                    lblStrength.ForeColor = Color.Red;
                    break;

                case 3:

                    lblStrength.Text = "Medium";
                    lblStrength.ForeColor = Color.Orange;
                    break;

                case 4:

                    lblStrength.Text = "Strong";
                    lblStrength.ForeColor = Color.Green;
                    break;

                case 5:

                    lblStrength.Text = "Very Strong";
                    lblStrength.ForeColor = Color.DarkGreen;
                    break;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordStrength(
                txtPassword.Text
            );
        }

        private void GenerateSuggestions(
    bool hasLength,
    bool hasUpper,
    bool hasLower,
    bool hasDigit,
    bool hasSpecial,
    bool isCommon)
        {
            lstSuggestions.Items.Clear();

            if (isCommon)
            {
                lstSuggestions.Items.Add(
                    "Avoid commonly used passwords."
                );
            }

            if (!hasLength)
                lstSuggestions.Items.Add(
                    "Add at least 12 characters."
                );

            if (!hasUpper)
                lstSuggestions.Items.Add(
                    "Add uppercase letters (A-Z)."
                );

            if (!hasLower)
                lstSuggestions.Items.Add(
                    "Add lowercase letters (a-z)."
                );

            if (!hasDigit)
                lstSuggestions.Items.Add(
                    "Add numeric digits (0-9)."
                );

            if (!hasSpecial)
                lstSuggestions.Items.Add(
                    "Add special characters (!@#$%^&*)."
                );

            if (hasLength &&
               hasUpper &&
               hasLower &&
               hasDigit &&
               hasSpecial)
            {
                lstSuggestions.Items.Add(
                    "Excellent password!"
                );
            }
        }

        private string GenerateStrongPassword(int length = 20)
        {
            const string chars =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "!@#$%^&*";

            Random random = new Random();

            return new string(
                Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray()
            );
        }

        private bool IsCommonPassword(string password)
        {
            string filePath =
                Path.Combine(
                    Application.StartupPath,
                    "common_passwords.txt");

            if (!File.Exists(filePath))
                return false;

            var passwords =
                File.ReadAllLines(filePath);

            return passwords.Any(p =>
                p.Equals(
                    password,
                    StringComparison.OrdinalIgnoreCase));

        }

        private void GenerateQrCodePython(string password)
        {
            ProcessStartInfo startInfo = new();

            startInfo.FileName = "python";

            startInfo.Arguments =
                $"generate_qr.py \"{password}\"";

            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            using Process process = Process.Start(startInfo);

            string output =
                process.StandardOutput.ReadToEnd();

            string error =
                process.StandardError.ReadToEnd();

            process.WaitForExit();

            MessageBox.Show(
                $"{output}\n ✓ Successfully");
        }

        private void LoadQrImage()
        {
            string qrPath = "password_qr.png";

            if (File.Exists(qrPath))
            {
                byte[] bytes =
                    File.ReadAllBytes(qrPath);

                using MemoryStream ms =
                    new MemoryStream(bytes);

                picQrCode.Image =
                    Image.FromStream(ms);
            }
        }


        private void btnSaveQR_Click_1(object sender, EventArgs e)
        {
            if (picQrCode.Image == null)
            {
                MessageBox.Show(
                    "Please generate a QR code first.",
                    "No QR Code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (SaveFileDialog saveDialog =
                   new SaveFileDialog())
            {
                saveDialog.Title = "Save QR Code";

                saveDialog.Filter =
                    "PNG Image (*.png)|*.png";

                saveDialog.DefaultExt = "png";

                saveDialog.InitialDirectory =
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.Desktop);

                saveDialog.FileName =
                    $"PasswordQR_{DateTime.Now:yyyyMMdd_HHmmss}.png";

                if (saveDialog.ShowDialog()
                    == DialogResult.OK)
                {
                    picQrCode.Image.Save(
                        saveDialog.FileName,
                        System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show(
                        $"Saved Successfully!\n\n{saveDialog.FileName}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
