using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VozilaController : ControllerBase
    {
        [HttpGet]
        [Route("vratiSvaVozila")]
        public IActionResult vratiSvaVozila()
        {
            var rez = DTOManager.vratiSvaVozila();
            return Ok(rez);
        }
        [HttpGet]
        [Route("vratiVozilo/{id}")]
        public IActionResult vratiVozilo(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            var rez = DTOManager.vratiVozilo(id);
            if (rez == null)
            {
                return NotFound("Nije pronađeno vozilo sa zadatim ID-jem.");
            }
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajVozilo")]
        public IActionResult dodajVozilo([FromBody] VoziloBasic vb)
        {
            if (vb == null)
            {
                return BadRequest("Podaci o vozilu nisu prosleđeni.");
            }

            if (string.IsNullOrWhiteSpace(vb.RegistarskaOznaka))
            {
                return BadRequest("Registarska oznaka je obavezna.");
            }

            bool uspesno = DTOManager.dodajVozilo(vb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja vozila.");
            }

            return Ok("Vozilo je uspešno dodato.");
        }

        [HttpPut]
        [Route("azurirajVozilo")]
        public IActionResult azurirajVozilo([FromBody] VoziloBasic vb)
        {
            if (vb == null)
            {
                return BadRequest("Podaci o vozilu nisu prosleđeni.");
            }

            if (vb.Id <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            bool uspesno = DTOManager.azurirajVozilo(vb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja vozila ili vozilo ne postoji.");
            }

            return Ok("Vozilo je uspešno ažurirano.");
        }

        [HttpDelete]
        [Route("obrisiVozilo/{id}")]
        public IActionResult obrisiVozilo(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            bool uspesno = DTOManager.obrisiVozilo(id);
            if (!uspesno)
            {
                return NotFound("Vozilo sa zadatim ID-jem nije pronađeno ili ne može biti obrisano.");
            }

            return Ok("Vozilo je uspešno obrisano.");
        }

        [HttpGet]
        [Route("vratiSvuOpremu")]
        public IActionResult vratiSvuOpremu()
        {
            var rez = DTOManager.vratiSvuOpremu();
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajOpremu")]
        public IActionResult dodajOpremu([FromBody] OpremaPregled op)
        {
            if (op == null)
            {
                return BadRequest("Podaci o opremi nisu prosleđeni.");
            }

            if (string.IsNullOrWhiteSpace(op.Naziv))
            {
                return BadRequest("Naziv opreme je obavezan.");
            }

            bool uspesno = DTOManager.dodajOpremu(op);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja opreme.");
            }

            return Ok("Oprema je uspešno dodata.");
        }

        [HttpPut]
        [Route("azurirajOpremu")]
        public IActionResult azurirajOpremu([FromBody] OpremaPregled op)
        {
            if (op == null)
            {
                return BadRequest("Podaci o opremi nisu prosleđeni.");
            }

            if (op.Id <= 0)
            {
                return BadRequest("Nevalidan ID opreme.");
            }

            if (string.IsNullOrWhiteSpace(op.Naziv))
            {
                return BadRequest("Naziv opreme je obavezan.");
            }

            bool uspesno = DTOManager.azurirajOpremu(op);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja opreme ili oprema ne postoji.");
            }

            return Ok("Oprema je uspešno ažurirana.");
        }

        [HttpDelete]
        [Route("obrisiOpremu/{id}")]
        public IActionResult obrisiOpremu(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID opreme.");
            }

            bool uspesno = DTOManager.obrisiOpremu(id);
            if (!uspesno)
            {
                return NotFound("Oprema sa zadatim ID-jem nije pronađena.");
            }

            return Ok("Oprema je uspešno obrisana.");
        }

        [HttpGet]
        [Route("vratiOpremuZaVozilo/{voziloId}")]
        public IActionResult vratiOpremuZaVozilo(int voziloId)
        {
            if (voziloId <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            var rez = DTOManager.vratiOpremuZaVozilo(voziloId);
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajOpremuVozilu/{voziloId}/{opremaId}")]
        public IActionResult dodajOpremuVozilu(int voziloId, int opremaId, [FromQuery] bool isDodatna = false)
        {
            if (voziloId <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            if (opremaId <= 0)
            {
                return BadRequest("Nevalidan ID opreme.");
            }

            bool uspesno = DTOManager.dodajOpremuVozilu(voziloId, opremaId, isDodatna);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodeljivanja opreme vozilu.");
            }

            return Ok("Oprema je uspešno dodeljena vozilu.");
        }

        [HttpDelete]
        [Route("obrisiOpremuSaVozila/{voziloId}/{opremaId}")]
        public IActionResult obrisiOpremuSaVozila(int voziloId, int opremaId)
        {
            if (voziloId <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            if (opremaId <= 0)
            {
                return BadRequest("Nevalidan ID opreme.");
            }

            bool uspesno = DTOManager.obrisiOpremuSaVozila(voziloId, opremaId);
            if (!uspesno)
            {
                return NotFound("Oprema za navedeno vozilo nije pronađena.");
            }

            return Ok("Oprema je uspešno uklonjena sa vozila.");
        }

        [HttpGet]
        [Route("vratiSvaPunjenjaTocenja")]
        public IActionResult vratiSvaPunjenjaTocenja([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            var rez = DTOManager.vratiSvaPunjenjaTocenja(voziloId);
            return Ok(rez);
        }

        [HttpGet]
        [Route("vratiPunjenjeTocenje/{id}")]
        public IActionResult vratiPunjenjeTocenje(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID punjenja/točenja.");
            }

            var rez = DTOManager.vratiPunjenjeTocenje(id);
            if (rez == null)
            {
                return NotFound("Evidencija o punjenju/točenju sa zadatim ID-jem nije pronađena.");
            }

            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajPunjenjeTocenje")]
        public IActionResult dodajPunjenjeTocenje([FromBody] PunjenjeTocenjeBasic pb)
        {
            if (pb == null)
            {
                return BadRequest("Podaci o punjenju/točenju nisu prosleđeni.");
            }

            if (pb.VoziloId <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            bool uspesno = DTOManager.dodajPunjenjeTocenje(pb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom evidentiranja punjenja/točenja.");
            }

            return Ok("Punjenje/točenje je uspešno evidentirano.");
        }

        [HttpPut]
        [Route("azurirajPunjenjeTocenje")]
        public IActionResult azurirajPunjenjeTocenje([FromBody] PunjenjeTocenjeBasic pb)
        {
            if (pb == null)
            {
                return BadRequest("Podaci o punjenju/točenju nisu prosleđeni.");
            }

            if (pb.Id <= 0)
            {
                return BadRequest("Nevalidan ID punjenja/točenja.");
            }

            bool uspesno = DTOManager.azurirajPunjenjeTocenje(pb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja punjenja/točenja.");
            }

            return Ok("Punjenje/točenje je uspešno ažurirano.");
        }

        [HttpDelete]
        [Route("obrisiPunjenjeTocenje/{id}")]
        public IActionResult obrisiPunjenjeTocenje(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID punjenja/točenja.");
            }

            bool uspesno = DTOManager.obrisiPunjenjeTocenje(id);
            if (!uspesno)
            {
                return NotFound("Evidencija o punjenju/točenju nije pronađena.");
            }

            return Ok("Punjenje/točenje je uspešno obrisano.");
        }

        [HttpGet]
        [Route("vratiSveServise")]
        public IActionResult vratiSveServise([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            var rez = DTOManager.vratiSveServise(voziloId);
            return Ok(rez);
        }

        [HttpGet]
        [Route("vratiServis/{id}")]
        public IActionResult vratiServis(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID servisa.");
            }

            var rez = DTOManager.vratiServis(id);
            if (rez == null)
            {
                return NotFound("Servis sa zadatim ID-jem nije pronađen.");
            }

            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajServis")]
        public IActionResult dodajServis([FromBody] ServisBasic sb)
        {
            if (sb == null)
            {
                return BadRequest("Podaci o servisu nisu prosleđeni.");
            }

            if (sb.VoziloId <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            if (sb.TipServisaId <= 0)
            {
                return BadRequest("Nevalidan ID tipa servisa.");
            }

            bool uspesno = DTOManager.dodajServis(sb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom evidentiranja servisa.");
            }

            return Ok("Servis je uspešno evidentiran.");
        }

        [HttpPut]
        [Route("azurirajServis")]
        public IActionResult azurirajServis([FromBody] ServisBasic sb)
        {
            if (sb == null)
            {
                return BadRequest("Podaci o servisu nisu prosleđeni.");
            }

            if (sb.Id <= 0)
            {
                return BadRequest("Nevalidan ID servisa.");
            }

            bool uspesno = DTOManager.azurirajServis(sb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja servisa.");
            }

            return Ok("Servis je uspešno ažuriran.");
        }

        [HttpDelete]
        [Route("obrisiServis/{id}")]
        public IActionResult obrisiServis(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID servisa.");
            }

            bool uspesno = DTOManager.obrisiServis(id);
            if (!uspesno)
            {
                return NotFound("Servis sa zadatim ID-jem nije pronađen.");
            }

            return Ok("Servis je uspešno obrisan.");
        }

        [HttpGet]
        [Route("vratiSveKvarove")]
        public IActionResult vratiSveKvarove([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            var rez = DTOManager.vratiSveKvarove(voziloId);
            return Ok(rez);
        }

        [HttpGet]
        [Route("vratiKvar/{id}")]
        public IActionResult vratiKvar(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID kvara.");
            }

            var rez = DTOManager.vratiKvar(id);
            if (rez == null)
            {
                return NotFound("Kvar sa zadatim ID-jem nije pronađen.");
            }

            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajKvar")]
        public IActionResult dodajKvar([FromBody] KvarBasic kb)
        {
            if (kb == null)
            {
                return BadRequest("Podaci o kvaru nisu prosleđeni.");
            }

            if (kb.VoziloId <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            if (kb.PrijavioId <= 0)
            {
                return BadRequest("Nevalidan ID prijavitelja kvara.");
            }

            bool uspesno = DTOManager.dodajKvar(kb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom prijave kvara.");
            }

            return Ok("Kvar je uspešno evidentiran.");
        }

        [HttpPut]
        [Route("azurirajKvar")]
        public IActionResult azurirajKvar([FromBody] KvarBasic kb)
        {
            if (kb == null)
            {
                return BadRequest("Podaci o kvaru nisu prosleđeni.");
            }

            if (kb.Id <= 0)
            {
                return BadRequest("Nevalidan ID kvara.");
            }

            bool uspesno = DTOManager.azurirajKvar(kb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja kvara.");
            }

            return Ok("Kvar je uspešno ažuriran.");
        }

        [HttpDelete]
        [Route("obrisiKvar/{id}")]
        public IActionResult obrisiKvar(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID kvara.");
            }

            bool uspesno = DTOManager.obrisiKvar(id);
            if (!uspesno)
            {
                return NotFound("Kvar sa zadatim ID-jem nije pronađen.");
            }

            return Ok("Kvar je uspešno obrisan.");
        }

        [HttpGet]
        [Route("vratiSveNezgodeStete")]
        public IActionResult vratiSveNezgodeStete([FromQuery] int? voziloId = null)
        {
            if (voziloId.HasValue && voziloId.Value <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            var rez = DTOManager.vratiSveNezgodeStete(voziloId);
            return Ok(rez);
        }

        [HttpGet]
        [Route("vratiNezgoduStetu/{id}")]
        public IActionResult vratiNezgoduStetu(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID nezgode/štete.");
            }

            var rez = DTOManager.vratiNezgoduStetu(id);
            if (rez == null)
            {
                return NotFound("Nezgoda/šteta sa zadatim ID-jem nije pronađena.");
            }

            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajNezgoduStetu")]
        public IActionResult dodajNezgoduStetu([FromBody] NezgodaStetaBasic nb)
        {
            if (nb == null)
            {
                return BadRequest("Podaci o nezgodi/šteti nisu prosleđeni.");
            }

            if (nb.VoziloId <= 0)
            {
                return BadRequest("Nevalidan ID vozila.");
            }

            if (nb.OdgovornostId <= 0)
            {
                return BadRequest("Nevalidan ID odgovornosti.");
            }

            bool uspesno = DTOManager.dodajNezgoduStetu(nb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom evidentiranja nezgode/štete.");
            }

            return Ok("Nezgoda/šteta je uspešno evidentirana.");
        }

        [HttpPut]
        [Route("azurirajNezgoduStetu")]
        public IActionResult azurirajNezgoduStetu([FromBody] NezgodaStetaBasic nb)
        {
            if (nb == null)
            {
                return BadRequest("Podaci o nezgodi/šteti nisu prosleđeni.");
            }

            if (nb.Id <= 0)
            {
                return BadRequest("Nevalidan ID nezgode/štete.");
            }

            bool uspesno = DTOManager.azurirajNezgoduStetu(nb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja nezgode/štete.");
            }

            return Ok("Nezgoda/šteta je uspešno ažurirana.");
        }

        [HttpDelete]
        [Route("obrisiNezgoduStetu/{id}")]
        public IActionResult obrisiNezgoduStetu(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID nezgode/štete.");
            }

            bool uspesno = DTOManager.obrisiNezgoduStetu(id);
            if (!uspesno)
            {
                return NotFound("Nezgoda/šteta sa zadatim ID-jem nije pronađena.");
            }

            return Ok("Nezgoda/šteta je uspešno obrisana.");
        }

        [HttpPost]
        [Route("dodajFotografijuStete/{nezgodaId}")]
        public IActionResult dodajFotografijuStete(int nezgodaId, [FromBody] string url)
        {
            if (nezgodaId <= 0)
            {
                return BadRequest("Nevalidan ID nezgode/štete.");
            }

            if (string.IsNullOrWhiteSpace(url))
            {
                return BadRequest("URL fotografije ne sme biti prazan.");
            }

            bool uspesno = DTOManager.dodajFotografijuStete(nezgodaId, url);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja fotografije štete.");
            }

            return Ok("Fotografija štete je uspešno dodata.");
        }

        [HttpDelete]
        [Route("obrisiFotografijuStete/{fotoId}")]
        public IActionResult obrisiFotografijuStete(int fotoId)
        {
            if (fotoId <= 0)
            {
                return BadRequest("Nevalidan ID fotografije.");
            }

            bool uspesno = DTOManager.obrisiFotografijuStete(fotoId);
            if (!uspesno)
            {
                return NotFound("Fotografija sa zadatim ID-jem nije pronađena.");
            }

            return Ok("Fotografija štete je uspešno obrisana.");
        }

        [HttpPost]
        [Route("dodajOsiguravajucuKucuStete/{nezgodaId}")]
        public IActionResult dodajOsiguravajucuKucuStete(int nezgodaId, [FromBody] string kuca)
        {
            if (nezgodaId <= 0)
            {
                return BadRequest("Nevalidan ID nezgode/štete.");
            }

            if (string.IsNullOrWhiteSpace(kuca))
            {
                return BadRequest("Naziv osiguravajuće kuće ne sme biti prazan.");
            }

            bool uspesno = DTOManager.dodajOsiguravajucuKucuStete(nezgodaId, kuca);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja osiguravajuće kuće.");
            }

            return Ok("Osiguravajuća kuća je uspešno dodata.");
        }

        [HttpDelete]
        [Route("obrisiOsiguravajucuKucuStete/{kucaId}")]
        public IActionResult obrisiOsiguravajucuKucuStete(int kucaId)
        {
            if (kucaId <= 0)
            {
                return BadRequest("Nevalidan ID osiguravajuće kuće.");
            }

            bool uspesno = DTOManager.obrisiOsiguravajucuKucuStete(kucaId);
            if (!uspesno)
            {
                return NotFound("Osiguravajuća kuća sa zadatim ID-jem nije pronađena.");
            }

            return Ok("Osiguravajuća kuća je uspešno obrisana.");
        }

        [HttpPost]
        [Route("dodajZapisnikStete/{nezgodaId}")]
        public IActionResult dodajZapisnikStete(int nezgodaId, [FromBody] string url)
        {
            if (nezgodaId <= 0)
            {
                return BadRequest("Nevalidan ID nezgode/štete.");
            }

            if (string.IsNullOrWhiteSpace(url))
            {
                return BadRequest("URL zapisnika ne sme biti prazan.");
            }

            bool uspesno = DTOManager.dodajZapisnikStete(nezgodaId, url);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja zapisnika.");
            }

            return Ok("Zapisnik je uspešno dodat.");
        }

        [HttpDelete]
        [Route("obrisiZapisnikStete/{zapisnikId}")]
        public IActionResult obrisiZapisnikStete(int zapisnikId)
        {
            if (zapisnikId <= 0)
            {
                return BadRequest("Nevalidan ID zapisnika.");
            }

            bool uspesno = DTOManager.obrisiZapisnikStete(zapisnikId);
            if (!uspesno)
            {
                return NotFound("Zapisnik sa zadatim ID-jem nije pronađen.");
            }

            return Ok("Zapisnik je uspešno obrisan.");
        }
    }
}
