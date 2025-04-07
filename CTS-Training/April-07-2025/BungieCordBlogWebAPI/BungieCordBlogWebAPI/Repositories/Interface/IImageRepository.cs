using BungieCordBlogWebAPI.Models.Domain;

namespace BungieCordBlogWebAPI.Repositories.Interface
{
    public interface IImageRepository
    {
        Task<BlogImage> Upload(IFormFile file, BlogImage blogImage);

        Task<IEnumerable<BlogImage>> GetAll();
    }
}
