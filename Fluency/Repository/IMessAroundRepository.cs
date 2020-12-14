using Mess_around.Fluency.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mess_around.Fluency.Repository
{
    public interface IMessAroundRepository
    {
        ImmutableAnimalModel GetImmuteableAnimalById(int animalId);
    }
}