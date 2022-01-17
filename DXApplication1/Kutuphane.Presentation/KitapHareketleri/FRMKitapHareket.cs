using System;
using System.Collections.Generic;
using Kutuphane.Business;
using Kutuphane.Business.DataTransferObject;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kutuphane.Presentation.KitapHareketleri
{
    public partial class FRMKitapHareket : DevExpress.XtraEditors.XtraForm
    {
      
        public FRMKitapHareket()
        {
            InitializeComponent();
            KitapHlistesiGöster();
            
        }
        public void KitapHlistesiGöster()
        {
            int saniye = 1;                                             // Veri Listeleme işleminde veri işlenemediği için göstermiyordu.
            saniye = ((saniye + Convert.ToInt32(DateTime.Now.Second)) % 60); // 1 saniyelik bir delay konuldu programa.
            for (; ; ) { if (saniye == DateTime.Now.Second) break; } 
            IKitapHareket KitapH = new KitapHareket(); // VERİTABANINDAN VERİ ÇEKİLİYR.
            var sonuc = KitapH.KitapHareketListesi("select KhId,Uyeler.UyeId,KtpId,Uyeler.Adi,Uyeler.SoyAdi,Kitaplar.KitapAdi,VerilisTarihi,VerilisSuresi,TeslimTarihi,KitapHareket.Aciklama from Uyeler,KitapHareket,Kitaplar where KitapHareket.UyeId=Uyeler.UyeId And KitapHareket.KitapId=KtpId");
            GridKontKitapH.DataSource = sonuc; //GRİDWİEV DE LİSTELENİYOR.
        }

        private void BtnKtpVer_Click(object sender, EventArgs e)
        {
            FRMKitapVerİslem islemyap = new FRMKitapVerİslem();
            islemyap.ShowDialog();
             KitapHlistesiGöster();   
        }

        private void BtnKtpAl_Click(object sender, EventArgs e)
        {
            FRMKitapAlislem KitapAL = new FRMKitapAlislem();
            KitapAL.GelenSecimİd = Convert.ToInt32(gridKitapH.GetFocusedRowCellValue(ID)); // Diğer forma seçili id yollanıyor
            KitapAL.kacgünGecikti = Convert.ToInt32(gridKitapH.GetFocusedRowCellValue(ColKacgunGecıktı)); // Diğer forma gecikme süresi yollanıyor.
            KitapAL.ShowDialog();
            KitapHlistesiGöster();
            
        }

        private void gridKitapH_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            string durum = Convert.ToString(gridKitapH.GetRowCellValue(e.RowHandle, Coldurumu)); //Durum Texti Çekiliyor.GridWiev den
            if (durum.Contains("TESLİM ALINDI")) //Text içinde arama yapılıyor(karşılaştırma.) .Geri dönen değer True-FALSE
            {
                e.Appearance.BackColor = Color.LimeGreen; // Satır Boyaması yapılıyor.
            }
            if (durum.Contains("Bugün Teslim Edilecek"))
            {
                e.Appearance.BackColor = Color.DarkGoldenrod;
            }
            if (durum.Contains("Gün içinde Teslim Edilecek"))
            {
                e.Appearance.BackColor = Color.Yellow;
            }
            if (durum.Contains("Gün Gecikti."))
            {
                e.Appearance.BackColor = Color.Red;
            }
        }


    }
}