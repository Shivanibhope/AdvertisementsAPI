using System;
using System.Collections.Generic;

namespace AdvertisementsAPI.Models
{
    public partial class OrderItem
    {
        public int OrderId { get; set; }
        public decimal? ItemNumber { get; set; }
        public int? ProductId { get; set; }
        public string? Quality { get; set; }
        public string? Price { get; set; }
    }
}
