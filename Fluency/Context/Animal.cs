using System;
using System.Collections.Generic;

#nullable disable

namespace Mess_around.Fluency.Context
{
    public partial class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnimalTypeId { get; set; }
        public string Color { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

        public virtual AnimalType AnimalType { get; set; }
    }
}