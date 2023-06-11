using System;
using System.Collections.Generic;

namespace AdvertisementsAPI.Models
{
    public partial class OrderDetail
    {
        public int OrdersId { get; set; }
        public int? ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Quality { get; set; }
        public string? Discount { get; set; }
    }
}
