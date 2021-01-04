using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        private int _characterId;
        [JsonProperty("id")]
        [Key]
        public int CharacterId
        { 
            get
            {
                return _characterId;
            }
            set
            {
                _characterId = value;
            }
        }

        private Species _species;
        [JsonProperty("species")]
        [ForeignKey("SpeciesId")]
        public virtual Species Species 
        { 
            get
            {
                return _species;
            }
            set
            {
                _species = value;
            }
        }

        private string _name;
        [JsonProperty("name")]
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private Status _status;
        [JsonProperty("status")]
        public Status Status 
        { 
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        private string _type;
        [JsonProperty("type")]
        public string Type 
        { 
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        private Gender _gender;
        [JsonProperty("gender")]
        public Gender Gender 
        { 
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        private string _pictureUrl;
        [JsonProperty("image")]
        public string PictureUrl
        {
            get
            {
                return _pictureUrl;
            }
            set
            {
                _pictureUrl = value;
            }
        }

        public Character()
        {
        }

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

        public override string ToString()
        {
            return Name;
        }
    }
}
