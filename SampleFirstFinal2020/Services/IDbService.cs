using SampleFirstFinal2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleFirstFinal2020.Services
{
    public interface IDbService
    {
        Task<IEnumerable<AnimalForGetting>> GetAnimals(string orderBy);
        Task AddAnimal(Animal animal);
    }
}
