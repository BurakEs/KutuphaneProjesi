using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.DataTransferObject
{
    public class KitapHareketDTO //Veri Tabanındaki Kolon isimlerinin (Join işlemlerinde kullandıklarımda dahil olmak üzere) tek tek property olarak tanımlanması.
    {
        public int KhId { get; set; }
        public int UyeId { get; set; }
        public int KtpId { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string KitapAdi { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public int VerilisSuresi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public string Aciklama { get; set; }
        //public virtual UyeDTO Uye { get; set; } //Yapmaya çalıştım ama olmadı.Olsa idi burda sadece 1 tane tablodaki sutun isimleri olacak joinledilediğim diğer tablolar olmayacaktı.
       // public virtual KitapDTO Kitap { get; set; }
    }
}
