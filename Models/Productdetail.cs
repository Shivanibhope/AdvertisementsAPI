using System;
using System.Collections.Generic;

namespace AdvertisementsAPI.Models
{
    public partial class Productdetail
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductPrice { get; set; }
    }
}
