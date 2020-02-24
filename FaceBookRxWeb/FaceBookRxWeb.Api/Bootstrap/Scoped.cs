#region Namespace
using Microsoft.Extensions.DependencyInjection;
using FaceBookRxWeb.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using FaceBookRxWeb.UnitOfWork.DbEntityAudit;
using FaceBookRxWeb.BoundedContext.Main;
using FaceBookRxWeb.UnitOfWork.Main;
using FaceBookRxWeb.Domain.Module;
            #endregion Namespace




namespace FaceBookRxWeb.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IPostContext, PostContext>();
            serviceCollection.AddScoped<IPostUow, PostUow>();
            #endregion ContextService




            #region DomainService

            
            serviceCollection.AddScoped<IPostLikeDomain, PostLikeDomain>();
            
            serviceCollection.AddScoped<IPostCommentDomain, PostCommentDomain>();
            
            serviceCollection.AddScoped<IPostShareDomain, PostShareDomain>();
            
            serviceCollection.AddScoped<IPostMessageDomain, PostMessageDomain>();
            
            serviceCollection.AddScoped<IPostDomain, PostDomain>();
            
            serviceCollection.AddScoped<IPostCaptionDomain, PostCaptionDomain>();
            #endregion DomainService






        }
    }
}




