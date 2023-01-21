using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProject.Models
{
    public class Categoryddl
    {
        public int Id { get; set; }
        //[Key]
        public string Category { get; set; }
    }
}