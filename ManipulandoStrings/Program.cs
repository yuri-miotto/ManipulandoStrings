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

        string palavra;
        int consoante, contador = 0;

        Console.WriteLine("Digite uma palavra: ");
        palavra = Console.ReadLine();

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

        Vogais(palavra);

        consoante = palavra.Length - contador;

        Console.WriteLine("A palavra digitada contém {0} vogais", contador);

        Console.WriteLine("A palavra digitada contém {0} consoantes", consoante);

        Console.WriteLine(palavra.ToLower());

        Console.WriteLine(palavra.ToUpper());

        Console.ReadLine();
    }
}