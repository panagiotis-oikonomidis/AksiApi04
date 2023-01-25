using AksiApi.Context;
using AksiApi.Entities;
using AksiApi.Repositories.Interfaces;

namespace AksiApi.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AtaContext context) : base(context)
        {
        }
    }
}
