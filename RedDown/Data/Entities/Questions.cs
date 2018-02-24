using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.Data.Entities
{
    public class Questions
    {
        public int Id { get; set; }
        public bool CardioTipo { get; set; }
        public bool Ecocardiograma { get; set; }
        public bool FuncTiroidea { get; set; }
        public bool Biometria { get; set; }
        public bool Auditiva { get; set; }
        public bool Oftalmologica { get; set; }
        public bool Dentista { get; set; }
        public bool PosDormir { get; set; }
        public bool Ortopedista { get; set; }
        public bool Nutriologo { get; set; }
        public bool MalaConducta { get; set; }
        public byte InterTemprana { get; set; }
        public byte TerapiaLeng { get; set; }
        public byte TerapiaFam { get; set; }
        public byte TerapiaAprenz { get; set; }
        public byte ActActual { get; set; }
        public string Fundacion { get; set; }
    }
}
