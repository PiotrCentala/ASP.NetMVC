using KursMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace KursMVC.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie;
        public IEnumerable<Genre> Genre;
    }
}