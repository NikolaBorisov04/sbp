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

            try
            {
                var rez = DTOManager.vratiSveKvarove(voziloId);
                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult vratiKvar(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID kvara." });
            }

            try
            {
                var rez = DTOManager.vratiKvar(id);
                if (rez == null)
                {
                    return NotFound(new { greska = "Kvar sa zadatim ID-jem nije pronađen." });
                }

                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
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

            try
            {
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
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
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

            try
            {
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
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult obrisiKvar(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID kvara." });
            }

            try
            {
                bool uspesno = DTOManager.obrisiKvar(id);
                if (!uspesno)
                {
                    return NotFound(new { greska = "Kvar sa zadatim ID-jem nije pronađen." });
                }

                return Ok(new { poruka = "Kvar je uspešno obrisan." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpGet]
        [Route("katalog/prijavitelji")]
        public IActionResult vratiSvePrijavioKvar()
        {
            try
            {
                var rez = DTOManager.vratiSvePrijavioKvar();
                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }
    }
}
