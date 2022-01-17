namespace Kutuphane.Presentation.KitapHareketleri
{
    partial class FRMKitapVerİslem
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
            this.pageUyeSec = new DevExpress.XtraWizard.WizardPage();
            this.GridKontUye = new DevExpress.XtraGrid.GridControl();
            this.gridUye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UyeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TcKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoyAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KayıtTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Borç = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.completionPageRapor = new DevExpress.XtraWizard.CompletionWizardPage();
            this.lblTarihSec = new DevExpress.XtraEditors.LabelControl();
            this.lblzet = new DevExpress.XtraEditors.LabelControl();
            this.lbRapor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CalenderTeslim = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.CalenderVerilis = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.pageKitapSec = new DevExpress.XtraWizard.WizardPage();
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.pageUyeSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.completionPageRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalenderTeslim.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalenderVerilis.CalendarTimeProperties)).BeginInit();
            this.pageKitapSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageUyeSec
            // 
            this.pageUyeSec.Controls.Add(this.GridKontUye);
            this.pageUyeSec.Name = "pageUyeSec";
            this.pageUyeSec.Size = new System.Drawing.Size(752, 322);
            this.pageUyeSec.Text = "";
            // 
            // GridKontUye
            // 
            this.GridKontUye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridKontUye.Location = new System.Drawing.Point(0, 0);
            this.GridKontUye.MainView = this.gridUye;
            this.GridKontUye.Name = "GridKontUye";
            this.GridKontUye.Size = new System.Drawing.Size(752, 322);
            this.GridKontUye.TabIndex = 4;
            this.GridKontUye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUye,
            this.gridView1});
            // 
            // gridUye
            // 
            this.gridUye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UyeId,
            this.TcKimlikNo,
            this.Adı,
            this.SoyAdı,
            this.KayıtTarihi,
            this.Borç,
            this.gridColumn2});
            this.gridUye.GridControl = this.GridKontUye;
            this.gridUye.Name = "gridUye";
            this.gridUye.OptionsView.ShowGroupPanel = false;
            // 
            // UyeId
            // 
            this.UyeId.Caption = "ID";
            this.UyeId.FieldName = "UyeId";
            this.UyeId.Name = "UyeId";
            this.UyeId.OptionsColumn.AllowEdit = false;
            this.UyeId.OptionsFilter.AllowFilter = false;
            this.UyeId.Visible = true;
            this.UyeId.VisibleIndex = 0;
            this.UyeId.Width = 98;
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Açıklama";
            this.gridColumn2.FieldName = "Aciklama";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 98;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridKontUye;
            this.gridView1.Name = "gridView1";
            // 
            // completionPageRapor
            // 
            this.completionPageRapor.Controls.Add(this.lblTarihSec);
            this.completionPageRapor.Controls.Add(this.lblzet);
            this.completionPageRapor.Controls.Add(this.lbRapor);
            this.completionPageRapor.Controls.Add(this.labelControl1);
            this.completionPageRapor.Controls.Add(this.CalenderTeslim);
            this.completionPageRapor.Controls.Add(this.labelControl2);
            this.completionPageRapor.Controls.Add(this.CalenderVerilis);
            this.completionPageRapor.FinishText = "Bitir";
            this.completionPageRapor.Name = "completionPageRapor";
            this.completionPageRapor.Size = new System.Drawing.Size(752, 322);
            this.completionPageRapor.Text = "İşlem Başarı İle Tamamlandı.";
            // 
            // lblTarihSec
            // 
            this.lblTarihSec.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihSec.Appearance.Options.UseFont = true;
            this.lblTarihSec.Appearance.Options.UseTextOptions = true;
            this.lblTarihSec.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTarihSec.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTarihSec.Location = new System.Drawing.Point(254, 3);
            this.lblTarihSec.Name = "lblTarihSec";
            this.lblTarihSec.Size = new System.Drawing.Size(244, 63);
            this.lblTarihSec.TabIndex = 6;
            this.lblTarihSec.Text = "Veriliş Tarihini Seçiniz.";
            // 
            // lblzet
            // 
            this.lblzet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblzet.Appearance.Options.UseFont = true;
            this.lblzet.Appearance.Options.UseTextOptions = true;
            this.lblzet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblzet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblzet.Location = new System.Drawing.Point(286, 135);
            this.lblzet.Name = "lblzet";
            this.lblzet.Size = new System.Drawing.Size(152, 63);
            this.lblzet.TabIndex = 5;
            this.lblzet.Text = "İşlem Özeti";
            this.lblzet.Visible = false;
            // 
            // lbRapor
            // 
            this.lbRapor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbRapor.Appearance.Options.UseFont = true;
            this.lbRapor.Appearance.Options.UseTextOptions = true;
            this.lbRapor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbRapor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbRapor.Location = new System.Drawing.Point(3, 204);
            this.lbRapor.Name = "lbRapor";
            this.lbRapor.Size = new System.Drawing.Size(746, 115);
            this.lbRapor.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(504, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(248, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Teslim Edilmesi Gereken Tarih";
            // 
            // CalenderTeslim
            // 
            this.CalenderTeslim.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CalenderTeslim.Location = new System.Drawing.Point(504, 19);
            this.CalenderTeslim.Name = "CalenderTeslim";
            this.CalenderTeslim.ReadOnly = true;
            this.CalenderTeslim.ShowFooter = false;
            this.CalenderTeslim.ShowMonthHeaders = false;
            this.CalenderTeslim.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.CalenderTeslim.Size = new System.Drawing.Size(248, 204);
            this.CalenderTeslim.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(248, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Verilis Tarihi";
            // 
            // CalenderVerilis
            // 
            this.CalenderVerilis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CalenderVerilis.Location = new System.Drawing.Point(0, 19);
            this.CalenderVerilis.Name = "CalenderVerilis";
            this.CalenderVerilis.ShowFooter = false;
            this.CalenderVerilis.ShowMonthHeaders = false;
            this.CalenderVerilis.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.CalenderVerilis.Size = new System.Drawing.Size(248, 204);
            this.CalenderVerilis.TabIndex = 0;
            this.CalenderVerilis.DateTimeChanged += new System.EventHandler(this.CalenderVerilis_DateTimeChanged);
            // 
            // pageKitapSec
            // 
            this.pageKitapSec.Controls.Add(this.GridKontKitap);
            this.pageKitapSec.Name = "pageKitapSec";
            this.pageKitapSec.Size = new System.Drawing.Size(752, 322);
            this.pageKitapSec.Text = "Vermek istediğiniz kitabı seçin.";
            // 
            // GridKontKitap
            // 
            this.GridKontKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridKontKitap.Location = new System.Drawing.Point(0, 0);
            this.GridKontKitap.MainView = this.gridKitap;
            this.GridKontKitap.Name = "GridKontKitap";
            this.GridKontKitap.Size = new System.Drawing.Size(752, 322);
            this.GridKontKitap.TabIndex = 3;
            this.GridKontKitap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitap,
            this.gridView2});
            this.GridKontKitap.Load += new System.EventHandler(this.GridKontKitap_Load);
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
            this.gridKitap.OptionsFind.AlwaysVisible = true;
            this.gridKitap.OptionsFind.FindDelay = 100;
            this.gridKitap.OptionsFind.FindNullPrompt = "Aranacak değeri giriniz.";
            this.gridKitap.OptionsFind.ShowCloseButton = false;
            this.gridKitap.OptionsFind.ShowFindButton = false;
            this.gridKitap.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "KtpId";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsFilter.AllowFilter = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 54;
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
            this.YazarAdı.Width = 98;
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
            this.TurAdı.Width = 98;
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
            this.BasımYeri.Width = 98;
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
            this.SayfaSayısı.Width = 98;
            // 
            // ÖdünçVerilmeDurumu
            // 
            this.ÖdünçVerilmeDurumu.Caption = "ÖdünçVerilmeDurumu";
            this.ÖdünçVerilmeDurumu.FieldName = "Durum";
            this.ÖdünçVerilmeDurumu.Name = "ÖdünçVerilmeDurumu";
            this.ÖdünçVerilmeDurumu.OptionsColumn.AllowEdit = false;
            this.ÖdünçVerilmeDurumu.OptionsFilter.AllowFilter = false;
            this.ÖdünçVerilmeDurumu.Visible = true;
            this.ÖdünçVerilmeDurumu.VisibleIndex = 6;
            this.ÖdünçVerilmeDurumu.Width = 121;
            // 
            // Açıklama
            // 
            this.Açıklama.Caption = "Açıklama";
            this.Açıklama.FieldName = "Acıklama";
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.OptionsColumn.AllowEdit = false;
            this.Açıklama.OptionsFilter.AllowFilter = false;
            this.Açıklama.Visible = true;
            this.Açıklama.VisibleIndex = 7;
            this.Açıklama.Width = 90;
            // 
            // Kitap
            // 
            this.Kitap.Caption = "KitapAdı";
            this.Kitap.FieldName = "KitapAdi";
            this.Kitap.Name = "Kitap";
            this.Kitap.OptionsColumn.AllowEdit = false;
            this.Kitap.Visible = true;
            this.Kitap.VisibleIndex = 1;
            this.Kitap.Width = 77;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GridKontKitap;
            this.gridView2.Name = "gridView2";
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelText = "&İptal";
            this.wizardControl1.Controls.Add(this.pageKitapSec);
            this.wizardControl1.Controls.Add(this.completionPageRapor);
            this.wizardControl1.Controls.Add(this.pageUyeSec);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.pageKitapSec,
            this.pageUyeSec,
            this.completionPageRapor});
            this.wizardControl1.Size = new System.Drawing.Size(812, 490);
            this.wizardControl1.Text = "Kitap Alışveriş Sihirbazı";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // FRMKitapVerİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 490);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMKitapVerİslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.pageUyeSec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridKontUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.completionPageRapor.ResumeLayout(false);
            this.completionPageRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalenderTeslim.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalenderVerilis.CalendarTimeProperties)).EndInit();
            this.pageKitapSec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridKontKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardPage pageUyeSec;
        private DevExpress.XtraGrid.GridControl GridKontUye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUye;
        private DevExpress.XtraGrid.Columns.GridColumn UyeId;
        private DevExpress.XtraGrid.Columns.GridColumn TcKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn Adı;
        private DevExpress.XtraGrid.Columns.GridColumn SoyAdı;
        private DevExpress.XtraGrid.Columns.GridColumn KayıtTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Borç;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraWizard.CompletionWizardPage completionPageRapor;
        private DevExpress.XtraEditors.LabelControl lblTarihSec;
        private DevExpress.XtraEditors.LabelControl lblzet;
        private DevExpress.XtraEditors.LabelControl lbRapor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Controls.CalendarControl CalenderTeslim;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.Controls.CalendarControl CalenderVerilis;
        private DevExpress.XtraWizard.WizardPage pageKitapSec;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraWizard.WizardControl wizardControl1;


    }
}