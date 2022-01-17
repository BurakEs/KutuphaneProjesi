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

namespace Kutuphane.Presentation.Turler
{
    public partial class FRMTurEkle : DevExpress.XtraEditors.XtraForm
    {
        public int GuncellemeId, GuncellemeKontrol;
        public FRMTurEkle()
        {
            InitializeComponent();
        }

        private void FRMTurEkle_Load(object sender, EventArgs e)
        {
            if (GuncellemeKontrol == 1) //Düzenleme mi eklememi Tek formda label ve buton textleri değiştirerek kullanma.
            {
                this.Text = "Tur Güncelleme ";
                this.labelControl1.Text = "Tur Güncelleme";
                this.BtnKaydet.Text = "Güncelle";
                ITur Turler = new Tur();

                var SeciliIdBilgileri = Turler.TurListesi("select * from Turler where Turler.Id="+GuncellemeId+""); //Veri Çekme işlemi.
                foreach (var item in SeciliIdBilgileri)
                {
                    TxtTurAdi.Text = item.TurAdi; 
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (GuncellemeKontrol == 1)
            {
                #region Tur Güncelleme
                if (TxtTurAdi.Text != "" )
                {
                    ITur Turler = new Tur();
                    Turler.Güncelle("update Turler set TurAdi = '" + TxtTurAdi.Text + "' where Id=" + GuncellemeId + ""); 
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
                #region Tur Ekleme
                if (TxtTurAdi.Text != "")
                {
                    ITur Turler = new Tur();
                    Turler.Ekle("insert into Turler (TurAdi) values ('" + TxtTurAdi.Text + "')");
                    MessageBox.Show(TxtTurAdi.Text + " İsimli Tur Başarı ile Kaydedilmiştir.");
                    DialogResult secim = MessageBox.Show("Kayıt işlemine Devam etmek istermisiniz ?", "Tur Ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secim == DialogResult.Yes)
                    {

                        TxtTurAdi.Text = "";
                       
                    }
                    else if (secim == DialogResult.No)
                    {
                        this.Close();
                        GuncellemeKontrol = 0;
                    }
                }
                else
                {
                    if (TxtTurAdi.Text == "")
                    { MessageBox.Show("Tur Adı Boş Bırakılamaz."); }

                }
                #endregion
            }
          
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}