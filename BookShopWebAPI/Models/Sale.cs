using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopWebAPI.Models
{
    public partial class Sale
    {
        [Key]
        public int SaleId { get; set; }
        [StringLength(10)]
        public string StoreId { get; set; }
        [StringLength(10)]
        public string OrderNum { get; set; }
        public DateTime OrderDate { get; set; }
        public short Quantity { get; set; }
        [StringLength(50)]
        public string PayTerms { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Store Store { get; set; }
    }
}
