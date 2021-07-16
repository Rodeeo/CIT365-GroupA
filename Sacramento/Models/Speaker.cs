using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Speaker : Person
    {
        public string Subject { get; set; }
    }
}