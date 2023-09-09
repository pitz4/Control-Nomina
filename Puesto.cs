using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaControl
{
    public class Puesto
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Nombre");
                }
                nombre = value;
            }
        }
        private decimal salario;
        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Salario");
                }
                salario = value;
            }
        }
    }
}
