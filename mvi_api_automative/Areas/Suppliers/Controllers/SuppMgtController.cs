using Microsoft.AspNetCore.Mvc;
using WebApp2.Areas.Suppliers.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp2.Areas.Suppliers.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class SuppMgtController : ControllerBase
        {
        ISuppRepo _repo;
        public SuppMgtController(ISuppRepo repo)
            {
            _repo = repo;
            }

        // POST api/<SuppMgtController>
        [HttpPost]
        public void Post([FromBody] SuppModel value)
            {
            _repo.Enroll(value);

            }

        // PUT api/<SuppMgtController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SuppModel value)
            {
            _repo.Update(id, value);
            }

        }
    }
