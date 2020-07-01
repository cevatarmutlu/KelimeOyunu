namespace KelimeOyunu
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
            this.labelSoru = new System.Windows.Forms.Label();
            this.richTextBoxSoru = new System.Windows.Forms.RichTextBox();
            this.labelCevap = new System.Windows.Forms.Label();
            this.buttonHarfAl = new System.Windows.Forms.Button();
            this.labelCevapYaz = new System.Windows.Forms.Label();
            this.textBoxCevapGir = new System.Windows.Forms.TextBox();
            this.buttonCevapGir = new System.Windows.Forms.Button();
            this.labelKasa = new System.Windows.Forms.Label();
            this.labelKasaDeger = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSoru
            // 
            this.labelSoru.AutoSize = true;
            this.labelSoru.Location = new System.Drawing.Point(123, 69);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(38, 13);
            this.labelSoru.TabIndex = 0;
            this.labelSoru.Text = "SORU";
            // 
            // richTextBoxSoru
            // 
            this.richTextBoxSoru.Location = new System.Drawing.Point(210, 34);
            this.richTextBoxSoru.Name = "richTextBoxSoru";
            this.richTextBoxSoru.Size = new System.Drawing.Size(302, 94);
            this.richTextBoxSoru.TabIndex = 1;
            this.richTextBoxSoru.Text = "";
            // 
            // labelCevap
            // 
            this.labelCevap.AutoSize = true;
            this.labelCevap.Location = new System.Drawing.Point(123, 177);
            this.labelCevap.Name = "labelCevap";
            this.labelCevap.Size = new System.Drawing.Size(42, 13);
            this.labelCevap.TabIndex = 0;
            this.labelCevap.Text = "CEVAP";
            // 
            // buttonHarfAl
            // 
            this.buttonHarfAl.Location = new System.Drawing.Point(298, 229);
            this.buttonHarfAl.Name = "buttonHarfAl";
            this.buttonHarfAl.Size = new System.Drawing.Size(75, 23);
            this.buttonHarfAl.TabIndex = 2;
            this.buttonHarfAl.Text = "Harf Al";
            this.buttonHarfAl.UseVisualStyleBackColor = true;
            this.buttonHarfAl.Click += new System.EventHandler(this.buttonHarfAl_Click);
            // 
            // labelCevapYaz
            // 
            this.labelCevapYaz.AutoSize = true;
            this.labelCevapYaz.Location = new System.Drawing.Point(123, 308);
            this.labelCevapYaz.Name = "labelCevapYaz";
            this.labelCevapYaz.Size = new System.Drawing.Size(66, 13);
            this.labelCevapYaz.TabIndex = 3;
            this.labelCevapYaz.Text = "CEVAP YAZ";
            // 
            // textBoxCevapGir
            // 
            this.textBoxCevapGir.Location = new System.Drawing.Point(210, 305);
            this.textBoxCevapGir.Name = "textBoxCevapGir";
            this.textBoxCevapGir.Size = new System.Drawing.Size(302, 20);
            this.textBoxCevapGir.TabIndex = 4;
            // 
            // buttonCevapGir
            // 
            this.buttonCevapGir.Location = new System.Drawing.Point(586, 303);
            this.buttonCevapGir.Name = "buttonCevapGir";
            this.buttonCevapGir.Size = new System.Drawing.Size(75, 23);
            this.buttonCevapGir.TabIndex = 5;
            this.buttonCevapGir.Text = "CEVAP GİR";
            this.buttonCevapGir.UseVisualStyleBackColor = true;
            this.buttonCevapGir.Click += new System.EventHandler(this.buttonCevapGir_Click);
            // 
            // labelKasa
            // 
            this.labelKasa.AutoSize = true;
            this.labelKasa.Location = new System.Drawing.Point(634, 68);
            this.labelKasa.Name = "labelKasa";
            this.labelKasa.Size = new System.Drawing.Size(35, 13);
            this.labelKasa.TabIndex = 6;
            this.labelKasa.Text = "KASA";
            // 
            // labelKasaDeger
            // 
            this.labelKasaDeger.AutoSize = true;
            this.labelKasaDeger.Location = new System.Drawing.Point(704, 68);
            this.labelKasaDeger.Name = "labelKasaDeger";
            this.labelKasaDeger.Size = new System.Drawing.Size(0, 13);
            this.labelKasaDeger.TabIndex = 6;
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.Location = new System.Drawing.Point(531, 67);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(0, 13);
            this.labelPuan.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 501);
            this.Controls.Add(this.labelPuan);
            this.Controls.Add(this.labelKasaDeger);
            this.Controls.Add(this.labelKasa);
            this.Controls.Add(this.buttonCevapGir);
            this.Controls.Add(this.textBoxCevapGir);
            this.Controls.Add(this.labelCevapYaz);
            this.Controls.Add(this.buttonHarfAl);
            this.Controls.Add(this.richTextBoxSoru);
            this.Controls.Add(this.labelCevap);
            this.Controls.Add(this.labelSoru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.RichTextBox richTextBoxSoru;
        private System.Windows.Forms.Label labelCevap;
        private System.Windows.Forms.Button buttonHarfAl;
        private System.Windows.Forms.Label labelCevapYaz;
        private System.Windows.Forms.TextBox textBoxCevapGir;
        private System.Windows.Forms.Button buttonCevapGir;
        private System.Windows.Forms.Label labelKasa;
        private System.Windows.Forms.Label labelKasaDeger;
        private System.Windows.Forms.Label labelPuan;
    }
}

