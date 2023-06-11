using System;
using System.Collections.Generic;

namespace AdvertisementsAPI.Models
{
    public partial class Supplier
    {
        public int SupplierId { get; set; }
        public string? CampanyName { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public decimal? Phone { get; set; }
        public string? Country { get; set; }
    }
}
