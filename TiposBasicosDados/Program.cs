using System;

namespace TiposBasicosDados
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 255; //OuverFlow quando um Calculo estrapola o limite da sua variavel.nO CASO É ATÉ 256
            n1++;
            

            Console.WriteLine(n1);
        }
    }
}
