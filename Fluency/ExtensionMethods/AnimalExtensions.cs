using Mess_around.Fluency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mess_around.Fluency.ExtensionMethods
{
    public static class AnimalExtensions
    {
        public static async Task<List<AnimalModel>> ConvertToAnimalModelListAsync(this Task<List<Context.Animal>> animals)
        {
            var result = new List<AnimalModel>();

            foreach (var animal in await animals)
            {
                result.Add(new AnimalModel
                {
                    Name = animal.Name,
                    Age = animal.Age,
                    BirthDate = animal.BirthDate,
                    Color = animal.Color,
                    Description = animal.AnimalType.Description
                });
            }

            return result;
        }

        public static async Task<AnimalModel> ConvertToAnimalModelAsync(this Task<Context.Animal> animalContext)
        {
            var animal = await animalContext;

            var result = new AnimalModel
            {
                Name = animal.Name,
                Age = animal.Age,
                BirthDate = animal.BirthDate,
                Color = animal.Color,
                Description = animal.AnimalType.Description
            };

            return result;
        }

        public static AnimalModel ConvertToAnimalModel(this Context.Animal animal)
        {
            return new AnimalModel
            {
                Name = animal.Name,
                Age = animal.Age,
                BirthDate = animal.BirthDate,
                Color = animal.Color,
                Description = animal.AnimalType.Description
            };
        }

        public static async Task<ImmutableAnimalModel> ConvertToImmutableModelAsync(this Task<AnimalModel> animal)
        {
            var animalModel = await animal;

            return new ImmutableAnimalModel(animalModel);
        }

        public static ImmutableAnimalModel ConvertToImmutableModel(this AnimalModel animalModel)
        {
            return new ImmutableAnimalModel(animalModel);
        }

        public static ImmutableAnimalModel RenameAnimal(this ImmutableAnimalModel animal, string newName)
        {
            var animalModel = new AnimalModel
            {
                Name = newName,
                Description = animal.Description,
                Color = animal.Color,
                Age = animal.Age,
                BirthDate = animal.BirthDate
            };

            return new ImmutableAnimalModel(animalModel);
        }

        public static ImmutableAnimalModel SetBirthday(this ImmutableAnimalModel animal, DateTime newBirthday)
        {
            var animalModel = new AnimalModel
            {
                Name = animal.Name,
                Description = animal.Description,
                Color = animal.Color,
                Age = animal.Age,
                BirthDate = newBirthday
            };

            return new ImmutableAnimalModel(animalModel);
        }

        public static ImmutableAnimalModel CalculateAge(this ImmutableAnimalModel animal)
        {
            var calculatedAge = DateTime.Today.Year - animal.BirthDate.Year;

            var animalModel = new AnimalModel
            {
                Name = animal.Name,
                Description = animal.Description,
                Color = animal.Color,
                Age = calculatedAge,
                BirthDate = animal.BirthDate
            };

            return new ImmutableAnimalModel(animalModel);
        }

        public static ImmutableAnimalModel ChangeColor(this ImmutableAnimalModel animal, string newColor)
        {
            var animalModel = new AnimalModel
            {
                Name = animal.Name,
                Description = animal.Description,
                Color = newColor,
                Age = animal.Age,
                BirthDate = animal.BirthDate
            };

            return new ImmutableAnimalModel(animalModel);
        }

        public static async Task<ImmutableAnimalModel> RenameAnimalAsync(this Task<ImmutableAnimalModel> animalTask, string newName)
        {
            var animal = await animalTask;

            var animalModel = new AnimalModel
            {
                Name = newName,
                Description = animal.Description,
                Color = animal.Color,
                Age = animal.Age,
                BirthDate = animal.BirthDate
            };

            return new ImmutableAnimalModel(animalModel);
        }

        public static async Task<ImmutableAnimalModel> SetBirthdayAsync(this Task<ImmutableAnimalModel> animalTask, DateTime newBirthday)
        {
            var animal = await animalTask;

            var animalModel = new AnimalModel
            {
                Name = animal.Name,
                Description = animal.Description,
                Color = animal.Color,
                Age = animal.Age,
                BirthDate = newBirthday
            };

            return new ImmutableAnimalModel(animalModel);
        }

        public static async Task<ImmutableAnimalModel> ChangeColorAsync(this Task<ImmutableAnimalModel> animalTask, string newColor)
        {
            var animal = await animalTask;

            var animalModel = new AnimalModel
            {
                Name = animal.Name,
                Description = animal.Description,
                Color = newColor,
                Age = animal.Age,
                BirthDate = animal.BirthDate
            };

            return new ImmutableAnimalModel(animalModel);
        }
    }
}