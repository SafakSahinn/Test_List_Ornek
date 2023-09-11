
namespace Test_List_Ornek
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
            this.BtnListele1 = new System.Windows.Forms.Button();
            this.BtnListele2 = new System.Windows.Forms.Button();
            this.BtnListele3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnListele1
            // 
            this.BtnListele1.Location = new System.Drawing.Point(12, 385);
            this.BtnListele1.Name = "BtnListele1";
            this.BtnListele1.Size = new System.Drawing.Size(232, 51);
            this.BtnListele1.TabIndex = 0;
            this.BtnListele1.Text = "LİSTELE1";
            this.BtnListele1.UseVisualStyleBackColor = true;
            this.BtnListele1.Click += new System.EventHandler(this.BtnListele1_Click);
            // 
            // BtnListele2
            // 
            this.BtnListele2.Location = new System.Drawing.Point(291, 385);
            this.BtnListele2.Name = "BtnListele2";
            this.BtnListele2.Size = new System.Drawing.Size(232, 51);
            this.BtnListele2.TabIndex = 1;
            this.BtnListele2.Text = "LİSTELE3";
            this.BtnListele2.UseVisualStyleBackColor = true;
            this.BtnListele2.Click += new System.EventHandler(this.BtnListele2_Click);
            // 
            // BtnListele3
            // 
            this.BtnListele3.Location = new System.Drawing.Point(566, 385);
            this.BtnListele3.Name = "BtnListele3";
            this.BtnListele3.Size = new System.Drawing.Size(232, 51);
            this.BtnListele3.TabIndex = 2;
            this.BtnListele3.Text = "LİSTELE2";
            this.BtnListele3.UseVisualStyleBackColor = true;
            this.BtnListele3.Click += new System.EventHandler(this.BtnListele3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 364);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(291, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(232, 364);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(566, 15);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(232, 364);
            this.listBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 448);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnListele3);
            this.Controls.Add(this.BtnListele2);
            this.Controls.Add(this.BtnListele1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnListele1;
        private System.Windows.Forms.Button BtnListele2;
        private System.Windows.Forms.Button BtnListele3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

