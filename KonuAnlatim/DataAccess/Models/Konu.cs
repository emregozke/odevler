using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Konu
    {
        public Konu()
        {
            Ogrencis = new HashSet<Ogrenci>();
        }

        public int KonuId { get; set; }
        public string KonuAdi { get; set; }

        public virtual ICollection<Ogrenci> Ogrencis { get; set; }
    }
}
