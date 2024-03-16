namespace VanyalandBank.Models
{
    public class CompanySharesTransaction
    {
        public long Id { get; set; }
        public long? FromPersonId { get; set; }
        public long? FromOwnerCompanyRegisterId { get; set; }
        public long? ToPersonId { get; set; }
        public long? ToOwnerCompanyRegisterId { get; set; }
        public decimal? PricePerShare { get; set; }
        public decimal? NumberShares { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
