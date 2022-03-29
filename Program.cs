using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matriz = new char[9, 9];
            int begin = -1;
            int end = 9;

            /* Set the values in the matrix */
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(i == 0)
                    {
                        matriz[i, j] = char.Parse(j.ToString());
                    }
                    else
                    {
                        if(j > begin && j < end)
                        {
                            matriz[i, j] = char.Parse(j.ToString());
                        }
                        else
                        {
                            matriz[i, j] = ' ';
                        }
                    }
                }

                begin++;
                end--;
            }

            /* Print the values on console */
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.Write("\n");
            }
        }
    }
}
