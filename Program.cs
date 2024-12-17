using System;

namespace Vector
{
    public class Vес
    {
        private double x, y;

        public Vес(double x = 0, double y = 0) => (this.x, this.y) = (x, y);
        public double Len => Math.Sqrt(x * x + y * y);
        public override string ToString() => $"({x}, {y})";

        public static Vес operator +(Vес a, Vес b) => new(a.x + b.x, a.y + b.y);
        public static Vес operator -(Vес a, Vес b) => new(a.x - b.x, a.y - b.y);
        public static Vес operator *(Vес v, double s) => new(v.x * s, v.y * s);
        public static Vес operator *(double s, Vес v) => v * s;
        public static double operator *(Vес a, Vес b) => a.x * b.x + a.y * b.y;
        public static Vес operator -(Vес v) => new(-v.x, -v.y);
        public static Vес operator ++(Vес v) => new(v.x + 1, v.y + 1);
        public static Vес operator --(Vес v) => new(v.x - 1, v.y - 1);

        public static bool operator ==(Vес a, Vес b) => a.x == b.x && a.y == b.y;
        public static bool operator !=(Vес a, Vес b) => !(a == b);
        public static bool operator true(Vес v) => v.x != 0 || v.y != 0;
        public static bool operator false(Vес v) => v.x == 0 && v.y == 0;

        public static explicit operator double(Vес v) => v.Len;
        public static implicit operator Vес(double d) => new(d, 0);

        public double this[int i]
        {
            get => i == 0 ? x : y;
            set { if (i == 0) x = value; else y = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Vес v1 = new(3, 4), v2 = new(1, 2), v3 = 5.0;

            Console.WriteLine($"v1: {v1}, v2: {v2}");
            Console.WriteLine($"v1+v2={v1 + v2}, v1-v2={v1 - v2}");
            Console.WriteLine($"v1*2={v1 * 2}, 2*v2={2 * v2}");
            Console.WriteLine($"v1*v2={v1 * v2}");
            Console.WriteLine($"v1==v2? {v1 == v2}, v1!=v2? {v1 != v2}");
            Console.WriteLine($"|v1|={(double)v1}, v3={v3}");
            Console.WriteLine($"-v1={-v1}, ++v1={++v1}, --v2={--v2}");
            Console.WriteLine($"v1? {(v1 ? "T" : "F")}, v0? {(new Vес() ? "T" : "F")}");
            v1[0] = 10; v1[1] = 20;
            Console.WriteLine($"v1: {v1}");
        }
    }
}
