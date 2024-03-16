using Eloe.RemoteEfExecute;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VanyalandBankWebApi.EntityFramework;

namespace VanyalandBankWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EfController : ControllerBase
    {
        private readonly VanyalandBankDbContext _context;
        private RemoteEfManager _remoteEfManager;
        public EfController(VanyalandBankDbContext context)
        {
            _context = context;
            _remoteEfManager = new RemoteEfManager(context);
        }

        [HttpPost("ExecuteFirstOrDefault")]
        public ActionResult<string> ExecuteFirstOrDefault(RemoteDbSetExecuteParam param)
        {
            return _remoteEfManager.FirstOrDefault(param.DbSetName, param.Includes, param.Expressions);
        }

        [HttpPost("ExecuteToList")]
        public ActionResult<string> ExecuteToList(RemoteDbSetExecuteParam param)
        {
            return _remoteEfManager.ToList(param.DbSetName, param.Includes, param.Expressions);
        }

        [HttpPost("SaveChanges")]
        public ActionResult<int> SaveChanges(RemoteDbSetSaveChangesParams saveChangesParams)
        {
            return _remoteEfManager.SaveChanges(saveChangesParams);
        }

        [HttpPost("Test")]
        public ActionResult<string> Test()
        {
            var account = _context.BankAccounts.FirstOrDefault();
            return $"Test OK, Account: {account?.AccountName}";
        }
    }
}
