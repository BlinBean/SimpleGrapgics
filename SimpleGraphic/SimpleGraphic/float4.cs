using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGraphic
{
    class float4
    {
        float x;
        float y;
        float z;
        float w;
        public float4(int x,int y,int z,int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public float4(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 0;
        }
        public float X{get { return x; } }
        public float Y { get { return y; } }
        public float Z { get { return z; } }
        public float W { get { return w; } }

    }
}
