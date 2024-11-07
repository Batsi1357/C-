using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {
        private DEmpleado dEmpleado = new DEmpleado();

        public List<Empleado> ListarTodo()
        {
            return dEmpleado.ListarTodo();
        }
    }
}
