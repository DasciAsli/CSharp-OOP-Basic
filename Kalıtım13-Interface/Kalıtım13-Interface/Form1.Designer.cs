
namespace Kalıtım13_Interface
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
            this.btnCagir = new System.Windows.Forms.Button();
            this.btnTel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCagir
            // 
            this.btnCagir.Location = new System.Drawing.Point(94, 38);
            this.btnCagir.Name = "btnCagir";
            this.btnCagir.Size = new System.Drawing.Size(139, 48);
            this.btnCagir.TabIndex = 0;
            this.btnCagir.Text = "Pc Getir";
            this.btnCagir.UseVisualStyleBackColor = true;
            this.btnCagir.Click += new System.EventHandler(this.btnCagir_Click);
            // 
            // btnTel
            // 
            this.btnTel.Location = new System.Drawing.Point(94, 120);
            this.btnTel.Name = "btnTel";
            this.btnTel.Size = new System.Drawing.Size(139, 48);
            this.btnTel.TabIndex = 1;
            this.btnTel.Text = "Telefon Getir";
            this.btnTel.UseVisualStyleBackColor = true;
            this.btnTel.Click += new System.EventHandler(this.btnTel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 222);
            this.Controls.Add(this.btnTel);
            this.Controls.Add(this.btnCagir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCagir;
        private System.Windows.Forms.Button btnTel;
    }
}

