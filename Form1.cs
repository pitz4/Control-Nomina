using Newtonsoft.Json;
namespace NominaControl
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }

        // Agregar un empleado a la lista de empleados
        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
            ActualizarListBox(); // Asegúrate de tener este método para actualizar la lista
        }

        private void ActualizarListBox()
        {
            lstEmpleados.DataSource = null; // Limpiar la fuente de datos
            lstEmpleados.DataSource = empleados;
        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado frmAgregar = new();
            frmAgregar.ShowDialog();
            if (frmAgregar.Nuevo != null)
            {
                empleados.Add(frmAgregar.Nuevo);
                ActualizarListBox();
            }
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists("empleados.json"))
            {
                var json= File.ReadAllText("empleados.json");
                empleados = (List<Empleado>)JsonConvert.DeserializeObject<List<Empleado>>(json);
            }
            else
            {
                empleados=new List<Empleado>();
            }
            ActualizarListBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedIndex >= 0)
            {
                Empleado emp = (Empleado) lstEmpleados.SelectedItem;
                if (MessageBox.Show($"Deseas eliminar a {emp.Nombre}?", "Confirmar eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    empleados.Remove(emp);
                     }
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            var json = JsonConvert.SerializeObject(empleados);
            File.WriteAllText("empleados.json", json);
        }
        // Otros métodos y eventos de tu formulario
        private void lstEmpleados_DoubleClick(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedIndex >= 0)
            {
                frmCambiarDiasTrabajados frm = new();
                frm.Empleado=(Empleado)lstEmpleados.SelectedItem;
                frm.ShowDialog();
                ActualizarListBox();
            }
        }
    }

}