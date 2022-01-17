using System;
using Kutuphane.Business;
using Kutuphane.Business.DataTransferObject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kutuphane.Presentation.Uyeler
{
    public partial class FRMUyeler : DevExpress.XtraEditors.XtraForm
    {
        IUye Uyeler;
        public FRMUyeler()
        {
            InitializeComponent();
            UyeListesiGoster();
        }
        #region Uye İşlemleri

        public void UyeListesiGoster() //veri çekme işlemi.
        {
            Uyeler = new Uye();
            var sonuc = Uyeler.UyeListesi("select * from Uyeler");
            GridKontUye.DataSource = sonuc;
        
        }
        #endregion

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FRMUyeEkle fUyeEKle = new FRMUyeEkle(); 
            fUyeEKle.ShowDialog();
            UyeListesiGoster();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int SecilenId = Convert.ToInt32( gridUye.GetFocusedRowCellValue(ID)); //seçili satır id yollama.
            FRMUyeEkle Gnclm = new FRMUyeEkle();
            Gnclm.Secilenid = SecilenId;
            Gnclm.GuncellemeKontrol = 1;
            Gnclm.ShowDialog();
            UyeListesiGoster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int Secilenid = Convert.ToInt32(gridUye.GetFocusedRowCellValue(ID)); //Seçili satır id çekme.
            var SecilenUye = gridUye.GetFocusedRowCellValue(TcKimlikNo); //Seçili satir UyeTcNo çekme.
            IUye Uyeler = new Uye();
            DialogResult secim = MessageBox.Show(SecilenUye.ToString() + " Tcli kişiyi silmek istediğinize Eminmisiniz ?", "Üye Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes)
            { Uyeler.Sil("Delete From Uyeler where UyeId=" + Secilenid + ""); MessageBox.Show("Silme İşlemi Başarı ile Gerçekleşti."); } //Veritabanından silme işlemi Sorgusu.
            else
            {
                MessageBox.Show("Silme İşlemi iptal edildi.");
            }
            UyeListesiGoster();
        }

        private void gridUye_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string ÜyeAdi = Convert.ToString(gridUye.GetFocusedRowCellValue(Adı)); //Seçilen satır adını buton a verme.
            BtnTakip.Text = ÜyeAdi + " isimli Üye Geçmişi";
        }

        private void BtnTakip_Click(object sender, EventArgs e)
        {
            FRMUyeBazlıArama AranacakId = new FRMUyeBazlıArama();
            AranacakId.Uyeıd = Convert.ToInt32(gridUye.GetFocusedRowCellValue(ID)); //Seçili satır id yi diğer forma geçirme.
            AranacakId.ShowDialog();
        }

    }
}