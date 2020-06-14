using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopWebAPI.Models
{
    public partial class Store
    {
        [Key]
        public string StoreId { get; set; }
        [Required]
        [StringLength(50)]
        public string StoreName { get; set; }
        [StringLength(50)]
        public string StoreAddress { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Zip { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
