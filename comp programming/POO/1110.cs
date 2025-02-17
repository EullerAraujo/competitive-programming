using System;
using System.Collections.Generic;
class Program {
    static void Main(string[] args) {


        while(true){
            Stack<int> minhaPilha = new Stack<int>();
            Stack<int> lixo = new Stack<int>();
            int numero = int.Parse(Console.ReadLine() ?? "");
            if (numero == 0) {
                break;
            }

            for(int i = numero; i >= 1; i--) {
                minhaPilha.Push(i);
            }
             
                                            
            while (minhaPilha.Count >= 2){
                
                lixo.Push(minhaPilha.Pop());  
            
                int topo = minhaPilha.Pop();   

                Stack<int> aux = new Stack<int>();

                while (minhaPilha.Count > 0) {
                    aux.Push(minhaPilha.Pop());
                }

                minhaPilha.Push(topo);    

                while (aux.Count > 0){
                    minhaPilha.Push(aux.Pop()); 
                }
                    if (minhaPilha.Count == 1){
                    Console.Write("Discarded cards: ");
                     Stack<int> lixoInvertido = new Stack<int>();
                    while (lixo.Count > 0) {
                        lixoInvertido.Push(lixo.Pop());
                    }

                    Console.WriteLine(string.Join(", ", lixoInvertido));
                    foreach(int item in minhaPilha){
                        Console.WriteLine("Remaining card: "+item);
                    }
                }
            }
        }
    }
}
//4 horas