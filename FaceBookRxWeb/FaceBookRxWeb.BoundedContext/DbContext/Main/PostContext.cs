using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FaceBookRxWeb.BoundedContext.SqlContext;
using FaceBookRxWeb.Models.Main;
using FaceBookRxWeb.Models;
using FaceBookRxWeb.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace FaceBookRxWeb.BoundedContext.Main
{
    public class PostContext : BaseBoundedContext, IPostContext
    {
        public PostContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            #endregion DbSets

    }


    public interface IPostContext : IDbContext
    {
    }
}

