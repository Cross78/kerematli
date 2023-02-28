
namespace WindowsFormsApp1
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
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_ArayaEkle = new System.Windows.Forms.Button();
            this.List_Sehirler = new System.Windows.Forms.ListBox();
            this.Txt_SehirEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Eklendi = new System.Windows.Forms.Label();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Arama = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_İndexSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Ekle.Location = new System.Drawing.Point(12, 73);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ekle.TabIndex = 0;
            this.Btn_Ekle.Text = "EKLE";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_ArayaEkle
            // 
            this.Btn_ArayaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ArayaEkle.Location = new System.Drawing.Point(93, 73);
            this.Btn_ArayaEkle.Name = "Btn_ArayaEkle";
            this.Btn_ArayaEkle.Size = new System.Drawing.Size(107, 23);
            this.Btn_ArayaEkle.TabIndex = 1;
            this.Btn_ArayaEkle.Text = "ARAYA EKLE";
            this.Btn_ArayaEkle.UseVisualStyleBackColor = true;
            this.Btn_ArayaEkle.Click += new System.EventHandler(this.Btn_ArayaEkle_Click);
            // 
            // List_Sehirler
            // 
            this.List_Sehirler.FormattingEnabled = true;
            this.List_Sehirler.Location = new System.Drawing.Point(542, 12);
            this.List_Sehirler.Name = "List_Sehirler";
            this.List_Sehirler.Size = new System.Drawing.Size(195, 290);
            this.List_Sehirler.TabIndex = 5;
            // 
            // Txt_SehirEkle
            // 
            this.Txt_SehirEkle.Location = new System.Drawing.Point(143, 32);
            this.Txt_SehirEkle.Name = "Txt_SehirEkle";
            this.Txt_SehirEkle.Size = new System.Drawing.Size(100, 20);
            this.Txt_SehirEkle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şehir Adi =";
            // 
            // Lbl_Eklendi
            // 
            this.Lbl_Eklendi.AutoSize = true;
            this.Lbl_Eklendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Eklendi.Location = new System.Drawing.Point(39, 138);
            this.Lbl_Eklendi.Name = "Lbl_Eklendi";
            this.Lbl_Eklendi.Size = new System.Drawing.Size(20, 18);
            this.Lbl_Eklendi.TabIndex = 8;
            this.Lbl_Eklendi.Text = "...";
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(206, 73);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guncelle.TabIndex = 9;
            this.Btn_Guncelle.Text = "GÜNCELLE";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Arama
            // 
            this.Btn_Arama.Location = new System.Drawing.Point(449, 73);
            this.Btn_Arama.Name = "Btn_Arama";
            this.Btn_Arama.Size = new System.Drawing.Size(75, 23);
            this.Btn_Arama.TabIndex = 10;
            this.Btn_Arama.Text = "ARAMA";
            this.Btn_Arama.UseVisualStyleBackColor = true;
            this.Btn_Arama.Click += new System.EventHandler(this.Btn_Arama_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(287, 73);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sil.TabIndex = 11;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_İndexSil
            // 
            this.Btn_İndexSil.Location = new System.Drawing.Point(368, 73);
            this.Btn_İndexSil.Name = "Btn_İndexSil";
            this.Btn_İndexSil.Size = new System.Drawing.Size(75, 23);
            this.Btn_İndexSil.TabIndex = 12;
            this.Btn_İndexSil.Text = "İNDEX SİL";
            this.Btn_İndexSil.UseVisualStyleBackColor = true;
            this.Btn_İndexSil.Click += new System.EventHandler(this.Btn_İndexSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_İndexSil);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Arama);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Lbl_Eklendi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_SehirEkle);
            this.Controls.Add(this.List_Sehirler);
            this.Controls.Add(this.Btn_ArayaEkle);
            this.Controls.Add(this.Btn_Ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_ArayaEkle;
        private System.Windows.Forms.ListBox List_Sehirler;
        private System.Windows.Forms.TextBox Txt_SehirEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Eklendi;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Arama;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_İndexSil;
    }
}

