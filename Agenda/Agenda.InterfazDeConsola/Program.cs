using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Agenda.InterfazDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto = new Contacto("Julian", "Rinaldi", "1159474835", "Juan bautisa labrdi 4427", Convert.ToDateTime("08/05/2001"), 1,1);
            Contacto contacto2 = new Contacto("Maria", "Ortigoza", "1154324815", "Juan bautisa labrdi 4427", Convert.ToDateTime("08/05/2001"), 1, 1);
            Contacto contacto3 = new Contacto("Juliana", "Rinalda", "1165234231", "Juan bautisa labrdi 4427", Convert.ToDateTime("08/05/2001"), 1, 1);
            Contacto contacto4 = new Contacto("Julienn", "Rinaldo", "1134936261", "Juan bautisa labrdi 4427", Convert.ToDateTime("08/05/2001"), 4, 1);

            agenda agenda = new agenda("Agenda de Julian", "a", 4);

            agenda.agregarContacto(contacto);
            agenda.agregarContacto(contacto2);
            agenda.agregarContacto(contacto3);
            agenda.agregarContacto(contacto4);
            foreach (Contacto a in agenda.listaDeContactos)
            {
                Console.WriteLine(a.ToString());
            }
            agenda.eliminarContacto(4);
            foreach (Contacto a in agenda.listaDeContactos)
            {
                Console.WriteLine(a.ToString());
            }



            Console.ReadKey();
        }
    }
}
