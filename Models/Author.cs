﻿using System.ComponentModel.DataAnnotations;

namespace Irimia_Ofelia_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        [Display(Name = "Full Name")]
        public string FullName => FirstName + " " + LastName;
    }
}
