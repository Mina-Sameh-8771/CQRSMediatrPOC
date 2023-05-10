using AutoMapper;
using CQRSMediatrPOC.AuotMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatrPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<UserViewModel> Get()
        {
            // Populate the user details from DB
            var user = new User
            {
                Address = new Address { Country = "Country"},
                Email = "Em",
                FirstName = "Fn",
                LastName = "Ln",
                Id = 1
            };

            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            return userViewModel;
        }
    }
}
