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
	
	public class PostCaptionsController : BaseDomainController<PostCaption, PostCaption>

    {
        public PostCaptionsController(IPostCaptionDomain domain):base(domain) {}

    }
}
