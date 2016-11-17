using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.Models.ViewModels
{
    public class HomeIndexVM
    {
        public DateTime Date { get; set; }
        public IEnumerable<HomeIndexListVM> ListItems{ get; set; }
    }

}
