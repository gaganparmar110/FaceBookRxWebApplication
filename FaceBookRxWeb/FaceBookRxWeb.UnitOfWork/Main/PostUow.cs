using RxWeb.Core.Data;
using FaceBookRxWeb.BoundedContext.Main;

namespace FaceBookRxWeb.UnitOfWork.Main
{
    public class PostUow : BaseUow, IPostUow
    {
        public PostUow(IPostContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IPostUow : ICoreUnitOfWork { }
}


