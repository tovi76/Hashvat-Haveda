using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hashavt_aveda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public static List<Product> ProductList = new List<Product> { };
        int index = 0;
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable <Product> Get()
        {
            return ProductList;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product p = ProductList.Find(x => x.Id == id);
            return p;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product NewProduct)
        {
           index++;
            ProductList.Add(new Product { Id = index, Name = NewProduct.Name,
                Description = NewProduct.Description,
                Category = NewProduct.Category, Place = NewProduct.Place }); 
           
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product UpdateProduct)
        {
            Product p = ProductList.Find(x => x.Id == UpdateProduct.Id);
            p= UpdateProduct;
        }

        // PUT api/<ProductController>/5
        //[HttpPut("{id}")]//שינוי סטטוס במקרה של מסירת החפץ
        //public void Put(int id)
        //{
        //    Product p = ProductList.Find(x => x.Id == id);
        //    if (p != null)
        //    p.status = true;
        //}


        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product p = ProductList.Find(x => x.Id == id);
            if(p != null) 
            {
                ProductList.Remove(p);
            }
            
        }

    }
}
