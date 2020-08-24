using AutoMapper;
using ITWorkRequest.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace ITWorkRequest.API.Controllers
{
    public class StatusListsController : ControllerBase
    {
        private readonly ITWorkRequestRepository _repo;
        private readonly IMapper _mapper;

        public StatusListsController(ITWorkRequestRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
    }
}