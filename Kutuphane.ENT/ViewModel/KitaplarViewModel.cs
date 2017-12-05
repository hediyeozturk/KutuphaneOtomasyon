using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.ViewModel
{
    public class KitaplarViewModel
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public bool Rafta { get; set; }
        public string KategoriAd { get; set; }
    }
}
