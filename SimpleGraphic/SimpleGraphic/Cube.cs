using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleGraphicMathf;

namespace SimpleGraphic
{
    class Cube
    {
        int num=0;
        float4 a = new float4(-0.5f, 0.5f, 0.5f, 1f);
        float4 b = new float4(0.5f, 0.5f, 0.5f, 1f);
        float4 c = new float4(0.5f, 0.5f, -0.5f,1f);
        float4 d = new float4(-0.5f, 0.5f, -0.5f,1f);

        float4 e = new float4(-0.5f, -0.5f, 0.5f, 1f);
        float4 f = new float4(0.5f, -0.5f, 0.5f, 1f);
        float4 g = new float4(0.5f, -0.5f, -0.5f, 1f);
        float4 h = new float4(-0.5f, -0.5f, -0.5f, 1f);

        Triangle[] triangles= new Triangle[12];
        public Cube()
        {
            //正面
            triangles[0] = new Triangle(d,c,g);
            triangles[1] = new Triangle(d,g,h);
            //后
            triangles[2] = new Triangle(a, e, b);
            triangles[3] = new Triangle(b, e, f);
            //左侧
            triangles[4] = new Triangle(a, d, h);
            triangles[5] = new Triangle(a, h, e);
            //右侧
            triangles[6] = new Triangle(b,f,c);
            triangles[7] = new Triangle(c,f,g);
            //上面
            triangles[8] = new Triangle(a,b,c);
            triangles[9] = new Triangle(a,c,d);
            //下面
            triangles[10] = new Triangle(e,h,f);
            triangles[11] = new Triangle(f,h,g);
        }
        public void Transform(float4x4 m)
        {
            foreach(Triangle item in triangles)
            {
                item.Transform(m);
            }
        }
        public void CalculateLighting(float4x4 m,float4 l) 
        {
            foreach (Triangle item in triangles)
            {
                item.CalculateLighting(m,l);

            }
        }

        public void Draw(Graphics g,bool lineOpen)
        {
            g.TranslateTransform(300, 300);
            foreach (Triangle item in triangles)
            {
                item.OnDraw(g, lineOpen);
            }
            //for (int i = 0; i < triangles.Count() - 1; i++)
            //{
            //    triangles[i].OnDraw(g);
            //}


        }
    }
}

