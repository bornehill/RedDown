using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.ViewModels
{
    public class RegistryDownViewModel
    {
        [Required]
        [MinLength(3, ErrorMessage ="El nombre es requerido (min. 3 caracteres)")]
        public string Name { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "El A. paterno es requerido (min. 5 caracteres)")]
        public string App { get; set; }
        
        [MinLength(5, ErrorMessage = "A. materno (min. 5 caracteres)")]
        public string Apm { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public int BirthPlace { get; set; }
        [Required]
        public int ResidencePlace { get; set; }
        [Required]
        public ParentViewModel Father { get; set; }
        [Required]
        public ParentViewModel Mother { get; set; }
    }
}
