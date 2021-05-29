using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;

namespace Silla3D
{
    class Controlador : GameWindow{

        IObjeto silla1 = new Silla(10, -1, 1, 6, 15, 10);
        IObjeto silla2 = new Silla(-5, -5, -7);

        public Controlador() : base(740, 740, OpenTK.Graphics.GraphicsMode.Default, "Silla"){

        }

        protected override void OnLoad(EventArgs e){
            GL.ClearColor(0f, 0f, 0f, 0f);
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Translate(0.0, 0.0, -45.0);
           // GL.Rotate(-20, 5.0, 0.0, 0.0);
            GL.PushMatrix();

            silla1.paint();
            silla2.paint();

            GL.PopMatrix();
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e){
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), (float)(Width / Height), 20.0f, 300.0f);
            GL.LoadMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Modelview);
            base.OnResize(e);
        }

    }
}
