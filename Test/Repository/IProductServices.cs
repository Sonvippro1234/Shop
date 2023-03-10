using Shop.Api.Models.CreateModel;
using Test.Data;
using Test.Models;

namespace Test.Repository
{
    public interface IProductServices
    {
        public Task<PageProduct> GetProductAsync(SearchModel search, PagingSearch paging);
        public Task<Product> GetOneProductAsync(Guid id);
        public Task<string> AddProductAsysnc(ProductAdd product);
    }
}
