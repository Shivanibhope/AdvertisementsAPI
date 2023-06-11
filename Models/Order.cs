using System;
using System.Collections.Generic;

namespace AdvertisementsAPI.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public string? ItemNumber { get; set; }
        public int ProductId { get; set; }
        public string? Quality { get; set; }
        public decimal? Price { get; set; }
    }
}
