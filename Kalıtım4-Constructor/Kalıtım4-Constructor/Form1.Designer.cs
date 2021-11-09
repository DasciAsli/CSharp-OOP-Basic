
namespace Kalıtım4_Constructor
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
            this.btnDiziCons = new System.Windows.Forms.Button();
            this.btnListeCons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listListele
            // 
            this.listListele.FormattingEnabled = true;
            this.listListele.Location = new System.Drawing.Point(139, 53);
            this.listListele.Name = "listListele";
            this.listListele.Size = new System.Drawing.Size(161, 134);
            this.listListele.TabIndex = 0;
            // 
            // btnDiziCons
            // 
            this.btnDiziCons.Location = new System.Drawing.Point(56, 205);
            this.btnDiziCons.Name = "btnDiziCons";
            this.btnDiziCons.Size = new System.Drawing.Size(150, 51);
            this.btnDiziCons.TabIndex = 1;
            this.btnDiziCons.Text = "DiziParametreliConstructor";
            this.btnDiziCons.UseVisualStyleBackColor = true;
            this.btnDiziCons.Click += new System.EventHandler(this.btnDiziCons_Click);
            // 
            // btnListeCons
            // 
            this.btnListeCons.Location = new System.Drawing.Point(248, 205);
            this.btnListeCons.Name = "btnListeCons";
            this.btnListeCons.Size = new System.Drawing.Size(150, 51);
            this.btnListeCons.TabIndex = 2;
            this.btnListeCons.Text = "ListeParametreliConstructor";
            this.btnListeCons.UseVisualStyleBackColor = true;
            this.btnListeCons.Click += new System.EventHandler(this.btnListeCons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 290);
            this.Controls.Add(this.btnListeCons);
            this.Controls.Add(this.btnDiziCons);
            this.Controls.Add(this.listListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listListele;
        private System.Windows.Forms.Button btnDiziCons;
        private System.Windows.Forms.Button btnListeCons;
    }
}

