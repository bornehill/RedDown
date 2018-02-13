using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.ViewModels
{
    public class QuestionsViewModel
    {
        [Required]
        public bool CardioTipo { get; set; }
        [Required]
        public bool Ecocardiograma { get; set; }
        [Required]
        public bool FuncTiroidea { get; set; }
        [Required]
        public bool Biometria { get; set; }
        [Required]
        public bool Auditiva { get; set; }
        [Required]
        public bool Oftalmologica { get; set; }
        [Required]
        public bool Dentista { get; set; }
        [Required]
        public bool PosDormir { get; set; }
        [Required]
        public bool Ortopedista { get; set; }
        [Required]
        public bool Nutriologo { get; set; }
        [Required]
        public bool MalaConducta { get; set; }
        [Required]
        public int InterTemprana { get; set; }
        [Required]
        public int TerapiaLeng { get; set; }
        [Required]
        public int TerapiaFam { get; set; }
        [Required]
        public int TerapiaAprenz { get; set; }
        [Required]
        public int ActActual { get; set; }
        [Required]
        [MinLength(2)]
        public string Fundacion { get; set; }
    }
}
