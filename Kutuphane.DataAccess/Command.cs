using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Kutuphane.DataAccess
{
    public class Command
    {
        Baglanti baglanti = new Baglanti();
        public OleDbCommand command(string SorguCümlesi) //Sorgu cümleleri için bağlantı açma ve işleme.
        {
            OleDbCommand cmd = new OleDbCommand(SorguCümlesi, baglanti.baglantiac());
            return cmd;
        }
    }
}
