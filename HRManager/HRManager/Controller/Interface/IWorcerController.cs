using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRMenager.Controller.Interface
{
    public  interface IWorcerController<T>
    {
        public void Create(T dto);

        public string Read();

        public void Update(T dto);

        public void Delete(int  WorkerId );
    }
}
