namespace Static
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Triangle: " + GeometryHelper.TriangleArea(14.2, 15.8, 16.1));
            Console.WriteLine("Area of Rectangle: " + GeometryHelper.RectangleArea(20, -5));
            Console.WriteLine("Area of Circle: " + GeometryHelper.CircleArea(5.4));
        }
    }
}