using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hashavt_aveda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FounderController : ControllerBase
    {

        public static List<Founder> FounderList = new List<Founder> { };
        int index = 0;
        // GET: api/<FounderController>
        [HttpGet]
        public IEnumerable<Founder> Get()
        {
            return FounderList;
        }

        // GET api/<FounderController>/5
        [HttpGet("{id}")]
        public Founder Get(int id)
        {
            Founder p = FounderList.Find(x => x.IdFounder == id);
            return p;

            // POST api/<FounderController>
            [HttpPost]
        public void Post([FromBody] Founder founder)
        {
                index++;
                FounderList.Add(new Founder { IdFounder=});
        }

        // PUT api/<FounderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FounderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
