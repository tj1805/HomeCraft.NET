using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCraft.Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }




    }
}
 