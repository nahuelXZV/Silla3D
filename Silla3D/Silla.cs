using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Silla3D
{
    class Silla{
        float x, y, z;
        float w, h, l;
        double ab, at, hb, hp, ha, ht, lt, lm;

        /*
          x = posicion en el eje x
          y = posicion en el eje y
          z = posicion en el eje z
          w = ancho de la silla
          h = alto de la silla
          l = largo de la silla
        */

        //Tamaño por defecto
        public Silla(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
            w = 11; h = 20; l = 10;
            dimensiones();
        }

        //tamaño personalizado
        public Silla(float x, float y, float z, float w, float h, float l)
        {
            this.x = x; this.y = y; this.z = z;
            this.h = h; this.w = w; this.l = l;
            dimensiones();
        }

        public void dimensiones()
        {
            ab = w * 0.5;
            at = w * 0.315;
            hb = h * 0.4;
            hp = h * 0.10;
            ha = h * 0;
            ht = h * 0.6;
            lt = l * 0.5;
            lm = l * 0.315;
        }

        public void paint()
        {
            // pata 1
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hb, z + lt);
            GL.Vertex3(x - at, y - hb, z + lt);
            GL.Vertex3(x - at, y - hp, z + lt);
            GL.Vertex3(x - ab, y - hp, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hb, z + lm);
            GL.Vertex3(x - at, y - hb, z + lm);
            GL.Vertex3(x - at, y - hp, z + lm);
            GL.Vertex3(x - ab, y - hp, z + lm);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hb, z + lt);
            GL.Vertex3(x - ab, y - hb, z + lm);
            GL.Vertex3(x - ab, y - hp, z + lm);
            GL.Vertex3(x - ab, y - hp, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - at, y - hb, z + lt);
            GL.Vertex3(x - at, y - hb, z + lm);
            GL.Vertex3(x - at, y - hp, z + lm);
            GL.Vertex3(x - at, y - hp, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hb, z + lt);
            GL.Vertex3(x - at, y - hb, z + lm);
            GL.Vertex3(x - at, y - hb, z + lm);
            GL.Vertex3(x - ab, y - hb, z + lt);
            GL.End();

            //pata 2----------------------------------------------------------------
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + at, y - hb, z + lt);
            GL.Vertex3(x + ab, y - hb, z + lt);
            GL.Vertex3(x + ab, y - hp, z + lt);
            GL.Vertex3(x + at, y - hp, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + at, y - hb, z + lm);
            GL.Vertex3(x + ab, y - hb, z + lm);
            GL.Vertex3(x + ab, y - hp, z + lm);
            GL.Vertex3(x + at, y - hp, z + lm);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + ab, y - hb, z + lt);
            GL.Vertex3(x + ab, y - hb, z + lm);
            GL.Vertex3(x + ab, y - hp, z + lm);
            GL.Vertex3(x + ab, y - hp, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + at, y - hb, z + lt);
            GL.Vertex3(x + at, y - hb, z + lm);
            GL.Vertex3(x + at, y - hp, z + lm);
            GL.Vertex3(x + at, y - hp, z + lt);
            GL.End();

            // pata 3 ---------------------------------------------------------------

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hb, z - lt);
            GL.Vertex3(x - at, y - hb, z - lt);
            GL.Vertex3(x - at, y - hp, z - lt);
            GL.Vertex3(x - ab, y - hp, z - lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hb, z - lm);
            GL.Vertex3(x - at, y - hb, z - lm);
            GL.Vertex3(x - at, y - hp, z - lm);
            GL.Vertex3(x - ab, y - hp, z - lm);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hb, z - lt);
            GL.Vertex3(x - ab, y - hb, z - lm);
            GL.Vertex3(x - ab, y - hp, z - lm);
            GL.Vertex3(x - ab, y - hp, z - lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - at, y - hb, z - lt);
            GL.Vertex3(x - at, y - hb, z - lm);
            GL.Vertex3(x - at, y - hp, z - lm);
            GL.Vertex3(x - at, y - hp, z - lt);
            GL.End();

            // pata 4-----------------------------------------------------
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + at, y - hb, z - lt);
            GL.Vertex3(x + ab, y - hb, z - lt);
            GL.Vertex3(x + ab, y - hp, z - lt);
            GL.Vertex3(x + at, y - hp, z - lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + at, y - hb, z - lm);
            GL.Vertex3(x + ab, y - hb, z - lm);
            GL.Vertex3(x + ab, y - hp, z - lm);
            GL.Vertex3(x + at, y - hp, z - lm);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + ab, y - hb, z - lt);
            GL.Vertex3(x + ab, y - hb, z - lm);
            GL.Vertex3(x + ab, y - hp, z - lm);
            GL.Vertex3(x + ab, y - hp, z - lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + at, y - hb, z - lt);
            GL.Vertex3(x + at, y - hb, z - lm);
            GL.Vertex3(x + at, y - hp, z - lm);
            GL.Vertex3(x + at, y - hp, z - lt);
            GL.End();


            //asiento----------------------------------------------------------------------
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hp, z + lt);
            GL.Vertex3(x + ab, y - hp, z + lt);
            GL.Vertex3(x + ab, y + ha, z + lt);
            GL.Vertex3(x - ab, y - ha, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hp, z - lt);
            GL.Vertex3(x - ab, y - ha, z - lt);
            GL.Vertex3(x + ab, y + ha, z - lt);
            GL.Vertex3(x + ab, y - hp, z - lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + ab, y - hp, z + lt);
            GL.Vertex3(x + ab, y - hp, z - lt);
            GL.Vertex3(x + ab, y + ha, z - lt);
            GL.Vertex3(x + ab, y + ha, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y - hp, z + lt);
            GL.Vertex3(x - ab, y - hp, z - lt);
            GL.Vertex3(x - ab, y - ha, z - lt);
            GL.Vertex3(x - ab, y - ha, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + ab, y + ha, z + lt);
            GL.Vertex3(x + ab, y + ha, z - lt);
            GL.Vertex3(x - ab, y - ha, z - lt);
            GL.Vertex3(x - ab, y - ha, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + ab, y - hp, z + lt);
            GL.Vertex3(x + ab, y - hp, z - lt);
            GL.Vertex3(x - ab, y - hp, z - lt);
            GL.Vertex3(x - ab, y - hp, z + lt);
            GL.End();

            //espaldar --------------------------------------------------------------------

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y + ha, z + lt);
            GL.Vertex3(x - at, y + ha, z + lt);
            GL.Vertex3(x - at, y + ht, z + lt);
            GL.Vertex3(x - ab, y + ht, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y + ha, z - lt);
            GL.Vertex3(x - at, y + ha, z - lt);
            GL.Vertex3(x - at, y + ht, z - lt);
            GL.Vertex3(x - ab, y + ht, z - lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y + ha, z + lt);
            GL.Vertex3(x - ab, y + ha, z - lt);
            GL.Vertex3(x - ab, y + ht, z - lt);
            GL.Vertex3(x - ab, y + ht, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - at, y + ha, z + lt);
            GL.Vertex3(x - at, y + ha, z - lt);
            GL.Vertex3(x - at, y + ht, z - lt);
            GL.Vertex3(x - at, y + ht, z + lt);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - ab, y + ht, z + lt);
            GL.Vertex3(x - ab, y + ht, z - lt);
            GL.Vertex3(x - at, y + ht, z - lt);
            GL.Vertex3(x - at, y + ht, z + lt);
            GL.End();


        }


    }
}
