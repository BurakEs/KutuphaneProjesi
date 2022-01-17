using Kutuphane.Business;
using Kutuphane.Business.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kutuphane.Presentation.Kitaplar
{
    public partial class FRMKitap : DevExpress.XtraEditors.XtraForm
    {
        IKitap Kitap1;

        public FRMKitap()
        {
            InitializeComponent();
            KitaplistesiGöster();

            
        }
        
               #region Kitap İşlemleri

        public void KitaplistesiGöster()
        {
            int saniye = 1;                                             // Veri Listeleme işleminde veri işlenemediği için göstermiyordu.
            saniye = ((saniye + Convert.ToInt32(DateTime.Now.Second)) % 60); // 1 saniyelik bir delay konuldu programa.
            for (; ; ) { if (saniye == DateTime.Now.Second) break; } 
            Kitap1 = new Kitap(); //Veritabanı veri çekme işlemi.
            var sonuc = Kitap1.KitapListesi("select KtpId,KitapAdi,YazarAdi,TurAdi,BasimYeri,SayfaSayisi,Durum,Kitaplar.Acıklama from Kitaplar,Yazarlar,Turler where Kitaplar.TuruId=Turler.Id And Yazarlar.Id=Kitaplar.YazarId");
            GridKontKitap.DataSource = sonuc;  
        }



        #endregion

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FRMKitapEkle ekle = new FRMKitapEkle();
            ekle.ShowDialog(); // KitapEkle formu açılıyor.
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int Secilenid = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(ID)); // Seçili SATIR Id bilgisi çekiliyor.
            FRMKitapEkle Gnclme = new FRMKitapEkle(); //Çekilen bilgi diğer forma göndermek için diğer formda global tanımlanıp burdan erişiliyor.
            Gnclme.GuncellemeId = Secilenid;
            Gnclme.GuncellemeKontrol = 1; // Güncelleme mi yoksa Eklememi Kontrol Tek form kullanmak için bir yöntem.
            Gnclme.ShowDialog();
            KitaplistesiGöster();
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int Secilenid = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(ID)); // Seçili SATIR Id bilgisi çekiliyor.
            var SecilenKitap = gridKitap.GetFocusedRowCellValue(Kitap); // Seçili SATIR KitapAdi bilgisi çekiliyor.
            IKitap Kitap1 = new Kitap();
            DialogResult secim = MessageBox.Show( SecilenKitap.ToString() + " bu kitabı silmek istediğinize eminmisiniz", "Kitap Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes) //Message box ile uyarılıp onaylatma işlemi.
            { Kitap1.Sil("Delete From Kitaplar where KtpId=" + Secilenid + ""); MessageBox.Show("Silme İşlemi Başarı ile Gerçekleşti."); } // Sql Sorgu silme işlemi.
            else 
            {
                MessageBox.Show("Silme İşlemi iptal edildi.");
            }
            KitaplistesiGöster();

        }



        private void gridKitap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) //Tıklanan Satır ı Button Text e aktarmak için bir işlem.
        {
            string Kitapadi = Convert.ToString(gridKitap.GetFocusedRowCellValue(Kitap)); // Seçili SATIR kİTAPADİ bilgisi çekiliyor.
            BtnTakip.Text = Kitapadi + " isimli Kitap Geçmişi";
        }

        private void BtnTakip_Click(object sender, EventArgs e) 
        {
            FRMKitapBazlıArama AranacakId = new FRMKitapBazlıArama();
            AranacakId.kitapid = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(ID)); //Seçili Satır ıd çek ve diğer forma aktar.
            AranacakId.ShowDialog();
        }



    }
}