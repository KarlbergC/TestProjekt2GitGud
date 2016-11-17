using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.Models.ViewModels
{
    public class HomeCreateVM
    {
        [Display(Name = "Namn")]
        [Required(ErrorMessage = "Ange ett namn!")]
        public string Name { get; set; }

        [Display(Name = "Djurtyp")]
        [Required(ErrorMessage = "Ange en djurtyp!")]
        public string AnimalType { get; set; }


        [Display(Name = "Temperament")]
        [Required(ErrorMessage = "Ange temperament värde mellan 1-10!")]
        [Range(1, 10)]
        public int Temper { get; set; }
    }
}
