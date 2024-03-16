using Microsoft.EntityFrameworkCore;
using VanyalandBank.Models;

namespace VanyalandBankWebApi.EntityFramework
{
    public class VanyalandBankDbContext : DbContext
    {
        private readonly string? _connectionString = null;

        public VanyalandBankDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public VanyalandBankDbContext(DbContextOptions<VanyalandBankDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<BankCard> BankCards { get; set; }
        public virtual DbSet<CompanyRegister> CompanyRegister { get; set; }
        public virtual DbSet<CompanyShare> CompanyShares { get; set; }
        public virtual DbSet<CompanySharesTransaction> CompanySharesTransactions { get; set;}
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}
