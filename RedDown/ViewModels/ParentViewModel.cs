using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.ViewModels
{
    public class ParentViewModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "El nombre es requerido (min. 3 caracteres)")]
        public string Name { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "El A. paterno es requerido (min. 5 caracteres)")]
        public string App { get; set; }
        [MinLength(5, ErrorMessage = "A. materno (min. 5 caracteres)")]
        public string Apm { get; set; }
        public int AgeBirth { get; set; }
        public int Pupilage { get; set; }
        public int RelationShip { get; set; }
    }
}
