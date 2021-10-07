using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Criando a variavel
            int n = int.Parse(Console.ReadLine());

            //Criando a matriz com os valores de coluna e linha = n
            int[,] mat = new int[n, n];

            //Criando a repetição para adicionar os valores da matriz, colocando como parametro os valores de linhas menores que a variavel N
            for (int i = 0; i < n; i++)
            {
                //Lendo cada número da matriz
                string[] values = Console.ReadLine().Split(' ');

                //Criando a repetição para adicionar os valores da matriz, colocando como parametro os valores de colunas menores que a variavel N
                for (int j = 0; j < n; j++)
                {
                    //Lendo os valores para cada posição da matriz
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Imprimindo a informação da diagonal principal
            Console.WriteLine("Main diagonal: ");

            //Criando a repetição para pegar os valores da matriz principal
            for (int i = 0; i < n; i++)
            {
                //Imprimindo os valores que tem a coluna e a linha como valores iguais
                Console.Write(mat[i, i] + "");
            }
            //Imprimindo uma linha em branco
            Console.WriteLine();

            //Criando variavel para contar os números negativos
            int count = 0;

            //Criando a repetição com o número de linhas menor q a variável N
            for (int i = 0; i < n; i++)
            {
                //Criando a repetição com o número de colunas menor q a variável N
                for (int j = 0; j < n; j++)
                {
                    //Comparando se o valor da posição da linha e da coluna é menor que zero
                    if(mat[i,j] < 0)
                    {
                        //Somando a variavel count + 1
                        count++;
                    }
                }
            }
            //Imprimindo quantos números negativos têm na matriz
            Console.WriteLine("Negative number: " + count);

            //--------------------------------------------------------------------

            
        }
    }
}
