using Mess_around.Fluency.Models;
using Mess_around.Fluency.Repository;
using System.Threading.Tasks;
using Mess_around.Fluency.ExtensionMethods;

namespace Mess_around.Fluency
{
    public class Operation
    {
        private readonly IMessAroundRepository _repository;

        public Operation(IMessAroundRepository repository)
        {
            _repository = repository;
        }

        public ImmutableAnimalModel GetImmutableAnimalModel(int id)
        {
            return _repository.GetImmuteableAnimalById(id)
                .RenameAnimal("Frank")
                .SetBirthday(System.DateTime.Parse("12-12-05"))
                .CalculateAge()
                .ChangeColor("Blue");
        }
    }
}