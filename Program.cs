using System;

class Program
{
    public static void Main()
    {
        int x;

        Console.Write("Digite o tamanho do vetor: ");
        x = int.Parse(Console.ReadLine());

        int[] giga;
        giga = new int[x];

        for (int i = 0; i < x; i++)
        {
            Console.Write("Digite o valor " + i + " do array: ");
            giga[i] = int.Parse(Console.ReadLine());
        }

        QuickSort(giga, 0, x - 1);

        Console.Write("Vetor ordenado: ");

        printvetor(giga, x);
    }
    static void QuickSort(int[] vetor, int menor, int maior)
    {
        if (menor < maior)
        {
            int pi = particao(vetor, menor, maior);

            QuickSort(vetor, menor, pi - 1);
            QuickSort(vetor, pi + 1, maior);
        }
    }

    static int particao(int[] vetor, int menor, int maior)
    {
        int pivo = vetor[maior];

        int index = (menor - 1);

        for (int j = menor; j <= maior - 1; j++)
        {
            if (vetor[j] < pivo)
            {
                index++;
                troca(vetor, index, j);
            }
        }
        troca(vetor, index + 1, maior);
        return (index + 1);
    }


    static void troca(int[] vetor, int i, int j)
    {
        int temp = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = temp;
    }
    static void printvetor(int[] vetor, int size)
    {
        for (int i = 0; i < size; i++)
            Console.Write(vetor[i] + " ");

        Console.WriteLine();
    }


}


