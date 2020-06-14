using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopWebAPI.Models
{
    public partial class BookAuthor
    {
        [Key]
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public byte? AuthorOrder { get; set; }
        public int? RoyalityPercentage { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
