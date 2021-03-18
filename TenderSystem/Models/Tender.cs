using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenderSystem.Models
{
    public class Tender
    {
        public int TenderId { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public int StateOrganId { get; set; }
        public virtual StateOrgan StateOrgan { get; set; }
    }
}
