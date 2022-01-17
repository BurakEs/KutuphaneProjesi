using System;
using Kutuphane.Business;
using Kutuphane.Presentation.Yazarlar;
using Kutuphane.Presentation.Turler;
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
    public partial class FRMKitapEkle : DevExpress.XtraEditors.XtraForm
    {
        public int GuncellemeId,GuncellemeKontrol;

        public FRMKitapEkle()
        {
            InitializeComponent();
        }

        private void FRMKitapEkle_Load(object sender, EventArgs e)
        {
            if (GuncellemeKontrol == 1)
            {
                this.Text = "Kitap Güncelleme ";
                this.labelControl1.Text = "Kitap Güncelleme";
                this.BtnKaydet.Text = "Güncelle";
             IKitap Kitap1 = new Kitap();

             var SeciliIdBilgileri = Kitap1.KitapListesi("select KtpId,KitapAdi,YazarAdi,TurAdi,BasimYeri,SayfaSayisi,Durum,Kitaplar.Acıklama from Kitaplar,Yazarlar,Turler where Kitaplar.TuruId=Turler.Id And Yazarlar.Id=Kitaplar.YazarId And KtpId=" + GuncellemeId + "");
                foreach (var item in SeciliIdBilgileri)
                {
                    TxtKitapadi.Text = item.KitapAdi;
                    CmbYazarAdi.DisplayMember = item.YazarAdi;
                    CmbTurAdi.DisplayMember = item.TurAdi;
                    TxtBasimYeri.Text = item.BasimYeri;
                    TxtSayfaSayisi.Text = item.SayfaSayisi.ToString();
                    TglSwDurum.EditValue = Convert.ToBoolean(item.Durum);
                    TxtAciklama.Text = item.Acıklama;
                }
            }

            YazarSecme();
            TurSecme();
        }

        public void YazarSecme()
        {
            IYazar Yazar = new Yazar();
            var sonuc = Yazar.YazarListesi("select * from Yazarlar");
            CmbYazarAdi.DataSource = sonuc;
            CmbYazarAdi.ValueMember = "Id"; //Asıl Değer
            CmbYazarAdi.DisplayMember = "YazarAdi"; //Görünen
         }
        public void TurSecme()
        {
            ITur Tura = new Tur();
            var sonuc1 = Tura.TurListesi("select * from Turler");
            CmbTurAdi.DataSource = sonuc1;
            CmbTurAdi.ValueMember = "Id";
            CmbTurAdi.DisplayMember = "TurAdi";
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(GuncellemeKontrol == 1)
            {
                #region Kitap Güncelleme
                if (TxtKitapadi.Text != "" && TxtBasimYeri.Text != "" && TxtSayfaSayisi.Text != "" && TxtAciklama.Text != "")
                {
                    IKitap Kitap1 = new Kitap();
                    Kitap1.Güncelle("update Kitaplar set KitapAdi = '" + TxtKitapadi.Text + "', YazarId = " + CmbYazarAdi.SelectedValue + ", TuruId = " + CmbTurAdi.SelectedValue + ", BasimYeri='" + TxtBasimYeri.Text + "', SayfaSayisi = " + TxtSayfaSayisi.Text + ", Durum = " + TglSwDurum.EditValue + ", Acıklama = '" + TxtAciklama.Text + "' where KtpId=" + GuncellemeId + "");
                    MessageBox.Show("Güncelleme işlemi başarı ile gerçekleşti", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Boş alan Bırakmayınız");
                }
                #endregion

            }
            else
            {
                #region Kitap Ekleme
                if (TxtKitapadi.Text != "" && TxtBasimYeri.Text != "" && TxtSayfaSayisi.Text != "" && TxtAciklama.Text != "")
                {
                              IKitap Kitap1 = new Kitap();
                              Kitap1.Ekle("insert into Kitaplar (KitapAdi,YazarId,TuruId,BasimYeri,SayfaSayisi,Durum,Acıklama) values ('" + TxtKitapadi.Text + "'," + CmbYazarAdi.SelectedValue + "," + CmbTurAdi.SelectedValue + ",'" + TxtBasimYeri.Text + "','" + TxtSayfaSayisi.Text + "'," + TglSwDurum.EditValue + ",'" + TxtAciklama.Text + "')");
                              MessageBox.Show( TxtKitapadi.Text + " İsimli Kitap Başarı ile Kaydedilmiştir.");
                              DialogResult secim = MessageBox.Show("Kayıt işlemine Devam etmek istermisiniz ?","Kitap Ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                              if (secim == DialogResult.Yes)
                                    {
                    
                                        TxtKitapadi.Text = "";
                                        TxtBasimYeri.Text = "";
                                        TxtSayfaSayisi.Text = "";
                                        TxtAciklama.Text = "";
                                        TglSwDurum.EditValue = false;
                                    }
                                else if (secim == DialogResult.No)
                                   {
                                       this.Close();
                                       GuncellemeKontrol = 0;
                                  }
                        }
                    else
                    {
                        if (TxtKitapadi.Text == "")
                        { MessageBox.Show("Kitap Adı Boş Bırakılamaz."); }
                        if (TxtBasimYeri.Text == "")
                        { MessageBox.Show("Basım Yeri Boş Bırakılamaz."); }
                        if (TxtSayfaSayisi.Text == "")
                        { MessageBox.Show("Sayfa Sayısı Boş Bırakılamaz."); }
                        if (TxtAciklama.Text == "")
                        { MessageBox.Show("Açıklama Satırı Boş Bırakılamaz."); }
                    }
                #endregion
            }
          
        }

        private void textEdit4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar); //Sadece String Girişi
        }

        private void textEdit5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Sadece Sayı girişi.
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnYazarEkle_Click(object sender, EventArgs e)
        {
            FRMYazarEkle YazarEkle = new FRMYazarEkle();
            YazarEkle.ShowDialog();
            YazarSecme();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FRMTurEkle TurEkle = new FRMTurEkle();
            TurEkle.ShowDialog();
            TurSecme();
        }

  
    }
}