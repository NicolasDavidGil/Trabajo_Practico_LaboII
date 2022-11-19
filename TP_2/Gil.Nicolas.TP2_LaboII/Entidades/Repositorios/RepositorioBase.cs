using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.Repositorios
{
    public abstract class RepositorioBase
    {
        protected const string connectionString = "Server = .\\; Database = TP2_LaboratorioII; Trusted_Connection = True;";


        public virtual List<T> GetFromBase<T>()
        {
            List<T> list = new List<T>();
            return list;
        }
    }
}
