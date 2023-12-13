using System;
using System.Collections.Generic;

namespace lab1_additional
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<TTriangle> triangleHashSet = new HashSet<TTriangle>();
            TTriangle triangle1 = new TTriangle(4, 3, 5);
            triangleHashSet.Add(triangle1);
            TTriangle triangle2 = new TTriangle(4, 3, 5);
            Console.WriteLine($"Does TriangleHashSet contains triangle2: {triangleHashSet.Contains(triangle2)}");

            HashSet<TTriangleF> triangleFHashSet = new HashSet<TTriangleF>();
            TTriangleF triangleF1 = new TTriangleF(4, 3, 5);
            triangleFHashSet.Add(triangleF1);
            TTriangleF triangleF2 = new TTriangleF(4, 3, 5);
            Console.WriteLine($"Does TriangleFHashSet contains triangleF2: {triangleFHashSet.Contains(triangleF2)}");

            HashSet<TTrianglePrizm> trianglePrizmHashSet = new HashSet<TTrianglePrizm>();
            trianglePrizmHashSet.Add(new TTrianglePrizm(4, 3, 5, 6));
            trianglePrizmHashSet.Add(new TTrianglePrizm(4, 3, 5, 7));
            trianglePrizmHashSet.Add(new TTrianglePrizm(4, 3, 5, 8));
            trianglePrizmHashSet.Add(new TTrianglePrizm(4, 3, 5, 9));
            trianglePrizmHashSet.Add(new TTrianglePrizm(4, 3, 5, 10));
            Console.WriteLine($"trianglePrizmHashSet count is equal to: {trianglePrizmHashSet.Count}");

            HashSet<TTrianglePrizmF> trianglePrizmFHashSet = new HashSet<TTrianglePrizmF>();
            trianglePrizmFHashSet.Add(new TTrianglePrizmF(4, 3, 5, 6));
            trianglePrizmFHashSet.Add(new TTrianglePrizmF(4, 3, 5, 7));
            trianglePrizmFHashSet.Add(new TTrianglePrizmF(4, 3, 5, 8));
            trianglePrizmFHashSet.Add(new TTrianglePrizmF(4, 3, 5, 9));
            trianglePrizmFHashSet.Add(new TTrianglePrizmF(4, 3, 5, 10));
            Console.WriteLine($"trianglePrizmFHashSet count is equal to: {trianglePrizmFHashSet.Count}");
        }
    }
}
