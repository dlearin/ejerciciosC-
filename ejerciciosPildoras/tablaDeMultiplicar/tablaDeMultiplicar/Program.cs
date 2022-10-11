namespace tablaDeMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;

            do
            {

                Console.WriteLine("introduce el número del que deseas calcular su tabla de multiplicar");

                num= Int32.Parse(Console.ReadLine());

            } while (num < 0 || num > 9);

            for (int i=0; i < 10; i++)
            {

                Console.WriteLine($"Multiplicar {num} x {i} es igual a {num*i} ");    

            }


        }

    }
}