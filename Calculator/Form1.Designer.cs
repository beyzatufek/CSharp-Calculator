namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEsit = new System.Windows.Forms.Button();
            this.buttonArtı = new System.Windows.Forms.Button();
            this.buttonEksi = new System.Windows.Forms.Button();
            this.buttonCarp = new System.Windows.Forms.Button();
            this.buttonBol = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.labelEkran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEsit
            // 
            this.buttonEsit.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonEsit.Location = new System.Drawing.Point(195, 388);
            this.buttonEsit.Name = "buttonEsit";
            this.buttonEsit.Size = new System.Drawing.Size(73, 59);
            this.buttonEsit.TabIndex = 35;
            this.buttonEsit.Text = "=";
            this.buttonEsit.UseVisualStyleBackColor = false;
            this.buttonEsit.Click += new System.EventHandler(this.buttonEsit_Click);
            // 
            // buttonArtı
            // 
            this.buttonArtı.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonArtı.Location = new System.Drawing.Point(305, 388);
            this.buttonArtı.Name = "buttonArtı";
            this.buttonArtı.Size = new System.Drawing.Size(85, 59);
            this.buttonArtı.TabIndex = 34;
            this.buttonArtı.Text = "+";
            this.buttonArtı.UseVisualStyleBackColor = false;
            this.buttonArtı.Click += new System.EventHandler(this.buttonArtı_Click);
            // 
            // buttonEksi
            // 
            this.buttonEksi.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonEksi.Location = new System.Drawing.Point(305, 323);
            this.buttonEksi.Name = "buttonEksi";
            this.buttonEksi.Size = new System.Drawing.Size(85, 59);
            this.buttonEksi.TabIndex = 33;
            this.buttonEksi.Text = "-";
            this.buttonEksi.UseVisualStyleBackColor = false;
            this.buttonEksi.Click += new System.EventHandler(this.buttonEksi_Click);
            // 
            // buttonCarp
            // 
            this.buttonCarp.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCarp.Location = new System.Drawing.Point(305, 258);
            this.buttonCarp.Name = "buttonCarp";
            this.buttonCarp.Size = new System.Drawing.Size(85, 59);
            this.buttonCarp.TabIndex = 32;
            this.buttonCarp.Text = "x";
            this.buttonCarp.UseVisualStyleBackColor = false;
            this.buttonCarp.Click += new System.EventHandler(this.buttonCarp_Click);
            // 
            // buttonBol
            // 
            this.buttonBol.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBol.Location = new System.Drawing.Point(305, 193);
            this.buttonBol.Name = "buttonBol";
            this.buttonBol.Size = new System.Drawing.Size(85, 59);
            this.buttonBol.TabIndex = 31;
            this.buttonBol.Text = "/";
            this.buttonBol.UseVisualStyleBackColor = false;
            this.buttonBol.Click += new System.EventHandler(this.buttonBol_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(37, 388);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(73, 59);
            this.buttonClear.TabIndex = 30;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Silver;
            this.button0.Location = new System.Drawing.Point(116, 388);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(73, 59);
            this.button0.TabIndex = 29;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(37, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 59);
            this.button1.TabIndex = 28;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(116, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 59);
            this.button2.TabIndex = 27;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(195, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 59);
            this.button3.TabIndex = 26;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(37, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 59);
            this.button4.TabIndex = 25;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(116, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 59);
            this.button5.TabIndex = 24;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(195, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 59);
            this.button6.TabIndex = 23;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(116, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 59);
            this.button8.TabIndex = 22;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Location = new System.Drawing.Point(195, 193);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 59);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(37, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 59);
            this.button7.TabIndex = 20;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // labelEkran
            // 
            this.labelEkran.BackColor = System.Drawing.Color.White;
            this.labelEkran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEkran.Location = new System.Drawing.Point(27, 44);
            this.labelEkran.Name = "labelEkran";
            this.labelEkran.Size = new System.Drawing.Size(370, 70);
            this.labelEkran.TabIndex = 19;
            this.labelEkran.Text = "0";
            this.labelEkran.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 500);
            this.Controls.Add(this.buttonEsit);
            this.Controls.Add(this.buttonArtı);
            this.Controls.Add(this.buttonEksi);
            this.Controls.Add(this.buttonCarp);
            this.Controls.Add(this.buttonBol);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.labelEkran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEsit;
        private System.Windows.Forms.Button buttonArtı;
        private System.Windows.Forms.Button buttonEksi;
        private System.Windows.Forms.Button buttonCarp;
        private System.Windows.Forms.Button buttonBol;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelEkran;
    }
}

