using FluentNHibernateTemplate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RezervacijeController : Controller
    {
        [HttpGet]
        [Route("vratiSveRezervacije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> vratiSveRezervacije()
        {
            var rezervacije = await DTOManager.vratiSveRezervacijeAsync();
            return Ok(rezervacije);
        }

        [HttpGet]
        [Route("VratiSveSluzbeneVoznje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> VratiSveSluzbeneVoznje()
        {
            var sluzbeneVoznje = await DTOManager.vratiSveSluzbeneVoznjeAsync();
            return Ok(sluzbeneVoznje);
        }

        [HttpGet]
        [Route("vratiRezervaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> VratiRezervaciju(int id)
        {
            if (id <= 0) return BadRequest("Nevalidan ID rezervacije.");

            var rezervacija = await DTOManager.vratiRezervacijuAsync(id);
            return Ok(rezervacija);
        }

        [HttpPost]
        [Route("dodajRezervaciju")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DodajRezervaciju([FromBody] RezervacijaPregled rez)
        {
            if (rez == null) return BadRequest("Podaci o rezervaciji nisu prosleđeni.");
            if (rez.KorisnikId <= 0) return BadRequest("Nevalidan ID korisnika.");
            if (rez.VoziloId <= 0) return BadRequest("Nevalidan ID vozila.");

            var rezervacija = await DTOManager.dodajRezervacijuAsync(rez);
            return StatusCode(201, rezervacija);
        }

        [HttpPost]
        [Route("dodajSluzbenuVoznju")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DodajSluzbenuVoznju([FromBody] SluzbenaVoznjaPregled v)
        {
            if (v == null) return BadRequest("Podaci o službenoj vožnji nisu prosleđeni.");
            if (v.KorisnikId <= 0) return BadRequest("Nevalidan ID korisnika.");
            if (v.VoziloId <= 0) return BadRequest("Nevalidan ID vozila.");

            var sluzbenaVoznja = await DTOManager.dodajSluzbenuVoznjuAsync(v);
            return StatusCode(201, sluzbenaVoznja);
        }

        [HttpPut]
        [Route("azurirajRezervaciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AzurirajRezervaciju([FromBody] RezervacijaPregled rez)
        {
            if (rez == null) return BadRequest("Podaci o rezervaciji nisu prosleđeni.");
            if (rez.Id <= 0) return BadRequest("Nevalidan ID rezervacije.");

            var rezervacija = await DTOManager.azurirajRezervacijuAsync(rez);
            return Ok(rezervacija);
        }

        [HttpPut]
        [Route("azurirajSluzbenuVoznju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> AzurirajSluzbenuVoznju([FromBody] SluzbenaVoznjaPregled v)
        {
            if (v == null) return BadRequest("Podaci o službenoj vožnji nisu prosleđeni.");
            if (v.Id <= 0) return BadRequest("Nevalidan ID službene vožnje.");

            var sluzbenaVoznja = await DTOManager.azurirajSluzbenuVoznjuAsync(v);
            return Ok(sluzbenaVoznja);
        }

        [HttpDelete]
        [Route("obrisiRezervaciju/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> ObrisiRezervaciju(int id)
        {
            if (id <= 0) return BadRequest("Nevalidan ID rezervacije.");

            await DTOManager.obrisiRezervacijuAsync(id);
            return StatusCode(204);
        }
    }
}
