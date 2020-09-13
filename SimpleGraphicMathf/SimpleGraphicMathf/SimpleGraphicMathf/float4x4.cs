using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGraphicMathf
{
   public class float4x4
    {
        float[,] pts;
        public float4x4()
        {
            pts = new float[4, 4];
        }
        public float this[int i, int j]
        {
            get { return pts[i - 1, j - 1]; }
            set { pts[i - 1, j - 1] = value; }
        }

        public float4 Mul(float4 r)
        {
            float x = this[1, 1] * r.X + this[2, 1] * r.Y + this[3, 1] * r.Z + this[4, 1] * r.W;
            float y = this[1, 2] * r.X + this[2, 2] * r.Y + this[3, 2] * r.Z + this[4, 2] * r.W;
            float z = this[1, 3] * r.X + this[2, 3] * r.Y + this[3, 3] * r.Z + this[4, 3] * r.W;
            float w = this[1, 4] * r.X + this[2, 4] * r.Y + this[3, 4] * r.Z + this[4, 4] * r.W;

            //float x = this[1, 1] * r.X + this[1, 2] * r.Y + this[1, 3] * r.Z + this[1, 4] * r.W;
            //float y = this[2, 1] * r.X + this[2, 2] * r.Y + this[2, 3] * r.Z + this[2, 4] * r.W;
            //float z = this[3, 1] * r.X + this[3, 2] * r.Y + this[3, 3] * r.Z + this[3, 4] * r.W;
            //float w = this[4, 1] * r.X + this[4, 2] * r.Y + this[4, 3] * r.Z + this[4, 4] * r.W;


            float4 re = new float4(x, y, z, w);
            return re;
        }
        public float4x4 Mul(float4x4 m)
        {
            float4x4 newM = new float4x4();
            for (int w = 1; w <= 4; w++)
            {
                for (int h = 1; h <= 4; h++)
                {
                    for (int n = 1; n <= 4; n++)
                    {
                        newM[w, h] += this[w, n] * m[n, h];
                    }
                }
            }
            return newM;
        }
        public float4x4 Transpose()
        {
            float4x4 m = new float4x4();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    m[i, j] = this[j, i];
                }
            }
            return m;

        }
    }
    
}
