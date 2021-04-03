using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApplication1.Models;
using WebApiApplication1.Repository;

namespace WebApiApplication1.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public string Post([FromBody] ProductModel ProductModel)
        {
            ProductRepository oProductRepository = new ProductRepository();
            int i=oProductRepository.CreateProduct(ProductModel);
            if (i == 1)
                {
                    return "Product Succesfully create";
                }
                else
                {
                    return "Samething is Wrong";
                }
        }
        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
