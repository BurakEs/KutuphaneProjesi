namespace Kutuphane.Presentation.Uyeler
{
    partial class FRMUyeler
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
            this.LblUye = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTakip = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.GridKontUye = new DevExpress.XtraGrid.GridControl();
            this.gridUye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TcKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoyAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KayıtTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Borç = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Açıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUye
            // 
            this.LblUye.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUye.Appearance.Image = global::Kutuphane.Presentation.Properties.Resources.customer_32x32;
            this.LblUye.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblUye.Appearance.Options.UseFont = true;
            this.LblUye.Appearance.Options.UseImage = true;
            this.LblUye.Appearance.Options.UseImageAlign = true;
            this.LblUye.Appearance.Options.UseTextOptions = true;
            this.LblUye.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblUye.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblUye.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblUye.Location = new System.Drawing.Point(0, 0);
            this.LblUye.Name = "LblUye";
            this.LblUye.Size = new System.Drawing.Size(758, 38);
            this.LblUye.TabIndex = 1;
            this.LblUye.Text = "Uye Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTakip);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 272);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(758, 96);
            this.groupControl1.TabIndex = 2;
            // 
            // BtnTakip
            // 
            this.BtnTakip.AutoSize = true;
            this.BtnTakip.Location = new System.Drawing.Point(480, 24);
            this.BtnTakip.MinimumSize = new System.Drawing.Size(152, 67);
            this.BtnTakip.Name = "BtnTakip";
            this.BtnTakip.Size = new System.Drawing.Size(152, 67);
            this.BtnTakip.TabIndex = 4;
            this.BtnTakip.Text = "Seçili Üye Takibi";
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
            // GridKontUye
            // 
            this.GridKontUye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridKontUye.Location = new System.Drawing.Point(0, 38);
            this.GridKontUye.MainView = this.gridUye;
            this.GridKontUye.Name = "GridKontUye";
            this.GridKontUye.Size = new System.Drawing.Size(758, 234);
            this.GridKontUye.TabIndex = 3;
            this.GridKontUye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUye});
            // 
            // gridUye
            // 
            this.gridUye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TcKimlikNo,
            this.Adı,
            this.SoyAdı,
            this.KayıtTarihi,
            this.Borç,
            this.Açıklama});
            this.gridUye.GridControl = this.GridKontUye;
            this.gridUye.Name = "gridUye";
            this.gridUye.OptionsView.ShowGroupPanel = false;
            this.gridUye.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridUye_RowClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "UyeId";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsFilter.AllowFilter = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 98;
            // 
            // TcKimlikNo
            // 
            this.TcKimlikNo.Caption = "TcKimlikNo";
            this.TcKimlikNo.FieldName = "TcKimlikNo";
            this.TcKimlikNo.Name = "TcKimlikNo";
            this.TcKimlikNo.OptionsColumn.AllowEdit = false;
            this.TcKimlikNo.OptionsFilter.AllowFilter = false;
            this.TcKimlikNo.Visible = true;
            this.TcKimlikNo.VisibleIndex = 1;
            this.TcKimlikNo.Width = 93;
            // 
            // Adı
            // 
            this.Adı.Caption = "Adı";
            this.Adı.FieldName = "Adi";
            this.Adı.Name = "Adı";
            this.Adı.OptionsColumn.AllowEdit = false;
            this.Adı.OptionsFilter.AllowFilter = false;
            this.Adı.Visible = true;
            this.Adı.VisibleIndex = 2;
            this.Adı.Width = 93;
            // 
            // SoyAdı
            // 
            this.SoyAdı.Caption = "SoyAdı";
            this.SoyAdı.FieldName = "SoyAdi";
            this.SoyAdı.Name = "SoyAdı";
            this.SoyAdı.OptionsColumn.AllowEdit = false;
            this.SoyAdı.OptionsFilter.AllowFilter = false;
            this.SoyAdı.Visible = true;
            this.SoyAdı.VisibleIndex = 3;
            this.SoyAdı.Width = 93;
            // 
            // KayıtTarihi
            // 
            this.KayıtTarihi.Caption = "KayıtTarihi";
            this.KayıtTarihi.FieldName = "KayıtTarihi";
            this.KayıtTarihi.Name = "KayıtTarihi";
            this.KayıtTarihi.OptionsColumn.AllowEdit = false;
            this.KayıtTarihi.OptionsFilter.AllowFilter = false;
            this.KayıtTarihi.Visible = true;
            this.KayıtTarihi.VisibleIndex = 4;
            this.KayıtTarihi.Width = 93;
            // 
            // Borç
            // 
            this.Borç.Caption = "Borç";
            this.Borç.FieldName = "Borc";
            this.Borç.Name = "Borç";
            this.Borç.OptionsColumn.AllowEdit = false;
            this.Borç.OptionsFilter.AllowFilter = false;
            this.Borç.Visible = true;
            this.Borç.VisibleIndex = 5;
            this.Borç.Width = 93;
            // 
            // Açıklama
            // 
            this.Açıklama.Caption = "Açıklama";
            this.Açıklama.FieldName = "Aciklama";
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.OptionsColumn.AllowEdit = false;
            this.Açıklama.OptionsFilter.AllowFilter = false;
            this.Açıklama.Visible = true;
            this.Açıklama.VisibleIndex = 6;
            this.Açıklama.Width = 98;
            // 
            // FRMUyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 368);
            this.Controls.Add(this.GridKontUye);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.LblUye);
            this.Name = "FRMUyeler";
            this.Text = "Uyeler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblUye;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraGrid.GridControl GridKontUye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUye;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn Adı;
        private DevExpress.XtraGrid.Columns.GridColumn SoyAdı;
        private DevExpress.XtraGrid.Columns.GridColumn KayıtTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Borç;
        private DevExpress.XtraGrid.Columns.GridColumn Açıklama;
        private DevExpress.XtraEditors.SimpleButton BtnTakip;
    }
}