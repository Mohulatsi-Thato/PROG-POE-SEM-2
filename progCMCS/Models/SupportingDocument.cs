namespace progCMCS.Models
{
    public class SupportingDocument
    {
        public int DocumentID { get; set; }
        public int ClaimID { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
    }
}
