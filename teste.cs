using System;

class Teste
{
    static void Main()
    {
        int[] a = new int[10];
        int i, nova;

        for (i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Você deseja adicionar algo a matriz {0}? [Numero/0]", i);
            nova = Convert.ToInt32(Console.ReadLine());
            if (nova == 0)
            {
                Console.WriteLine("Nada foi adicionado a Array {0} posição {1}", a, i);
            }
            else
            {
                a[i] = nova;
                Console.WriteLine("O valor {0} foi adicionada a Array {1}, posição {2}", nova, a, i);
            }
        }

        for (i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}