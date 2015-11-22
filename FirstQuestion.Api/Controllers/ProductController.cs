using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstQuestion.Api.Controllers
{
    public class ProductController : ApiController
    {
        private IEnumerable<Product> init = new List<Product> {
            new Product { Id=1, Name="Shoes", CountryOfOrigin="UK" },
            new Product { Id=2, Name="T-Shirt", CountryOfOrigin="US" },
            new Product { Id=3, Name="Shorts", CountryOfOrigin="US" },
            new Product { Id=4, Name="Jeans", CountryOfOrigin="FR" }
        };

        public IEnumerable<Product> GetAll()
        {
            return init;
        }

        public Product GetById(int id)
        {
            return init.First(foo => foo.Id == id);
        }

        public Product GetByName(string name)
        {
            return init.First(foo => String.Equals(foo.Name, name, StringComparison.CurrentCultureIgnoreCase));
        }
    }


    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CountryOfOrigin { get; set; }
    }
}
