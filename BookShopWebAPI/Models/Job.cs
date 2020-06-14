using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShopWebAPI.Models
{
    public partial class Job
    {
        [Key]
        public short JobId { get; set; }
        [StringLength(255)]
        public string JobDesc { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
