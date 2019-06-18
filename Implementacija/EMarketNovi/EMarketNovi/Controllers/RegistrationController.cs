using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMarketNovi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMarketNovi.Controllers
{
    public class RegistrationController : Controller
    {
        private static OOADContext baza = OOADContext.getInstance();
        public IActionResult Index()
        {
            return View("Register");
        }

        [HttpPost]
        public IActionResult Registruj(string etFirstName, string etLastName,  string etUsername,  string etPassword, string etConfirmPassword, string etAddress, string etSigurnosnoPitanje,string etOdgovor)
        {
            Boolean validiraj = true;
            if (etFirstName.Equals("") || etLastName.Equals("") || etUsername.Equals("") || etPassword.Equals("") || etConfirmPassword.Equals("") || etAddress.Equals("") || etSigurnosnoPitanje.Equals("") || etOdgovor.Equals("")) validiraj = false;
            if (!etPassword.Equals(etConfirmPassword)) validiraj = false;

            var osoba = baza.Osoba.Where((Osoba korisnik) => korisnik.KorisnickoIme.Equals(etUsername));
            if (osoba.Count() != 0 ) validiraj = false;

            if (validiraj)
            {
                baza.Osoba.Add(new Klijent
                {
                    Ime = etFirstName,
                    Prezime = etLastName,
                    KorisnickoIme = etUsername,
                    Lozinka = etPassword,
                    AdresaIsporuke = etAddress,
                    SigurnosnoPitanje = etSigurnosnoPitanje,
                    Odgovor = etOdgovor
                });
                baza.SaveChanges();
                var peopleUpdated = baza.Osoba.Where((Osoba person) => person.KorisnickoIme.Equals(etUsername)).ToList();
                Osoba thisPerson = peopleUpdated[0];

                baza.Log.Add(new Log
                {
                    DateTime = DateTime.Now,
                    Note = "Novi korisnik \"" + thisPerson.KorisnickoIme + "\" registovan.",
                    PersonID = thisPerson.Id

                });
                //baza.SaveChanges();
                return View("../Home/Login");
            }
            return View("Register");
        }
    }
}