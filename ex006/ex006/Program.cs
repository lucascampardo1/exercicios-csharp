namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double areaTriangulo = (a * c) / 2.0;
            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"));

            double areaCirculo = 3.14159 * Math.Pow(c, 2);
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));

            double areaTrapezio = ((a + b) * c) / 2.0;
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));

            double areaQuadrado = Math.Pow(b, 2);
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));

            double areaRetangulo = a * b;
            Console.WriteLine("RETÂNGULO: " + areaRetangulo.ToString("F3"));
        }
    }
}