namespace VanyalandBank.Models
{
    public class CompanyShare
    {
        public long Id { get; set; }
        public long? CompanyRegisterId { get; set; }
        public long? NumberShares { get; set; }
        public long? PersionId { get; set; }
        public long? OwnerCompanyRegisterId { get; set; }
        public decimal? PricePerShare { get; set; }
    }
}
