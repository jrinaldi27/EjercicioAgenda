using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class agenda
    {
        private string nombre { get; set; }
        private string tipo { get; set; }

        public List<Contacto> listaDeContactos ;

        private int cantidadMaximaDeContactos { get; set; }


        public agenda(string nom, string tip, int cant)
        {
            nombre = nom;
            tipo = tip;
            listaDeContactos = new List<Contacto>();
            cantidadMaximaDeContactos = cant;

       
        }

        public void agregarContacto(Contacto a)
        {
            if (listaDeContactos.Count <= cantidadMaximaDeContactos)
            {
                listaDeContactos.Add(a);
            }
            
        }

        public void eliminarContacto(int id)
        {
            int contactosBorrados = 0;
            foreach(Contacto a in listaDeContactos)
            {

                if (a.getCodigo() == id)
                {
                    listaDeContactos.Remove(a);
                    Console.WriteLine("Se elimino el contacto correctamente");
                    contactosBorrados = 1;
                    break;
                }
                
            }
            if (contactosBorrados == 0)
            {
                Console.WriteLine("No se pudo encontrar el contacto deseado");
            }
        }

        //public Contacto traerContactoFrecuente()

        

    }
}
