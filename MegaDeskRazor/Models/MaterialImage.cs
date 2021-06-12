using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MegaDeskRazorPages.Models
{
    public class MaterialImage
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile file { get; set; }
    }
}