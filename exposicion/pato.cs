using System;
using System.Collections.Generic;
using System.Text;

namespace exposicion
{
    public class pato : animal, Ivolar, Inadar
    {
        public pato(string nombre, string color) : base(nombre, color)
        {

        }
    }
}