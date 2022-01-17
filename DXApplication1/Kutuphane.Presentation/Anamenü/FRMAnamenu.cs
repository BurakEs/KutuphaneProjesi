using System;
using Kutuphane.Presentation.Kitaplar;
using Kutuphane.Presentation.Yazarlar;
using Kutuphane.Presentation.Uyeler;
using Kutuphane.Presentation.Turler;
using Kutuphane.Presentation.KitapHareketleri;
using Kutuphane.Business;
using Kutuphane.Business.DataTransferObject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Kutuphane.Presentation
{
    public partial class FRMAnamenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRMAnamenu()
        {
            InitializeComponent();
            ZgTürDurumu.Visible = false;
            KitapGrafik(ZgKitapDurumu);
            ZgKitapDurumu.Visible = true;
        }

        private void BtnKitaplarItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            #region Graphları Temizleme  
            ZgKitapDurumu.GraphPane.CurveList.Clear(); //Temizlenmezse Değerler birbirine ekleniyor her tıklamada
            ZgKitapDurumu.GraphPane.GraphObjList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            #endregion

            ZgTürDurumu.Visible = false;
            ZgKitapDurumu.Visible = false;
            FRMKitap Kitaplar = new FRMKitap();
            Kitaplar.MdiParent = this;
            Kitaplar.Show();
        }

        private void BtnUyeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Graphları Temizleme
            ZgKitapDurumu.GraphPane.CurveList.Clear(); //Temizlenmezse Değerler birbirine ekleniyor her tıklamada
            ZgKitapDurumu.GraphPane.GraphObjList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            #endregion

            ZgTürDurumu.Visible = false; //GRAFİKLERİ GİZLE
            ZgKitapDurumu.Visible = false; //GRAFİKLERİ GİZLE
            FRMUyeler Uyeler = new FRMUyeler(); //Formdan nsne üret
            Uyeler.MdiParent = this; // Parent ayarla
            Uyeler.Show(); // ve göster.
        }

        private void BtnYazar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Graphları Temizleme
            ZgKitapDurumu.GraphPane.CurveList.Clear(); //Temizlenmezse Değerler birbirine ekleniyor her tıklamada
            ZgKitapDurumu.GraphPane.GraphObjList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            #endregion

            ZgTürDurumu.Visible = false;
            ZgKitapDurumu.Visible = false;
            FRMYazarlar Yazarlar = new FRMYazarlar();
            Yazarlar.MdiParent = this;
            Yazarlar.Show();
        }

        private void BtnTur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Graphları Temizleme
            ZgKitapDurumu.GraphPane.CurveList.Clear(); //Temizlenmezse Değerler birbirine ekleniyor her tıklamada
            ZgKitapDurumu.GraphPane.GraphObjList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            #endregion

            ZgTürDurumu.Visible = false;
            ZgKitapDurumu.Visible = false;
            FRMTurler Turler = new FRMTurler();
            Turler.MdiParent = this;
            Turler.Show();
        }

        private void BtnKitapHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Graphları Temizleme
            ZgKitapDurumu.GraphPane.CurveList.Clear(); //Temizlenmezse Değerler birbirine ekleniyor her tıklamada
            ZgKitapDurumu.GraphPane.GraphObjList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            #endregion

            ZgTürDurumu.Visible = false;
            ZgKitapDurumu.Visible = false;
            FRMKitapHareket KitapH = new FRMKitapHareket();
            KitapH.MdiParent = this;
            KitapH.Show();
        }

        private void BtnKitapDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            #region Graphları Temizleme
            ZgKitapDurumu.GraphPane.CurveList.Clear(); //Temizlenmezse Değerler birbirine ekleniyor her tıklamada
            ZgKitapDurumu.GraphPane.GraphObjList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            #endregion

            KitapGrafik(ZgKitapDurumu);
            ZgTürDurumu.Visible = false;
            ZgKitapDurumu.Visible = true;
        }

        private void KitapGrafik(ZedGraphControl zg1)
        {
          


            GraphPane DurumGrafik = zg1.GraphPane;

            // Set the pane title
            DurumGrafik.Title.Text = "Kütüphanedeki Kitap Durumu";

            // Enter some data values

            Double[] kitapsayiları = new Double[2]; // Durum True ve false olduğu için 2 değerin toplam sayisi
            IKitap KitapSay = new Kitap(); // Veritabanından veri çekme işlemi.
            var sayilar = KitapSay.KitapSayisi("Select COUNT(Durum) as Sayi from Kitaplar GROUP BY Durum");
            int i = 0;
            foreach (var item in sayilar) // Veriyi diziye işleme
            {
                kitapsayiları[i] = item.Sayisi;
                i++;
            }


            Color[] colors = { Color.Red, Color.Blue };
            string[] DilimTextleri = { "Kütüphane İçinde", "Kütüphane Dışında" }; 

            // ??
            DurumGrafik.Fill = new Fill(Color.Cornsilk);
            DurumGrafik.Chart.Fill = new Fill(Color.Cornsilk);
            DurumGrafik.Legend.Position = LegendPos.Right;



            // dilimlere gerekli verileri işleme
            PieItem[] dilim = new PieItem[2];
            dilim = DurumGrafik.AddPieSlices(kitapsayiları, DilimTextleri);

            // İSİM TİPLERİNİ % BARINDIRICAK ŞEKİLDE AYARLADIK
            ((PieItem)dilim[0]).LabelType = PieLabelType.Name_Value_Percent;
            ((PieItem)dilim[1]).LabelType = PieLabelType.Name_Value_Percent;




            CurveList DilimDegerTPL = DurumGrafik.CurveList;
            double total = 0;
            for (int x = 0; x < DilimDegerTPL.Count; x++)  // TOPLAM KİTAP SAYISI HESABI.
                total += ((PieItem)DilimDegerTPL[x]).Value;

            // TEXT İŞLEMİ
            TextObj text = new TextObj("Kütüphanede kayıtlarında toplam " + total.ToString() + " kitap mevcut.", 0.79F, 0.25F, CoordType.PaneFraction);
            text.Location.AlignH = AlignH.Center;
            text.Location.AlignV = AlignV.Bottom;
            text.FontSpec.Border.IsVisible = false;
            text.FontSpec.Fill = new Fill(Color.White, Color.PowderBlue, 45F);
            text.FontSpec.StringAlignment = StringAlignment.Center;
            DurumGrafik.GraphObjList.Add(text);

            // ARKAPLAN İŞLEMİ.
            BoxObj box = new BoxObj(0, 0, 1, 1, Color.Empty, Color.PeachPuff);
            box.Location.CoordinateFrame = CoordType.ChartFraction;
            box.Border.IsVisible = false;
            box.Location.AlignH = AlignH.Left;
            box.Location.AlignV = AlignV.Top;
            box.ZOrder = ZOrder.E_BehindCurves;
            DurumGrafik.GraphObjList.Add(box);
            zg1.AxisChange();
        }

        private void BtnTürGrafiği_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Graphları Temizleme
            ZgKitapDurumu.GraphPane.CurveList.Clear(); //Temizlenmezse Değerler birbirine ekleniyor her tıklamada
            ZgKitapDurumu.GraphPane.GraphObjList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            ZgTürDurumu.GraphPane.CurveList.Clear();
            #endregion

            TürGrafik(ZgTürDurumu);
            ZgKitapDurumu.Visible = false;
            ZgTürDurumu.Visible = true;
        }

        private void TürGrafik(ZedGraphControl z1)
        {
            GraphPane DurumGrafik = z1.GraphPane;
            DurumGrafik.Title.Text = "Kütüphanedeki Kitapların Tür Grafiği";




            ITur TurSay = new Tur(); // VERİTABANINDA VERİLERİ ÇEKİP SÖZLÜĞE ATTIK.
            var TurSayiları = TurSay.TurSayisi("Select COUNT(TuruId) as Id,TurAdi from Kitaplar,Turler where Kitaplar.TuruId=Turler.Id GROUP BY TurAdi");
            Dictionary<string, Double> TurSayisi = new Dictionary<string, Double>();

            foreach (var item in TurSayiları)  // GELEN VERİLERİ TEK TEK SÖZLÜĞE EKLEDİK KEY VALUE OLARAK
            {
                TurSayisi.Add(item.TurAdi, item.Id);
            }
            PieItem[] dilim = new PieItem[TurSayisi.Count];  // Sözlük boyutu ile aynı olan 3 dizi yarattık. Dilim Temsil eden dizi
            string[] DilimTextleri = new string[TurSayisi.Count]; // Tür isminin barındıran dizi
            Double[] DilimDeğerleri = new Double[TurSayisi.Count]; // Tür Sayisini Barındıran dizi
            int i = 0;
            foreach (var item in TurSayisi)  // Dizilere gerekli atamalar.
            {
                DilimTextleri[i] = item.Key.ToString();
                DilimDeğerleri[i] = (int)item.Value;
                i++;     
            }

            dilim = DurumGrafik.AddPieSlices(DilimDeğerleri, DilimTextleri); // Dilimlerin oluşturulması
            for (int j = 0; j < TurSayisi.Count; j++)
            {
                
                ((PieItem)dilim[j]).LabelType = PieLabelType.Name_Value_Percent;  // Dilimlerin Yazısına yüzdelik ekleme.

            }
            Color[] colors = { Color.Red, Color.Blue }; // renk dizisi
     

            // ??
            DurumGrafik.Fill = new Fill(Color.Cornsilk);
            DurumGrafik.Chart.Fill = new Fill(Color.Cornsilk);
            DurumGrafik.Legend.Position = LegendPos.Right;







            // Yazının konumu rengi vb şeylerin ayar kısmı
            TextObj text = new TextObj("Kütüphanede kayıtlarında toplam " + i.ToString() + " Tür mevcut.", 0.20F, 0.99F, CoordType.PaneFraction);
            text.Location.AlignH = AlignH.Center;
            text.Location.AlignV = AlignV.Bottom;
            text.FontSpec.Border.IsVisible = false;
            text.FontSpec.Fill = new Fill(Color.White, Color.PowderBlue, 45F);
            text.FontSpec.StringAlignment = StringAlignment.Center;
            DurumGrafik.GraphObjList.Add(text);

            // Arkaplan rnegi vb.
            BoxObj box = new BoxObj(0, 0, 1, 1, Color.Empty, Color.PeachPuff);
            box.Location.CoordinateFrame = CoordType.ChartFraction;
            box.Border.IsVisible = false;
            box.Location.AlignH = AlignH.Left;
            box.Location.AlignV = AlignV.Top;
            box.ZOrder = ZOrder.E_BehindCurves;
            DurumGrafik.GraphObjList.Add(box);
            z1.AxisChange();
           
        }




    }
}
