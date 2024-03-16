namespace VanyalandBank.Models
{
    public class Transaction
    {
        public long ID { get; set; }
        public DateTime? TransactionTime { get; set; }
        public long? FromBankAccountId { get; set; }
        public long? ToBankAccountId { get; set; }
        public decimal? Amount { get; set; }
    }
}
