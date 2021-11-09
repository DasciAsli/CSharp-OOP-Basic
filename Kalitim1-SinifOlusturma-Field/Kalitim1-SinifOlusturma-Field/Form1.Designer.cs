
namespace Kalitim1_SinifOlusturma_Field
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
            this.btnField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnField
            // 
            this.btnField.Location = new System.Drawing.Point(228, 104);
            this.btnField.Name = "btnField";
            this.btnField.Size = new System.Drawing.Size(150, 38);
            this.btnField.TabIndex = 0;
            this.btnField.Text = "Field İle Yazdır";
            this.btnField.UseVisualStyleBackColor = true;
            this.btnField.Click += new System.EventHandler(this.btnField_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 282);
            this.Controls.Add(this.btnField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnField;
    }
}

