using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VozilaController : ControllerBase
    {
        [HttpGet]
        [Route("vratiSvaVozila")]
        public IActionResult vratiSvaVozila()
        {
            var rez = DTOManager.vratiSvaVozila();
            return Ok(rez);
        }
        [HttpGet]
        [Route("vratiVozilo/{id}")]
        public IActionResult vratiVozilo(int id)
        {
            var rez = DTOManager.vratiVozilo(id);
            if(rez == null)
            {
                return NotFound("Nije pronadjeno vozilo sa tim id-ijem");
            }
            return Ok(rez);
        }
    }
}
