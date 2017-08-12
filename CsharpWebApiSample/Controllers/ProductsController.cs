using System.Collections.Generic;
using System.Web.Http;
using CsharpWebApiSample.Models;
using System.Linq;

namespace CsharpWebApiSample.Controllers
{
	public class ProductsController : ApiController	
	{
		Product[] products = new Product[] {
			new Product{ Id = 1, Name = "Tomato", Category = "Vegetables", Price = 1 },
			new Product{ Id = 2, Name = "peach", Category = "Fruit", Price = 2.75M },
			new Product{ Id = 3, Name = "Laurier", Category = "sasoning", Price = 3.25M } 
		};

		// GET api/Products
		public IEnumerable<Product> GetAllProducts()
		{
			return products;
		}

		// GET api/Products/{id}
		public Product GetProduct(int id)
		{
			var product = products.SingleOrDefault(x => x.Id == id);
			return product;
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}