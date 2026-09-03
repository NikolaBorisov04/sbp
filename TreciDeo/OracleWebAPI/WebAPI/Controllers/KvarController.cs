using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KvarController : ControllerBase
    {
        [HttpGet]
        [Route("sve")]
        public IActionResult vratiSveKvarove([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            var rez = DTOManager.vratiSveKvarove(voziloId);
            return Ok(rez);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult vratiKvar(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID kvara." });
            }

            var rez = DTOManager.vratiKvar(id);
            if (rez == null)
            {
                return NotFound(new { greska = "Kvar sa zadatim ID-jem nije pronađen." });
            }

            return Ok(rez);
        }

        [HttpPost]
        [Route("")]
        public IActionResult dodajKvar([FromBody] KvarCreate kb)
        {
            if (kb == null)
            {
                return BadRequest(new { greska = "Podaci o kvaru nisu prosleđeni." });
            }

            if (kb.VoziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            if (kb.PrijavioId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID prijavitelja kvara." });
            }

            KvarBasic kb_internal = new KvarBasic
            {
                Id = 0,
                VoziloId = kb.VoziloId,
                PrijavioId = kb.PrijavioId,
                DatumPrijave = kb.DatumPrijave,
                OpisProblema = kb.OpisProblema,
                ProcenaOzbiljnosti = kb.ProcenaOzbiljnosti,
                Status = kb.Status,
                DatumOtklanjanja = kb.DatumOtklanjanja
            };

            bool uspesno = DTOManager.dodajKvar(kb_internal);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom prijave kvara." });
            }

            return Ok(new { poruka = "Kvar je uspešno evidentiran." });
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult azurirajKvar(int id, [FromBody] KvarUpdate kb)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID kvara." });
            }

            if (kb == null)
            {
                return BadRequest(new { greska = "Podaci o kvaru nisu prosleđeni." });
            }

            if (kb.Id != id)
            {
                return BadRequest(new { greska = "ID u URL-u i u body-ju se ne poklapaju." });
            }

            KvarBasic kb_internal = new KvarBasic
            {
                Id = kb.Id,
                VoziloId = kb.VoziloId,
                PrijavioId = kb.PrijavioId,
                DatumPrijave = kb.DatumPrijave,
                OpisProblema = kb.OpisProblema,
                ProcenaOzbiljnosti = kb.ProcenaOzbiljnosti,
                Status = kb.Status,
                DatumOtklanjanja = kb.DatumOtklanjanja
            };

            bool uspesno = DTOManager.azurirajKvar(kb_internal);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom ažuriranja kvara." });
            }

            return Ok(new { poruka = "Kvar je uspešno ažuriran." });
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult obrisiKvar(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID kvara." });
            }

            bool uspesno = DTOManager.obrisiKvar(id);
            if (!uspesno)
            {
                return NotFound(new { greska = "Kvar sa zadatim ID-jem nije pronađen." });
            }

            return Ok(new { poruka = "Kvar je uspešno obrisan." });
        }

        [HttpGet]
        [Route("katalog/prijavitelji")]
        public IActionResult vratiSvePrijavioKvar()
        {
            var rez = DTOManager.vratiSvePrijavioKvar();
            return Ok(rez);
        }
    }
}