namespace VanyalandBank.Models
{
    public class CompanyRegister
    {
        public long Id { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyNumber { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
