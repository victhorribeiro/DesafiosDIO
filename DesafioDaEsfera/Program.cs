using System;

class DIO
{

    static void Main(string[] args)
    {

        double pi = 3.14159;

        double raio = double.Parse(Console.ReadLine());
        double volume = ((4.0 / 3) * pi * Math.Pow(raio, 3));

        Console.WriteLine("VOLUME = {0:0.000}", volume);
    }
}
//public class DIO
//{
//    static void Main(string[] args)
//    {
//        double pi = 3.14159;

//        int numeroTentativas = 0;

//        while(numeroTentativas < 3)
//        {
//            double raio = double.Parse(Console.ReadLine());
//            double volumeEsfera = ((4 / 3) * pi * Math.Pow(raio, 3));

//            Console.WriteLine($"VOLUME = {volumeEsfera}");
//            numeroTentativas++;
//        }
//    }
//}