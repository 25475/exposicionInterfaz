using System;
using System.Collections.Generic;
using System.Text;

namespace exposicion
{
    public class animal
    {
        string nombre { get; set; }
        string color { get; set; }

        public animal(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        public void imprimir()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Color:" + color);

        }

        public void nadar()
        {
            Console.WriteLine("Nada");
        }

        public void volar()
        {
            Console.WriteLine("vuela");
        }
    }
}