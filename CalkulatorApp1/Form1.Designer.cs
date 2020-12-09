namespace CalkulatorApp1
{
    partial class Form1
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
            this.Hasil = new System.Windows.Forms.GroupBox();
            this.Hasile = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.Hasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hasil
            // 
            this.Hasil.Controls.Add(this.Hasile);
            this.Hasil.Controls.Add(this.btnHitung);
            this.Hasil.Location = new System.Drawing.Point(12, 12);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(493, 393);
            this.Hasil.TabIndex = 0;
            this.Hasil.TabStop = false;
            this.Hasil.Text = "[ Hasil ]";
            // 
            // Hasile
            // 
            this.Hasile.FormattingEnabled = true;
            this.Hasile.ItemHeight = 16;
            this.Hasile.Location = new System.Drawing.Point(7, 32);
            this.Hasile.Name = "Hasile";
            this.Hasile.Size = new System.Drawing.Size(461, 292);
            this.Hasile.TabIndex = 2;
            this.Hasile.SelectedIndexChanged += new System.EventHandler(this.Hasile_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(364, 343);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(104, 32);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.Hasil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Hasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Hasil;
        private System.Windows.Forms.ListBox Hasile;
        private System.Windows.Forms.Button btnHitung;
    }
}