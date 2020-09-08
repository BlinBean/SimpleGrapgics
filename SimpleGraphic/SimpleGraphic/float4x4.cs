using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphic
{
    class float4x4
    {
        float ax; float ay; float az; float aw;
        float bx; float by; float bz; float bw;
        float cx; float cy; float cz; float cw;
        float dx; float dy; float dz; float dw;
        public float4x4(float ax,float ay,float az,float aw,
                        float bx, float by, float bz, float bw,
                        float cx, float cy, float cz, float cw,
                        float dx, float dy, float dz, float dw
                        )
        {
            this.ax = ax;
            this.ay = ay;
            this.az = az;
            this.aw = aw;

            this.bx = bx;
            this.by = by;
            this.bz = bz;
            this.bw = bw;

            this.cx = cx;
            this.cy = cy;
            this.cz = cz;
            this.cw = cw;

            this.dx = dx;
            this.dy = dy;
            this.dz = dz;
            this.dw = dw;
        }
        public float4x4(float4 a,float4 b,float4 c,float4 d)
        {
            this.ax = a.X;
            this.ay = a.Y;
            this.az = a.Z;
            this.aw = a.W;

            this.bx = b.X;
            this.by = b.Y;
            this.bz = b.Z;
            this.bw = b.W;

            this.cx = c.X;
            this.cy = c.Y;
            this.cz = c.Z;
            this.cw = c.W;

            this.dx = d.X;
            this.dy = d.Y;
            this.dz = d.Z;
            this.dw = d.W;
        }
        public float4 Mul(float4 r)
        {
            float x = ax * r.X + ay * r.Y + az * r.Z + aw * r.W;
            float y = bx * r.X + by * r.Y + bz * r.Z + bw * r.W;
            float z = cx * r.X + cy * r.Y + cz * r.Z + cw * r.W;
            float w = dx * r.X + dy * r.Y + dz * r.Z + dw * r.W;
            float4 re = new float4(x,y,z,w);
            return re;
        }
    }
}
