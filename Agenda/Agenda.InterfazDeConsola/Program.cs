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
            Contacto contacto = new Contacto("Julian", "Rinaldi", "1159474835", "Juan bautisa labrdi 4427", Convert.ToDateTime("08/05/2001"), 1);
            Console.WriteLine(contacto.edad());
       
            Console.ReadKey();
        }
    }
}
