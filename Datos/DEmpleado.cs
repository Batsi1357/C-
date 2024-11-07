using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEmpleado
    {
        public List<Empleado> ListarTodo()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using(var context=new BDEFEntitiess())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    empleados = context.Empleado.Where(a => a.Eliminado == false).ToList();
                    context.SaveChanges();
                }
                return empleados;
            }
            catch (Exception ex)
            {
                return empleados;
            }
        }
    }
}
