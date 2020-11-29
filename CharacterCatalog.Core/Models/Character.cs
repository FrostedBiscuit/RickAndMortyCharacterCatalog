using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterCatalog.Core.Models
{
    public enum Status
    {
        Alive, Unknown, Dead
    }

    public enum Gender
    {
        Female, Genderless, Unknown, Male
    }

    public class Character
    {
        [JsonProperty("id")]
        public int CharacterId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("status")]
        public Status Status { get; set; }
        [JsonProperty("species")]
        public string Species { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("gender")]
        public Gender Gender { get; set; }
        [JsonProperty("image")]
        public string PictureUrl { get; set; }

        public void Update(Character other)
        {
            if (CharacterId != other.CharacterId)
            {
                throw new InvalidOperationException($"Trying to update character id {CharacterId} with character id {other.CharacterId}");
            }

            Name = other.Name;
            Status = other.Status;
            Species = other.Species;
            Type = other.Type;
            Gender = other.Gender;
            PictureUrl = other.PictureUrl;
        }
    }
}
