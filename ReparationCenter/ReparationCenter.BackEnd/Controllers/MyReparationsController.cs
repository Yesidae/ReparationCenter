using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReparationCenter.BackEnd.Data;
using ReparationCenter.Shared.Entities;
using System.Threading.Tasks;

namespace ReparationCenter.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyReparationsController : ControllerBase
    {
        private readonly DataContext _context;

        public MyReparationsController(DataContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.MyReparations.OrderBy(t => t.DateStarted).ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var repair = _context.MyReparations.FirstOrDefault(x => x.Id == id);
            if (repair == null)
            {
                return NotFound();
            }

            return Ok(repair);
        }


        [HttpPost]
        public IActionResult Post(MyReparation myReparation)
        {
            _context.Add(myReparation);
            _context.SaveChanges();
            return Ok(myReparation);
        }

        [HttpPut]
        public IActionResult Put(MyReparation myReparation) 
        {
            var repair = _context.MyReparations.FirstOrDefault(x => x.Id == myReparation.Id);
            if (repair == null)
            {
                return NotFound();
            }

            repair.DeviceType = myReparation.DeviceType;
            repair.Brand = myReparation.Brand;
            repair.OwnerName = myReparation.OwnerName;
            repair.OwnerLastName = myReparation.OwnerLastName;
            repair.OwnerPhone = myReparation.OwnerPhone;
            repair.Email = myReparation.Email;
            repair.DamageDiagnosis = myReparation.DamageDiagnosis;
            repair.TechnicalComents = myReparation.TechnicalComents;
            repair.DateStarted = myReparation.DateStarted;
            repair.DateFinished = myReparation.DateFinished;
            repair.RepairValue = myReparation.RepairValue;
            repair.RepairStatus = myReparation.RepairStatus;

            



            _context.Update(repair);
            _context.SaveChanges();
            return Ok(repair);

        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id) 
        {
            var repair = _context.MyReparations.FirstOrDefault(x => x.Id == id);
            if (repair == null)
            {
                return NotFound();
            }

            _context.Remove(repair);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
