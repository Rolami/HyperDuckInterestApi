using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HyperDuckInterestApi.Models;
using System.Text.Json;

namespace HyperDuckInterestApi.Data
{
    public class HyperDuckInterestApiContext : DbContext
    {
        public HyperDuckInterestApiContext (DbContextOptions<HyperDuckInterestApiContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=HyperDuckApiDB;Trusted_Connection=true;TrustServerCertificate=true;");

        }

        public DbSet<Interest> Interests { get; set; } = default!;
        public DbSet<InterestLink> InterestLinks { get; set; } = default!;
        public DbSet<InterestList> InterestLists { get; set; } = default!;
        public DbSet<Person> Persons { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          // Load data from interests.json
            var interestJson = File.ReadAllText(("Data/Interest.json"));
            var interests = JsonSerializer.Deserialize<List<Interest>>(interestJson);
            modelBuilder.Entity<Interest>().HasData(interests);

            // -||-  iLinks.json
            var iLinksjson = File.ReadAllText(("Data/iLinks.json"));
            var iLinks = JsonSerializer.Deserialize<List<InterestLink>>(iLinksjson);
            modelBuilder.Entity<InterestLink>().HasData(iLinks);




            // -||- InterestLists.json
            var interestListJson = File.ReadAllText(("Data/InterestList.json"));
            var interestLists = JsonSerializer.Deserialize<List<InterestList>>(interestListJson);
            modelBuilder.Entity<InterestList>().HasData(interestLists);



          // -||- Persons.json
            var personJson = File.ReadAllText(("Data/Person.json"));
            var persons = JsonSerializer.Deserialize<List<Person>>(personJson);
            modelBuilder.Entity<Person>().HasData(persons);



        


            base.OnModelCreating(modelBuilder);
        }
    }
}
