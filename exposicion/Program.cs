using System;

namespace exposicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pato Pato = new pato("Pato Lucas", "Amarillo");
            Pato.imprimir();
            Pato.nadar();
            Pato.volar();

            pinguino Pinguino = new pinguino("Pinguino Pepe", "Blanco");
            Pinguino.imprimir();
            Pinguino.nadar();
        }
    }
}
