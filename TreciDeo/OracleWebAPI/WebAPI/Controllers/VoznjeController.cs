using FluentNHibernateTemplate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoznjeController : ControllerBase
    {
        [HttpGet]
        [Route("vratiSveVoznje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> VratiSveVoznje()
        {
            var voznje = await DTOManager.vratiSveVoznjeAsync();
            return Ok(voznje);
        }

        [HttpGet]
        [Route("vratiVoznju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> VratiVoznju(int id)
        {
            if (id <= 0) return BadRequest("Nevalidan ID vožnje.");

            var voznja = await DTOManager.vratiVoznjuAsync(id);
            return Ok(voznja);
        }

        [HttpPost]
        [Route("dodajVoznju")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DodajVoznju([FromBody] VoznjaPregled v)
        {
            if (v == null) return BadRequest("Podaci o vožnji nisu prosleđeni.");

            if (v.RezervacijaId <= 0) return BadRequest("Nevalidan ID rezervacije.");

            var voznja = await DTOManager.dodajVoznjuAsync(v);
            return StatusCode(201, voznja);
        }

        [HttpPut]
        [Route("azurirajVoznju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AzurirajVoznju([FromBody] VoznjaPregled v)
        {
            if (v == null) return BadRequest("Podaci o vožnji nisu prosleđeni.");
            if (v.Id <= 0) return BadRequest("Nevalidan ID vožnje.");

            var voznja = await DTOManager.azurirajVoznjuAsync(v);
            return Ok(voznja);
        }

        [HttpDelete]
        [Route("obrisiVoznju/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ObrisiVoznju(int id)
        {
            if (id <= 0) return BadRequest("Nevalidan ID vožnje.");

            await DTOManager.obrisiVoznjuAsync(id);
            return StatusCode(204);
        }
    }
}