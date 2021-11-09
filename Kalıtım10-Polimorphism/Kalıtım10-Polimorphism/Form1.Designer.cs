
namespace Kalıtım10_Polimorphism
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
            this.btnPoly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPoly
            // 
            this.btnPoly.Location = new System.Drawing.Point(114, 77);
            this.btnPoly.Name = "btnPoly";
            this.btnPoly.Size = new System.Drawing.Size(102, 40);
            this.btnPoly.TabIndex = 0;
            this.btnPoly.Text = "Polimorphsim";
            this.btnPoly.UseVisualStyleBackColor = true;
            this.btnPoly.Click += new System.EventHandler(this.btnPoly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 218);
            this.Controls.Add(this.btnPoly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPoly;
    }
}

