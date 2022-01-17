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
    public class Tur : ITur
    {
        Baglanti bag = new Baglanti();
        Command cmd = new Command();

        public void Ekle(string SorguCümlesi)
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi); //Gelen Sorguyu işleme aşaması.
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Sil(string SorguCümlesi)
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi); //Gelen Sorguyu işleme aşaması.
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Güncelle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        { 
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public List<DataTransferObject.TurDTO> TurListesi(string SorguCümlesi)
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader();
            List<TurDTO> trdto = new List<TurDTO>();
            while (Okuyucu.Read())
            {


                trdto.Add(new TurDTO
                {
                    Id = Convert.ToInt32(Okuyucu["Id"]),
                    TurAdi = Okuyucu["TurAdi"].ToString()
                });
            }
            bag.baglantiKapat();
            return trdto;
            throw new NotImplementedException();
        }
        public List<DataTransferObject.TurDTO> TurSayisi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        { 
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader();//Okumak için datareader dan bir nesne oluşturuyoruz.
            List<TurDTO> trdto = new List<TurDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read())
            {


                trdto.Add(new TurDTO //Listeye ekleme işlemi.
                {
                    Id = Convert.ToInt32(Okuyucu["Id"]),
                    TurAdi = Okuyucu["TurAdi"].ToString()
                });
            }
            bag.baglantiKapat();
            return trdto;
            throw new NotImplementedException();
        }
    }
}
