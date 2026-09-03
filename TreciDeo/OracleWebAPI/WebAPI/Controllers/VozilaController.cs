using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VozilaController : ControllerBase
    {
        [HttpGet]
        [Route("sve")]
        public IActionResult vratiSvaVozila()
        {
            var rez = DTOManager.vratiSvaVozila();
            return Ok(rez);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult vratiVozilo(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            var rez = DTOManager.vratiVozilo(id);
            if (rez == null)
            {
                return NotFound(new { greska = "Nije pronađeno vozilo sa zadatim ID-jem." });
            }
            return Ok(rez);
        }

        [HttpPost]
        [Route("")]
        public IActionResult dodajVozilo([FromBody] VoziloCreate vb)
        {
            if (vb == null)
            {
                return BadRequest(new { greska = "Podaci o vozilu nisu prosleđeni." });
            }

            if (string.IsNullOrWhiteSpace(vb.RegistarskaOznaka))
            {
                return BadRequest(new { greska = "Registarska oznaka je obavezna." });
            }

            if (vb.TipPogonaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID tipa pogona." });
            }

            if (vb.TipKoriscenjaId <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID tipa koriscenja." });
            }

            VoziloBasic vb_internal = new VoziloBasic
            {
                Id = 0,
                RegistarskaOznaka = vb.RegistarskaOznaka,
                Vin = vb.Vin,
                Marka = vb.Marka,
                Model = vb.Model,
                GodinaProizvodnje = vb.GodinaProizvodnje,
                DatumNabavke = vb.DatumNabavke,
                Status = vb.Status,
                BrojSedista = vb.BrojSedista,
                StanjeEnterijera = vb.StanjeEnterijera,
                StanjeEksterijera = vb.StanjeEksterijera,
                OgranicenjaKoriscenja = vb.OgranicenjaKoriscenja,
                TipKoriscenjaId = vb.TipKoriscenjaId,
                TipPogonaId = vb.TipPogonaId,
                KapacitetBaterije = vb.KapacitetBaterije,
                TrenutniNivoNapunjenosti = vb.TrenutniNivoNapunjenosti,
                Autonomija = vb.Autonomija,
                TipPunjenja = vb.TipPunjenja,
                BrojCiklusaPunjenja = vb.BrojCiklusaPunjenja,
                TipHibridnogPogona = vb.TipHibridnogPogona,
                TipGoriva = vb.TipGoriva,
                ZapreminaRezervoara = vb.ZapreminaRezervoara,
                ProsecnaPotrosnja = vb.ProsecnaPotrosnja
            };

            bool uspesno = DTOManager.dodajVozilo(vb_internal);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom dodavanja vozila." });
            }

            return Ok(new { poruka = "Vozilo je uspešno dodato." });
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult azurirajVozilo(int id, [FromBody] VoziloUpdate vb)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            if (vb == null)
            {
                return BadRequest(new { greska = "Podaci o vozilu nisu prosleđeni." });
            }

            if (vb.Id != id)
            {
                return BadRequest(new { greska = "ID u URL-u i u body-ju se ne poklapaju." });
            }

            if (string.IsNullOrWhiteSpace(vb.RegistarskaOznaka))
            {
                return BadRequest(new { greska = "Registarska oznaka je obavezna." });
            }

            VoziloBasic vb_internal = new VoziloBasic
            {
                Id = vb.Id,
                RegistarskaOznaka = vb.RegistarskaOznaka,
                Vin = vb.Vin,
                Marka = vb.Marka,
                Model = vb.Model,
                GodinaProizvodnje = vb.GodinaProizvodnje,
                DatumNabavke = vb.DatumNabavke,
                Status = vb.Status,
                BrojSedista = vb.BrojSedista,
                StanjeEnterijera = vb.StanjeEnterijera,
                StanjeEksterijera = vb.StanjeEksterijera,
                OgranicenjaKoriscenja = vb.OgranicenjaKoriscenja,
                TipKoriscenjaId = vb.TipKoriscenjaId,
                TipPogonaId = vb.TipPogonaId,
                KapacitetBaterije = vb.KapacitetBaterije,
                TrenutniNivoNapunjenosti = vb.TrenutniNivoNapunjenosti,
                Autonomija = vb.Autonomija,
                TipPunjenja = vb.TipPunjenja,
                BrojCiklusaPunjenja = vb.BrojCiklusaPunjenja,
                TipHibridnogPogona = vb.TipHibridnogPogona,
                TipGoriva = vb.TipGoriva,
                ZapreminaRezervoara = vb.ZapreminaRezervoara,
                ProsecnaPotrosnja = vb.ProsecnaPotrosnja
            };

            bool uspesno = DTOManager.azurirajVozilo(vb_internal);
            if (!uspesno)
            {
                return BadRequest(new { greska = "Došlo je do greške prilikom ažuriranja vozila ili vozilo ne postoji." });
            }

            return Ok(new { poruka = "Vozilo je uspešno ažurirano." });
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult obrisiVozilo(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { greska = "Nevalidan ID vozila." });
            }

            bool uspesno = DTOManager.obrisiVozilo(id);
            if (!uspesno)
            {
                return NotFound(new { greska = "Vozilo sa zadatim ID-jem nije pronađeno ili ne može biti obrisano." });
            }

            return Ok(new { poruka = "Vozilo je uspešno obrisano." });
        }

        [HttpGet]
        [Route("katalog/tipovi-pogona")]
        public IActionResult vratiSveTipovePogona()
        {
            var rez = DTOManager.vratiSveTipovePogona();
            return Ok(rez);
        }

        [HttpGet]
        [Route("katalog/tipovi-koriscenja")]
        public IActionResult vratiSveTipoveKoriscenja()
        {
            var rez = DTOManager.vratiSveTipoveKoriscenja();
            return Ok(rez);
        }
    }
}