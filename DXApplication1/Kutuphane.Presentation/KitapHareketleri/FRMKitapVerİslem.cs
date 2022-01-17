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
    public partial class FRMKitapVerİslem : DevExpress.XtraEditors.XtraForm
    {
        public FRMKitapVerİslem()
        {
            InitializeComponent();
        }
        private void GridKontKitap_Load(object sender, EventArgs e)
        {
            VerilebilirKitapListesiGörüntüle();
        }

        object SecilenKitap, SecilenUyeAdi, SecilenUyeSoyAdi; //global değişken tanımlamaları
        int SecilenKitapid = -1, SecilenUyeid = -1,KitapSüresi; //global değişken tanımlamaları
        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == pageKitapSec) //Şuanki Sayfa KitapSec ise içeri gir.
            {

                SecilenKitapid = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(ID)); //SECİLİ SATIR İD ÇEKİLİYOR.
                SecilenKitap = gridKitap.GetFocusedRowCellValue(Kitap); // SEÇİLİ SATIR KİTAP ADI ÇEKİLİYOR.
                DialogResult Kitapsecim = MessageBox.Show(SecilenKitap + " isimli Kitapla işleme devam etmek istiyormusunuz", "Kitap Seçme", MessageBoxButtons.YesNo);
                if (Kitapsecim == DialogResult.No) // MESSAGE BOX DAN GELEN DİALOG KONTROL EDİLİYOR.
                {
                    e.Cancel = true;
                }
            }
            if (e.Page == pageUyeSec) // Şuanki Sayfa UyeSec ise içeri gir.
            {
                pageUyeSec.Text = SecilenKitap + " isimli kitabı vermek istediğiniz ÜYE'yi Seçin.";
                UyeListesiGoster();
            }
            if (e.PrevPage == pageUyeSec) // önceki sayfa üyesec ise Daha doğrusu ileriye basıldığında.
            {
                SecilenUyeid = Convert.ToInt32(gridUye.GetFocusedRowCellValue(UyeId)); // SEÇİLİ SATIR UYE İD ÇEKME İŞLEMİ.
                SecilenUyeAdi = gridUye.GetFocusedRowCellValue(Adı); //SEÇİLİ SATIR UYE ADİ ÇEKME İŞLEMİ.
                SecilenUyeSoyAdi = gridUye.GetFocusedRowCellValue(SoyAdı); //SEÇİLİ SATIR UYE Soyadi ÇEKME İŞLEMİ.

                FRMVerilisSuresi sonkontrol = new FRMVerilisSuresi(); //Verilis Süresi için diğer form çağırılıyor.
                sonkontrol.lblSecimSorusu.Text= SecilenKitap + " isimli Kitabı"+" '"+SecilenUyeAdi+" "+SecilenUyeSoyAdi+"' "+"isimli kişiye vermek istiyormusunuz?";
                sonkontrol.ShowDialog();
                if (sonkontrol.DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (sonkontrol.TxtVerilisSüresi.Text == "" )
                    {
                        MessageBox.Show("Lütfen Verilis Süresini Girip Öyle Devam ediniz.");
                        e.Cancel = true;
                    }
                    else
                    {
                        KitapSüresi = Convert.ToInt32(sonkontrol.TxtVerilisSüresi.Text); // Girilen Süre Textboxdan global değişkene alınır.
                    }


                }


            }
        }


       
        public void VerilebilirKitapListesiGörüntüle()
        { 
            IKitap Kitap1 = new Kitap(); //Veritabanı veri çekme işlemi.
            var sonuc = Kitap1.KitapListesi("select KtpId,KitapAdi,YazarAdi,TurAdi,BasimYeri,SayfaSayisi,Durum,Kitaplar.Acıklama from Kitaplar,Yazarlar,Turler where Kitaplar.TuruId=Turler.Id And Yazarlar.Id=Kitaplar.YazarId And Durum=True");
            GridKontKitap.DataSource = sonuc;
        }
        public void UyeListesiGoster()
        {
            IUye Uyeler = new Uye(); //Veritabanı veri çekme işlemi.
            var sonuc = Uyeler.UyeListesi("select * from Uyeler");
            GridKontUye.DataSource = sonuc;

        }
        public void KitapHareketEkle(int kitapid,int uyeid,DateTime verilistarihi,int verilisSüresi,DateTime TslmGrknTarih)
        {
            IKitap Kitap1 = new Kitap(); //Veri Tabanına veri işleme için yazılmış bir fonksiyon.
            Kitap1.Güncelle("update Kitaplar set Durum = " + false + " where KtpId=" + kitapid + "");
            IKitapHareket KitapHareket = new KitapHareket();
            KitapHareket.Ekle("insert into KitapHareket (KitapId,UyeId,VerilisTarihi,VerilisSuresi,Aciklama) values (" + kitapid + "," + uyeid + ",'" + verilistarihi.ToString("d") + "'," + verilisSüresi + ",'Yönetici Tarafından Verilmiştir.')");
        }



        private void CalenderVerilis_DateTimeChanged(object sender, EventArgs e)
        {
            
            CalenderTeslim.DateTime = CalenderVerilis.DateTime.AddDays(KitapSüresi); //Teslim Süresi Verilis+Verilme süresi şeklinde hesaplanıyor.
            lblTarihSec.Visible = false;
            lblzet.Visible = true;
            lbRapor.Text =  SecilenKitap + " isimli kitap " + SecilenUyeAdi + " " + SecilenUyeSoyAdi + " isimli kişiye " + CalenderVerilis.DateTime.ToString("d") + " tarihinde "+KitapSüresi+" gün süreyle,\n" + CalenderTeslim.DateTime.ToString("d") + " tarihinde getirilmek şartıyla teslim edilecektir.\n          İşlemi Kaydetmek için KAYDET butonuna Basınız.           ";
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e) //WizarControl isimli Tool için Finish Butonu Click Eventi Yazılıyor
        {
            if (lblTarihSec.Visible == false) //Kontrol için DateTime değiştiğinde değişen Visible değeri kullanılıyor
            {
                KitapHareketEkle(SecilenKitapid, SecilenUyeid,CalenderVerilis.DateTime, KitapSüresi, CalenderTeslim.DateTime);
                this.Close();
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Lütfen Tarih Seçimi Yapınız.", "Tarih Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e) //Wizar Control İsimli Tool için Cancel Click Eventi Yazılıyor.
        {
         DialogResult islem = MessageBox.Show("İşlemi İptal etmek istediğinize eminmisinz ?","İşlem İptali",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
         if (islem== DialogResult.Yes)
         {
             this.Close();
         }
        }


    }
 }