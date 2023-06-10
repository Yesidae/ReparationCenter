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
            return Ok(_context.MyReparations.ToList());
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
            
            repair.RepairStatus = myReparation.RepairStatus;
            repair.RepairValue = myReparation.RepairValue;
            repair.DamageDiagnosis = myReparation.DamageDiagnosis;
            repair.DateFinished = myReparation.DateFinished;
            repair.TechnicalComents = myReparation.TechnicalComents;
            
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
