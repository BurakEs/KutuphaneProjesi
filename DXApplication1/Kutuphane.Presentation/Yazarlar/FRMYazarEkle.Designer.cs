namespace Kutuphane.Presentation.Yazarlar
{
    partial class FRMYazarEkle
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
            this.LblYazar = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.DateTimeDgmTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtDogumYeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtYazarAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAcik = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogumYeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYazarAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcik.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LblYazar
            // 
            this.LblYazar.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYazar.Appearance.Image = global::Kutuphane.Presentation.Properties.Resources.editcontact_32x32;
            this.LblYazar.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblYazar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblYazar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblYazar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblYazar.Location = new System.Drawing.Point(0, 0);
            this.LblYazar.Name = "LblYazar";
            this.LblYazar.Size = new System.Drawing.Size(346, 38);
            this.LblYazar.TabIndex = 3;
            this.LblYazar.Text = "Yazar Ekle";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnKapat);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 289);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(346, 75);
            this.groupControl1.TabIndex = 4;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Location = new System.Drawing.Point(232, 23);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(109, 40);
            this.BtnKapat.TabIndex = 7;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click_1);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(117, 23);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(109, 40);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click_1);
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl2.Controls.Add(this.DateTimeDgmTarihi);
            this.groupControl2.Controls.Add(this.TxtDogumYeri);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.TxtYazarAdi);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.TxtAcik);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 38);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(346, 251);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Genel Bilgiler";
            // 
            // DateTimeDgmTarihi
            // 
            this.DateTimeDgmTarihi.Location = new System.Drawing.Point(129, 54);
            this.DateTimeDgmTarihi.Name = "DateTimeDgmTarihi";
            this.DateTimeDgmTarihi.Size = new System.Drawing.Size(194, 21);
            this.DateTimeDgmTarihi.TabIndex = 2;
            // 
            // TxtDogumYeri
            // 
            this.TxtDogumYeri.Location = new System.Drawing.Point(127, 81);
            this.TxtDogumYeri.Name = "TxtDogumYeri";
            this.TxtDogumYeri.Size = new System.Drawing.Size(195, 20);
            this.TxtDogumYeri.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.Location = new System.Drawing.Point(12, 106);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(110, 20);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Açıklama";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.Location = new System.Drawing.Point(12, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(110, 20);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Doğum Yılı";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.Location = new System.Drawing.Point(12, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 20);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Doğum Yeri";
            // 
            // TxtYazarAdi
            // 
            this.TxtYazarAdi.Location = new System.Drawing.Point(127, 29);
            this.TxtYazarAdi.Name = "TxtYazarAdi";
            this.TxtYazarAdi.Size = new System.Drawing.Size(195, 20);
            this.TxtYazarAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(12, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Yazar Adı";
            // 
            // TxtAcik
            // 
            this.TxtAcik.Location = new System.Drawing.Point(128, 107);
            this.TxtAcik.Name = "TxtAcik";
            this.TxtAcik.Size = new System.Drawing.Size(195, 131);
            this.TxtAcik.TabIndex = 4;
            // 
            // FRMYazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 364);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.LblYazar);
            this.Name = "FRMYazarEkle";
            this.Text = "FRMYazarEkle";
            this.Load += new System.EventHandler(this.FRMYazarEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogumYeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYazarAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcik.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl LblYazar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DateTimePicker DateTimeDgmTarihi;
        private DevExpress.XtraEditors.TextEdit TxtDogumYeri;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtYazarAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit TxtAcik;
    }
}