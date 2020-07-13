using System;

namespace POINT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\x1b[0m\x1b[46m\n[                TEST 1                ]\x1b[0m");
            Console.WriteLine("\x1b[33mPoint origin = new Point();");
            Console.WriteLine("Point point1 = new Point(10, -15);");
            Console.WriteLine("origin.PrintCoordinate();");
            Console.WriteLine("point1.PrintCoordinate();\x1b[36m");
            Point origin = new Point();
            Point point1 = new Point(10, -15);
            origin.PrintCoordinate();
            point1.PrintCoordinate();

            Console.WriteLine("\x1b[0m\x1b[46m\n[                TEST 2                ]\x1b[0m");
            Console.WriteLine("\x1b[33mpoint1.Move(-20, 12);");
            Console.WriteLine("point1.PrintCoordinate();\x1b[36m");
            point1.Move(-20, 12);
            point1.PrintCoordinate();

            Console.WriteLine("\x1b[0m\x1b[46m\n[                TEST 3                ]\x1b[0m");
            Console.WriteLine("\x1b[33mPoint point2 = point1.OrdinateAxialSymmetry();");
            Console.WriteLine("Point point3 = point1.AbcissaAxialSymmetry();");
            Console.WriteLine("Point point4 = point1.CentralSymmetry();");
            Console.WriteLine("point1.PrintCoordinate(); \x1b[32m// Should be (-20 ; 12)\x1b[0m");
            Console.WriteLine("\x1b[33mpoint2.PrintCoordinate(); \x1b[32m// Should be (20 ; 12)\x1b[0m");
            Console.WriteLine("\x1b[33mpoint3.PrintCoordinate(); \x1b[32m// Should be (-20 ; -12)\x1b[0m");
            Console.WriteLine("\x1b[33mpoint4.PrintCoordinate(); \x1b[32m// Should be (20 ; -12)\x1b[36m");
            Point point2 = point1.OrdinateAxialSymmetry();
            Point point3 = point1.AbcissaAxialSymmetry();
            Point point4 = point1.CentralSymmetry();
            point1.PrintCoordinate();
            point2.PrintCoordinate();
            point3.PrintCoordinate();
            point4.PrintCoordinate();

            Console.WriteLine("\x1b[0m\x1b[46m\n[                TEST 4                ]\x1b[0m");
            Console.WriteLine("\x1b[33mpoint1.SwapCoordinate();");
            Console.WriteLine("point1.PrintCoordinate(); \x1b[32m// Should be (12 ; -20)\x1b[36m");
            point1.SwapCoordinate();
            point1.PrintCoordinate();
            Console.WriteLine("\x1b[0m");
        }
    }
}
