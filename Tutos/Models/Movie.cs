using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutos.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Actors { get; set; }
        public string ProductionCompany {  get; set; }
    }
}