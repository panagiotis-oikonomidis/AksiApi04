using AksiApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AksiApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController<T> : ControllerBase where T : class
    {
        private readonly IRepository<T> _repository;

        public BaseApiController(IRepository<T> repository)
        {
            _repository = repository;
        }

    }
}

