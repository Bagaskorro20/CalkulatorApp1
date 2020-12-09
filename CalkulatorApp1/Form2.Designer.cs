namespace CalkulatorApp1
{
    partial class Form2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.Operasi = new System.Windows.Forms.Label();
            this.NilaiA = new System.Windows.Forms.Label();
            this.NilaiB = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(101, 74);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(203, 22);
            this.txtNilaiA.TabIndex = 1;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(101, 119);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(203, 22);
            this.txtNilaiB.TabIndex = 2;
            // 
            // Operasi
            // 
            this.Operasi.AutoSize = true;
            this.Operasi.Location = new System.Drawing.Point(16, 31);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(58, 17);
            this.Operasi.TabIndex = 3;
            this.Operasi.Text = "Operasi";
            // 
            // NilaiA
            // 
            this.NilaiA.AutoSize = true;
            this.NilaiA.Location = new System.Drawing.Point(16, 77);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(48, 17);
            this.NilaiA.TabIndex = 4;
            this.NilaiA.Text = "Nilai A";
            // 
            // NilaiB
            // 
            this.NilaiB.AutoSize = true;
            this.NilaiB.Location = new System.Drawing.Point(16, 122);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(48, 17);
            this.NilaiB.TabIndex = 5;
            this.NilaiB.Text = "Nilai B";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(205, 162);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(99, 32);
            this.btnProses.TabIndex = 6;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 246);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.Operasi);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Label Operasi;
        private System.Windows.Forms.Label NilaiA;
        private System.Windows.Forms.Label NilaiB;
        private System.Windows.Forms.Button btnProses;
    }
}