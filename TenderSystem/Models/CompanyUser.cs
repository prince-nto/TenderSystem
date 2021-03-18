using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenderSystem.Models
{
    public class CompanyUser
    {
        public int CompanyUserId { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
