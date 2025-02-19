using System;
using System.Collections.Generic;
using System.Numerics;
using System.Globalization;

class Program {
    static void Main(string[] args) {

        int cNumero = 0; 
        int rNumero = 0;
        int sNumero = 0;

        int tamanho = int.Parse(Console.ReadLine() ?? "");
        for(int i = 1; i<=tamanho; i++){
            string entrada = Console.ReadLine(); 

            string[] partes = entrada.Split(' '); 

            int numero = int.Parse(partes[0]); 
            char letra = char.Parse(partes[1]); 

            

            if (letra == 'C') {
                cNumero += numero; 
            }
             if (letra == 'R') {
                rNumero += numero;
            }
             if (letra == 'S') {
                sNumero += numero; 
            }
        }
        float total = cNumero + rNumero + sNumero;
        float resultadoC = (cNumero/total) * 100;
        float resultadoR = (rNumero/total) * 100;
        float resultadoS = (sNumero/total) * 100;
        Console.WriteLine($"Total: {cNumero + rNumero + sNumero} cobaias");
        Console.WriteLine($"Total de coelhos: {cNumero}");
        Console.WriteLine($"Total de ratos: {rNumero}");
        Console.WriteLine($"Total de sapos: {sNumero}");
        Console.WriteLine($"Percentual de coelhos: {resultadoC.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {resultadoR.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {resultadoS.ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}
//30 min