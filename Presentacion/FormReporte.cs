using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporte : Form
    {
        private NRetiro nRetiro = new NRetiro();

        private void MostrarRetiros(List<Retiro> retiros)
        {

        }

        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnBuscarRetirosAFPHabitat_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarRetirosEmpleadosMayoresA30_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
