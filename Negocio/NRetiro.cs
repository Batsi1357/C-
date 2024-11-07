using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRetiro
    {
        private DRetiro dRetiro = new DRetiro();
        public String Registrar(Retiro retiro)
        {
            return dRetiro.Registrar(retiro);
        }

        public String Modificar(Retiro retiro)
        {
            return dRetiro.Modificar(retiro);
        }

        public String Eliminar(int retiroId)
        {
            return dRetiro.Eliminar(retiroId);
        }

        public List<Retiro> ListarTodo()
        {
            return dRetiro.ListarTodo();
        }

        public List<Retiro> BuscarRetirosAFPHabitat()
        {
            return null;
        }

        public List<Retiro> BuscarRetirosEmpleadosMayoresA30()
        {
            return null;
        }

        public Decimal ObtenerMontoPromedio()
        {
            return 0;
        }
    }
}
