using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMvcAuthApp.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcAuthApp.Repository
{
    public class UploadImageRepository : IUploadImageRepository
    {
        private readonly ApplicationDbContext _context;

        public UploadImageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Method for uploading a single image
        public async Task<string> UploadImage(IFormFile uploadImage)
        {
            // Validate that the file is an image
            if (!IsImage(uploadImage))
            {
                throw new ArgumentException("Yalnızca resim dosyalarına izin verilmektedir.");
            }

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(uploadImage.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await uploadImage.CopyToAsync(stream);
            }

            return fileName;
        }

        // Method for uploading a single image (implementing the interface method)
        public async Task<string> UploadImage(Uploadİmage uploadImage)
        {
            // Implement the logic for uploading Uploadİmage
            // This is a placeholder implementation
            return await Task.FromResult(string.Empty);
        }

        // Method for uploading multiple images
        public async Task<List<string>> UploadImages(List<IFormFile> images)
        {
            var fileNames = new List<string>();

            foreach (var image in images)
            {
                // Validate that each file is an image
                if (!IsImage(image))
                {
            throw new ArgumentException("Yalnızca resim dosyalarına izin verilmektedir.");
                }

                // Generate a unique file name
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                // Determine the file path to save the image
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                // Save the image to the file path
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                // Add the file name to the list of uploaded images
                fileNames.Add(fileName);
            }

            return fileNames; // Return the list of file names
        }

        // Helper method to check if the file is an image (made public to implement the interface)
        public bool IsImage(IFormFile file)
        {
            var permittedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

            // Check if the extension is allowed
            if (string.IsNullOrEmpty(extension) || !permittedExtensions.Contains(extension))
            {
                return false;
            }

            // Check the content type (MIME type)
            var permittedMimeTypes = new[] { "image/jpeg", "image/png", "image/gif" };
            if (!permittedMimeTypes.Contains(file.ContentType))
            {
                return false;
            }

            return true;
        }
    }
}
