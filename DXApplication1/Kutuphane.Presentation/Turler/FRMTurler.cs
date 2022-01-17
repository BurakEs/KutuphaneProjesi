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
    public partial class FRMTurler : DevExpress.XtraEditors.XtraForm
    {
        public FRMTurler()
        {
            InitializeComponent();
        }
        public void TurlistesiGöster()
        {
            ITur Turler = new Tur(); // Veritabanı veri çekme işlemi.
            var sonuc = Turler.TurListesi("Select * from Turler");
            GridKontKitap.DataSource = sonuc;
        }

        private void FRMTurler_Load(object sender, EventArgs e)
        {
            TurlistesiGöster();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FRMTurEkle ekle = new FRMTurEkle(); // Ekleme formu çağırma.
            ekle.ShowDialog();
            TurlistesiGöster();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int Secilenid = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(ID)); //Seçili Satır ı diğer forma göndermek için değişken aktarımı.
            FRMTurEkle Gnclme = new FRMTurEkle();
            Gnclme.GuncellemeId = Secilenid;
            Gnclme.GuncellemeKontrol = 1;
            Gnclme.ShowDialog();
            TurlistesiGöster();
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int Secilenid = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(ID)); //Seçili satır İd bilgisi.
            var SecilenTur= gridKitap.GetFocusedRowCellValue(TurAdı); //Seçili SATIR TÜR ADİ ÇEKME İŞLEMİ.
            ITur Turler = new Tur();
            DialogResult secim = MessageBox.Show(SecilenTur.ToString() + " bu türü silmek istediğinize eminmisiniz", "Tür Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes)
            { Turler.Sil("Delete From Turler where Id=" + Secilenid + ""); MessageBox.Show("Silme İşlemi Başarı ile Gerçekleşti."); }
            else
            {
                MessageBox.Show("Silme İşlemi iptal edildi.");
            }
            TurlistesiGöster();
        }
    }
}