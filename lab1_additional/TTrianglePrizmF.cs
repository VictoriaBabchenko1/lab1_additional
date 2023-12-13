using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_additional
{
    class TTrianglePrizmF : TTrianglePrizm
    {
        public TTrianglePrizmF(float a, float b, float c, float h) : base(a, b, c, h) { }

        public override bool Equals(object obj)
        {
            return obj is TTrianglePrizmF other && A == other.A && B == other.B && C == other.C && H == other.H;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C, H);
        }
    }
}
