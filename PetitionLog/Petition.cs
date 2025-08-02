using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionLog
{
    public class Petition
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string CCE { get; set; }
        public DateTime DateFiled { get; set; }
        public string Remarks { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
