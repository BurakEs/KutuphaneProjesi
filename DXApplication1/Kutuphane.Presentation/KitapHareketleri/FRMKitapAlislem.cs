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
    public partial class FRMKitapAlislem : DevExpress.XtraEditors.XtraForm
    {
        public FRMKitapAlislem()
        {
            InitializeComponent();
        }

        public int GelenSecimİd,kacgünGecikti,KitapId,UyeId,borc; //Diğer formlardan gelecek olan değerler için global public değişkenler.

        private void FRMKitapAlislem_Load(object sender, EventArgs e)
        {
            IKitapHareket KitapAl = new KitapHareket(); // Seçili gelen satır için satır bilgileri çekiliyor
            var SatırBilgisi = KitapAl.KitapHareketListesi("select KhId,Uyeler.UyeId,KtpId,Uyeler.Adi,Uyeler.SoyAdi,Kitaplar.KitapAdi,VerilisTarihi,VerilisSuresi,TeslimTarihi,KitapHareket.Aciklama from KitapHareket,Uyeler,Kitaplar where KitapHareket.UyeId=Uyeler.UyeId AND KitapHareket.KitapId=KtpId   AND KhId=" + GelenSecimİd + "");
            foreach (var item in SatırBilgisi) // Gelen veri işleniyor ve textboxlara ve değişkenlere atanıyor.
            {
                KitapId = item.KtpId;
                UyeId = item.UyeId;
                TxtKitapAdi.Text = item.KitapAdi;
                TxtUyeadi.Text = item.Adi;
                TxtUyeSoy.Text = item.SoyAdi;
                DtVerilisTarihi.Value = item.VerilisTarihi;
                TxtVerilisSure.Text = item.VerilisSuresi.ToString();
            }
           
            label6.Text = TxtKitapAdi.Text + " isimli kitabı";
            label7.Text = TxtUyeadi.Text + " " + TxtUyeSoy.Text + " isimli Uyeden " + CalenderVerilis.DateTime.Date.ToString("d") + " \n Tarihinde teslim aldığınızı Onaylıyormusunuz ? ";
            if (kacgünGecikti <= 0) // kaçgüngecikti devexpress in GridControl Özelliği ile gridwiev de hesaplanan hazır bir değer.
            {
                TxtBorc.Text = "Bu Kitap Zamanında Teslim Edildi."; //
                label10.Text = "Bu Kitap Zamanında Teslim Edildi.";
                TxtBorc.ReadOnly = true; // sadece okunabilir yapıyoruz. Çünkü borç yok.

            }
            else
            {
                TxtBorc.ReadOnly = false;
                label10.Text = Math.Abs(kacgünGecikti) + " Gün Gecikti.";
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            label10.Visible = false; //Label in tıklanınca gizlenmesi için.
        }

        private void TxtBorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // Sadece Sayı Girişi
        }

        private void BtnOnay_Click(object sender, EventArgs e)
        {
            if (TxtBorc.Text == "" || RtZamanDeger.Rating == 0) //Txt in ve yıldızların kontrol ü.
            {
                MessageBox.Show("Girdiğiniz Borç Değerinde yada Değerlendirmenizde bir hata mevcut", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IKitap KAlKitap = new Kitap();
                IKitapHareket KAlKitapH = new KitapHareket();
                IUye KAlUye = new Uye();
                KAlKitap.Güncelle("update Kitaplar set Durum = " + true + " where KtpId=" + KitapId + ""); //Verilen kitapın Durum u true oluyor.Tekrar Verilebilsin Diye.
                if (TxtBorc.Text != "Bu Kitap Zamanında Teslim Edildi.") // Sebebi : Borc u olan birinin daha önceki borc değeri çekilip verilen borcla toplansın .
                {
                    var borcgetir = KAlUye.UyeListesi("Select * from Uyeler where  UyeId="+ UyeId +"");
                    foreach (var item in borcgetir)
                    {
                        borc = item.Borc;
                    }
                    IUye KAlUyeGuncelle = new Uye(); // Oluşturmassam bağlantı açık kalıyor ve sıkıntıya düşüyor
                    KAlUyeGuncelle.Güncelle("update Uyeler set Borc=" + (borc + Convert.ToInt32(TxtBorc.Text)) + " where UyeId=" + UyeId + "");
                }
                KAlKitapH.Güncelle("update KitapHareket set TeslimTarihi='"+ CalenderVerilis.DateTime.ToString("d") +"' where KhId=" + GelenSecimİd + ""); // Son olarak kitap harekete teslim tarihi işleniyor.
                MessageBox.Show("Kitap Başarı ile Teslim alındı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}