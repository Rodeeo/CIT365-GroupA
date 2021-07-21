using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Speaker
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public string Subject { get; set; }
    }
}