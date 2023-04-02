using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Contacto
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private string telefono { get; set; }
        private string direccion { get; set; }
        private DateTime fechaNacimiento { get; set; }

        private int codigo { get; set; }
        private int llamadas { get; set; }

        public Contacto(string nom, string ape, string tel, string direcc, DateTime fechaNac, int cod, int llam)
        {
            nombre = nom;
            apellido = ape;
            telefono = tel;
            direccion = direcc;
            fechaNacimiento = fechaNac;
            llamadas = llam;
            codigo = cod;
        }

        public int edad()
        {
            Double calculo = (DateTime.Now - fechaNacimiento).TotalDays;
            int edad = Convert.ToInt32(calculo) / 365;

            return edad;

        }

        public void llamar()
        {
            llamadas += 1;
        }

        public int getCodigo()
        {
            return codigo;
        }
        public int getLlamadas()
        {
            return llamadas;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} - Apellido: {1} - Telefono: {2} - Fecha de nacimiento: {3} -Direccion: {4} - Codigo: {5}",
                nombre, apellido, telefono, fechaNacimiento.ToString("dd/mm/yyyy"), direccion, codigo);
        }

    }
}
