using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NominaControl
{
    public partial class AgregarEmpleado : Form
    {
        private List<Puesto> puestos;
        public Empleado Nuevo { get; set; }

        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            puestos = new List<Puesto>();

            puestos.Add(new Puesto()
            {
                Nombre = "Operario",
                Salario = 750
            });

            puestos.Add(new Puesto()
            {
                Nombre = "Supervisor",
                Salario = 1000
            });

            puestos.Add(new Puesto()
            {
                Nombre = "Gerente",
                Salario = 1500
            });

            cmbPuestos.DataSource = puestos;
            cmbPuestos.DisplayMember = "Nombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Nuevo = new Empleado();
            Nuevo.Nombre = txtNombre.Text;
            Nuevo.Puesto = (Puesto)cmbPuestos.SelectedItem;

            // Agrega el nuevo empleado a la lista de empleados en Form1
           
            Close();
        }
    }
}
