namespace POINT
{
    class Point
    {
        //===================== ATTRIBUTES =====================//
        private int x;
        private int y;

        //===================== CONSTRUCTORS ====================//
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        //======================= METHODS ======================//
        public override string ToString() => ("(" + x + " ; " + y + ")");

        public void PrintCoordinate() => System.Console.WriteLine("Point coordinates : " + this.ToString());

        public void Move(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public Point OrdinateAxialSymmetry()
        {
            if (x == int.MinValue)
                return new Point(x, y);
            return new Point(-x, y);
        }

        public Point AbcissaAxialSymmetry()
        {
            if (y == int.MinValue)
                return new Point(x, y);
            return new Point(x, -y);
        }

        public Point CentralSymmetry()
        {
            if (x == int.MinValue || y == int.MinValue)
                return new Point(x, y);
            return new Point(-x, -y);
        }

        public void SwapCoordinate()
        {
            int tmp;

            tmp = x;
            x = y;
            y = tmp;
        }
    }
}