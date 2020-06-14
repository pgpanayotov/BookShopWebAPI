using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopWebAPI.Models
{
    public partial class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(10)]
        public string Zip { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
