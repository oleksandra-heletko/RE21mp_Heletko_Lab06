using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Media;

namespace Heletko_Lab06
{
    public partial class Form1 : Form
    {
        byte[] fArray = new byte[0];
        byte[] randArray = new byte[0];
        byte[] resArray = new byte[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kLengthComboBox.SelectedItem = "8";
            vPassCheckBox.Checked = false;
        }

        string StringHEX(byte[] randArr)
        {
            BitArray randomBitArr = new BitArray(randArray);
            string hexText = BitConverter.ToString(randArray);
            return hexText.Replace("-", "");
        }

        byte[] StringToByteArr(string stHEX)
        {
            int length = stHEX.Length;
            if (length % 2 == 1)
            {
                stHEX = "0" + stHEX;
                kHEXTextBox.Text = stHEX;
                length++;
            }

            int halfLength = length / 2;
            byte[] bs = new byte[halfLength];

            for (int i = 0; i != halfLength; i++)
            {
                bs[i] = (byte)Int32.Parse(stHEX.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }

        private string ToDigitString(BitArray array)
        {
            var stBuilder = new StringBuilder();
            foreach (var bit in array.Cast<bool>())
            {
                stBuilder.Append(bit ? "1" : "0");
            }
            return stBuilder.ToString();
        }

        private void oKeyFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = "MyKey";
            saveDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            saveDialog.FilterIndex = 2;
            saveDialog.CreatePrompt = true;
            saveDialog.OverwritePrompt = true;
            saveDialog.RestoreDirectory = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                oKeyPathBox.Text = saveDialog.FileName;

                try
                {
                    string kPath = oKeyPathBox.Text;
                    this.randArray = File.ReadAllBytes(kPath);
                    kHEXTextBox.Text = StringHEX(this.randArray);
                    kLengthComboBox.Text = this.randArray.Length.ToString();
                }
                catch (Exception)
                {
                    this.randArray = new byte[0];
                    File.Create(oKeyPathBox.Text).Close();
                }
            }
        }

        private void generateKeyButton_Click(object sender, EventArgs e)
        {
            string kPath = oKeyPathBox.Text;
            DateTime stTime;
            DateTime finTime;
            TimeSpan allTime;
            totalTimeLabel.Text = "00:00.00";

            if (kPath == "")
            {
                MessageBox.Show("Невірний шлях до файлу ключа!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oKeyPathBox.Focus();
                return;
            }

            if (!File.Exists(kPath))
            {
                MessageBox.Show("Файл ключа не існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oKeyFileBtn.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            stTime = DateTime.Now;

            if (kRNGRadioButton.Checked)
            {
                this.randArray = KeyGen.GenerateKey(int.Parse(kLengthComboBox.Text));
            }
            if (kExtendRadioButton.Checked)
            {
                PasswordGen password = new PasswordGen(pTextBox.Text, kLengthComboBox.Text);
                this.randArray = password.Result;
            }

            File.WriteAllBytes(kPath, this.randArray);
            kHEXTextBox.Text = StringHEX(this.randArray);
            finTime = DateTime.Now;
            allTime = finTime - stTime;
            totalTimeLabel.Text = allTime.ToString(@"hh\:mm\:ss");

            this.Cursor = Cursors.Default;
            SystemSounds.Hand.Play();
        }

        private void kRNGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kRNGRadioButton.Checked)
            {
                generateKeyButton.ImageIndex = 0;
                eButton.ImageIndex = 0;
                pTextBox.ForeColor = Color.DarkGreen;
            }
        }

        private void kExtendRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (kExtendRadioButton.Checked)
            {
                generateKeyButton.ImageIndex = 1;
                eButton.ImageIndex = 1;
                pTextBox.ForeColor = Color.Black;
            }
        }

        private void kLengthComboBox_TextChanged(object sender, EventArgs e)
        {
            string st = kLengthComboBox.Text;
            if (st != "")
            {
                kLengthLabel.Text = Convert.ToString(Convert.ToInt32(st) * 8);
            }
        }

        private void kLengthComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void eHEXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (eHEXCheckBox.Checked) kHEXTextBox.ReadOnly = false;
            else
            {
                kHEXTextBox.ReadOnly = true;

                string kPath = oKeyPathBox.Text;

                if (kPath == "")
                {
                    MessageBox.Show("Неправильний шлях до файлу ключа!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eHEXCheckBox.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    oKeyPathBox.Focus();
                    return;
                }
                if (!File.Exists(kPath))
                {
                    MessageBox.Show("Файл ключа не існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eHEXCheckBox.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    oKeyFileBtn.Focus();
                    return;
                }

                this.randArray = StringToByteArr(kHEXTextBox.Text);

                File.WriteAllBytes(kPath, this.randArray);
            }
        }

        private void aLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Студентка\r\n Гелетко О. Я.\r\n РТФ\r\n Викладач\r\n Навроцький Д. О.", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kHEXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || c == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void oFileButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            openDialog.FilterIndex = 2;
            openDialog.RestoreDirectory = true;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string fPath = openDialog.FileName;
                this.fArray = File.ReadAllBytes(fPath);
                oFileLabel.Text = "Файл";
                oFileLabel.ForeColor = Color.Green;
                eLabel.Text = "(нема)";
                eLabel.ForeColor = Color.Red;
                sFileLabel.Text = "(нема)";
                sFileLabel.ForeColor = Color.Red;
                SystemSounds.Beep.Play();
            }
            this.Cursor = Cursors.Default;
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            int fLength = this.fArray.Length;
            if (fLength == 0)
            {
                MessageBox.Show("Щось не так з вашим файлом!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int keyLength = this.randArray.Length;
            if (keyLength == 0)
            {
                MessageBox.Show("Щось не так з вашим ключем!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            this.resArray = new byte[fLength];
            for (int i = 0; i < fLength; i++)
            {
                this.resArray[i] = (byte)(this.fArray[i] ^ this.randArray[i % keyLength]);
            }

            eLabel.Text = "Файл";
            eLabel.ForeColor = Color.Green;
            sFileLabel.Text = "(нема)";
            sFileLabel.ForeColor = Color.Red;
            SystemSounds.Beep.Play();
            this.Cursor = Cursors.Default;
        }

        private void sFileButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            saveDialog.CreatePrompt = true;
            saveDialog.OverwritePrompt = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string sPath = saveDialog.FileName;
                File.WriteAllBytes(sPath, this.resArray);

                if (this.resArray.Length == 0)
                {
                    MessageBox.Show("Щось не так з шифруванням!" + Environment.NewLine + "Файл був збережений, але\r\n його розмір: 0 байтів", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }

                sFileLabel.Text = "Файл";
                sFileLabel.ForeColor = Color.Green;
                SystemSounds.Beep.Play();
            }
            this.Cursor = Cursors.Default;
        }

        private void vPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vPassCheckBox.Checked)
            {
                pTextBox.PasswordChar = '\0';
            }
            else
            {
                pTextBox.PasswordChar = '*';
            }
        }
    }
}
