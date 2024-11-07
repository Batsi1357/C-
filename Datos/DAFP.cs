using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAFP
    {
     
   
        public List<AFP> ListarTodo()
        {
            List<AFP> afps = new List<AFP>();
            try
            {
                using (var context = new BDEFEntitiess())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    afps = context.AFP.Where(a => a.Eliminado == false).ToList();
                    context.SaveChanges();
                }
                return afps;
            }
            catch (Exception ex)
            {
                return afps;
            }
        }
    }
}
