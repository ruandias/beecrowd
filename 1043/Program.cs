using System;

namespace _1043
{
    class Program
    {
        static bool EhTriangulo(float a, float b, float c)
        {
            bool condicao1 = (a > Math.Abs(b - c) && a < b + c);
            bool condicao2 = (b > Math.Abs(a - c) && b < a + c);
            bool condicao3 = (c > Math.Abs(a - b) && c < a + b);

            if(condicao1 && condicao2 && condicao3)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            float a = float.Parse(valores[0]);
            float b = float.Parse(valores[1]);
            float c = float.Parse(valores[2]);

            if(EhTriangulo(a, b, c))
            {
                float perimetro = a + b + c;
                Console.WriteLine("Perimetro = {0}", perimetro.ToString("N1"));

            }
            else 
            {
                float area = ((a + b )* c) / 2;
                Console.WriteLine("Area = {0}", area.ToString("N1"));
            }
        }
    }
}
