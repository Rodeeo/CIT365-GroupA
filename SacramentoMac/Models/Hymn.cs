using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Hymn
    {
        public int ID { get; set; }

        public int Number { get; set; }
        public String Name { get; set; }
    }
}