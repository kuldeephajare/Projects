using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowsePublic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                textBoxPublic.Text = openFileDialog.FileName;
            }

            textBoxInput.Enabled = textBoxPublic.Text.Length > 0 && textBoxPriv.Text.Length > 0;
        }

        private void buttonBrowsePrivate_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PEM files(*.PEM) | *.PEM";
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                textBoxPriv.Text = openFileDialog.FileName;
            }

            textBoxInput.Enabled = textBoxPublic.Text.Length > 0 && textBoxPriv.Text.Length > 0;
        }

        private void textBoxInput_TextChanged_1(object sender, EventArgs e)
        {
            buttonEncrypt.Enabled = textBoxInput.Text.Length > 0 && textBoxPublic.Text.Length > 0;
            buttonDecrypt.Enabled = textBoxInput.Text.Length > 0 && textBoxPriv.Text.Length > 0;
        }

        private void buttonEncrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput.Text = Cryptography.EncryptWithPublicKey(textBoxPublic.Text, textBoxInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDecrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput.Text = Cryptography.DecryptWithPrivateKey(textBoxPriv.Text, textBoxOutput.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCopyToInput_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxOutput.Text;
        }
    }
}
