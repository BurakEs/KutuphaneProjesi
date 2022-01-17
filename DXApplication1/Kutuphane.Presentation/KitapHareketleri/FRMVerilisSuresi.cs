using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Kutuphane.Presentation.KitapHareketleri
{
    public partial class FRMVerilisSuresi : DevExpress.XtraEditors.XtraForm
    {
        public FRMVerilisSuresi()
        {
            InitializeComponent();
        }

        private void TxtVerilisSüresi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtVerilisSüresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // Sadece Sayı girişi.
        } 
    }
}