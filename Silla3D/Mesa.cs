using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Silla3D {
    class Mesa : Objeto{
        double ht, hm, hb, wt, wm, wb, lt, lm, lp, lm2, lp2, lt2;

        public Mesa(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
            w = 15; h = 10; l = 15;
            dimensiones();
        }

        //tamaño personalizado
        public Mesa(float x, float y, float z, float w, float h, float l)
        {
            this.x = x; this.y = y; this.z = z;
            this.h = h; this.w = w; this.l = l;
            dimensiones();
        }

        public void dimensiones()
        {
            ht = h * 0;
            hm = h * 0.15;
            hb = h * 1;
            wt = w * 0.5;
            wm = w * 0.4;
            wb = w * 0.3;
            lt = l * 0;
            lm = l * 0.1;
            lp = l * 0.2;
            lp2 = l * 0.8;
            lm2 = l * 0.9;
            lt2 = l * 1;
        }

        public override void paint()
        {
            // tabla
            GL.Color4(0.0, 0.0, 0.8, 0.05);
            // parte delantera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wt, y - hm, z - lt);
            GL.Vertex3(x + wt, y - hm, z - lt);
            GL.Vertex3(x + wt, y + ht, z - lt);
            GL.Vertex3(x - wt, y + ht, z - lt);
            GL.End();

            //parte trasera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wt, y - hm, z - lt2);
            GL.Vertex3(x + wt, y - hm, z - lt2);
            GL.Vertex3(x + wt, y + ht, z - lt2);
            GL.Vertex3(x - wt, y + ht, z - lt2);
            GL.End();

            // lateral izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wt, y - hm, z - lt);
            GL.Vertex3(x - wt, y - ht, z - lt);
            GL.Vertex3(x - wt, y - ht, z - lt2);
            GL.Vertex3(x - wt, y - hm, z - lt2);
            GL.End();

            // lateral derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wt, y + ht, z - lt);
            GL.Vertex3(x + wt, y - hm, z - lt);
            GL.Vertex3(x + wt, y - hm, z - lt2);
            GL.Vertex3(x + wt, y + ht, z - lt2);
            GL.End();

            // parte inferior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wt, y - hm, z - lt);
            GL.Vertex3(x + wt, y - hm, z - lt);
            GL.Vertex3(x + wt, y - hm, z - lt2);
            GL.Vertex3(x - wt, y - hm, z - lt2);
            GL.End();

            // parte superior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wt, y + ht, z - lt);
            GL.Vertex3(x - wt, y - ht, z - lt);
            GL.Vertex3(x - wt, y - ht, z - lt2);
            GL.Vertex3(x + wt, y + ht, z - lt2);
            GL.End();


            // pata 1------------------------------------------------------------------------------------
            GL.Color4(0.5, 0.5, 0.5, 0.05);
            // parte delantera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hb, z - lm);
            GL.Vertex3(x - wb, y - hb, z - lm);
            GL.Vertex3(x - wb, y - hm, z - lm);
            GL.Vertex3(x - wm, y - hm, z - lm);
            GL.End();

            // parte trasera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hb, z - lp);
            GL.Vertex3(x - wb, y - hb, z - lp);
            GL.Vertex3(x - wb, y - hm, z - lp);
            GL.Vertex3(x - wm, y - hm, z - lp);
            GL.End();

            // lateral izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hm, z - lm);
            GL.Vertex3(x - wm, y - hb, z - lm);
            GL.Vertex3(x - wm, y - hb, z - lp);
            GL.Vertex3(x - wm, y - hm, z - lp);
            GL.End();

            //lateral derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wb, y - hm, z - lm);
            GL.Vertex3(x - wb, y - hb, z - lm);
            GL.Vertex3(x - wb, y - hb, z - lp);
            GL.Vertex3(x - wb, y - hm, z - lp);
            GL.End();

            // parte inferior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hb, z - lm);
            GL.Vertex3(x - wb, y - hb, z - lm);
            GL.Vertex3(x - wb, y - hb, z - lp);
            GL.Vertex3(x - wm, y - hb, z - lp);
            GL.End();

            //parte superior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hm, z - lm);
            GL.Vertex3(x - wb, y - hm, z - lm);
            GL.Vertex3(x - wb, y - hm, z - lp);
            GL.Vertex3(x - wm, y - hm, z - lp);
            GL.End();


            // pata 2
            // parte delantera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hb, z - lm);
            GL.Vertex3(x + wb, y - hb, z - lm);
            GL.Vertex3(x + wb, y - hm, z - lm);
            GL.Vertex3(x + wm, y - hm, z - lm);
            GL.End();

            // parte trasera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hb, z - lp);
            GL.Vertex3(x + wb, y - hb, z - lp);
            GL.Vertex3(x + wb, y - hm, z - lp);
            GL.Vertex3(x + wm, y - hm, z - lp);
            GL.End();

            // lateral izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hm, z - lm);
            GL.Vertex3(x + wm, y - hb, z - lm);
            GL.Vertex3(x + wm, y - hb, z - lp);
            GL.Vertex3(x + wm, y - hm, z - lp);
            GL.End();

            //lateral derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wb, y - hm, z - lm);
            GL.Vertex3(x + wb, y - hb, z - lm);
            GL.Vertex3(x + wb, y - hb, z - lp);
            GL.Vertex3(x + wb, y - hm, z - lp);
            GL.End();

            // parte inferior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hb, z - lm);
            GL.Vertex3(x + wb, y - hb, z - lm);
            GL.Vertex3(x + wb, y - hb, z - lp);
            GL.Vertex3(x + wm, y - hb, z - lp);
            GL.End();

            //parte superior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hm, z - lm);
            GL.Vertex3(x + wb, y - hm, z - lm);
            GL.Vertex3(x + wb, y - hm, z - lp);
            GL.Vertex3(x + wm, y - hm, z - lp);
            GL.End();


            // pata 3
            // parte delantera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hb, z - lm2);
            GL.Vertex3(x - wb, y - hb, z - lm2);
            GL.Vertex3(x - wb, y - hm, z - lm2);
            GL.Vertex3(x - wm, y - hm, z - lm2);
            GL.End();

            // parte trasera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hb, z - lp2);
            GL.Vertex3(x - wb, y - hb, z - lp2);
            GL.Vertex3(x - wb, y - hm, z - lp2);
            GL.Vertex3(x - wm, y - hm, z - lp2);
            GL.End();

            // lateral izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hm, z - lm2);
            GL.Vertex3(x - wm, y - hb, z - lm2);
            GL.Vertex3(x - wm, y - hb, z - lp2);
            GL.Vertex3(x - wm, y - hm, z - lp2);
            GL.End();

            //lateral derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wb, y - hm, z - lm2);
            GL.Vertex3(x - wb, y - hb, z - lm2);
            GL.Vertex3(x - wb, y - hb, z - lp2);
            GL.Vertex3(x - wb, y - hm, z - lp2);
            GL.End();

            // parte inferior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hb, z - lm2);
            GL.Vertex3(x - wb, y - hb, z - lm2);
            GL.Vertex3(x - wb, y - hb, z - lp2);
            GL.Vertex3(x - wm, y - hb, z - lp2);
            GL.End();

            //parte superior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x - wm, y - hm, z - lm2);
            GL.Vertex3(x - wb, y - hm, z - lm2);
            GL.Vertex3(x - wb, y - hm, z - lp2);
            GL.Vertex3(x - wm, y - hm, z - lp2);
            GL.End();

            // pata 4
            // parte delantera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hb, z - lm2);
            GL.Vertex3(x + wb, y - hb, z - lm2);
            GL.Vertex3(x + wb, y - hm, z - lm2);
            GL.Vertex3(x + wm, y - hm, z - lm2);
            GL.End();

            // parte trasera
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hb, z - lp2);
            GL.Vertex3(x + wb, y - hb, z - lp2);
            GL.Vertex3(x + wb, y - hm, z - lp2);
            GL.Vertex3(x + wm, y - hm, z - lp2);
            GL.End();

            // lateral izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hm, z - lm2);
            GL.Vertex3(x + wm, y - hb, z - lm2);
            GL.Vertex3(x + wm, y - hb, z - lp2);
            GL.Vertex3(x + wm, y - hm, z - lp2);
            GL.End();

            //lateral derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wb, y - hm, z - lm2);
            GL.Vertex3(x + wb, y - hb, z - lm2);
            GL.Vertex3(x + wb, y - hb, z - lp2);
            GL.Vertex3(x + wb, y - hm, z - lp2);
            GL.End();

            // parte inferior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hb, z - lm2);
            GL.Vertex3(x + wb, y - hb, z - lm2);
            GL.Vertex3(x + wb, y - hb, z - lp2);
            GL.Vertex3(x + wm, y - hb, z - lp2);
            GL.End();

            //parte superior
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(x + wm, y - hm, z - lm2);
            GL.Vertex3(x + wb, y - hm, z - lm2);
            GL.Vertex3(x + wb, y - hm, z - lp2);
            GL.Vertex3(x + wm, y - hm, z - lp2);
            GL.End();
        }

        public override void rotate()
        {
            throw new NotImplementedException();
        }
        public override void move()
        {
            throw new NotImplementedException();
        }
    }
}
