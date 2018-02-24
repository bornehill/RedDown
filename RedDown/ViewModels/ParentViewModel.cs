using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RedDown.Data.Entities;

namespace RedDown.ViewModels
{
    public class ParentViewModel
    {
        public int ParentId;
        [Required]
        [MinLength(3, ErrorMessage = "El nombre es requerido (min. 3 caracteres)")]
        public string Name { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "El Apellido paterno es requerido (min. 5 caracteres)")]
        public string App { get; set; }
        [MinLength(4, ErrorMessage = "El Apellido materno (min. 5 caracteres)")]
        public string Apm { get; set; }
        [Required]
        public int AgeBirth { get; set; }
        [Required]
        public Pupilage Pupilage { get; set; }
        //public int RelationShip { get; set; }
    }
}
