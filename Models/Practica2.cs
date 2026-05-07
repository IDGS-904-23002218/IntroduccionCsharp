using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploCsharp
{
    class Practica2
    {
        String nombre;
        private int edad;
        protected string carrera;

        public void IngresarDatos()
        {
            Console.Write("Ingresar tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu carrera: ");
            carrera = Console.ReadLine();
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
        }

        static void Main(String[] args)
        {
            Practica2 p2 = new Practica2();
            p2.IngresarDatos();
            p2.MostrarDatos();
        }
    }
}
