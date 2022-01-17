using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.DataTransferObject
{
    public class UyeDTO //Veri Tabanındaki Kolon isimlerinin (Join işlemlerinde kullandıklarımda dahil olmak üzere) tek tek property olarak tanımlanması.
    {
        public int UyeId { get; set; }
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public DateTime KayıtTarihi { get; set; }
        public int Borc { get; set; }
        public string Aciklama { get; set; }
    }
}
