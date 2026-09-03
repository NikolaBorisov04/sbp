using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServisController : ControllerBase
    {
        [HttpGet]
        [Route("sve")]
        public IActionResult vratiSveServise([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            try
            {
                var rez = DTOManager.vratiSveServise(voziloId);
                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult vratiServis(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID servisa." });
            }

            try
            {
                var rez = DTOManager.vratiServis(id);
                if (rez == null)
                {
                    return NotFound(new { greska = "Servis sa zadatim ID-jem nije pronađen." });
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
        public IActionResult dodajServis([FromBody] ServisCreate sb)
        {
            if (sb == null)
            {
                return BadRequest(new { greska = "Podaci o servisu nisu prosleđeni." });
            }

            if (sb.VoziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            if (sb.TipServisaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID tipa servisa." });
            }

            try
            {
                ServisBasic sb_internal = new ServisBasic
                {
                    Id = 0,
                    VoziloId = sb.VoziloId,
                    TipServisaId = sb.TipServisaId,
                    ServisniCentar = sb.ServisniCentar,
                    DatumPrijema = sb.DatumPrijema,
                    DatumZavrsetka = sb.DatumZavrsetka,
                    OpisRadova = sb.OpisRadova,
                    ZamenjeniDelovi = sb.ZamenjeniDelovi,
                    Troskovi = sb.Troskovi,
                    Status = sb.Status
                };

                bool uspesno = DTOManager.dodajServis(sb_internal);
                if (!uspesno)
                {
                    return BadRequest(new { greska = "Došlo je do greške prilikom evidentiranja servisa." });
                }

                return Ok(new { poruka = "Servis je uspešno evidentiran." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult azurirajServis(int id, [FromBody] ServisUpdate sb)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID servisa." });
            }

            if (sb == null)
            {
                return BadRequest(new { greska = "Podaci o servisu nisu prosleđeni." });
            }

            if (sb.Id != id)
            {
                return BadRequest(new { greska = "ID u URL-u i u body-ju se ne poklapaju." });
            }

            try
            {
                ServisBasic sb_internal = new ServisBasic
                {
                    Id = sb.Id,
                    VoziloId = sb.VoziloId,
                    TipServisaId = sb.TipServisaId,
                    ServisniCentar = sb.ServisniCentar,
                    DatumPrijema = sb.DatumPrijema,
                    DatumZavrsetka = sb.DatumZavrsetka,
                    OpisRadova = sb.OpisRadova,
                    ZamenjeniDelovi = sb.ZamenjeniDelovi,
                    Troskovi = sb.Troskovi,
                    Status = sb.Status
                };

                bool uspesno = DTOManager.azurirajServis(sb_internal);
                if (!uspesno)
                {
                    return BadRequest(new { greska = "Došlo je do greške prilikom ažuriranja servisa." });
                }

                return Ok(new { poruka = "Servis je uspešno ažuriran." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult obrisiServis(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID servisa." });
            }

            try
            {
                bool uspesno = DTOManager.obrisiServis(id);
                if (!uspesno)
                {
                    return NotFound(new { greska = "Servis sa zadatim ID-jem nije pronađen." });
                }

                return Ok(new { poruka = "Servis je uspešno obrisan." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpGet]
        [Route("katalog/tipovi-servisa")]
        public IActionResult vratiSveTipoveServisa()
        {
            try
            {
                var rez = DTOManager.vratiSveTipoveServisa();
                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }
    }
}
