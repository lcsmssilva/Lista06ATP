using System;
namespace Lista06ATP
{
    public static class Ex01
    {
        public static void Executar()
        {
            char space = ' ';
            int contagem = 0;

            Console.WriteLine("Escreva uma frase aleatória: ");
            string frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (space == frase[i])
                {
                    contagem++;
                }
            }
            Console.WriteLine("Na frase temos " + contagem + " espaços");
        }
    }
}