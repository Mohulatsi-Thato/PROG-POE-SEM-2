using System;

namespace progCMCS.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public DateTime DateSubmitted { get; set; }
        public decimal ClaimAmount { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
