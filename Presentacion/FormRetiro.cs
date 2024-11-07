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
    public partial class FormRetiro : Form
    {
        private NRetiro nRetiro = new NRetiro();
        private NEmpleado nEmpleado  = new NEmpleado();
        private NAFP nAFP = new NAFP();

        public FormRetiro()
        {
            InitializeComponent();
            MostrarAFPs(nAFP.ListarTodo());
            MostrarEmpleados(nEmpleado.ListarTodo());
            MostrarRetiros(nRetiro.ListarTodo());
        }

        private void MostrarEmpleados(List<Empleado> empleados)
        {
            cbEmpleado.DataSource = null;
            if(empleados.Count==0)
            {
                return;
            }
            else
            {
                cbEmpleado.DataSource = empleados;
                cbEmpleado.DisplayMember = "DNI";
                cbEmpleado.ValueMember = "EmpleadoId";
            }
        }

        private void MostrarAFPs(List<AFP> afps)
        {
            cbAFP.DataSource = null;
            if (afps.Count == 0)
            {
                return;
            }
            else
            {
                cbAFP.DataSource = afps;
                cbAFP.DisplayMember = "Nombre";
                cbAFP.ValueMember = "AFPId";
            }
        }

        private void MostrarRetiros(List<Retiro> retiros)
        {
            dgRetiros.DataSource = retiros;
            if (retiros.Count == 0)
            {
                return;
            }
            else
            {
                dgRetiros.DataSource = retiros;
                dgRetiros.Columns["Eliminado"].Visible=false;
                dgRetiros.Columns["Empleado"].Visible = false;
                dgRetiros.Columns["AFP"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           if(cbEmpleado.Text==""||cbAFP.Text==""||tbMonto.Text==""||tbCuentaInterbancaria.Text=="")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            Decimal monto = 0;
            try
            {
                monto = Decimal.Parse(tbMonto.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese campos correctos!!!");
                return;
            }

            Retiro retiro = new Retiro()
            {
                AFPId = int.Parse(cbAFP.SelectedValue.ToString()),
                EmpleadoId=int.Parse(cbEmpleado.SelectedValue.ToString()),
                Monto = monto,
                CuentaInterbancaria=tbCuentaInterbancaria.Text
            };
            string mensaje = nRetiro.Registrar(retiro);
            MessageBox.Show(mensaje);

            MostrarRetiros(nRetiro.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgRetiros.SelectedRows.Count==0)
            {
                MessageBox.Show("Seleccione un retiro");
                return;
            }
            if (cbEmpleado.Text == "" || cbAFP.Text == "" || tbMonto.Text == "" || tbCuentaInterbancaria.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            Decimal monto = 0;
            try
            {
                monto = Decimal.Parse(tbMonto.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese campos correctos!!!");
                return;
            }

            Retiro retiro = new Retiro()
            {
                RetiroId = int.Parse(dgRetiros.SelectedRows[0].Cells[0].Value.ToString()),
                AFPId = int.Parse(cbAFP.SelectedValue.ToString()),
                EmpleadoId = int.Parse(cbEmpleado.SelectedValue.ToString()),
                Monto = monto,
                CuentaInterbancaria = tbCuentaInterbancaria.Text
            };
            string mensaje = nRetiro.Modificar(retiro);
            MessageBox.Show(mensaje);
            MostrarRetiros(nRetiro.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgRetiros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un retiro");
                return;
            }
            int retiroId = int.Parse(dgRetiros.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Estas seguro que quieres borrar el registro con Id " + retiroId + "?", " ", MessageBoxButtons.YesNo);
            if(dialogResult== DialogResult.Yes) 
            {
                string mensaje = nRetiro.Eliminar(retiroId);
                MessageBox.Show(mensaje);
                MostrarRetiros(nRetiro.ListarTodo());
            }
          
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
