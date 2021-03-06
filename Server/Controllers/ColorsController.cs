using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork; 

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; 
        }

        // GET: api/Colors
        [HttpGet]
        public async Task<IActionResult> GetColors()
        {            
            var Colors = await _unitOfWork.Colors.GetAll();
            return Ok(Colors); 
        }

        // GET: api/Colors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor(int id)
        {
            var Color = await _unitOfWork.Colors.Get(m => m.Id == id); 

            if (Color == null)
            {
                return NotFound();
            }

            return Ok(Color);
        }

        // PUT: api/Colors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color Color)
        {
            if (id != Color.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colors.Update(Color); 


            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColorExists(id))
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

        // POST: Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color Color)
        {
            await _unitOfWork.Colors.Insert(Color);
            await _unitOfWork.Save(HttpContext); 
            return CreatedAtAction("GetColor", new { id = Color.Id }, Color);
        }

        // DELETE: Colors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var Color = await _unitOfWork.Colors.Get(m => m.Id == id);
            if (Color == null)
                return NotFound(); 

            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> ColorExists(int id)
        {
            return await _unitOfWork.Colors.Any(m => m.Id == id);
        }
    }
}
