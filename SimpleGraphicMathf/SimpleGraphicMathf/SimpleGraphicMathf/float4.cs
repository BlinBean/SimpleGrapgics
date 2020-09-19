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
        public float4 Cross(float4 n)
        {

            float4 c=new float4(this.y*n.Z-this.z*n.Y ,
                                this.z*n.X-this.x*n.Z ,
                                this.x*n.Y-this.y*n.X ,
                                0);
            return c;
        }
        public float Dot(float4 n)
        {
            return (float)(this.x * n.X + this.y * n.Y + this.z * n.Z );
        }
        public static float4 operator -(float4 a,float4 b)
        {
            return new float4(a.X - b.X,
                              a.Y - b.Y,
                              a.Z - b.Z,
                              a.W - b.W);
        }
        public float4 Normalized
        {
            get
            {
                float sum = (float)Math.Sqrt(x * x + y * y + z * z + w * w);
                return new float4(x / sum, y / sum, z / sum, w / sum);
            }
        }
        public override bool Equals(object v)
        {
            if (v == null)
            {
                return false;
            }
            float4 M = (float4)v;
            if (this.x == M.X && this.y == M.Y && this.z == M.Z && this.w == M.W)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            //return this.Eid.GetHashCode() + this.Name.GetHashCode() + this.Money.GetHashCode();
            return this.x.GetHashCode() + this.y.GetHashCode() + this.z.GetHashCode() + this.w.GetHashCode();
        }
    }
}
