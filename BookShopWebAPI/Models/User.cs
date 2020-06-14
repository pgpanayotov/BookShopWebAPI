using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopWebAPI.Models
{
    public partial class User
    {
        public string UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string email_address { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public short JobId { get; set; }
        public byte? JobLevel { get; set; }
        public int PubId { get; set; }
        public DateTime HireDate { get; set; }

        public virtual Job Job { get; set; }
        public virtual Publisher Pub { get; set; }
    }
}
