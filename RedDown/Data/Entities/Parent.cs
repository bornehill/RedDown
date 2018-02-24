using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.Data.Entities
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public int AgeBirth { get; set; }
        public byte Pupilage { get; set; }
    }
}
