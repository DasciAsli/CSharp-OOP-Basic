
namespace Kalıtım12_AbstractClass2
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
            this.listYüzüklerinEfendisi = new System.Windows.Forms.ListBox();
            this.btnYE = new System.Windows.Forms.Button();
            this.btnHp = new System.Windows.Forms.Button();
            this.listHarryPotter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listYüzüklerinEfendisi
            // 
            this.listYüzüklerinEfendisi.FormattingEnabled = true;
            this.listYüzüklerinEfendisi.Location = new System.Drawing.Point(30, 51);
            this.listYüzüklerinEfendisi.Name = "listYüzüklerinEfendisi";
            this.listYüzüklerinEfendisi.Size = new System.Drawing.Size(230, 147);
            this.listYüzüklerinEfendisi.TabIndex = 0;
            // 
            // btnYE
            // 
            this.btnYE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYE.Location = new System.Drawing.Point(30, 207);
            this.btnYE.Name = "btnYE";
            this.btnYE.Size = new System.Drawing.Size(230, 30);
            this.btnYE.TabIndex = 1;
            this.btnYE.Text = "Yüzüklerin Efendisi";
            this.btnYE.UseVisualStyleBackColor = true;
            this.btnYE.Click += new System.EventHandler(this.btnYE_Click);
            // 
            // btnHp
            // 
            this.btnHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHp.Location = new System.Drawing.Point(318, 207);
            this.btnHp.Name = "btnHp";
            this.btnHp.Size = new System.Drawing.Size(230, 30);
            this.btnHp.TabIndex = 3;
            this.btnHp.Text = "Harry Potter";
            this.btnHp.UseVisualStyleBackColor = true;
            this.btnHp.Click += new System.EventHandler(this.btnHp_Click);
            // 
            // listHarryPotter
            // 
            this.listHarryPotter.FormattingEnabled = true;
            this.listHarryPotter.Location = new System.Drawing.Point(318, 51);
            this.listHarryPotter.Name = "listHarryPotter";
            this.listHarryPotter.Size = new System.Drawing.Size(230, 147);
            this.listHarryPotter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 279);
            this.Controls.Add(this.btnHp);
            this.Controls.Add(this.listHarryPotter);
            this.Controls.Add(this.btnYE);
            this.Controls.Add(this.listYüzüklerinEfendisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listYüzüklerinEfendisi;
        private System.Windows.Forms.Button btnYE;
        private System.Windows.Forms.Button btnHp;
        private System.Windows.Forms.ListBox listHarryPotter;
    }
}

