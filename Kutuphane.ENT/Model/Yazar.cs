﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.Model
{
    public class Yazar : BaseModel
    {
        [Required(ErrorMessage ="Bu alan zorunludur")]
        public string YazarAdi { get; set; }
        public long? Aciklama { get; set; }

        public virtual List<Kitap> Kitaplar { get; set; } = new List<Kitap>();
    }
}
