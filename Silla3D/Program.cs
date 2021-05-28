using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silla3D
{
    static class Program
    {

        static void Main()
        {
            Controlador ctrl = new Controlador();
            ctrl.Run(1 / 60);
        }
    }
}
