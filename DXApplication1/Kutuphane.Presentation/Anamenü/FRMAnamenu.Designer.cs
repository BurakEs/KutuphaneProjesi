namespace Kutuphane.Presentation
{
    partial class FRMAnamenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAnamenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnKitaplar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUyeler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKitapHareket = new DevExpress.XtraBars.BarButtonItem();
            this.BtnYazar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTur = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ZgKitapDurumu = new ZedGraph.ZedGraphControl();
            this.Grafikler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnKitapDurum = new DevExpress.XtraBars.BarButtonItem();
            this.BtnTürGrafiği = new DevExpress.XtraBars.BarButtonItem();
            this.ZgTürDurumu = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnKitaplar,
            this.BtnUyeler,
            this.BtnKitapHareket,
            this.BtnYazar,
            this.BtnTur,
            this.BtnKitapDurum,
            this.BtnTürGrafiği});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1014, 162);
            // 
            // BtnKitaplar
            // 
            this.BtnKitaplar.Caption = "Kitap Kayıtları";
            this.BtnKitaplar.Id = 1;
            this.BtnKitaplar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKitaplar.ImageOptions.Image")));
            this.BtnKitaplar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKitaplar.ImageOptions.LargeImage")));
            this.BtnKitaplar.Name = "BtnKitaplar";
            this.BtnKitaplar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKitaplarItem_ItemClick);
            // 
            // BtnUyeler
            // 
            this.BtnUyeler.Caption = "Üye Kayıtları";
            this.BtnUyeler.Id = 2;
            this.BtnUyeler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUyeler.ImageOptions.Image")));
            this.BtnUyeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUyeler.ImageOptions.LargeImage")));
            this.BtnUyeler.Name = "BtnUyeler";
            this.BtnUyeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUyeler_ItemClick);
            // 
            // BtnKitapHareket
            // 
            this.BtnKitapHareket.Caption = "Kitap Hareketleri";
            this.BtnKitapHareket.Id = 6;
            this.BtnKitapHareket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKitapHareket.ImageOptions.Image")));
            this.BtnKitapHareket.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKitapHareket.ImageOptions.LargeImage")));
            this.BtnKitapHareket.Name = "BtnKitapHareket";
            this.BtnKitapHareket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKitapHareket_ItemClick);
            // 
            // BtnYazar
            // 
            this.BtnYazar.Caption = "Yazar Kayıtları";
            this.BtnYazar.Id = 7;
            this.BtnYazar.ImageOptions.Image = global::Kutuphane.Presentation.Properties.Resources.editcontact_16x16;
            this.BtnYazar.ImageOptions.LargeImage = global::Kutuphane.Presentation.Properties.Resources.editcontact_32x32;
            this.BtnYazar.Name = "BtnYazar";
            this.BtnYazar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnYazar_ItemClick);
            // 
            // BtnTur
            // 
            this.BtnTur.Caption = "Tür Kayıtları";
            this.BtnTur.Id = 8;
            this.BtnTur.ImageOptions.Image = global::Kutuphane.Presentation.Properties.Resources.editcomment_16x16;
            this.BtnTur.ImageOptions.LargeImage = global::Kutuphane.Presentation.Properties.Resources.editcomment_32x32;
            this.BtnTur.Name = "BtnTur";
            this.BtnTur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTur_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.Grafikler});
            this.ribbonPage1.Image = global::Kutuphane.Presentation.Properties.Resources.home_32x32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kütüphane";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKitaplar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUyeler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnYazar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnTur);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Kayıtlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnKitapHareket);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "İşlemler";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ZgKitapDurumu
            // 
            this.ZgKitapDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZgKitapDurumu.Location = new System.Drawing.Point(0, 162);
            this.ZgKitapDurumu.Name = "ZgKitapDurumu";
            this.ZgKitapDurumu.ScrollGrace = 0D;
            this.ZgKitapDurumu.ScrollMaxX = 0D;
            this.ZgKitapDurumu.ScrollMaxY = 0D;
            this.ZgKitapDurumu.ScrollMaxY2 = 0D;
            this.ZgKitapDurumu.ScrollMinX = 0D;
            this.ZgKitapDurumu.ScrollMinY = 0D;
            this.ZgKitapDurumu.ScrollMinY2 = 0D;
            this.ZgKitapDurumu.Size = new System.Drawing.Size(1014, 553);
            this.ZgKitapDurumu.TabIndex = 2;
            this.ZgKitapDurumu.TabStop = false;
            // 
            // Grafikler
            // 
            this.Grafikler.ItemLinks.Add(this.BtnKitapDurum);
            this.Grafikler.ItemLinks.Add(this.BtnTürGrafiği);
            this.Grafikler.Name = "Grafikler";
            this.Grafikler.Text = "Grafikler";
            // 
            // BtnKitapDurum
            // 
            this.BtnKitapDurum.Caption = "Kütüphane Kitap Grafiği";
            this.BtnKitapDurum.Id = 11;
            this.BtnKitapDurum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.BtnKitapDurum.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.BtnKitapDurum.Name = "BtnKitapDurum";
            this.BtnKitapDurum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKitapDurum_ItemClick);
            // 
            // BtnTürGrafiği
            // 
            this.BtnTürGrafiği.Caption = "Tür Grafiği";
            this.BtnTürGrafiği.Id = 12;
            this.BtnTürGrafiği.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.BtnTürGrafiği.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.BtnTürGrafiği.Name = "BtnTürGrafiği";
            this.BtnTürGrafiği.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTürGrafiği_ItemClick);
            // 
            // ZgTürDurumu
            // 
            this.ZgTürDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZgTürDurumu.Location = new System.Drawing.Point(0, 162);
            this.ZgTürDurumu.Name = "ZgTürDurumu";
            this.ZgTürDurumu.ScrollGrace = 0D;
            this.ZgTürDurumu.ScrollMaxX = 0D;
            this.ZgTürDurumu.ScrollMaxY = 0D;
            this.ZgTürDurumu.ScrollMaxY2 = 0D;
            this.ZgTürDurumu.ScrollMinX = 0D;
            this.ZgTürDurumu.ScrollMinY = 0D;
            this.ZgTürDurumu.ScrollMinY2 = 0D;
            this.ZgTürDurumu.Size = new System.Drawing.Size(1014, 553);
            this.ZgTürDurumu.TabIndex = 3;
            this.ZgTürDurumu.Visible = false;
            // 
            // FRMAnamenu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 715);
            this.Controls.Add(this.ZgTürDurumu);
            this.Controls.Add(this.ZgKitapDurumu);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FRMAnamenu";
            this.Ribbon = this.ribbonControl1;
            this.RibbonAlwaysAtBack = false;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnKitaplar;
        private DevExpress.XtraBars.BarButtonItem BtnUyeler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnKitapHareket;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnYazar;
        private DevExpress.XtraBars.BarButtonItem BtnTur;
        private ZedGraph.ZedGraphControl ZgKitapDurumu;
        private DevExpress.XtraBars.BarButtonItem BtnKitapDurum;
        private DevExpress.XtraBars.BarButtonItem BtnTürGrafiği;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Grafikler;
        private ZedGraph.ZedGraphControl ZgTürDurumu;
    }
}

