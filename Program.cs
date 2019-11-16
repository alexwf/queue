using System;
using System.Collections;

namespace fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
             
            //Inserindo três elementos
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            
            Console.WriteLine("Listando elementos da fila:");
            
            //Enquanto houver elementos na lista, exibir e remover o primeiro
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            
            //Exibe a quantidade de elementos restantes, ou seja, zero
            Console.WriteLine("A lista agora possui " + q.Count.ToString() + " elementos.");
            Console.Read();
        }
    }
}
