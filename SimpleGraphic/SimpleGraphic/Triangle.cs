using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleGraphicMathf;


namespace SimpleGraphic
{
    class Triangle
    {
        float4 A;
        float4 B;
        float4 C;

        float4 a;
        float4 b;
        float4 c;

       // float4 normal;
        float dot;
        bool cullBack;
        public Triangle(float4 a,float4 b,float4 c)
        {
            this.A =this.a= new float4(a);
            this.B =this.b= new float4(b);
            this.C = this.c=new float4(c);
        }
        public void Transform(float4x4 m)
        {
           this.a= m.Mul(A);
           this.b= m.Mul(B);
           this.c= m.Mul(C);
        }
        public void OnDraw(Graphics g,bool lineOpen)
        {
            //设置坐标系中心
            //g.TranslateTransform(300, 300);

            Pen pen = new Pen(Color.Red,2);
            PointF[] getpoints=this.GetPointF();

            if(lineOpen)
                g.DrawLines(pen,getpoints);

            else
            {
                SolidBrush br;
                if (!cullBack)
                {
                    GraphicsPath path = new GraphicsPath();
                    path.AddLines(getpoints);
                    int r = (int)(200 * dot) + 55;
                   // r = 255;
                    br = new SolidBrush(Color.FromArgb(r, r, r, r));
                    g.FillPath(br, path);
                }
            }


        }
        public PointF[] GetPointF()
        {
            PointF[] getPoints= new PointF[4];
            getPoints[0] = new PointF(a.X / a.W, -a.Y / a.W);
            getPoints[1] = new PointF(b.X / b.W,- b.Y / b.W);
            getPoints[2] = new PointF(c.X / c.W, -c.Y / c.W);
            //这里是因为需要从最末连到第一个顶点
            getPoints[3] = getPoints[0];
            return getPoints;
        }
        public void CalculateLighting(float4x4 m,float4 l)
        {
            this.Transform(m);
            float4 u= b-a;
            float4 v = c-a;
            float4 normal = v.Cross(u).Normalized;
            dot = l.Normalized.Dot(normal);
            //dot = 0 > dot ? 0 : dot;
            //dot = dot > 1 ? 1 : dot;
            dot = Math.Max(0,dot);
            //if (dot.ToString() == "NaN")
            //    throw new Exception();
            dot = Math.Min(1,dot);
            cullBack = new float4(0, 0, -1, 0).Dot(normal.Normalized) < 0 ? true : false;
        }
    }
}
