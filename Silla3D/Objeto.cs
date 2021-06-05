using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silla3D
{
    // lista de parte
    abstract class Objeto : IObjeto
    {
        // posicicion
        public double x, y, z;
        // medidas
        public double w, h, l;
        // colores
        public double r, g, b;

        public abstract void paint();

        public abstract void move();

        public abstract void rotate();
    }
}
