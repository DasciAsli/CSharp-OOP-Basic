
namespace Kalıtım6_Inheritence2
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
            this.btnKadın = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listListele
            // 
            this.listListele.FormattingEnabled = true;
            this.listListele.Location = new System.Drawing.Point(129, 51);
            this.listListele.Name = "listListele";
            this.listListele.Size = new System.Drawing.Size(145, 121);
            this.listListele.TabIndex = 0;
            // 
            // btnKadın
            // 
            this.btnKadın.Location = new System.Drawing.Point(170, 193);
            this.btnKadın.Name = "btnKadın";
            this.btnKadın.Size = new System.Drawing.Size(75, 23);
            this.btnKadın.TabIndex = 1;
            this.btnKadın.Text = "Kadın";
            this.btnKadın.UseVisualStyleBackColor = true;
            this.btnKadın.Click += new System.EventHandler(this.btnKadın_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 258);
            this.Controls.Add(this.btnKadın);
            this.Controls.Add(this.listListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listListele;
        private System.Windows.Forms.Button btnKadın;
    }
}

