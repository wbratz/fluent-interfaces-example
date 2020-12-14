using System;
using System.Collections.Generic;

#nullable disable

namespace Mess_around.Fluency.Context
{
    public partial class AnimalType
    {
        public AnimalType()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
