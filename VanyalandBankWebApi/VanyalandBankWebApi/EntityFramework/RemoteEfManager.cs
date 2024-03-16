using Eloe.RemoteEfExecute;
using VanyalandBank.Models;

namespace VanyalandBankWebApi.EntityFramework
{
    public class RemoteEfManager : ExecuteEfManagerBase
    {
        private readonly VanyalandBankDbContext _context;
        public RemoteEfManager(VanyalandBankDbContext context)
        {
            _context = context;
            AddDbSetExecuter(new EfCoreExecuteDbSet<BankAccount>(nameof(_context.BankAccounts), _context.BankAccounts));
            AddDbSetExecuter(new EfCoreExecuteDbSet<Person>(nameof(_context.Persons), _context.Persons));
            AddDbSetExecuter(new EfCoreExecuteDbSet<Currency>(nameof(_context.Currencies), _context.Currencies));
            AddDbSetExecuter(new EfCoreExecuteDbSet<Passport>(nameof(_context.Passports), _context.Passports));
            AddDbSetExecuter(new EfCoreExecuteDbSet<BankCard>(nameof(_context.BankCards), _context.BankCards));
            AddDbSetExecuter(new EfCoreExecuteDbSet<Transaction>(nameof(_context.Transactions), _context.Transactions));
            AddDbSetExecuter(new EfCoreExecuteDbSet<CompanyRegister>(nameof(_context.CompanyRegister), _context.CompanyRegister));
            AddDbSetExecuter(new EfCoreExecuteDbSet<CompanyShare>(nameof(_context.CompanyShares), _context.CompanyShares));
            AddDbSetExecuter(new EfCoreExecuteDbSet<CompanySharesTransaction>(nameof(_context.CompanySharesTransactions), _context.CompanySharesTransactions));

        }

        protected override int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
