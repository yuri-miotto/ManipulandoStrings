using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine(nome.Trim('f'));

        void RemoverVogais(string x)
        {
            x = x.Replace('a','\0');
            x = x.Replace('e', '\0');
            x = x.Replace('i', '\0');
            x = x.Replace('o', '\0');
            x = x.Replace('u', '\0');
            Console.WriteLine(x);

        }
        */

        string palavra, resultante;
        int consoante, contador = 0;

        Console.WriteLine("Digite uma palavra: ");
        palavra = Console.ReadLine();

        resultante = InsereCaractere(palavra);

        Console.WriteLine("A palavra digitada contém {0} caracteres", palavra.Length); 

        int Vogais(string palavra)
        {
            
            for (int i = 0; i < palavra.Length; i++)
            {
                
                if ((palavra[i] == 'a') || (palavra[i] == 'e') || (palavra[i] == 'i') || (palavra[i] == 'o') || (palavra[i] == 'u'))
                {
                    contador++;
                }
            }
            return contador;
           
            
           
        }

        int resultado = Vogais(palavra);

        consoante = palavra.Length - resultado;

        Console.WriteLine("A palavra digitada contém {0} vogais", resultado);

        Console.WriteLine("A palavra digitada contém {0} consoantes", consoante);

        Console.WriteLine(palavra.ToLower());

        Console.WriteLine(palavra.ToUpper());



        Console.WriteLine(resultante);

        string InsereCaractere(string palavra)
        {
            char[] aux = new char[palavra.Length*2];

            string alterada = "";
            for (int i = 0, j = 0; i < palavra.Length; i++)
            {
                if ((palavra[i] != 'a') && (palavra[i] != 'e') && (palavra[i] != 'i') && (palavra[i] != 'o') && (palavra[i] != 'u'))
                {
                    aux[j] = '.';
                    aux[j+1] = palavra[i];
                    j+=2;
                }
                else
                {
                    aux[j] = palavra[i];
                    j++;
                }
            }

            for (int i = 0; i < aux.Length; i++)
            {
                alterada += aux[i];
            }

            return alterada;
        }



        Console.ReadLine();
    }
}