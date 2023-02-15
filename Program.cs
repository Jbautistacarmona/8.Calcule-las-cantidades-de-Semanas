using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Calcule_las_cantidades_de_Semanas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la primera fecha (formato dd/mm/aaaa):");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda fecha (formato dd/mm/aaaa):");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());//Convierte la representación de cadena de una fecha y hora en su equivalente DateTime

            TimeSpan diferencia = fecha2 - fecha1;//restar fecha2 de la fecha1 y divirlo en 7, para lograr ver la cantidad de semanas
            int semanas = (int)diferencia.TotalDays / 7;//procede con un numero entero.

            Console.WriteLine("Entre las fechas " + fecha1.ToShortDateString() + " y " + fecha2.ToShortDateString() + " hay " + semanas + " semanas.");//mensaje en pantalla.

            Console.ReadLine();// imprimir en pantalla
        }
    }
}
