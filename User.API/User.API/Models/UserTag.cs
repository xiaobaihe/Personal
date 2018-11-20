using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.API.Models
{
    public class UserTag
    {
        public DateTime CreateTime { get; set; }
        public Guid UserId { get; set; }

        public string Tag { get; set; }
    }
}
