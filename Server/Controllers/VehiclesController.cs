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
using Microsoft.AspNetCore.Hosting;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor; 

        public VehiclesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor; 
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var includes = new List<string> { "Make", "Model", "Color" }; 
            var Vehicles = await _unitOfWork.Vehicles.GetAll(includes:includes);
            return Ok(Vehicles); 
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var includes = new List<string> { "Make", "Model", "Color", "Bookings" };
            var Vehicle = await _unitOfWork.Vehicles.Get(m => m.Id == id, includes:includes); 

            if (Vehicle == null)
            {
                return NotFound();
            }

            return Ok(Vehicle);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }

            if (vehicle.Image != null)
            {
                var filePath = CreateFilePath(vehicle.Image, vehicle.ImageName);
                vehicle.ImageName = filePath;
            }

            _unitOfWork.Vehicles.Update(vehicle); 


            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
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

        // POST: Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            if (vehicle.Image != null)
            {
                var filePath = CreateFilePath(vehicle.Image, vehicle.ImageName);
                vehicle.ImageName = filePath; 
            }
            await _unitOfWork.Vehicles.Insert(vehicle);
            await _unitOfWork.Save(HttpContext); 
            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        // DELETE: Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var Vehicle = await _unitOfWork.Vehicles.Get(m => m.Id == id);
            if (Vehicle == null)
                return NotFound(); 

            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            return await _unitOfWork.Vehicles.Any(m => m.Id == id);
        }

        private string CreateFilePath(byte[] image, string name)
        {
            var host = _httpContextAccessor.HttpContext.Request.Host.Value;
            var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{name}";
            using (var fileStream = System.IO.File.Create(path))
            {
                fileStream.Write(image, 0, image.Length);
                fileStream.Close();
            }
            return $"https://{host}/uploads/{name}";
        }

    }
}
