namespace Kutuphane.Presentation.Kitaplar
{
    partial class FRMKitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMKitapEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnYazarEkle = new DevExpress.XtraEditors.SimpleButton();
            this.CmbTurAdi = new System.Windows.Forms.ComboBox();
            this.CmbYazarAdi = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TglSwDurum = new DevExpress.XtraEditors.ToggleSwitch();
            this.TxtSayfaSayisi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBasimYeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKitapadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAciklama = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TglSwDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSayfaSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBasimYeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKitapadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(451, 38);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kitap Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnKapat);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 361);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(451, 75);
            this.groupControl1.TabIndex = 2;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Location = new System.Drawing.Point(337, 23);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(109, 40);
            this.BtnKapat.TabIndex = 2;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(219, 23);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(109, 40);
            this.BtnKaydet.TabIndex = 0;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.BtnYazarEkle);
            this.groupControl2.Controls.Add(this.CmbTurAdi);
            this.groupControl2.Controls.Add(this.CmbYazarAdi);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.TglSwDurum);
            this.groupControl2.Controls.Add(this.TxtSayfaSayisi);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.TxtBasimYeri);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.TxtKitapadi);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.TxtAciklama);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 38);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(451, 323);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Genel Bilgiler";
            // 
            // simpleButton4
            // 
            this.simpleButton4.BackgroundImage = global::Kutuphane.Presentation.Properties.Resources.add_32x32;
            this.simpleButton4.Location = new System.Drawing.Point(329, 80);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(82, 21);
            this.simpleButton4.TabIndex = 19;
            this.simpleButton4.Text = "Tur Ekle";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // BtnYazarEkle
            // 
            this.BtnYazarEkle.BackgroundImage = global::Kutuphane.Presentation.Properties.Resources.add_32x32;
            this.BtnYazarEkle.Location = new System.Drawing.Point(328, 54);
            this.BtnYazarEkle.Name = "BtnYazarEkle";
            this.BtnYazarEkle.Size = new System.Drawing.Size(82, 21);
            this.BtnYazarEkle.TabIndex = 18;
            this.BtnYazarEkle.Text = "Yazar Ekle";
            this.BtnYazarEkle.Click += new System.EventHandler(this.BtnYazarEkle_Click);
            // 
            // CmbTurAdi
            // 
            this.CmbTurAdi.FormattingEnabled = true;
            this.CmbTurAdi.Items.AddRange(new object[] {
            "Ekle"});
            this.CmbTurAdi.Location = new System.Drawing.Point(127, 82);
            this.CmbTurAdi.Name = "CmbTurAdi";
            this.CmbTurAdi.Size = new System.Drawing.Size(195, 21);
            this.CmbTurAdi.TabIndex = 17;
            // 
            // CmbYazarAdi
            // 
            this.CmbYazarAdi.FormattingEnabled = true;
            this.CmbYazarAdi.Items.AddRange(new object[] {
            "Ekle"});
            this.CmbYazarAdi.Location = new System.Drawing.Point(128, 54);
            this.CmbYazarAdi.Name = "CmbYazarAdi";
            this.CmbYazarAdi.Size = new System.Drawing.Size(194, 21);
            this.CmbYazarAdi.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.Location = new System.Drawing.Point(12, 185);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 20);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Açıklama";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.Location = new System.Drawing.Point(12, 159);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 20);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Ödünç Verilebilir";
            // 
            // TglSwDurum
            // 
            this.TglSwDurum.Location = new System.Drawing.Point(127, 156);
            this.TglSwDurum.Name = "TglSwDurum";
            this.TglSwDurum.Properties.OffText = "Off";
            this.TglSwDurum.Properties.OnText = "On";
            this.TglSwDurum.Size = new System.Drawing.Size(100, 24);
            this.TglSwDurum.TabIndex = 10;
            // 
            // TxtSayfaSayisi
            // 
            this.TxtSayfaSayisi.Location = new System.Drawing.Point(127, 133);
            this.TxtSayfaSayisi.Name = "TxtSayfaSayisi";
            this.TxtSayfaSayisi.Size = new System.Drawing.Size(195, 20);
            this.TxtSayfaSayisi.TabIndex = 9;
            this.TxtSayfaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit5_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl6.Location = new System.Drawing.Point(11, 133);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(110, 20);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Sayfa Sayısı";
            // 
            // TxtBasimYeri
            // 
            this.TxtBasimYeri.Location = new System.Drawing.Point(127, 107);
            this.TxtBasimYeri.Name = "TxtBasimYeri";
            this.TxtBasimYeri.Size = new System.Drawing.Size(195, 20);
            this.TxtBasimYeri.TabIndex = 7;
            this.TxtBasimYeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit4_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.Location = new System.Drawing.Point(11, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(110, 20);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Basım Yeri";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.Location = new System.Drawing.Point(11, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 20);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Tur";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(11, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Yazar Adı";
            // 
            // TxtKitapadi
            // 
            this.TxtKitapadi.Location = new System.Drawing.Point(127, 29);
            this.TxtKitapadi.Name = "TxtKitapadi";
            this.TxtKitapadi.Size = new System.Drawing.Size(195, 20);
            this.TxtKitapadi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(11, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kitap Adı";
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Location = new System.Drawing.Point(128, 186);
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(210, 131);
            this.TxtAciklama.TabIndex = 13;
            // 
            // FRMKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 436);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMKitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.FRMKitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TglSwDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSayfaSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBasimYeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKitapadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtKitapadi;
        private DevExpress.XtraEditors.ToggleSwitch TglSwDurum;
        private DevExpress.XtraEditors.TextEdit TxtSayfaSayisi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtBasimYeri;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit TxtAciklama;
        private System.Windows.Forms.ComboBox CmbTurAdi;
        private System.Windows.Forms.ComboBox CmbYazarAdi;
        private DevExpress.XtraEditors.SimpleButton BtnYazarEkle;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}