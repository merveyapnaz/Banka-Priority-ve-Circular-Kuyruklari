namespace Banka
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
            this.txbOncelikli = new System.Windows.Forms.TextBox();
            this.btBKSure = new System.Windows.Forms.Button();
            this.btKarsilastirKB = new System.Windows.Forms.Button();
            this.btKBSure = new System.Windows.Forms.Button();
            this.lbOncelikli = new System.Windows.Forms.Label();
            this.txbDairesel = new System.Windows.Forms.TextBox();
            this.lblDairesel = new System.Windows.Forms.Label();
            this.btDaireselIslemTamamlanma = new System.Windows.Forms.Button();
            this.lblIsaret = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btKarsilastirBK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbOncelikli
            // 
            this.txbOncelikli.Enabled = false;
            this.txbOncelikli.Location = new System.Drawing.Point(372, 83);
            this.txbOncelikli.Multiline = true;
            this.txbOncelikli.Name = "txbOncelikli";
            this.txbOncelikli.Size = new System.Drawing.Size(413, 393);
            this.txbOncelikli.TabIndex = 17;
            // 
            // btBKSure
            // 
            this.btBKSure.Location = new System.Drawing.Point(372, 53);
            this.btBKSure.Name = "btBKSure";
            this.btBKSure.Size = new System.Drawing.Size(269, 23);
            this.btBKSure.TabIndex = 16;
            this.btBKSure.Text = "Büyükten Küçüğe İşlem Tamamlanma Süreleri Listesi";
            this.btBKSure.UseVisualStyleBackColor = true;
            this.btBKSure.Click += new System.EventHandler(this.btBKSure_Click);
            // 
            // btKarsilastirKB
            // 
            this.btKarsilastirKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKarsilastirKB.Location = new System.Drawing.Point(671, 23);
            this.btKarsilastirKB.Name = "btKarsilastirKB";
            this.btKarsilastirKB.Size = new System.Drawing.Size(128, 25);
            this.btKarsilastirKB.TabIndex = 15;
            this.btKarsilastirKB.Text = "Kısalan Süreler! (K->B)";
            this.btKarsilastirKB.UseVisualStyleBackColor = true;
            this.btKarsilastirKB.Click += new System.EventHandler(this.btKarsilastir_Click);
            // 
            // btKBSure
            // 
            this.btKBSure.Location = new System.Drawing.Point(372, 24);
            this.btKBSure.Name = "btKBSure";
            this.btKBSure.Size = new System.Drawing.Size(269, 23);
            this.btKBSure.TabIndex = 14;
            this.btKBSure.Text = "Küçükten Büyüğe İşlem Tamamlanma Süreleri Listesi";
            this.btKBSure.UseVisualStyleBackColor = true;
            this.btKBSure.Click += new System.EventHandler(this.btKBSure_Click);
            // 
            // lbOncelikli
            // 
            this.lbOncelikli.AutoSize = true;
            this.lbOncelikli.Location = new System.Drawing.Point(503, 8);
            this.lbOncelikli.Name = "lbOncelikli";
            this.lbOncelikli.Size = new System.Drawing.Size(83, 13);
            this.lbOncelikli.TabIndex = 13;
            this.lbOncelikli.Text = "Öncelikli Kuyruk";
            // 
            // txbDairesel
            // 
            this.txbDairesel.Enabled = false;
            this.txbDairesel.Location = new System.Drawing.Point(6, 53);
            this.txbDairesel.Multiline = true;
            this.txbDairesel.Name = "txbDairesel";
            this.txbDairesel.Size = new System.Drawing.Size(328, 422);
            this.txbDairesel.TabIndex = 12;
            // 
            // lblDairesel
            // 
            this.lblDairesel.AutoSize = true;
            this.lblDairesel.Location = new System.Drawing.Point(123, 8);
            this.lblDairesel.Name = "lblDairesel";
            this.lblDairesel.Size = new System.Drawing.Size(81, 13);
            this.lblDairesel.TabIndex = 11;
            this.lblDairesel.Text = "Dairesel Kuyruk";
            // 
            // btDaireselIslemTamamlanma
            // 
            this.btDaireselIslemTamamlanma.Location = new System.Drawing.Point(6, 24);
            this.btDaireselIslemTamamlanma.Name = "btDaireselIslemTamamlanma";
            this.btDaireselIslemTamamlanma.Size = new System.Drawing.Size(328, 23);
            this.btDaireselIslemTamamlanma.TabIndex = 10;
            this.btDaireselIslemTamamlanma.Text = "İşlem Tamamlanma Süreleri Listesi";
            this.btDaireselIslemTamamlanma.UseVisualStyleBackColor = true;
            this.btDaireselIslemTamamlanma.Click += new System.EventHandler(this.btDaireselIslemTamamlanma_Click);
            // 
            // lblIsaret
            // 
            this.lblIsaret.AutoSize = true;
            this.lblIsaret.Location = new System.Drawing.Point(643, 29);
            this.lblIsaret.Name = "lblIsaret";
            this.lblIsaret.Size = new System.Drawing.Size(22, 13);
            this.lblIsaret.TabIndex = 18;
            this.lblIsaret.Text = "--->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "--->";
            // 
            // btKarsilastirBK
            // 
            this.btKarsilastirBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKarsilastirBK.Location = new System.Drawing.Point(671, 52);
            this.btKarsilastirBK.Name = "btKarsilastirBK";
            this.btKarsilastirBK.Size = new System.Drawing.Size(128, 25);
            this.btKarsilastirBK.TabIndex = 20;
            this.btKarsilastirBK.Text = "Kısalan Süreler! (B->K)";
            this.btKarsilastirBK.UseVisualStyleBackColor = true;
            this.btKarsilastirBK.Click += new System.EventHandler(this.btKarsilastirBK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 536);
            this.Controls.Add(this.btKarsilastirBK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIsaret);
            this.Controls.Add(this.txbOncelikli);
            this.Controls.Add(this.btBKSure);
            this.Controls.Add(this.btKarsilastirKB);
            this.Controls.Add(this.btKBSure);
            this.Controls.Add(this.lbOncelikli);
            this.Controls.Add(this.txbDairesel);
            this.Controls.Add(this.lblDairesel);
            this.Controls.Add(this.btDaireselIslemTamamlanma);
            this.Name = "Form1";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOncelikli;
        private System.Windows.Forms.Button btBKSure;
        private System.Windows.Forms.Button btKarsilastirKB;
        private System.Windows.Forms.Button btKBSure;
        private System.Windows.Forms.Label lbOncelikli;
        private System.Windows.Forms.TextBox txbDairesel;
        private System.Windows.Forms.Label lblDairesel;
        private System.Windows.Forms.Button btDaireselIslemTamamlanma;
        private System.Windows.Forms.Label lblIsaret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btKarsilastirBK;
    }
}

