namespace Kutuphane.Presentation.Kitaplar
{
    partial class FRMKitap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraGrid.Columns.GridColumn KitapAdı = new DevExpress.XtraGrid.Columns.GridColumn();
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMKitap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTakip = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.GridKontKitap = new DevExpress.XtraGrid.GridControl();
            this.gridKitap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YazarAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TurAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BasımYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SayfaSayısı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ÖdünçVerilmeDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Açıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kitap = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.Appearance.Options.UseImageAlign = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(805, 38);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kitap Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTakip);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 398);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(805, 96);
            this.groupControl1.TabIndex = 1;
            // 
            // BtnTakip
            // 
            this.BtnTakip.AutoSize = true;
            this.BtnTakip.Location = new System.Drawing.Point(480, 23);
            this.BtnTakip.MinimumSize = new System.Drawing.Size(152, 67);
            this.BtnTakip.Name = "BtnTakip";
            this.BtnTakip.Size = new System.Drawing.Size(152, 67);
            this.BtnTakip.TabIndex = 3;
            this.BtnTakip.Text = "Seçili Kitap Takibi";
            this.BtnTakip.Click += new System.EventHandler(this.BtnTakip_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(322, 24);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(152, 67);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(164, 24);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(152, 67);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.Text = "Düzenle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(6, 24);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(152, 67);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // GridKontKitap
            // 
            this.GridKontKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridKontKitap.Location = new System.Drawing.Point(0, 38);
            this.GridKontKitap.MainView = this.gridKitap;
            this.GridKontKitap.Name = "GridKontKitap";
            this.GridKontKitap.Size = new System.Drawing.Size(805, 360);
            this.GridKontKitap.TabIndex = 2;
            this.GridKontKitap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitap});
            // 
            // gridKitap
            // 
            this.gridKitap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.YazarAdı,
            this.TurAdı,
            this.BasımYeri,
            this.SayfaSayısı,
            this.ÖdünçVerilmeDurumu,
            this.Açıklama,
            this.Kitap});
            this.gridKitap.GridControl = this.GridKontKitap;
            this.gridKitap.Name = "gridKitap";
            this.gridKitap.OptionsView.ShowGroupPanel = false;
            this.gridKitap.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridKitap_RowClick);
            // 
            // ID
            // 
            this.ID.Caption = "KtpId";
            this.ID.FieldName = "KtpId";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsFilter.AllowFilter = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 98;
            // 
            // YazarAdı
            // 
            this.YazarAdı.Caption = "YazarAdı";
            this.YazarAdı.FieldName = "YazarAdi";
            this.YazarAdı.Name = "YazarAdı";
            this.YazarAdı.OptionsColumn.AllowEdit = false;
            this.YazarAdı.OptionsFilter.AllowFilter = false;
            this.YazarAdı.Visible = true;
            this.YazarAdı.VisibleIndex = 2;
            this.YazarAdı.Width = 93;
            // 
            // TurAdı
            // 
            this.TurAdı.Caption = "TurAdı";
            this.TurAdı.FieldName = "TurAdi";
            this.TurAdı.Name = "TurAdı";
            this.TurAdı.OptionsColumn.AllowEdit = false;
            this.TurAdı.OptionsFilter.AllowFilter = false;
            this.TurAdı.Visible = true;
            this.TurAdı.VisibleIndex = 3;
            this.TurAdı.Width = 93;
            // 
            // BasımYeri
            // 
            this.BasımYeri.Caption = "BasımYeri";
            this.BasımYeri.FieldName = "BasimYeri";
            this.BasımYeri.Name = "BasımYeri";
            this.BasımYeri.OptionsColumn.AllowEdit = false;
            this.BasımYeri.OptionsFilter.AllowFilter = false;
            this.BasımYeri.Visible = true;
            this.BasımYeri.VisibleIndex = 4;
            this.BasımYeri.Width = 93;
            // 
            // SayfaSayısı
            // 
            this.SayfaSayısı.Caption = "SayfaSayısı";
            this.SayfaSayısı.FieldName = "SayfaSayisi";
            this.SayfaSayısı.Name = "SayfaSayısı";
            this.SayfaSayısı.OptionsColumn.AllowEdit = false;
            this.SayfaSayısı.OptionsFilter.AllowFilter = false;
            this.SayfaSayısı.Visible = true;
            this.SayfaSayısı.VisibleIndex = 5;
            this.SayfaSayısı.Width = 93;
            // 
            // ÖdünçVerilmeDurumu
            // 
            this.ÖdünçVerilmeDurumu.Caption = "ÖdünçVerilmeDurumu";
            this.ÖdünçVerilmeDurumu.FieldName = "Durum";
            this.ÖdünçVerilmeDurumu.Name = "ÖdünçVerilmeDurumu";
            this.ÖdünçVerilmeDurumu.OptionsColumn.AllowEdit = false;
            this.ÖdünçVerilmeDurumu.OptionsFilter.AllowFilter = false;
            this.ÖdünçVerilmeDurumu.Width = 93;
            // 
            // Açıklama
            // 
            this.Açıklama.Caption = "Açıklama";
            this.Açıklama.FieldName = "Acıklama";
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.OptionsColumn.AllowEdit = false;
            this.Açıklama.OptionsFilter.AllowFilter = false;
            this.Açıklama.Visible = true;
            this.Açıklama.VisibleIndex = 6;
            this.Açıklama.Width = 98;
            // 
            // Kitap
            // 
            this.Kitap.Caption = "KitapAdı";
            this.Kitap.FieldName = "KitapAdi";
            this.Kitap.Name = "Kitap";
            this.Kitap.OptionsColumn.AllowEdit = false;
            this.Kitap.Visible = true;
            this.Kitap.VisibleIndex = 1;
            // 
            // FRMKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 494);
            this.Controls.Add(this.GridKontKitap);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FRMKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraGrid.GridControl GridKontKitap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKitap;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn YazarAdı;
        private DevExpress.XtraGrid.Columns.GridColumn TurAdı;
        private DevExpress.XtraGrid.Columns.GridColumn BasımYeri;
        private DevExpress.XtraGrid.Columns.GridColumn SayfaSayısı;
        private DevExpress.XtraGrid.Columns.GridColumn ÖdünçVerilmeDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn Açıklama;
        private DevExpress.XtraGrid.Columns.GridColumn Kitap;
        private DevExpress.XtraEditors.SimpleButton BtnTakip;


    }
}