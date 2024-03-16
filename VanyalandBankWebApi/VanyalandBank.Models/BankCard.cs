namespace VanyalandBank.Models
{
    public class BankCard
    {
        public long Id { get; set; }
        public long? BankAccountId { get; set; }
        public string? CardId { get; set; }
        public long? PinCode { get; set; }
    }
}
