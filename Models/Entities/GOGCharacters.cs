using System.Collections.Generic;

namespace MyFirstMAUIApp.Models.Entities
{
    public class GOGCharacters
    {
        public string NameofCharacter { get; set; }
        public string NameofActor { get; set; }
        public string ImagePath { get; set; }

        public GOGCharacters() { }

        public GOGCharacters(string character, string actor, string imagePath)
        {
            NameofCharacter = character;
            NameofActor = actor;
            ImagePath = imagePath;
        }

        // Sample data – names/images from the PDF
        public static List<GOGCharacters> GetCharacter() => new()
        {
            new GOGCharacters("Starlord", "Chris Pratt", "starlord.jpg"),
            new GOGCharacters("Gamora",  "Zoe Saldana",  "gamora.jpg"),
            new GOGCharacters("Groot",   "Vin Diesel",   "groot.jpg"),
            new GOGCharacters("Rocket",  "Bradley Cooper","rocket.jpg"),
            new GOGCharacters("Nebula",  "Karen Gillan", "nebula.jpg"),
        };
    }
}
