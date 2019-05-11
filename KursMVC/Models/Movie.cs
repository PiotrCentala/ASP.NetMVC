﻿using KursMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? RealeseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public int Genreid { get; set; }


    }

    // / movies/random
}