namespace Kutuphane.Presentation.Yazarlar
{
    partial class FRMYazarlar
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
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.GridKontYazar = new DevExpress.XtraGrid.GridControl();
            this.gridYazar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YazarAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoğumYılı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoğumYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Açıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKontYazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridYazar)).BeginInit();
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
            this.LblYazar.Size = new System.Drawing.Size(709, 38);
            this.LblYazar.TabIndex = 2;
            this.LblYazar.Text = "Yazar Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 267);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(709, 96);
            this.groupControl1.TabIndex = 3;
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
            // GridKontYazar
            // 
            this.GridKontYazar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridKontYazar.Location = new System.Drawing.Point(0, 38);
            this.GridKontYazar.MainView = this.gridYazar;
            this.GridKontYazar.Name = "GridKontYazar";
            this.GridKontYazar.Size = new System.Drawing.Size(709, 229);
            this.GridKontYazar.TabIndex = 4;
            this.GridKontYazar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridYazar});
            // 
            // gridYazar
            // 
            this.gridYazar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.YazarAdı,
            this.DoğumYılı,
            this.DoğumYeri,
            this.Açıklama});
            this.gridYazar.GridControl = this.GridKontYazar;
            this.gridYazar.Name = "gridYazar";
            this.gridYazar.OptionsView.ShowGroupPanel = false;
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
            // YazarAdı
            // 
            this.YazarAdı.Caption = "YazarAdı";
            this.YazarAdı.FieldName = "YazarAdi";
            this.YazarAdı.Name = "YazarAdı";
            this.YazarAdı.OptionsColumn.AllowEdit = false;
            this.YazarAdı.OptionsFilter.AllowFilter = false;
            this.YazarAdı.Visible = true;
            this.YazarAdı.VisibleIndex = 1;
            this.YazarAdı.Width = 93;
            // 
            // DoğumYılı
            // 
            this.DoğumYılı.Caption = "DoğumYılı";
            this.DoğumYılı.FieldName = "DogumYili";
            this.DoğumYılı.Name = "DoğumYılı";
            this.DoğumYılı.OptionsColumn.AllowEdit = false;
            this.DoğumYılı.OptionsFilter.AllowFilter = false;
            this.DoğumYılı.Visible = true;
            this.DoğumYılı.VisibleIndex = 2;
            this.DoğumYılı.Width = 93;
            // 
            // DoğumYeri
            // 
            this.DoğumYeri.Caption = "DoğumYeri";
            this.DoğumYeri.FieldName = "DogumYeri";
            this.DoğumYeri.Name = "DoğumYeri";
            this.DoğumYeri.OptionsColumn.AllowEdit = false;
            this.DoğumYeri.OptionsFilter.AllowFilter = false;
            this.DoğumYeri.Visible = true;
            this.DoğumYeri.VisibleIndex = 3;
            this.DoğumYeri.Width = 93;
            // 
            // Açıklama
            // 
            this.Açıklama.Caption = "Açıklama";
            this.Açıklama.FieldName = "Aciklama";
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.OptionsColumn.AllowEdit = false;
            this.Açıklama.OptionsFilter.AllowFilter = false;
            this.Açıklama.Visible = true;
            this.Açıklama.VisibleIndex = 4;
            this.Açıklama.Width = 98;
            // 
            // FRMYazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 363);
            this.Controls.Add(this.GridKontYazar);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.LblYazar);
            this.Name = "FRMYazarlar";
            this.Text = "Yazarlar";
            this.Load += new System.EventHandler(this.FRMYazarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridKontYazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridYazar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblYazar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraGrid.GridControl GridKontYazar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridYazar;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn YazarAdı;
        private DevExpress.XtraGrid.Columns.GridColumn DoğumYılı;
        private DevExpress.XtraGrid.Columns.GridColumn DoğumYeri;
        private DevExpress.XtraGrid.Columns.GridColumn Açıklama;
    }
}