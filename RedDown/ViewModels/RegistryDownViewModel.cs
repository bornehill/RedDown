﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RedDown.Data.Entities;

namespace RedDown.ViewModels
{
    public class RegistryDownViewModel
    {
        public int DownId;
        [Required]
        [StringLength(18, MinimumLength =18, ErrorMessage = "El CURP es requerido (18 caracteres)")]
        public string Curp { get; set; }
        [Required]
        [MinLength(3, ErrorMessage ="El nombre es requerido (min. 3 caracteres)")]
        public string Name { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "El A. paterno es requerido (min. 5 caracteres)")]
        public string App { get; set; }
        
        [MinLength(4, ErrorMessage = "A. materno (min. 5 caracteres)")]
        public string Apm { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public States BirthPlace { get; set; }
        [Required]
        public States ResidencePlace { get; set; }
        [Required]
        public ParentViewModel Father { get; set; }
        [Required]
        public ParentViewModel Mother { get; set; }
        [Required]
        public byte SonNumber { get; set; }
        [Required]
        public byte BrothersNumber { get; set; }
        [Required]
        public MainCarer MainCarer { get; set; }
        [Required]
        public Diagnostic DiagnosticTime { get; set; }
        [Required]
        public MedicalAtention MedicalCare { get; set; }
        [Required]
        public QuestionsViewModel Questions { get; set; }
    }
}
