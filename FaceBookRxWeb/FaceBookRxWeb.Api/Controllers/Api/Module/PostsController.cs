using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FaceBookRxWeb.UnitOfWork.Main;
using FaceBookRxWeb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FaceBookRxWeb.Api.Controllers.Module
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class PostsController : BaseController<Post,Post,Post>

    {
        public PostsController(IPostUow uow):base(uow) {}

    }
}
