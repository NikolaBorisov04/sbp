using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NezgodeController : ControllerBase
    {
        [HttpGet]
        [Route("sve")]
        public IActionResult vratiSveNezgodeStete([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            var rez = DTOManager.vratiSveNezgodeStete(voziloId);
            return Ok(rez);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult vratiNezgoduStetu(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID nezgode/štete." });
            }

            var rez = DTOManager.vratiNezgoduStetu(id);
            if (rez == null)
            {
                return NotFound(new { greska = "Nezgoda/šteta sa zadatim ID-jem nije pronađena." });
            }

            return Ok(rez);
        }

        [HttpPost]
        [Route("")]
        public IActionResult dodajNezgoduStetu([FromBody] NezgodaStetaCreate nb)
        {
            if (nb == null)
            {
                return BadRequest(new { greska = "Podaci o nezgodi/šteti nisu prosleđeni." });
            }

            if (nb.VoziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            if (nb.OdgovornostId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID odgovornosti." });
            }

            NezgodaStetaBasic nb_internal = new NezgodaStetaBasic
            {
                Id = 0,
                VoziloId = nb.VoziloId,
                OdgovornostId = nb.OdgovornostId,
                ProcenaStete = nb.ProcenaStete,
                Fotografije = nb.Fotografije,
                OsiguravajuceKuce = nb.OsiguravajuceKuce,
                Zapisnici = nb.Zapisnici
            };

            bool uspesno = DTOManager.dodajNezgoduStetu(nb_internal);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom evidentiranja nezgode/štete." });
            }

            return Ok(new { poruka = "Nezgoda/šteta je uspešno evidentirana." });
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult azurirajNezgoduStetu(int id, [FromBody] NezgodaStetaUpdate nb)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID nezgode/štete." });
            }

            if (nb == null)
            {
                return BadRequest(new { greska = "Podaci o nezgodi/šteti nisu prosleđeni." });
            }

            if (nb.Id != id)
            {
                return BadRequest(new { greska = "ID u URL-u i u body-ju se ne poklapaju." });
            }

            NezgodaStetaBasic nb_internal = new NezgodaStetaBasic
            {
                Id = nb.Id,
                VoziloId = nb.VoziloId,
                OdgovornostId = nb.OdgovornostId,
                ProcenaStete = nb.ProcenaStete
            };

            bool uspesno = DTOManager.azurirajNezgoduStetu(nb_internal);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom ažuriranja nezgode/štete." });
            }

            return Ok(new { poruka = "Nezgoda/šteta je uspešno ažurirana." });
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult obrisiNezgoduStetu(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID nezgode/štete." });
            }

            bool uspesno = DTOManager.obrisiNezgoduStetu(id);
            if (!uspesno)
            {
                return NotFound(new { greska = "Nezgoda/šteta sa zadatim ID-jem nije pronađena." });
            }

            return Ok(new { poruka = "Nezgoda/šteta je uspešno obrisana." });
        }

        [HttpPost]
        [Route("{nezgodaId}/fotografije")]
        public IActionResult dodajFotografijuStete(int nezgodaId, [FromBody] string url)
        {
            if (nezgodaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID nezgode/štete." });
            }

            if (string.IsNullOrWhiteSpace(url))
            {
                return BadRequest(new { greska = "URL fotografije ne sme biti prazan." });
            }

            bool uspesno = DTOManager.dodajFotografijuStete(nezgodaId, url);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom dodavanja fotografije štete." });
            }

            return Ok(new { poruka = "Fotografija štete je uspešno dodata." });
        }

        [HttpDelete]
        [Route("fotografije/{fotoId}")]
        public IActionResult obrisiFotografijuStete(int fotoId)
        {
            if (fotoId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID fotografije." });
            }

            bool uspesno = DTOManager.obrisiFotografijuStete(fotoId);
            if (!uspesno)
            {
                return NotFound(new { greska = "Fotografija sa zadatim ID-jem nije pronađena." });
            }

            return Ok(new { poruka = "Fotografija štete je uspešno obrisana." });
        }

        [HttpPost]
        [Route("{nezgodaId}/osiguravajuce-kuce")]
        public IActionResult dodajOsiguravajucuKucuStete(int nezgodaId, [FromBody] string kuca)
        {
            if (nezgodaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID nezgode/štete." });
            }

            if (string.IsNullOrWhiteSpace(kuca))
            {
                return BadRequest(new { greska = "Naziv osiguravajuće kuće ne sme biti prazan." });
            }

            bool uspesno = DTOManager.dodajOsiguravajucuKucuStete(nezgodaId, kuca);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom dodavanja osiguravajuće kuće." });
            }

            return Ok(new { poruka = "Osiguravajuća kuća je uspešno dodata." });
        }

        [HttpDelete]
        [Route("osiguravajuce-kuce/{kucaId}")]
        public IActionResult obrisiOsiguravajucuKucuStete(int kucaId)
        {
            if (kucaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID osiguravajuće kuće." });
            }

            bool uspesno = DTOManager.obrisiOsiguravajucuKucuStete(kucaId);
            if (!uspesno)
            {
                return NotFound(new { greska = "Osiguravajuća kuća sa zadatim ID-jem nije pronađena." });
            }

            return Ok(new { poruka = "Osiguravajuća kuća je uspešno obrisana." });
        }

        [HttpPost]
        [Route("{nezgodaId}/zapisnici")]
        public IActionResult dodajZapisnikStete(int nezgodaId, [FromBody] string url)
        {
            if (nezgodaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID nezgode/štete." });
            }

            if (string.IsNullOrWhiteSpace(url))
            {
                return BadRequest(new { greska = "URL zapisnika ne sme biti prazan." });
            }

            bool uspesno = DTOManager.dodajZapisnikStete(nezgodaId, url);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom dodavanja zapisnika." });
            }

            return Ok(new { poruka = "Zapisnik je uspešno dodat." });
        }

        [HttpDelete]
        [Route("zapisnici/{zapisnikId}")]
        public IActionResult obrisiZapisnikStete(int zapisnikId)
        {
            if (zapisnikId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID zapisnika." });
            }

            bool uspesno = DTOManager.obrisiZapisnikStete(zapisnikId);
            if (!uspesno)
            {
                return NotFound(new { greska = "Zapisnik sa zadatim ID-jem nije pronađen." });
            }

            return Ok(new { poruka = "Zapisnik je uspešno obrisan." });
        }

        [HttpGet]
        [Route("katalog/tipovi-odgovornosti")]
        public IActionResult vratiSveTipoveOdgovornosti()
        {
            var rez = DTOManager.vratiSveTipoveOdgovornosti();
            return Ok(rez);
        }
    }
}