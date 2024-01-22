using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona persona = new Persona();
            persona.crearPersona(1, "luis", "gerente \n");

            Console.WriteLine(" id:" + persona.Id + "\n" + "Nombre:" + persona.Name + "\n" + "tipo de usuario:" + persona.Type +"\n");
            Console.WriteLine("Esta es una sobrecarga de metodo-- " + persona.crearPersona());//metodo sobrecargado
            */

            Estudiante obj = new Estudiante();
            obj.Name = "jorge";
            obj.Edad = 20;
            obj.Matricula = "4564160";
            obj.Grado = "primero";
            obj.Grupo = "A";

            Console.WriteLine($"Estudiante: \nNombre:{obj.Name} \nEdad: {obj.Edad} \nMatricula: {obj.Matricula} \nGrado: {obj.Grado} \nGrupo: {obj.Grupo}\n");

            Profesor objPro = new Profesor();
            objPro.crearPersona( 2, "juan peres", "matematica");
            objPro.NoEmpleado = "6564646";
            objPro.Sueldo = 500.000;

            Console.WriteLine($"Profesor: \nNombre:{objPro.Name} \nEdad: {objPro.Edad} \nMatricula: {objPro.NoEmpleado} \nGrado: {objPro.Sueldo}");
            Console.ReadLine();
        }
    }
}
