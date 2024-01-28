using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsDiagram.models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string Article { get; set; }

        public Product() { }

        public Product(string title, decimal cost, string article)
        {
            Title = title;
            Cost = cost;
            Article = article;
        }
    }
}
