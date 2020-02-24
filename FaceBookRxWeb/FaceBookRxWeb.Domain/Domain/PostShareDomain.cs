using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FaceBookRxWeb.UnitOfWork.Main;
using FaceBookRxWeb.Models.Main;

namespace FaceBookRxWeb.Domain.Module
{
    public class PostShareDomain : IPostShareDomain
    {
        public PostShareDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(PostShare parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostShare parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostShare entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostShare entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostShare entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostShare entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostShare parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostShare parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostShareDomain : ICoreDomain<PostShare, PostShare> { }
}
