
namespace EncryptDecrypt
{
    partial class Form1
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
            this.textBoxPublic = new System.Windows.Forms.TextBox();
            this.buttonBrowsePublic = new System.Windows.Forms.Button();
            this.labelPublic = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrivate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowsePrivate = new System.Windows.Forms.Button();
            this.textBoxPriv = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCopyToInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPublic
            // 
            this.textBoxPublic.Enabled = false;
            this.textBoxPublic.Location = new System.Drawing.Point(24, 42);
            this.textBoxPublic.Name = "textBoxPublic";
            this.textBoxPublic.Size = new System.Drawing.Size(891, 27);
            this.textBoxPublic.TabIndex = 0;
            // 
            // buttonBrowsePublic
            // 
            this.buttonBrowsePublic.Location = new System.Drawing.Point(921, 40);
            this.buttonBrowsePublic.Name = "buttonBrowsePublic";
            this.buttonBrowsePublic.Size = new System.Drawing.Size(94, 29);
            this.buttonBrowsePublic.TabIndex = 1;
            this.buttonBrowsePublic.Text = "Browse...";
            this.buttonBrowsePublic.UseVisualStyleBackColor = true;
            this.buttonBrowsePublic.Click += new System.EventHandler(this.buttonBrowsePublic_Click_1);
            // 
            // labelPublic
            // 
            this.labelPublic.AutoSize = true;
            this.labelPublic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPublic.Location = new System.Drawing.Point(24, 19);
            this.labelPublic.Name = "labelPublic";
            this.labelPublic.Size = new System.Drawing.Size(212, 20);
            this.labelPublic.TabIndex = 2;
            this.labelPublic.Text = "Select the public key PEM file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1869, 803);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPrivate
            // 
            this.textBoxPrivate.Enabled = false;
            this.textBoxPrivate.Location = new System.Drawing.Point(972, 805);
            this.textBoxPrivate.Name = "textBoxPrivate";
            this.textBoxPrivate.Size = new System.Drawing.Size(891, 27);
            this.textBoxPrivate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select the private key PEM file";
            // 
            // buttonBrowsePrivate
            // 
            this.buttonBrowsePrivate.Location = new System.Drawing.Point(921, 135);
            this.buttonBrowsePrivate.Name = "buttonBrowsePrivate";
            this.buttonBrowsePrivate.Size = new System.Drawing.Size(94, 29);
            this.buttonBrowsePrivate.TabIndex = 6;
            this.buttonBrowsePrivate.Text = "Browse...";
            this.buttonBrowsePrivate.UseVisualStyleBackColor = true;
            this.buttonBrowsePrivate.Click += new System.EventHandler(this.buttonBrowsePrivate_Click_1);
            // 
            // textBoxPriv
            // 
            this.textBoxPriv.Enabled = false;
            this.textBoxPriv.Location = new System.Drawing.Point(24, 137);
            this.textBoxPriv.Name = "textBoxPriv";
            this.textBoxPriv.Size = new System.Drawing.Size(891, 27);
            this.textBoxPriv.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(956, 492);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(24, 237);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(401, 206);
            this.textBoxInput.TabIndex = 9;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged_1);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(614, 237);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(401, 206);
            this.textBoxOutput.TabIndex = 10;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(469, 285);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(94, 29);
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click_1);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(469, 368);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(94, 29);
            this.buttonDecrypt.TabIndex = 12;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input string";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(614, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Output string";
            // 
            // buttonCopyToInput
            // 
            this.buttonCopyToInput.Location = new System.Drawing.Point(724, 205);
            this.buttonCopyToInput.Name = "buttonCopyToInput";
            this.buttonCopyToInput.Size = new System.Drawing.Size(108, 29);
            this.buttonCopyToInput.TabIndex = 15;
            this.buttonCopyToInput.Text = "Copy to input";
            this.buttonCopyToInput.UseVisualStyleBackColor = true;
            this.buttonCopyToInput.Click += new System.EventHandler(this.buttonCopyToInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 533);
            this.Controls.Add(this.buttonCopyToInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowsePrivate);
            this.Controls.Add(this.textBoxPriv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPrivate);
            this.Controls.Add(this.labelPublic);
            this.Controls.Add(this.buttonBrowsePublic);
            this.Controls.Add(this.textBoxPublic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Everything Embedded - Asymmetric Encryption/Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPublic;
        private System.Windows.Forms.Button buttonBrowsePublic;
        private System.Windows.Forms.Label labelPublic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowsePrivate;
        private System.Windows.Forms.TextBox textBoxPriv;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCopyToInput;
    }
}

