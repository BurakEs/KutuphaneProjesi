using Kutuphane.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Kutuphane.Business.DataTransferObject;

namespace Kutuphane.Business
{
    public class KitapHareket : IKitapHareket
    {
        Baglanti bag = new Baglanti();
        Command cmd = new Command();

        public void Ekle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Sil(string SorguCümlesi)
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        } //Gelen Sorguyu işleme aşaması.

        public void Güncelle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public List<DataTransferObject.KitapHareketDTO> KitapHareketListesi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<KitapHareketDTO> khdto = new List<KitapHareketDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read())
            {


                khdto.Add(new KitapHareketDTO //Listeye ekleme işlemi.
                {
                    KhId = Convert.ToInt32(Okuyucu["KhId"]),
                    UyeId = Convert.ToInt32(Okuyucu["UyeId"]),
                    KtpId = Convert.ToInt32(Okuyucu["KtpId"]),
                    Adi =Okuyucu["Adi"].ToString(),
                    SoyAdi = Okuyucu["SoyAdi"].ToString(),
                    KitapAdi = Okuyucu["KitapAdi"].ToString(),
                    VerilisTarihi = Convert.ToDateTime(Okuyucu["VerilisTarihi"]),
                    VerilisSuresi = Convert.ToInt32(Okuyucu["VerilisSuresi"]),
                    TeslimTarihi = (Okuyucu["TeslimTarihi"] == DBNull.Value) ? (DateTime?)null :Convert.ToDateTime(Okuyucu["TeslimTarihi"]),
                    Aciklama = Okuyucu["Aciklama"].ToString()
                });
            }
            bag.baglantiKapat();
            return khdto;
            throw new NotImplementedException();
        }
    }
}
