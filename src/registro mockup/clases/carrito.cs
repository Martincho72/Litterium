using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_mockup.clases
{
    internal static class carrito
    {
        static List<Ejemplar>  miCarrito = new List<Ejemplar>();

        public static List<Ejemplar> MiCarrito { get { return miCarrito; }}


        public static void agregarAlCarrito(Ejemplar ejemplar)
        {
            miCarrito.Add(ejemplar);
        }


    }
}
