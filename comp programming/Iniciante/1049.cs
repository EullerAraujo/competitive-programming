using System;
using System.Collections.Generic;
class _1049
{
    static void Main(string[] args)
    {
        string palavra1 = Console.ReadLine();
        string palavra2 = Console.ReadLine();
        string palavra3 = Console.ReadLine();
       

        if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "carnivoro")
        {
            Console.WriteLine("aguia");
        }
        if (palavra1 == "vertebrado" && palavra2 == "ave" && palavra3 == "onivoro")
        {
            Console.WriteLine("pomba");
        }
        if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "onivoro")
        {
            Console.WriteLine("homem");
        }
        if (palavra1 == "vertebrado" && palavra2 == "mamifero" && palavra3 == "herbivoro")
        {
            Console.WriteLine("vaca");
        }

        if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "hematofago")
        {
            Console.WriteLine("pulga");
        }
        if (palavra1 == "invertebrado" && palavra2 == "inseto" && palavra3 == "herbivoro")
        {
            Console.WriteLine("largata");
        }
        if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "hematofago")
        {
            Console.WriteLine("sanguessuga");
        }
        if (palavra1 == "invertebrado" && palavra2 == "anelideo" && palavra3 == "onivoro")
        {
            Console.WriteLine("minhoca");
        }
    }
}

//Essa é a forma burra de fazer. Recomendo usar dicionario.