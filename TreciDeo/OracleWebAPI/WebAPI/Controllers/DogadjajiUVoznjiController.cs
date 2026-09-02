using FluentNHibernateTemplate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogadjajiUVoznjiController : ControllerBase
    {
        [HttpGet]
        [Route("vratiDogadjajeZaVoznju/{voznjaId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> VratiDogadjajeZaVoznju(int voznjaId)
        {
            if (voznjaId <= 0) return BadRequest("Nevalidan ID vožnje.");

            var dogadjaji = await DTOManager.vratiDogadjajeZaVoznjuAsync(voznjaId);
            return Ok(dogadjaji);
        }

        [HttpGet]
        [Route("vratiDogadjaj/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> VratiDogadjaj(int id)
        {
            if (id <= 0) return BadRequest("Nevalidan ID događaja.");

            var dogadjaj = await DTOManager.vratiDogadjajAsync(id);
            return Ok(dogadjaj);
        }

        [HttpPost]
        [Route("dodajDogadjaj/{voznjaId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DodajDogadjaj(int voznjaId, [FromBody] DogadjajUVoznjiPregled d)
        {
            if (voznjaId <= 0)  return BadRequest("Nevalidan ID vožnje.");
            if (d == null) return BadRequest("Podaci o događaju nisu prosleđeni.");

            var dogadjaj = await DTOManager.dodajDogadjajAsync(d, voznjaId);
            return StatusCode(201, dogadjaj);
        }

        [HttpPut]
        [Route("azurirajDogadjaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AzurirajDogadjaj([FromBody] DogadjajUVoznjiPregled d)
        {
            if (d == null) return BadRequest("Podaci o događaju nisu prosleđeni.");
            if (d.Id <= 0) return BadRequest("Nevalidan ID događaja.");

            var dogadjaj = await DTOManager.azurirajDogadjajAsync(d);
            return Ok(dogadjaj);
        }

        [HttpDelete]
        [Route("obrisiDogadjaj/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ObrisiDogadjaj(int id)
        {
            if (id <= 0) return BadRequest("Nevalidan ID događaja.");

            await DTOManager.obrisiDogadjajAsync(id);
            return StatusCode(204);
        }
    }
}