using MyMvcAuthApp.Data;

namespace MyMvcAuthApp.Repository
{
    public interface IUploadImageRepository
    {
        Task<string> UploadImage(Uploadİmage uploadİmage);
        Task<List<string>> UploadImages(List<IFormFile> images);
         bool IsImage(IFormFile file);
    }
}