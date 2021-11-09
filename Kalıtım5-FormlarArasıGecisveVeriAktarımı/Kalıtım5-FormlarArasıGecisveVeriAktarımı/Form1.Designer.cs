
namespace Kalıtım5_FormlarArasıGecisveVeriAktarımı
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
            this.listListele = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGecis = new System.Windows.Forms.Button();
            this.btnGelen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listListele
            // 
            this.listListele.FormattingEnabled = true;
            this.listListele.Location = new System.Drawing.Point(77, 52);
            this.listListele.Name = "listListele";
            this.listListele.Size = new System.Drawing.Size(139, 121);
            this.listListele.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(89, 198);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(115, 29);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGecis
            // 
            this.btnGecis.Location = new System.Drawing.Point(89, 239);
            this.btnGecis.Name = "btnGecis";
            this.btnGecis.Size = new System.Drawing.Size(115, 29);
            this.btnGecis.TabIndex = 2;
            this.btnGecis.Text = "Form2 Aç";
            this.btnGecis.UseVisualStyleBackColor = true;
            this.btnGecis.Click += new System.EventHandler(this.btnGecis_Click);
            // 
            // btnGelen
            // 
            this.btnGelen.Location = new System.Drawing.Point(243, 79);
            this.btnGelen.Name = "btnGelen";
            this.btnGelen.Size = new System.Drawing.Size(115, 29);
            this.btnGelen.TabIndex = 3;
            this.btnGelen.Text = "Form2 Gelen Liste";
            this.btnGelen.UseVisualStyleBackColor = true;
            this.btnGelen.Click += new System.EventHandler(this.btnGelen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 280);
            this.Controls.Add(this.btnGelen);
            this.Controls.Add(this.btnGecis);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.listListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listListele;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGecis;
        private System.Windows.Forms.Button btnGelen;
    }
}

