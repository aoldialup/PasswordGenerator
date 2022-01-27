using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly Random random;

        public Form1()
        {
            InitializeComponent();

            random = new Random();
        }

        private const string LETTERS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SYMBOLS = "!@#$%^&*";
        private const string NUMBERS = "0123456789";

        private const int MAX_PASSWORD_LENGTH = 1024;
        private const int MIN_PASSWORD_LENGTH = 1;

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int passwordLength = int.Parse(textBoxPasswordLength.Text);

            if (passwordLength > MAX_PASSWORD_LENGTH)
            {
                MessageBox.Show(
                    $"Password length must be less than or equal to {MAX_PASSWORD_LENGTH}",
                    "Password Generator", MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    0, "mspaint.chm",
                    HelpNavigator.KeywordIndex, "ovals"
                    );

                textBoxPasswordLength.Clear();
                textBoxPasswordLength.Focus();
            }
            else if (passwordLength < MIN_PASSWORD_LENGTH)
            {
                MessageBox.Show("Password length must be greater than or equal to 1",
                                    "Password Generator", MessageBoxButtons.OK,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1,
                                   0, "mspaint.chm",
                                   HelpNavigator.KeywordIndex, "ovals");

                textBoxPasswordLength.Clear();
                textBoxPasswordLength.Focus();
            }
            else
            {
                textBoxPasswordOutput.Clear();
                textBoxPasswordOutput.Text = GeneratePassword();
            }
        }

        private string GeneratePassword()
        {
            int passwordLength = int.Parse(textBoxPasswordLength.Text);

            string charsToUse = LETTERS;

            if (checkBoxUseNumbers.Checked)
            {
                charsToUse += NUMBERS;
            }

            if (checkBoxUseSymbols.Checked)
            {
                charsToUse += SYMBOLS;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                sb.Append(charsToUse[random.Next(0, charsToUse.Length)]);
            }

            return sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }







    }
}
