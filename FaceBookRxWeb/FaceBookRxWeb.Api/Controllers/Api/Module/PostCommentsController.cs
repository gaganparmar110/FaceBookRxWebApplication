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
	
	public class PostCommentsController : BaseDomainController<PostComment,PostComment>

    {
        public PostCommentsController(IPostCommentDomain domain):base(domain) {}

    }
}
