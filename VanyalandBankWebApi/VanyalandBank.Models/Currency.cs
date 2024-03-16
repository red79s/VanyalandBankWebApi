using System.ComponentModel.DataAnnotations.Schema;

namespace VanyalandBank.Models
{
    public class Currency
    {
        public long Id { get; set; }
        [Column("Currency")]
        public string CurrencyName { get; set; }
        public string CountryName { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
