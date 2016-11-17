using AnimalFarm.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    public class DataManager
    {
        static List<Animal> dbAnimals = new List<Animal>
        {
            new Animal {Id=1,Name="Daisy", AnimalType="Ko", Temper=9, Created=DateTime.Now },
            new Animal {Id=1,Name="Gösta", AnimalType="Häst", Temper=1, Created=DateTime.Now },
        };
        internal static object GetHomeIndexVM()
        {
            return new HomeIndexVM
            {
                Date = DateTime.Now,
                ListItems = dbAnimals
              .Select(a => new HomeIndexListVM
              {
                  Name = a.Name,
                  AnimalType = a.AnimalType,
                  IsDangerous = a.Temper > 7
              })

            };
        }

        internal static void CreateAnimal(HomeCreateVM viewModel)
        {
            dbAnimals.Add(new Animal
            {
                Id=dbAnimals.Max(p=>p.Id)+1,
                Name=viewModel.Name,
                AnimalType=viewModel.AnimalType,
                Temper=viewModel.Temper,
                Created=DateTime.Now
            });
        }
    }
}
