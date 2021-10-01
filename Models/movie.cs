using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace Lab12_2.Models
{
    [Table("movies")]
    public class movie
    {
        [ExplicitKey]
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
    }
}
