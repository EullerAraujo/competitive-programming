using System;
using System.Collections.Generic;
using System.Numerics;
using System.Globalization;
using System.Linq;


class Program {
    static void Main(string[] args) {

        int tamanho = int.Parse(Console.ReadLine() ?? "");

        Queue<int> par = new Queue<int>();
        Queue<int> impar = new Queue<int>();
        

            for(int i = 1; i<=tamanho; i++){
                
                int numero = int.Parse(Console.ReadLine() ?? "");
                if (numero % 2 == 0) {
                par.Enqueue(numero);
            }
                else {
                impar.Enqueue(numero);
            }

        }
            Queue<int> filaOrdenadaPar = new Queue<int>(par.OrderBy(x => x));
            Queue<int> filaOrdenadaImpar = new Queue<int>(impar.OrderByDescending(x => x));

        foreach(int x in filaOrdenadaPar){
            Console.WriteLine(x);
        }
        foreach(int x in filaOrdenadaImpar){
            Console.WriteLine(x);
        }
    }
}
//25 min
