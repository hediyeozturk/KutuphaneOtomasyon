using Kutuphane.ENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.BL.Repository
{
    public class UyeRepo : RepositoryBase<Uye, int> { }
    public class KitapRepo : RepositoryBase<Kitap, int> { }
    public class YazarRepo : RepositoryBase<Yazar, int> { }
    public class KategoriRepo : RepositoryBase<Kategori, int> { }
    public class OduncRepo : RepositoryBase<Odunc, int> { }
}
