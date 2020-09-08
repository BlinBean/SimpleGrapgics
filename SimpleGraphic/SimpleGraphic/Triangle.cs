using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphic
{
    class Triangle
    {
        float4 a;
        float4 b;
        float4 c;

        public Triangle(float4 a,float4 b,float4 c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void OnDraw(Graphics g)
        {
            PointF one = new PointF(a.X/a.W,a.Y/a.W);
            PointF two = new PointF(b.X / b.W, b.Y / b.W);
            PointF three = new PointF(c.X / c.W, c.Y / c.W);

            Pen pen = new Pen(Color.Red,2);
            g.DrawLine(pen,one,two);
            g.DrawLine(pen,one,three);
            g.DrawLine(pen,three,two);
        }
        public PointF[] GetPointF()
        {
            PointF[] getPoints= new PointF[3];
        }
    }
}
