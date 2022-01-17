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
    public class Uye : IUye
    {
        Baglanti bag = new Baglanti();
        Command cmd = new Command();

        public void Ekle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Sil(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Güncelle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public List<DataTransferObject.UyeDTO> UyeListesi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<UyeDTO> uyedto = new List<UyeDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read())
            {


                uyedto.Add(new UyeDTO //Listeye ekleme işlemi.
                {
                    UyeId = Convert.ToInt32(Okuyucu["UyeId"]),
                    TcKimlikNo = Okuyucu["TcKimlikNo"].ToString(),
                    Adi = Okuyucu["Adi"].ToString(),
                    SoyAdi = Okuyucu["SoyAdi"].ToString(),
                    KayıtTarihi = Convert.ToDateTime(Okuyucu["KayıtTarihi"]),
                    Borc = Convert.ToInt32(Okuyucu["Borc"]),
                    Aciklama = Okuyucu["Aciklama"].ToString()
                });
            }
            bag.baglantiKapat();
            return uyedto;
            throw new NotImplementedException();
        }
    }
}
