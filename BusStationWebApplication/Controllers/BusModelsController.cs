using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusStationWebApplication.Models;

namespace BusStationWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusModelsController : ControllerBase
    {
        private readonly BusStationContext _context;

        public BusModelsController(BusStationContext context)
        {
            _context = context;
        }

        // GET: api/BusModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusModel>>> GetBusModels()
        {
            return await _context.BusModels.ToListAsync();
        }

        // GET: api/BusModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusModel>> GetBusModel(int id)
        {
            var busModel = await _context.BusModels.FindAsync(id);

            if (busModel == null)
            {
                return NotFound();
            }

            return busModel;
        }

        // PUT: api/BusModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusModel(int id, BusModel busModel)
        {
            if (id != busModel.BusModelID)
            {
                return BadRequest();
            }

            _context.Entry(busModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BusModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BusModel>> PostBusModel(BusModel busModel)
        {
            _context.BusModels.Add(busModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusModel", new { id = busModel.BusModelID }, busModel);
        }

        // DELETE: api/BusModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusModel(int id)
        {
            var busModel = await _context.BusModels.FindAsync(id);
            if (busModel == null)
            {
                return NotFound();
            }

            _context.BusModels.Remove(busModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusModelExists(int id)
        {
            return _context.BusModels.Any(e => e.BusModelID == id);
        }
    }
}
