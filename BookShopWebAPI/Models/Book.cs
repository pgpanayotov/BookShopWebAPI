using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopWebAPI.Models
{
    public partial class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        public int PubId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YtdSales { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        public DateTime PublishedDate { get; set; }

        public virtual Publisher Pub { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
