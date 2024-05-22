using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_mockup.clases
{
    internal class carrito
    {
        List<Ejemplar> miCarrito = new List<Ejemplar>();

        public List<Ejemplar> MiCarrito { get { return miCarrito; } }


        public void agregarAlCarrito(Ejemplar ejemplar)
        {
            miCarrito.Add(ejemplar);
        }


    }
}
