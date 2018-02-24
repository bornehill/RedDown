using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.Data.Entities
{
    public class RegistryDown
    {
        public int Id { get; set; }
        public string Curp { get; set; }
        public string Name { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public DateTime BirthDate { get; set; }
        public byte BirthPlace { get; set; }
        public byte ResidencePlace { get; set; }
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public byte SonNumber { get; set; }
        public byte BrothersNumber { get; set; }
        public byte MainCarer { get; set; }
        public byte DiagnosticTime { get; set; }
        public byte MedicalCare { get; set; }
        public Questions Questions { get; set; }
    }
}
