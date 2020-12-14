using Mess_around.Fluency.Context;
using Mess_around.Fluency.ExtensionMethods;
using Mess_around.Fluency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mess_around.Fluency.Repository
{
    public class MessAroundRepository : IMessAroundRepository
    {
        public ImmutableAnimalModel GetImmuteableAnimalById(int animalId)
        {
            return ReturnAnimal()
                .ConvertToAnimalModel()
                .ConvertToImmutableModel();
        }

        private static Animal ReturnAnimal()
        {
            return new Animal
            {
                Id = 12,
                Name = "Fred",
                AnimalTypeId = 1,
                AnimalType = new AnimalType
                {
                    Id = 1,
                    Description = "This Type is an Animal"
                },
                Color = "Green",
                BirthDate = DateTime.Parse("08-19-1999")
            };
        }
    }
}