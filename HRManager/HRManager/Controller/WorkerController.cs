using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMenager.Controller.Interface;
using HRMenager.DTO;
using HRMenager.Database;
namespace HRMenager.Controller
{
    internal class WorkerController : IWorcerController<Worker>
    {
      private DatabaseWorker databaseWorker;


       internal  WorkerController() 
        {
            databaseWorker = new DatabaseWorker();


        }

        public void Create(Worker dto)
        {
            databaseWorker.Create(dto);
        }

        public void Delete(int WorkerId)
        {
            databaseWorker.Delete(WorkerId);
        }

        public string Read()
        {
          return  databaseWorker.Read();
        }

        public void Update(Worker dto)
        {
            databaseWorker.Update(dto);
        }
    }
}
