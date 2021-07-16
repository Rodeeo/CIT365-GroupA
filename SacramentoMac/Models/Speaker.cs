using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Speaker : Person
    {
        public String Subject { get; set; }
    }
}