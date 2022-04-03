using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMenager.DTO
{
    internal class Worker : IWorker
    {
        internal Worker() { }

        public int WorkerId { get; set; }
        public string Surname { get; set ; }
        public string Name { get ; set ; }
        public string MiddleName { get ; set ; }
        public DateTime DataBirth { get; set; }
        public string PlaceBirth { get; set ; }
    }
}
