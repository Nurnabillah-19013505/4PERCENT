using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace FYPFinalCode.Models
{
    public class FileManagerModel
    {
        public FileInfo[] Files { get; set; }
        public IFormFile IFormFile { get; set; }
        public List<IFormFile> IFormFiles { get; set; }
    }
}
