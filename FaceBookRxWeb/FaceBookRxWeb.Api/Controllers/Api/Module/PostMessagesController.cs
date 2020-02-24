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
	
	public class PostMessagesController : BaseDomainController<PostMessage, PostMessage>

    {
        public PostMessagesController(IPostMessageDomain domain):base(domain) {}

    }
}
