using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    //Mappar mot en databas-tabell
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Temper { get; set; }
        public DateTime Created { get; set; }
    }
}
