using System;

namespace SimpleGraphicMathf
{
    public class float4
    {
        float x;
        float y;
        float z;
        float w;
        public float4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public float4(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 0;
        }
        public float4(float4 f)
        {
            this.x = f.X;
            this.y = f.Y;
            this.z = f.Z;
            this.w = f.W;
        }
        public float X { get { return x; } }
        public float Y { get { return y; } }
        public float Z { get { return z; } }
        public float W { get { return w; } }

    }
}
