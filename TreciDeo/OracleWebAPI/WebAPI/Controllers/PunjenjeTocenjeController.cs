using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PunjenjeTocenjeController : ControllerBase
    {
        [HttpGet]
        [Route("sve")]
        public IActionResult vratiSvaPunjenjaTocenja([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            try
            {
                var rez = DTOManager.vratiSvaPunjenjaTocenja(voziloId);
                return Ok(rez);
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult vratiPunjenjeTocenje(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID punjenja/točenja." });
            }

            try
            {
                var rez = DTOManager.vratiPunjenjeTocenje(id);
                if (rez == null)
                {
                    return NotFound(new { greska = "Evidencija o punjenju/točenju sa zadatim ID-jem nije pronađena." });
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
        public IActionResult dodajPunjenjeTocenje([FromBody] PunjenjeTocenjeCreate pb)
        {
            if (pb == null)
            {
                return BadRequest(new { greska = "Podaci o punjenju/točenju nisu prosleđeni." });
            }

            if (pb.VoziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            try
            {
                PunjenjeTocenjeBasic pb_internal = new PunjenjeTocenjeBasic
                {
                    Id = 0,
                    VoziloId = pb.VoziloId,
                    DatumVreme = pb.DatumVreme,
                    Lokacija = pb.Lokacija,
                    Kolicina = pb.Kolicina,
                    Cena = pb.Cena,
                    NacinEvidentiranja = pb.NacinEvidentiranja,
                    Evidentirao = pb.Evidentirao
                };

                bool uspesno = DTOManager.dodajPunjenjeTocenje(pb_internal);
                if (!uspesno)
                {
                    return BadRequest(new { greska = "Došlo je do greške prilikom evidentiranja punjenja/točenja." });
                }

                return Ok(new { poruka = "Punjenje/točenje je uspešno evidentirano." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult azurirajPunjenjeTocenje(int id, [FromBody] PunjenjeTocenjeUpdate pb)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID punjenja/točenja." });
            }

            if (pb == null)
            {
                return BadRequest(new { greska = "Podaci o punjenju/točenju nisu prosleđeni." });
            }

            if (pb.Id != id)
            {
                return BadRequest(new { greska = "ID u URL-u i u body-ju se ne poklapaju." });
            }

            if (pb.VoziloId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            try
            {
                PunjenjeTocenjeBasic pb_internal = new PunjenjeTocenjeBasic
                {
                    Id = pb.Id,
                    VoziloId = pb.VoziloId,
                    DatumVreme = pb.DatumVreme,
                    Lokacija = pb.Lokacija,
                    Kolicina = pb.Kolicina,
                    Cena = pb.Cena,
                    NacinEvidentiranja = pb.NacinEvidentiranja,
                    Evidentirao = pb.Evidentirao
                };

                bool uspesno = DTOManager.azurirajPunjenjeTocenje(pb_internal);
                if (!uspesno)
                {
                    return BadRequest(new { greska = "Došlo je do greške prilikom ažuriranja punjenja/točenja." });
                }

                return Ok(new { poruka = "Punjenje/točenje je uspešno ažurirano." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult obrisiPunjenjeTocenje(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID punjenja/točenja." });
            }

            try
            {
                bool uspesno = DTOManager.obrisiPunjenjeTocenje(id);
                if (!uspesno)
                {
                    return NotFound(new { greska = "Evidencija o punjenju/točenju nije pronađena." });
                }

                return Ok(new { poruka = "Punjenje/točenje je uspešno obrisano." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { greska = ex.Message });
            }
        }
    }
}
