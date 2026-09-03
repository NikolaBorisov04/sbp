using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentNHibernateTemplate;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        //KORISNICI
        [HttpGet]
        [Route("vratiSveKorisnike")]
        public IActionResult vratiSveKorisnike()
        {
            var rez = DTOManager.vratiSveKorisnike();
            return Ok(rez);
        }

        [HttpGet]
        [Route("vratiSvaFizickaLica")]
        public IActionResult vratiSvaFizickaLica()
        {
            var rez = DTOManager.vratiSvaFizickaLica();
            return Ok(rez);
        }

        [HttpGet]
        [Route("vratiKorisnika/{id}")]
        public IActionResult vratiKorisnika(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            var rez = DTOManager.vratiKorisnika(id);
            if (rez == null)
            {
                return NotFound("Nije pronađen korisnik sa zadatim ID-jem.");
            }
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajKorisnika")]
        public IActionResult dodajKorisnika([FromBody] KorisnikBasic kb)
        {
            if (kb == null)
            {
                return BadRequest("Podaci o korisniku nisu prosleđeni.");
            }

            if (kb.TipKorisnikaId <= 0)
            {
                return BadRequest("Nevalidan ID tipa korisnika.");
            }

            if (string.IsNullOrWhiteSpace(kb.EmailAdresa))
            {
                return BadRequest("Email adresa je obavezna.");
            }

            bool uspesno = DTOManager.dodajKorisnika(kb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja korisnika.");
            }

            return Ok("Korisnik je uspešno dodat.");
        }

        [HttpPut]
        [Route("azurirajKorisnika")]
        public IActionResult azurirajKorisnika([FromBody] KorisnikBasic kb)
        {
            if (kb == null)
            {
                return BadRequest("Podaci o korisniku nisu prosleđeni.");
            }

            if (kb.Id <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            bool uspesno = DTOManager.azurirajKorisnika(kb);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja korisnika ili korisnik ne postoji.");
            }

            return Ok("Korisnik je uspešno ažuriran.");
        }

        [HttpDelete]
        [Route("obrisiKorisnika/{id}")]
        public IActionResult obrisiKorisnika(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            bool uspesno = DTOManager.obrisiKorisnika(id);
            if (!uspesno)
            {
                return NotFound("Korisnik sa zadatim ID-jem nije pronađen.");
            }

            return Ok("Korisnik je uspešno obrisan.");
        }

        //TIPOVI KORISNIKA

        [HttpGet]
        [Route("vratiSveTipoveKorisnika")]
        public IActionResult vratiSveTipoveKorisnika()
        {
            var rez = DTOManager.vratiSveTipoveKorisnika();
            return Ok(rez);
        }

        //TELEFONI KORISNIKA

        [HttpGet]
        [Route("vratiTelefoneKorisnika/{korisnikId}")]
        public IActionResult vratiTelefoneKorisnika(int korisnikId)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            var rez = DTOManager.vratiTelefoneKorisnika(korisnikId);
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajTelefonKorisniku/{korisnikId}")]
        public IActionResult dodajTelefonKorisniku(int korisnikId, [FromBody] string brojTelefona)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            if (string.IsNullOrWhiteSpace(brojTelefona))
            {
                return BadRequest("Broj telefona ne sme biti prazan.");
            }

            bool uspesno = DTOManager.dodajTelefonKorisniku(korisnikId, brojTelefona);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja telefona.");
            }

            return Ok("Telefon je uspešno dodat korisniku.");
        }

        [HttpDelete]
        [Route("obrisiTelefonKorisnika/{telefonId}")]
        public IActionResult obrisiTelefonKorisnika(int telefonId)
        {
            if (telefonId <= 0)
            {
                return BadRequest("Nevalidan ID telefona.");
            }

            bool uspesno = DTOManager.obrisiTelefonKorisnika(telefonId);
            if (!uspesno)
            {
                return NotFound("Telefon sa zadatim ID-jem nije pronađen.");
            }

            return Ok("Telefon je uspešno obrisan.");
        }

        //VERIFIKACIJE KORISNIKA

        [HttpGet]
        [Route("vratiVerifikacijeKorisnika/{korisnikId}")]
        public IActionResult vratiVerifikacijeKorisnika(int korisnikId)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            var rez = DTOManager.vratiVerifikacijeKorisnika(korisnikId);
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajVerifikacijuKorisniku/{korisnikId}")]
        public IActionResult dodajVerifikacijuKorisniku(int korisnikId, [FromBody] VerifikacijaPregled vp)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            if (vp == null)
            {
                return BadRequest("Podaci o verifikaciji nisu prosleđeni.");
            }

            if (string.IsNullOrWhiteSpace(vp.Verifikator))
            {
                return BadRequest("Verifikator je obavezan.");
            }

            if (string.IsNullOrWhiteSpace(vp.Rezultat))
            {
                return BadRequest("Rezultat verifikacije je obavezan.");
            }

            bool uspesno = DTOManager.dodajVerifikacijuKorisniku(korisnikId, vp.DatumVerifikacije, vp.Verifikator, vp.Rezultat, vp.Ogranicenja);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja verifikacije.");
            }

            return Ok("Verifikacija je uspešno dodata korisniku.");
        }

        [HttpDelete]
        [Route("obrisiVerifikacijuKorisnika/{verifikacijaId}")]
        public IActionResult obrisiVerifikacijuKorisnika(int verifikacijaId)
        {
            if (verifikacijaId <= 0)
            {
                return BadRequest("Nevalidan ID verifikacije.");
            }

            bool uspesno = DTOManager.obrisiVerifikacijuKorisnika(verifikacijaId);
            if (!uspesno)
            {
                return NotFound("Verifikacija sa zadatim ID-jem nije pronađena.");
            }

            return Ok("Verifikacija je uspešno obrisana.");
        }

        //NAČINI PLAĆANJA KORISNIKA

        [HttpGet]
        [Route("vratiNacinePlacanjaKorisnika/{korisnikId}")]
        public IActionResult vratiNacinePlacanjaKorisnika(int korisnikId)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            var rez = DTOManager.vratiNacinePlacanjaKorisnika(korisnikId);
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajNacinPlacanjaKorisniku/{korisnikId}")]
        public IActionResult dodajNacinPlacanjaKorisniku(int korisnikId, [FromBody] NacinPlacanjaPregled np)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            if (np == null)
            {
                return BadRequest("Podaci o načinu plaćanja nisu prosleđeni.");
            }

            if (string.IsNullOrWhiteSpace(np.TipPlacanja))
            {
                return BadRequest("Tip plaćanja je obavezan.");
            }

            if (string.IsNullOrWhiteSpace(np.Status))
            {
                return BadRequest("Status načina plaćanja je obavezan.");
            }

            bool uspesno = DTOManager.dodajNacinPlacanjaKorisniku(korisnikId, np.TipPlacanja, np.Status, np.DatumDodavanja, np.Ogranicenja);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja načina plaćanja.");
            }

            return Ok("Način plaćanja je uspešno dodat korisniku.");
        }

        [HttpDelete]
        [Route("obrisiNacinPlacanjaKorisnika/{nacinId}")]
        public IActionResult obrisiNacinPlacanjaKorisnika(int nacinId)
        {
            if (nacinId <= 0)
            {
                return BadRequest("Nevalidan ID načina plaćanja.");
            }

            bool uspesno = DTOManager.obrisiNacinPlacanjaKorisnika(nacinId);
            if (!uspesno)
            {
                return NotFound("Način plaćanja sa zadatim ID-jem nije pronađen.");
            }

            return Ok("Način plaćanja je uspešno obrisan.");
        }

        //ULOGE

        [HttpGet]
        [Route("vratiSveUloge")]
        public IActionResult vratiSveUloge()
        {
            var rez = DTOManager.vratiSveUloge();
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajUlogu")]
        public IActionResult dodajUlogu([FromBody] UlogaPregled up)
        {
            if (up == null)
            {
                return BadRequest("Podaci o ulozi nisu prosleđeni.");
            }

            if (string.IsNullOrWhiteSpace(up.Naziv))
            {
                return BadRequest("Naziv uloge je obavezan.");
            }

            bool uspesno = DTOManager.dodajUlogu(up);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodavanja uloge.");
            }

            return Ok("Uloga je uspešno dodata.");
        }

        [HttpPut]
        [Route("azurirajUlogu")]
        public IActionResult azurirajUlogu([FromBody] UlogaPregled up)
        {
            if (up == null)
            {
                return BadRequest("Podaci o ulozi nisu prosleđeni.");
            }

            if (up.Id <= 0)
            {
                return BadRequest("Nevalidan ID uloge.");
            }

            if (string.IsNullOrWhiteSpace(up.Naziv))
            {
                return BadRequest("Naziv uloge je obavezan.");
            }

            bool uspesno = DTOManager.azurirajUlogu(up);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom ažuriranja uloge ili uloga ne postoji.");
            }

            return Ok("Uloga je uspešno ažurirana.");
        }

        [HttpDelete]
        [Route("obrisiUlogu/{id}")]
        public IActionResult obrisiUlogu(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Nevalidan ID uloge.");
            }

            bool uspesno = DTOManager.obrisiUlogu(id);
            if (!uspesno)
            {
                return NotFound("Uloga sa zadatim ID-jem nije pronađena.");
            }

            return Ok("Uloga je uspešno obrisana.");
        }

        //ULOGE KORISNIKA (M:N)

        [HttpGet]
        [Route("vratiUlogeZaKorisnika/{korisnikId}")]
        public IActionResult vratiUlogeZaKorisnika(int korisnikId)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            var rez = DTOManager.vratiUlogeZaKorisnika(korisnikId);
            return Ok(rez);
        }

        [HttpPost]
        [Route("dodajUloguKorisniku/{korisnikId}/{ulogaId}")]
        public IActionResult dodajUloguKorisniku(int korisnikId, int ulogaId)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            if (ulogaId <= 0)
            {
                return BadRequest("Nevalidan ID uloge.");
            }

            bool uspesno = DTOManager.dodajUloguKorisniku(korisnikId, ulogaId);
            if (!uspesno)
            {
                return BadRequest("Došlo je do greške prilikom dodeljivanja uloge korisniku (možda već postoji).");
            }

            return Ok("Uloga je uspešno dodeljena korisniku.");
        }

        [HttpDelete]
        [Route("obrisiUloguSaKorisnika/{korisnikId}/{ulogaId}")]
        public IActionResult obrisiUloguSaKorisnika(int korisnikId, int ulogaId)
        {
            if (korisnikId <= 0)
            {
                return BadRequest("Nevalidan ID korisnika.");
            }

            if (ulogaId <= 0)
            {
                return BadRequest("Nevalidan ID uloge.");
            }

            bool uspesno = DTOManager.obrisiUloguSaKorisnika(korisnikId, ulogaId);
            if (!uspesno)
            {
                return NotFound("Dodeljena uloga za navedenog korisnika nije pronađena.");
            }

            return Ok("Uloga je uspešno uklonjena sa korisnika.");
        }
    }
}