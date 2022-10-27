using Inventory.Dao;
using Inventory.Models;
using Inventory.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalletController : ControllerBase
    {
        PalletService palletService=new PalletService();
        // GET: api/<PalletController>
        [HttpGet]
        public IEnumerable<Pallet> Get()
        {
            return palletService.getAllPallets();
        }

        // GET api/<PalletController>/5
        [HttpGet("{id}")]
        public Pallet Get(string id)
        {
            return palletService.findPalletById(id);
        }

        // POST api/<PalletController>
        [HttpPost]
        public void Post([FromBody] PalletDao palletDao)
        {
            palletService.addPallet(palletDao);
        }

        // PUT api/<PalletController>/5
        [HttpPut("{id}")]
        public void Put(string id)
        {
            palletService.updatePalletInfo(id);
        }
    }
}
