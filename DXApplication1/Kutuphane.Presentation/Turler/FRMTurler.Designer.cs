namespace Kutuphane.Presentation.Turler
{
    partial class FRMTurler
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.GridKontKitap = new DevExpress.XtraGrid.GridControl();
            this.gridKitap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TurAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Image = global::Kutuphane.Presentation.Properties.Resources.editcomment_32x32;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(727, 38);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tur Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 281);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(727, 96);
            this.groupControl1.TabIndex = 2;
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
            this.GridKontKitap.Size = new System.Drawing.Size(727, 243);
            this.GridKontKitap.TabIndex = 3;
            this.GridKontKitap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitap});
            // 
            // gridKitap
            // 
            this.gridKitap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TurAdı});
            this.gridKitap.GridControl = this.GridKontKitap;
            this.gridKitap.Name = "gridKitap";
            this.gridKitap.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsFilter.AllowFilter = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 98;
            // 
            // TurAdı
            // 
            this.TurAdı.Caption = "TurAdı";
            this.TurAdı.FieldName = "TurAdi";
            this.TurAdı.Name = "TurAdı";
            this.TurAdı.OptionsColumn.AllowEdit = false;
            this.TurAdı.OptionsFilter.AllowFilter = false;
            this.TurAdı.Visible = true;
            this.TurAdı.VisibleIndex = 1;
            this.TurAdı.Width = 93;
            // 
            // FRMTurler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 377);
            this.Controls.Add(this.GridKontKitap);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FRMTurler";
            this.Text = "Tur Listesi";
            this.Load += new System.EventHandler(this.FRMTurler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Columns.GridColumn TurAdı;
    }
}