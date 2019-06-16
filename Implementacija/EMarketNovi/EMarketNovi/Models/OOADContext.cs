using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EMarketNovi.Models
{
    public class OOADContext : DbContext
    {
        public static OOADContext instance;

        public OOADContext(DbContextOptions<OOADContext> options) : base(options)
        {
            instance = this;
        }

        public static OOADContext getInstance()
        {
            return instance;
        }

        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<StavkaNarudzbe> StavkaNarudzbe { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        //public DbSet<Klijent> Klijent { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proizvod>().ToTable("Proizvod");
            modelBuilder.Entity<VocePovrce>().ToTable("VocePovrce");
            modelBuilder.Entity<HigijenskiProizvod>().ToTable("HigijenskiProizvod");
            modelBuilder.Entity<PrehrambeniProizvod>().ToTable("PrehrambeniProizvod");
            modelBuilder.Entity<Narudzba>().ToTable("Narudzba");
            modelBuilder.Entity<StavkaNarudzbe>().ToTable("StavkaNarudzbe");
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<Klijent>().ToTable("Klijent");
            modelBuilder.Entity<Menadzer>().ToTable("Menadzer");
            modelBuilder.Entity<Dostavljac>().ToTable("Dostavljac");
        }

    }
}
