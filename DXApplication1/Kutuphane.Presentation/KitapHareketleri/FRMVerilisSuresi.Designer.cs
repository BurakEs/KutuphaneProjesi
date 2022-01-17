namespace Kutuphane.Presentation.KitapHareketleri
{
    partial class FRMVerilisSuresi
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
            this.lblSecimSorusu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtVerilisSüresi = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.Btniptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecimSorusu
            // 
            this.lblSecimSorusu.Location = new System.Drawing.Point(19, 9);
            this.lblSecimSorusu.Name = "lblSecimSorusu";
            this.lblSecimSorusu.Size = new System.Drawing.Size(263, 46);
            this.lblSecimSorusu.TabIndex = 0;
            this.lblSecimSorusu.Text = "label1";
            this.lblSecimSorusu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verilis Süresi Giriniz";
            // 
            // TxtVerilisSüresi
            // 
            this.TxtVerilisSüresi.Location = new System.Drawing.Point(152, 69);
            this.TxtVerilisSüresi.Name = "TxtVerilisSüresi";
            this.TxtVerilisSüresi.Size = new System.Drawing.Size(130, 21);
            this.TxtVerilisSüresi.TabIndex = 2;
            this.TxtVerilisSüresi.TextChanged += new System.EventHandler(this.TxtVerilisSüresi_TextChanged);
            this.TxtVerilisSüresi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVerilisSüresi_KeyPress);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnKaydet.Location = new System.Drawing.Point(66, 103);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // Btniptal
            // 
            this.Btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btniptal.Location = new System.Drawing.Point(152, 103);
            this.Btniptal.Name = "Btniptal";
            this.Btniptal.Size = new System.Drawing.Size(75, 23);
            this.Btniptal.TabIndex = 4;
            this.Btniptal.Text = "İPTAL";
            this.Btniptal.UseVisualStyleBackColor = true;
            // 
            // FRMVerilisSuresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 154);
            this.Controls.Add(this.Btniptal);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtVerilisSüresi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSecimSorusu);
            this.Name = "FRMVerilisSuresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Verme İşlemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button Btniptal;
        public System.Windows.Forms.Label lblSecimSorusu;
        public System.Windows.Forms.TextBox TxtVerilisSüresi;
    }
}