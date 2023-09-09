using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaControl
{
    public class Empleado
    {
        /// <summary>
        /// Represena un objeto de tipo Empleado
        /// </summary>
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Nombre", "El nombre esta vacio");
                }
                nombre = value;
            }
        }
        private float diasTrabajados;
        /// <summary>
        /// Obtiene o establece las horas trabajadas
        /// </summary>
        public float HorasTrabajadas
        {
            get { return diasTrabajados; }
            set
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("DiasTrabajados", "El valor esta fuera de rango (0 a 7)");
                }
                diasTrabajados = value;
            }

        }
        public Puesto Puesto { get; set; }

        public decimal SalarioSemanal
        {
            get
            {
                return (decimal)diasTrabajados * Puesto.Salario;
            }
        }

        public float DiasTrabajados { get; internal set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre} Dias: {diasTrabajados} Diario: {Puesto.Salario} Semanal: {SalarioSemanal} Puesto: {Puesto.Nombre}";

        }
    }
}
