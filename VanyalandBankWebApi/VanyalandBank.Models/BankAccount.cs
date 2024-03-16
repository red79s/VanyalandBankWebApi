namespace VanyalandBank.Models
{
    public class BankAccount
    {
        public long Id { get; set; }
        public long? PersonId { get; set; }
        public decimal Amount { get; set; }
        public string AccountName { get; set; }
        public long CurrencyId { get; set; }
        public long? CompanyRegisterId { get; set; }
    }
}
