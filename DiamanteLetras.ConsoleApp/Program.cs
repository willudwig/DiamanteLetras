using System;

namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int meio = 0;
            int numLetra = 0;
            int contAlfabeto = 1;

            //Input da letra
            Console.Write("Digiete a letra: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("\n");
            
            //encontrar o índice do meio da letra
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == letra)
                {
                    numLetra = i + 1;
                }
            }
            int distancia = (numLetra - 1) + numLetra;
            meio = distancia / 2;

            char[] vazio = new char[distancia];

            //preenchendo o array vazio com espaços.
            for (int i = 0; i < vazio.Length; i++)
            {
                vazio[i] = ' ';
            }

            //imprimindo a linha 1
            for (int i = 0; i < vazio.Length; i++)
            {
                if (i == meio)
                {
                    vazio[i] = alfabeto[0];
                    Console.Write(vazio[i]);
                   
                }
                else
                    Console.Write(vazio[i]);
            }

            vazio[meio] = ' ';
            Console.WriteLine("\n");

            //encaixando as letras de forma crescente
            for (int k = 1; k < numLetra; k++)
            {
                for (int i = k; i < vazio.Length; i++)
                {
                    if (i == meio)
                    {
                        vazio[i - k] = alfabeto[contAlfabeto];
                        vazio[i + k] = alfabeto[contAlfabeto];

                        //apresentando
                        for (int j = 0; j < vazio.Length; j++)
                        {
                            Console.Write(vazio[j]);
                        }

                        vazio[meio + k] = ' ';
                        vazio[meio - k] = ' ';

                        Console.WriteLine("\n");
                        contAlfabeto++;
                    }
                }
            }

            //preenchendo o array vazio com espaços.
            for (int i = 0; i < vazio.Length; i++)
            {
                vazio[i] = ' ';
            }

            int c = 1;
            contAlfabeto -= 2;
            //encaixando as letras de forma decrescente
            for (int k = 1; k < numLetra; k++)
            {
                for (int i = (vazio.Length - 1); i > 1; i--)
                {
                    if (vazio[meio - 1 ] == ' ')
                    {
                        vazio[i - 1] = alfabeto[contAlfabeto];
                        vazio[distancia - i] = alfabeto[contAlfabeto];

                        //apresentando
                        for (int j = 0; j < vazio.Length; j++)
                        {
                            Console.Write(vazio[j]);
                        }

                        vazio[i - k] = ' ';
                        vazio[c] = ' ';
                        c++;
                        Console.WriteLine("\n");
                        contAlfabeto--;
                        if (contAlfabeto == -1) break;
                    }
                    if (contAlfabeto == -1) break;
                }
                if (contAlfabeto == -1) break;
            }

            //preenchendo o array vazio com espaços.
            for (int i = 0; i < vazio.Length; i++)
            {
                vazio[i] = ' ';
            }

            Console.ReadKey();  
        }
    }
}