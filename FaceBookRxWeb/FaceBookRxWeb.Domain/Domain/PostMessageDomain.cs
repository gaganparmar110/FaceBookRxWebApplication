using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FaceBookRxWeb.UnitOfWork.Main;
using FaceBookRxWeb.Models.Main;

namespace FaceBookRxWeb.Domain.Module
{
    public class PostMessageDomain : IPostMessageDomain
    {
        public PostMessageDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(PostMessage parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostMessage parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostMessage entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostMessage entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostMessage entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostMessage entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostMessage parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostMessage parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostMessageDomain : ICoreDomain<PostMessage, PostMessage> { }
}
