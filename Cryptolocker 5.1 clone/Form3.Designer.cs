namespace Cryptolocker_5._1_clone
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chiave_pubblica = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chiave_privata = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chiave_pubblica);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chiave Pubblica  :";
            // 
            // chiave_pubblica
            // 
            this.chiave_pubblica.BackColor = System.Drawing.SystemColors.Window;
            this.chiave_pubblica.Location = new System.Drawing.Point(6, 19);
            this.chiave_pubblica.Name = "chiave_pubblica";
            this.chiave_pubblica.ReadOnly = true;
            this.chiave_pubblica.Size = new System.Drawing.Size(805, 134);
            this.chiave_pubblica.TabIndex = 0;
            this.chiave_pubblica.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chiave_privata);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chiave Privata  :";
            // 
            // chiave_privata
            // 
            this.chiave_privata.BackColor = System.Drawing.SystemColors.Window;
            this.chiave_privata.Location = new System.Drawing.Point(6, 19);
            this.chiave_privata.Name = "chiave_privata";
            this.chiave_privata.ReadOnly = true;
            this.chiave_privata.Size = new System.Drawing.Size(805, 134);
            this.chiave_privata.TabIndex = 0;
            this.chiave_privata.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRV-Key Password / Passphrase:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sblocca i file";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(841, 396);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Sblocca tutti i file .locked :";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}