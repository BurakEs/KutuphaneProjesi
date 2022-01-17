using System;
using System.Collections.Generic;
using Kutuphane.Business;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kutuphane.Presentation.Yazarlar
{
    public partial class FRMYazarEkle : DevExpress.XtraEditors.XtraForm
    {
        public int Secilenid, GuncellemeKontrol = 0;
        public FRMYazarEkle()
        {
            InitializeComponent();
        }

        private void FRMYazarEkle_Load(object sender, EventArgs e)
        {
            if (GuncellemeKontrol == 1)
            {
                this.Text = "Yazar Güncelleme ";
                this.LblYazar.Text = "Yazar Güncelleme";
                this.BtnKaydet.Text = "Güncelle";
                IYazar Yazarlar = new Yazar();

                var SeciliIdBilgileri = Yazarlar.YazarListesi("select * from Yazarlar where Id=" + Secilenid + "");
                foreach (var item in SeciliIdBilgileri)
                {
                    TxtYazarAdi.Text = item.YazarAdi;
                    DateTimeDgmTarihi.Value = item.DogumYili;
                    TxtDogumYeri.Text = item.DogumYeri;
                    TxtAcik.Text = item.Aciklama;
                }
            }
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            if (GuncellemeKontrol == 1)
            {
                #region Yazar Guncelle
                if (TxtYazarAdi.Text != "" && TxtDogumYeri.Text != "" && TxtAcik.Text != "")
                {
                    IYazar Yazar = new Yazar();
                    Yazar.Güncelle("update Yazarlar set YazarAdi = '" + TxtYazarAdi.Text + "', DogumYili = '" + DateTimeDgmTarihi.Value + "', DogumYeri = '" + TxtDogumYeri.Text + "', Aciklama = '" + TxtAcik.Text + "' where Id=" + Secilenid + "");
                    MessageBox.Show("Güncelleme işlemi başarı ile gerçekleşti", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
                }
                #endregion
            }
            else
            {
                #region Yazar Ekleme
                if (TxtYazarAdi.Text != "" && TxtDogumYeri.Text != "" && TxtAcik.Text != "")
                {
                    IYazar Yazar = new Yazar();
                    Yazar.Ekle("insert into Yazarlar (YazarAdi,DogumYili,DogumYeri,Aciklama) values ('" + TxtYazarAdi.Text + "','" + DateTimeDgmTarihi.Value + "','" + TxtDogumYeri.Text + "','" + TxtAcik.Text + "')");
                    MessageBox.Show(TxtYazarAdi.Text + " isimli Kayıt Başarı İle Oluşturulmuştur.");
                    DialogResult secim = MessageBox.Show("Kayıt işlemine Devam etmek istermisiniz ?", "Üye Ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secim == DialogResult.Yes)
                    {
                        TxtYazarAdi.Text = "";
                        DateTimeDgmTarihi.Value = DateTime.Now;
                        TxtDogumYeri.Text = "";
                        TxtAcik.Text = "";

                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    if ((Convert.ToDouble(TxtYazarAdi.Text) <= 1000000000) && (Convert.ToDouble(TxtYazarAdi.Text) >= 99999999999))
                    {
                        MessageBox.Show("Tc Kimlik No 11 Haneden Büyük veya Küçük Olamaz!!!");
                    }
                    else
                    {
                        MessageBox.Show("Tüm Alanları Eksiksiz Doldurunuz.");
                    }
                }
                #endregion
            }
        }

        private void BtnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}