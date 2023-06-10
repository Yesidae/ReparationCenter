using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReparationCenter.Shared.Entities;
using System.Threading.Tasks;

namespace ReparationCenter.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyReparationsController : ControllerBase
    {
        private List<MyReparation> _myReparations;
        public MyReparationsController() 
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_myReparations);
        }


        [HttpPost]
        public IActionResult Post(MyReparation myReparation)
        {
            _myReparations.Add(myReparation);

            return Ok(myReparation);
        }

        [HttpPut]
        public IActionResult Put(MyReparation myReparation) 
        {
            var reparation = _myReparations.FirstOrDefault(r => r.OwnerName == myReparation.OwnerName);

            if (reparation == null) 
            {
                return NotFound();
            }
            reparation.RepairValue = myReparation.RepairValue;
            reparation.RepairStatus = myReparation.RepairStatus;
            reparation.DateFinished = myReparation.DateFinished;
            reparation.TechnicalComents = myReparation.TechnicalComents;
            reparation.RepairValue = myReparation.RepairValue;

            return Ok(reparation);
        }

        [HttpDelete("{OwnerName:string}")]
        public IActionResult Delete(string name) 
        {
            var reparacion = _myReparations.FirstOrDefault(r => r.OwnerName == name);

            if (reparacion == null)
            {
                return NotFound();
            }

            _myReparations.Remove(reparacion);
            return NoContent();
        }

    }
}
