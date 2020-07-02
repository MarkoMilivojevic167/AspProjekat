using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AspProjekat.Implementation
{
    public class UploadImageFunction
    {
        public static string UploadImage(IFormFile image)
        {

            var guid = Guid.NewGuid();
            var extension = Path.GetExtension(image.FileName);
            var newName = guid + extension;

            var path = Path.Combine("wwwroot", "images", newName);


            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(fileStream);
            }


            return newName;
        }
    }
}
