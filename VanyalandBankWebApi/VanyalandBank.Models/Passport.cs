namespace VanyalandBank.Models
{
    public class Passport
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public string PassportNumber { get; set; }
        public DateTime PassportIssued { get; set; }
        public DateTime PassportExpires { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public decimal Height { get; set; }
        public string EyeColor { get; set; }
    }
}
