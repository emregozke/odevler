using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public int? KonuId { get; set; }
        public bool Anlattimi { get; set; }
        public DateTime? AnlatimTarihi { get; set; }

        public virtual Konu Konu { get; set; }
    }
}
