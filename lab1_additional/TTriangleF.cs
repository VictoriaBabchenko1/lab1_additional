using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_additional
{
    class TTriangleF : TTriangle
    {
        public TTriangleF(float a, float b, float c) : base( a, b, c) { }
        public override bool Equals(object obj)
        {
            return obj is TTriangleF other && A == other.A && B == other.B && C == other.C;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }
    }
}
