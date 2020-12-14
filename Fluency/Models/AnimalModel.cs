using System;

namespace Mess_around.Fluency.Models
{
    public class AnimalModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
    }

    public class ImmutableAnimalModel
    {
        private readonly string _name;
        private readonly string _description;
        private readonly string _color;
        private readonly DateTime _birthDate;
        private readonly int _age;

        public ImmutableAnimalModel(AnimalModel animal)
        {
            _name = animal.Name;
            _description = animal.Description;
            _color = animal.Color;
            _birthDate = animal.BirthDate;
            _age = animal.Age;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Color
        {
            get { return _color; }
        }

        public DateTime BirthDate { get { return _birthDate; } }
        public int Age { get { return _age; } }
    }
}