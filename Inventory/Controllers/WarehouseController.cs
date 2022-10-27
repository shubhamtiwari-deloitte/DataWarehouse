using Inventory.Dao;
using Inventory.Models;
using Inventory.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {

        WarehouseService warehouseService=new WarehouseService();
        // GET: api/<WarehouseController>
        [HttpGet]
        public IEnumerable<Warehouse> Get()
        {
            return warehouseService.getWarehouses();
        }

        // GET api/<WarehouseController>/5
        [HttpGet("{id}")]
        public Warehouse Get(string id)
        {
            return warehouseService.getWarehouseById(id);
        }

        // POST api/<WarehouseController>
        [HttpPost]
        public void Post([FromBody] WarehouseDao warehouseDao)
        {
            warehouseService.addWarehouse(warehouseDao);
        }
    }
}
