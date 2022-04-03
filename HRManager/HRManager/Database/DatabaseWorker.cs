using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMenager.Controller.Interface;
//using System.Data.Entity.Migrations;
using HRMenager.DTO;
using Microsoft.EntityFrameworkCore;
using SecureDevelopment_1;


namespace HRMenager.Database
{
    internal class DatabaseWorker : IWorcerController<Worker>
    {

         internal DatabaseContext databaseContext;
         internal  DatabaseWorker()
          {
              DatabaseContext _databaseContext = new DatabaseContext();
              databaseContext = _databaseContext;

          }

    

         public  void Create(Worker dto)
           {
            
             databaseContext.Add(dto);
               databaseContext.SaveChanges();
           }

        public    void Delete(int WorkerId)
           {
               Worker t = databaseContext.Set<Worker>().FindAsync(WorkerId).Result;
               databaseContext.Set<Worker>().Remove(t);
               databaseContext.SaveChanges();
           }

        public string Read()
        {
            List<Worker> ListWorker = databaseContext.Set<Worker>().ToList();
            String StringWorker =string.Empty;
            for (int i = 0; i < ListWorker.Count; i++)
            {
                string s = $"\n Табельный номер{ListWorker[i].WorkerId.ToString()} Фамилия {ListWorker[i].Surname}  Имя {ListWorker[i].Name} Отчество {ListWorker[i].MiddleName} Датай рождения {ListWorker[i].DataBirth.ToString()} Местом рождения {ListWorker[i].PlaceBirth} \n";

                StringWorker += s;

            }

            return StringWorker;
        }

           public  void Update(Worker dto)
           {
               Worker? t = databaseContext.Set<Worker>().FindAsync(dto.WorkerId).Result;
               t.Surname = dto.Surname;
               t.Name = dto.Name;
               t.MiddleName = dto.MiddleName;
               t.DataBirth = dto.DataBirth;
               t.PlaceBirth = dto.PlaceBirth;

               databaseContext.SaveChanges();
           } 

    }
}
