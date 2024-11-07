using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRetiro
    {
        public String Registrar(Retiro retiro)
        {
            try
            {
                using(var context=new BDEFEntitiess())
                {
                    context.Retiro.Add(retiro);
                    context.SaveChanges();
                }
                return "Se registro!!!";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Retiro retiro)
        {
            try
            {
                using (var context = new BDEFEntitiess())
                {
                    Retiro retiroTemporal=context.Retiro.Find(retiro.AFPId);
                    retiroTemporal.EmpleadoId = retiro.EmpleadoId;
                    retiroTemporal.AFPId = retiro.AFPId;
                    retiroTemporal.Monto = retiro.Monto;
                    retiroTemporal.CuentaInterbancaria = retiro.CuentaInterbancaria;
                    context.SaveChanges();
                }
                return "Se Modifico!!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int retiroId)
        {
            try
            {
                using (var context = new BDEFEntitiess())
                {
                    Retiro retiroTemporal = context.Retiro.Find(retiroId);
                    retiroTemporal.Eliminado = true;
                    context.SaveChanges();
                }
                return "Se elimino!!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Retiro> ListarTodo()
        {
            List<Retiro> retiros = new List<Retiro>();
            try
            {
                using (var context = new BDEFEntitiess())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    retiros=context.Retiro.Where(a => a.Eliminado == false).ToList();
                    context.SaveChanges();
                }
                return retiros;
            }
            catch(Exception ex)
            {
                return retiros;
            }
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
