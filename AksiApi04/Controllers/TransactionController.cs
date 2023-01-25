using AksiApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace AksiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : BaseApiController<Transaction>
    {
        public TransactionController(IRepository<Transaction> repository) : base(repository)
        {
        }
    }

}
