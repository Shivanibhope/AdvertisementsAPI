using System;
using System.Collections.Generic;

namespace AdvertisementsAPI.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
    }
}
