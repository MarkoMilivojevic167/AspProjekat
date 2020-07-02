using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.DataTransfer
{
    public class ImageDto
    {
        public IFormFile Path { get; set; }

        public string Alt { get; set; }

        public int ProductId { get; set; }
    }
}
