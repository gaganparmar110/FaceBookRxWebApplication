using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FaceBookRxWeb.Domain.Module;
using FaceBookRxWeb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FaceBookRxWeb.Api.Controllers.Module
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class PostSharesController : BaseDomainController<PostShare, PostShare>

    {
        public PostSharesController(IPostShareDomain domain):base(domain) {}

    }
}
