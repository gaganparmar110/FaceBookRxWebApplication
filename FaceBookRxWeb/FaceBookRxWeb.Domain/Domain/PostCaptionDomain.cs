using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FaceBookRxWeb.UnitOfWork.Main;
using FaceBookRxWeb.Models.Main;

namespace FaceBookRxWeb.Domain.Module
{
    public class PostCaptionDomain : IPostCaptionDomain
    {
        public PostCaptionDomain(IPostUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(PostCaption parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(PostCaption parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostCaption entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostCaption entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(PostCaption entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostCaption entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostCaption parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostCaption parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IPostCaptionDomain : ICoreDomain<PostCaption, PostCaption> { }
}
