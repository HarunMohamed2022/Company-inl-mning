using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public DbSet<Företag> Företags => Set<Företag>();
        public DbSet<Anställd> Anställds => Set<Anställd>();
        public DbSet<Avdelning> Avdelnings => Set<Avdelning>();
        public DbSet<Beffatning> Beffatnings => Set<Beffatning>();
        public DbSet<AnställdBefattningar> AnställdBefattningars => Set<AnställdBefattningar>();


        public CompanyContext(DbContextOptions<CompanyContext> options): base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AnställdBefattningar>().HasKey(ab => new {ab.Anställdid,ab.Befattningid});
            SeedData(builder);

        }
        private void SeedData(ModelBuilder builder)
        {
            var företags = new List<Företag>
        {
            new Företag
            {
                id = 1,
                Name="ClassOlson",
                OrgNum = 123456,
            },
            new Företag
            {
                id = 2,
                Name="Elgiganten",
                OrgNum = 654321,
            }
        };
            builder.Entity<Företag>().HasData(företags);

            var anställds = new List<Anställd>
        {
            new Anställd
            {
                id=1,
                Avdelningid=1,
                FörNamn="Peter",
                EfterNamn="Parker",
                Lön=30000,
                Fackförening=true,
            },
            new Anställd
            {
                id=2,
                Avdelningid=3,
                FörNamn="Jack",
                EfterNamn="Black",
                Lön=40000,
                Fackförening=true,
            },
            new Anställd
            {
                id=3,
                Avdelningid=4,
                FörNamn="John",
                EfterNamn="Wick",
                Lön=50000,
                Fackförening=true,
            },
            new Anställd
            {
                id=4,
                Avdelningid=2,
                FörNamn="Joe",
                EfterNamn="Mama",
                Lön=60000,
                Fackförening=true,
            },
        };
            builder.Entity<Anställd>().HasData(anställds);

            var avdelnings = new List<Avdelning>
            {
                new Avdelning
                {
                    id = 1,
                    Företagid=1,
                    Name="accounting",
                    
                },
                new Avdelning
                {
                    id = 2,
                    Företagid=2,
                    Name="marketing",

                },
                new Avdelning
                {
                    id = 3,
                    Företagid=2,
                    Name="human resources",

                },
                new Avdelning
                {
                    id = 4,
                    Företagid=1,
                    Name="legal",

                },

            };
            builder.Entity<Avdelning>().HasData(avdelnings);

            var beffatnings = new List<Beffatning>
            {
                new Beffatning
                {
                    id=1,
                    Tittle="Doctor",
                },
                new Beffatning
                {
                    id=2,
                    Tittle="Police",
                },
                new Beffatning
                {
                    id=3,
                    Tittle="Pilot",
                },
                new Beffatning
                {
                    id=4,
                    Tittle="Lumberjack",
                },
            };
            builder.Entity<Beffatning>().HasData(beffatnings);

            var anställdBefattningars = new List<AnställdBefattningar>
            {
                new AnställdBefattningar
                {
                    Anställdid=1,
                    Befattningid=1,
                },
                new AnställdBefattningar
                {
                    Anställdid=1,
                    Befattningid=2,
                },
                new AnställdBefattningar
                {
                    Anställdid=2,
                    Befattningid=2,
                },
                new AnställdBefattningar
                {
                    Anställdid=3,
                    Befattningid=4,
                },
            };
            builder.Entity<AnställdBefattningar>().HasData(anställdBefattningars);




        }

    }
}
