using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;

namespace CharacterCatalog.Core.Models
{
    public class CharacterDbContext : DbContext
    {
        public DbSet<Species> Species { get; set; }
        public DbSet<Character> Character { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=..\\CharacterCatalog.DB\\test2_character.db", 
                o => o.MigrationsAssembly("CharacterCatalog.Web"));
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasOne(c => c.Species)
                .WithMany(s => s.Characters);

            modelBuilder.Entity<Character>()
                .Navigation(c => c.Species)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            var characters = loadCharactersFromFile();
            var species = characters.Select(c => c.Species).Distinct().ToArray();

            modelBuilder.Entity<Species>().HasData(species);
            //modelBuilder.Entity<Character>().HasData(characters);

            foreach (var character in characters)
            {
                modelBuilder.Entity<Character>()
                    .HasData(new
                    {
                        character.CharacterId,
                        character.Species.SpeciesId,
                        character.Name,
                        character.Status,
                        character.Type,
                        character.Gender,
                        character.PictureUrl
                    });
            }
        }

        public async Task<object> ExecuteScalarAsync(string sql)
        {
            using (var dbConnection = Database.GetDbConnection())
            using (var command = dbConnection.CreateCommand())
            {
                await dbConnection.OpenAsync();

                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                var result = await command.ExecuteScalarAsync();

                await dbConnection.CloseAsync();

                return result;
            }
        }

        public async Task<DataTable> ExecuteTableAsync(string sql)
        {
            using (var dbConnection = Database.GetDbConnection())
            using (var command = dbConnection.CreateCommand())
            {
                await dbConnection.OpenAsync();

                var result = new DataTable();

                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                
                using (var reader = command.ExecuteReader())
                {
                    result.Load(reader);
                }

                await dbConnection.CloseAsync();

                return result;
            }
        }

        private Character[] loadCharactersFromFile()
        {
            var fileContent = File.ReadAllText(@"..\rnm_test_restructured.json");
            var serializedArray = JsonConvert.DeserializeObject<Character[]>(fileContent);

            return serializedArray;
        }
    }
}
