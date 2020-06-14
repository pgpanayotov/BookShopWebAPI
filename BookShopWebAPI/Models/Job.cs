using System;
using System.Collections.Generic;

namespace BookShopWebAPI.Models
{
    public partial class Job
    {
        public short JobId { get; set; }
        public string JobDesc { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
