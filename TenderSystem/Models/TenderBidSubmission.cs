using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenderSystem.Models
{
    public class TenderBidSubmission
    {
        public int TenderBidSubmissionId { get; set; }
        public decimal TotalQuotation { get; set; }
        public int SumittedById { get; set; }
        public virtual User SumittedBy { get; set; }
    }
}
