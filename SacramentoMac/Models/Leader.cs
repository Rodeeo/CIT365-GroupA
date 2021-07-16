using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Leader : Person
    {
        public String CallDescription { get; set; }
    }
}