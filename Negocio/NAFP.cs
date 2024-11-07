using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAFP
    {
        private DAFP dAFP = new DAFP();

        public List<AFP> ListarTodo()
        {
            return dAFP.ListarTodo();
        }
    }
}
