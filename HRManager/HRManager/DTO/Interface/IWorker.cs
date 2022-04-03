using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMenager.DTO
{
    internal interface IWorker
    {
        internal int WorkerId { get; set; }
        internal string Surname {get; set;}
        internal string Name { get; set; }
        internal string MiddleName { get; set; }
        internal DateTime DataBirth { get; set; }
        internal string PlaceBirth { get; set; } // Место рожления

    }
}
