using CharacterCatalog.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Newtonsoft.Json;

namespace CharacterCatalog.Web.Models
{
    public class CharacterDbContext : DbContext
    {
        public DbSet<Character> Character { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=..\\CharacterCatalog.DB\\character.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var character in loadCharactersFromFile())
            {
                modelBuilder.Entity<Character>().HasData(character);
            }
        }

        private Character[] loadCharactersFromFile()
        {
            var fileContent = File.ReadAllText(@"..\rick_and_morty_characters.json");
            var serializedArray = JsonConvert.DeserializeObject<Character[]>(fileContent);

            return serializedArray;
        }
    }
}
