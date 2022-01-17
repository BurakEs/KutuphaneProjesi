namespace Kutuphane.Presentation.Uyeler
{
    partial class FRMUyeBazlıArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUyeBazlıArama));
            this.LblUye = new DevExpress.XtraEditors.LabelControl();
            this.GridKontUyeArama = new DevExpress.XtraGrid.GridControl();
            this.gridUyeArama = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UyeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ÜyeAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ÜyeSoyAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KitapAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilisSüresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Açıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimHesap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKacgunGecıktı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coldurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontUyeArama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUyeArama)).BeginInit();
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
            this.LblUye.Size = new System.Drawing.Size(784, 38);
            this.LblUye.TabIndex = 2;
            this.LblUye.Text = "Uye Takibi";
            // 
            // GridKontUyeArama
            // 
            this.GridKontUyeArama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridKontUyeArama.Location = new System.Drawing.Point(0, 38);
            this.GridKontUyeArama.MainView = this.gridUyeArama;
            this.GridKontUyeArama.Name = "GridKontUyeArama";
            this.GridKontUyeArama.Size = new System.Drawing.Size(784, 323);
            this.GridKontUyeArama.TabIndex = 5;
            this.GridKontUyeArama.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUyeArama});
            // 
            // gridUyeArama
            // 
            this.gridUyeArama.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.UyeID,
            this.ÜyeAdı,
            this.ÜyeSoyAdi,
            this.KitapAdı,
            this.colVerilisTarihi,
            this.colVerilisSüresi,
            this.colTeslimTarihi,
            this.Açıklama,
            this.colTeslimHesap,
            this.ColKacgunGecıktı,
            this.Coldurumu});
            this.gridUyeArama.GridControl = this.GridKontUyeArama;
            this.gridUyeArama.Name = "gridUyeArama";
            this.gridUyeArama.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridUyeArama.OptionsFind.AlwaysVisible = true;
            this.gridUyeArama.OptionsFind.FindDelay = 100;
            this.gridUyeArama.OptionsFind.FindFilterColumns = "ÜyeAdı";
            this.gridUyeArama.OptionsFind.FindNullPrompt = "Aramak istediğiniz Üye adını girin.";
            this.gridUyeArama.OptionsFind.ShowCloseButton = false;
            this.gridUyeArama.OptionsFind.ShowFindButton = false;
            this.gridUyeArama.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridUyeArama.OptionsView.ShowGroupPanel = false;
            this.gridUyeArama.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridUyeArama_RowCellStyle);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "KhId";
            this.ID.Name = "ID";
            // 
            // UyeID
            // 
            this.UyeID.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.UyeID.AppearanceCell.Options.UseBackColor = true;
            this.UyeID.Caption = "UyeID";
            this.UyeID.FieldName = "UyeId";
            this.UyeID.Name = "UyeID";
            this.UyeID.OptionsColumn.AllowEdit = false;
            this.UyeID.OptionsFilter.AllowFilter = false;
            this.UyeID.Visible = true;
            this.UyeID.VisibleIndex = 1;
            this.UyeID.Width = 40;
            // 
            // ÜyeAdı
            // 
            this.ÜyeAdı.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.ÜyeAdı.AppearanceCell.Options.UseBackColor = true;
            this.ÜyeAdı.Caption = "ÜyeAdı";
            this.ÜyeAdı.FieldName = "Adi";
            this.ÜyeAdı.Name = "ÜyeAdı";
            this.ÜyeAdı.OptionsColumn.AllowEdit = false;
            this.ÜyeAdı.OptionsFilter.AllowFilter = false;
            this.ÜyeAdı.Visible = true;
            this.ÜyeAdı.VisibleIndex = 2;
            this.ÜyeAdı.Width = 45;
            // 
            // ÜyeSoyAdi
            // 
            this.ÜyeSoyAdi.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.ÜyeSoyAdi.AppearanceCell.Options.UseBackColor = true;
            this.ÜyeSoyAdi.Caption = "ÜyeSoyAdi";
            this.ÜyeSoyAdi.FieldName = "SoyAdi";
            this.ÜyeSoyAdi.Name = "ÜyeSoyAdi";
            this.ÜyeSoyAdi.OptionsColumn.AllowEdit = false;
            this.ÜyeSoyAdi.OptionsFilter.AllowFilter = false;
            this.ÜyeSoyAdi.Visible = true;
            this.ÜyeSoyAdi.VisibleIndex = 3;
            this.ÜyeSoyAdi.Width = 73;
            // 
            // KitapAdı
            // 
            this.KitapAdı.Caption = "KitapAdı";
            this.KitapAdı.FieldName = "KitapAdi";
            this.KitapAdı.Name = "KitapAdı";
            this.KitapAdı.OptionsColumn.AllowEdit = false;
            this.KitapAdı.OptionsFilter.AllowFilter = false;
            this.KitapAdı.Visible = true;
            this.KitapAdı.VisibleIndex = 4;
            this.KitapAdı.Width = 73;
            // 
            // colVerilisTarihi
            // 
            this.colVerilisTarihi.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colVerilisTarihi.AppearanceCell.Options.UseBackColor = true;
            this.colVerilisTarihi.Caption = "VerilişTarihi";
            this.colVerilisTarihi.FieldName = "VerilisTarihi";
            this.colVerilisTarihi.Name = "colVerilisTarihi";
            this.colVerilisTarihi.OptionsColumn.AllowEdit = false;
            this.colVerilisTarihi.OptionsFilter.AllowFilter = false;
            this.colVerilisTarihi.Visible = true;
            this.colVerilisTarihi.VisibleIndex = 5;
            this.colVerilisTarihi.Width = 73;
            // 
            // colVerilisSüresi
            // 
            this.colVerilisSüresi.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colVerilisSüresi.AppearanceCell.Options.UseBackColor = true;
            this.colVerilisSüresi.Caption = "VerilişSüresi";
            this.colVerilisSüresi.FieldName = "VerilisSuresi";
            this.colVerilisSüresi.Name = "colVerilisSüresi";
            this.colVerilisSüresi.OptionsColumn.AllowEdit = false;
            this.colVerilisSüresi.OptionsFilter.AllowFilter = false;
            this.colVerilisSüresi.Visible = true;
            this.colVerilisSüresi.VisibleIndex = 6;
            this.colVerilisSüresi.Width = 68;
            // 
            // colTeslimTarihi
            // 
            this.colTeslimTarihi.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colTeslimTarihi.AppearanceCell.Options.UseBackColor = true;
            this.colTeslimTarihi.Caption = "TeslimTarihi";
            this.colTeslimTarihi.FieldName = "TeslimTarihi";
            this.colTeslimTarihi.Name = "colTeslimTarihi";
            this.colTeslimTarihi.OptionsColumn.AllowEdit = false;
            this.colTeslimTarihi.OptionsFilter.AllowFilter = false;
            this.colTeslimTarihi.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colTeslimTarihi.Visible = true;
            this.colTeslimTarihi.VisibleIndex = 8;
            this.colTeslimTarihi.Width = 103;
            // 
            // Açıklama
            // 
            this.Açıklama.Caption = "Açıklama";
            this.Açıklama.FieldName = "Aciklama";
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.OptionsColumn.AllowEdit = false;
            this.Açıklama.OptionsFilter.AllowFilter = false;
            this.Açıklama.Width = 74;
            // 
            // colTeslimHesap
            // 
            this.colTeslimHesap.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colTeslimHesap.AppearanceCell.Options.UseBackColor = true;
            this.colTeslimHesap.Caption = "Teslim Edilmesi Gereken Tarih";
            this.colTeslimHesap.FieldName = "colTeslimHesap";
            this.colTeslimHesap.Name = "colTeslimHesap";
            this.colTeslimHesap.OptionsColumn.AllowEdit = false;
            this.colTeslimHesap.OptionsFilter.AllowFilter = false;
            this.colTeslimHesap.UnboundExpression = "AddDays([VerilisTarihi], [VerilisSuresi])";
            this.colTeslimHesap.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colTeslimHesap.Visible = true;
            this.colTeslimHesap.VisibleIndex = 7;
            this.colTeslimHesap.Width = 135;
            // 
            // ColKacgunGecıktı
            // 
            this.ColKacgunGecıktı.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.ColKacgunGecıktı.AppearanceCell.Options.UseBackColor = true;
            this.ColKacgunGecıktı.Caption = "Kaç Gün Geçikti";
            this.ColKacgunGecıktı.FieldName = "ColKacgunGecıktı";
            this.ColKacgunGecıktı.Name = "ColKacgunGecıktı";
            this.ColKacgunGecıktı.OptionsColumn.AllowEdit = false;
            this.ColKacgunGecıktı.OptionsFilter.AllowFilter = false;
            this.ColKacgunGecıktı.UnboundExpression = "DateDiffDay([colTeslimHesap], Today())";
            this.ColKacgunGecıktı.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // Coldurumu
            // 
            this.Coldurumu.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.Coldurumu.AppearanceCell.Options.UseBackColor = true;
            this.Coldurumu.Caption = "Durumu";
            this.Coldurumu.FieldName = "Coldurumu";
            this.Coldurumu.Name = "Coldurumu";
            this.Coldurumu.OptionsColumn.AllowEdit = false;
            this.Coldurumu.OptionsFilter.AllowFilter = false;
            this.Coldurumu.UnboundExpression = resources.GetString("Coldurumu.UnboundExpression");
            this.Coldurumu.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Coldurumu.Visible = true;
            this.Coldurumu.VisibleIndex = 0;
            this.Coldurumu.Width = 115;
            // 
            // FRMUyeBazlıArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.GridKontUyeArama);
            this.Controls.Add(this.LblUye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRMUyeBazlıArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMUyeBazlıArama";
            this.Load += new System.EventHandler(this.FRMUyeBazlıArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridKontUyeArama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUyeArama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblUye;
        private DevExpress.XtraGrid.GridControl GridKontUyeArama;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUyeArama;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn UyeID;
        private DevExpress.XtraGrid.Columns.GridColumn ÜyeAdı;
        private DevExpress.XtraGrid.Columns.GridColumn ÜyeSoyAdi;
        private DevExpress.XtraGrid.Columns.GridColumn KitapAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilisSüresi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Açıklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimHesap;
        private DevExpress.XtraGrid.Columns.GridColumn ColKacgunGecıktı;
        private DevExpress.XtraGrid.Columns.GridColumn Coldurumu;
    }
}