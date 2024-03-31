using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using duto.api.react.Server.DatabaseContext;
using duto.api.react.Server.Models;
using duto.api.react.Server.ViewModels;
using System.Collections;
using static System.Net.WebRequestMethods;
using Microsoft.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;

namespace duto.api.react.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForexCandlesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ForexCandlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("GetForexCandles")]
        public async Task<ReturnObject<ForexReturnDataVm>> GetForexCandles()
        {

            ForexReturnDataVm data = new ForexReturnDataVm();

            using (HttpClient client = new HttpClient())
            {
                string url = "https://api.polygon.io/v2/aggs/ticker/C:EURUSD/range/1/hour/2024-03-15/2024-03-15?apiKey=CNf_dxojmDFqzsMz6p6iX5pTnGh61Vep";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<ForexReturnDataVm>(result);
                }
            }

            return new ReturnObject<ForexReturnDataVm>() { Success = true, Data = data, Validated = true };
        }

        // GET: api/ForexCandles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForexCandle>> GetForexCandle(int id)
        {
          if (_context.ForexCandles == null)
          {
              return NotFound();
          }
            var forexCandle = await _context.ForexCandles.FindAsync(id);

            if (forexCandle == null)
            {
                return NotFound();
            }

            return forexCandle;
        }

        //// PUT: api/ForexCandles/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutForexCandle(int id, ForexCandle forexCandle)
        //{
        //    if (id != forexCandle.ForexCandleID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(forexCandle).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ForexCandleExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/ForexCandles
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<ForexCandle>> PostForexCandle(ForexCandle forexCandle)
        //{
        //  if (_context.ForexCandles == null)
        //  {
        //      return Problem("Entity set 'ApplicationDbContext.ForexCandles'  is null.");
        //  }
        //    _context.ForexCandles.Add(forexCandle);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetForexCandle", new { id = forexCandle.ForexCandleID }, forexCandle);
        //}

        // DELETE: api/ForexCandles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForexCandle(int id)
        {
            if (_context.ForexCandles == null)
            {
                return NotFound();
            }
            var forexCandle = await _context.ForexCandles.FindAsync(id);
            if (forexCandle == null)
            {
                return NotFound();
            }

            _context.ForexCandles.Remove(forexCandle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //private bool ForexCandleExists(int id)
        //{
        //    return (_context.ForexCandles?.Any(e => e.ForexCandleID == id)).GetValueOrDefault();
        //}
    }
}
