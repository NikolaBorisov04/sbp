using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpremaController : ControllerBase
    {
        [HttpGet]
        [Route("sve")]
        public IActionResult vratiSvuOpremu()
        {
            try
            {
                var rez = DTOManager.vratiSvuOpremu();
                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpPost]
        [Route("")]
        public IActionResult dodajOpremu([FromBody] OpremaCreate op)
        {
            if (op == null)
            {
                return BadRequest(new { greska = "Podaci o opremi nisu prosleđeni." });
            }

            if (string.IsNullOrWhiteSpace(op.Naziv))
            {
                return BadRequest(new { greska = "Naziv opreme je obavezan." });
            }

            try
            {
                OpremaPregled op_pregled = new OpremaPregled
                {
                    Id = 0,
                    Naziv = op.Naziv,
                    Opis = op.Opis
                };

                bool uspesno = DTOManager.dodajOpremu(op_pregled);
                if (!uspesno)
                {
                    return BadRequest(new { greska = "Došlo je do greške prilikom dodavanja opreme." });
                }

                return Ok(new { poruka = "Oprema je uspešno dodata." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult azurirajOpremu(int id, [FromBody] OpremaUpdate op)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID opreme." });
            }

            if (op == null)
            {
                return BadRequest(new { greska = "Podaci o opremi nisu prosleđeni." });
            }

            if (op.Id != id)
            {
                return BadRequest(new { greska = "ID u URL-u i u body-ju se ne poklapaju." });
            }

            if (string.IsNullOrWhiteSpace(op.Naziv))
            {
                return BadRequest(new { greska = "Naziv opreme je obavezan." });
            }

            try
            {
                OpremaPregled op_pregled = new OpremaPregled
                {
                    Id = op.Id,
                    Naziv = op.Naziv,
                    Opis = op.Opis
                };

                bool uspesno = DTOManager.azurirajOpremu(op_pregled);
                if (!uspesno)
                {
                    return BadRequest(new { greska = "Došlo je do greške prilikom ažuriranja opreme ili oprema ne postoji." });
                }

                return Ok(new { poruka = "Oprema je uspešno ažurirana." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult obrisiOpremu(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID opreme." });
            }

            try
            {
                bool uspesno = DTOManager.obrisiOpremu(id);
                if (!uspesno)
                {
                    return NotFound(new { greska = "Oprema sa zadatim ID-jem nije pronađena." });
                }

                return Ok(new { poruka = "Oprema je uspešno obrisana." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpGet]
        [Route("vozilo/{voziloId}")]
        public IActionResult vratiOpremuZaVozilo(int voziloId)
        {
            if (voziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            try
            {
                var rez = DTOManager.vratiOpremuZaVozilo(voziloId);
                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpPost]
        [Route("vozilo/{voziloId}/oprema/{opremaId}")]
        public IActionResult dodajOpremuVozilu(int voziloId, int opremaId, [FromQuery] bool isDodatna = false)
        {
            if (voziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            if (opremaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID opreme." });
            }

            try
            {
                bool uspesno = DTOManager.dodajOpremuVozilu(voziloId, opremaId, isDodatna);
                if (!uspesno)
                {
                    return BadRequest(new { greska = "Došlo je do greške prilikom dodeljivanja opreme vozilu." });
                }

                return Ok(new { poruka = "Oprema je uspešno dodeljena vozilu." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpDelete]
        [Route("vozilo/{voziloId}/oprema/{opremaId}")]
        public IActionResult obrisiOpremuSaVozila(int voziloId, int opremaId)
        {
            if (voziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            if (opremaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID opreme." });
            }

            try
            {
                bool uspesno = DTOManager.obrisiOpremuSaVozila(voziloId, opremaId);
                if (!uspesno)
                {
                    return NotFound(new { greska = "Oprema za navedeno vozilo nije pronađena." });
                }

                return Ok(new { poruka = "Oprema je uspešno uklonjena sa vozila." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }
    }
}
