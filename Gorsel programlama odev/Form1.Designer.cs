namespace Gorsel_programlama_odev
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSaga = new System.Windows.Forms.Button();
            this.btnSola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSecilenler = new System.Windows.Forms.ListBox();
            this.lstSehirler = new System.Windows.Forms.ListBox();
            this.txtIlAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(338, 56);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaga
            // 
            this.btnSaga.Location = new System.Drawing.Point(338, 99);
            this.btnSaga.Name = "btnSaga";
            this.btnSaga.Size = new System.Drawing.Size(75, 23);
            this.btnSaga.TabIndex = 0;
            this.btnSaga.Text = ">>";
            this.btnSaga.UseVisualStyleBackColor = true;
            this.btnSaga.Click += new System.EventHandler(this.btnSaga_Click);
            // 
            // btnSola
            // 
            this.btnSola.Location = new System.Drawing.Point(338, 171);
            this.btnSola.Name = "btnSola";
            this.btnSola.Size = new System.Drawing.Size(75, 23);
            this.btnSola.TabIndex = 0;
            this.btnSola.Text = "<<";
            this.btnSola.UseVisualStyleBackColor = true;
            this.btnSola.Click += new System.EventHandler(this.btnSola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İl Adı:";
            // 
            // lstSecilenler
            // 
            this.lstSecilenler.FormattingEnabled = true;
            this.lstSecilenler.Items.AddRange(new object[] {
            "İzmir",
            "Sivas",
            "İstanbul",
            "Erzurum"});
            this.lstSecilenler.Location = new System.Drawing.Point(430, 99);
            this.lstSecilenler.Name = "lstSecilenler";
            this.lstSecilenler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSecilenler.Size = new System.Drawing.Size(120, 95);
            this.lstSecilenler.TabIndex = 2;
            // 
            // lstSehirler
            // 
            this.lstSehirler.FormattingEnabled = true;
            this.lstSehirler.Items.AddRange(new object[] {
            "Tokat",
            "Sinop",
            "Samsun",
            "Ankara"});
            this.lstSehirler.Location = new System.Drawing.Point(197, 99);
            this.lstSehirler.Name = "lstSehirler";
            this.lstSehirler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSehirler.Size = new System.Drawing.Size(120, 95);
            this.lstSehirler.TabIndex = 2;
            // 
            // txtIlAdi
            // 
            this.txtIlAdi.Location = new System.Drawing.Point(197, 56);
            this.txtIlAdi.Name = "txtIlAdi";
            this.txtIlAdi.Size = new System.Drawing.Size(120, 20);
            this.txtIlAdi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIlAdi);
            this.Controls.Add(this.lstSehirler);
            this.Controls.Add(this.lstSecilenler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSola);
            this.Controls.Add(this.btnSaga);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSaga;
        private System.Windows.Forms.Button btnSola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSecilenler;
        private System.Windows.Forms.ListBox lstSehirler;
        private System.Windows.Forms.TextBox txtIlAdi;
    }
}

