using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RedDown.Data.Entities;

namespace RedDown.ViewModels
{
    public class QuestionsViewModel
    {
        public int QId;
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
        public ActivityTherapy InterTemprana { get; set; }
        [Required]
        public ActivityTherapy TerapiaLeng { get; set; }
        [Required]
        public ActivityTherapy TerapiaFam { get; set; }
        [Required]
        public ActivityTherapy TerapiaAprenz { get; set; }
        [Required]
        public ActivitySchool ActActual { get; set; }
        [Required]
        [MinLength(2)]
        public string Fundacion { get; set; }
    }
}
