using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_mockup.clases
{
    internal static class carrito
    {
        static List<Libro>  miCarrito = new List<Libro>();

        public static List<Libro> MiCarrito { get { return miCarrito; }}


        public static void agregarAlCarrito(Libro libro)
        {
            miCarrito.Add(libro);
        }


    }
}
