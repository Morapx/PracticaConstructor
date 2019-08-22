using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Console.WriteLine("Alumno 1:");
            Console.WriteLine("Nombre:" + alumno1.Nombre);
            Console.WriteLine("Matricula:" + alumno1.Matricula);

            //Usa el constructor sin  parametros
            //Despues establece sus atributos
            Alumno alumno2 = new Alumno();

            alumno2.Nombre = "Pedro";
            alumno2.Matricula = "CBA147";
            Console.WriteLine("Alumno 2:");
            Console.WriteLine("Nombre:" + alumno2.Nombre);
            Console.WriteLine("Matricula:" + alumno2.Matricula);

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            Alumno alumno3 = new Alumno("Ana", "CBA158");
            Console.WriteLine("Alumno 3:");
            Console.WriteLine(" Nombre:" + alumno3.Nombre);
            Console.WriteLine("Matricula:" + alumno3.Matricula);
            Console.Read();
        }
    }
}
