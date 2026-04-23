namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("A área do círculo é: " + area);
        }
    }
}