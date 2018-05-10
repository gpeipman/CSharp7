using System;

namespace CS70
{
    class SwitchPatternsSample
    {
        public static void Show(Shape shape)
        {
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine($"circle with radius {c.Radius}");
                    break;
                case Rectangle s when (s.Length == s.Height):
                    Console.WriteLine($"{s.Length} x {s.Height} square");
                    break;
                case Rectangle r:
                    Console.WriteLine($"{r.Length} x {r.Height} rectangle");
                    break;
                default:
                    Console.WriteLine("<unknown shape>");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
            }
        }
    }

    #region DemoClasses
    public class Shape { }
    public class Circle : Shape { public double Radius { get; set; } }
    public class Rectangle : Shape { public double Length { get; set; } public double Height { get; set; } }
    #endregion
}
