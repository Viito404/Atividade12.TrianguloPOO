using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12.TrianguloPOO
{
     internal class Triangulo
     {
          public decimal x, y, z;

          public decimal PegarValor(string mensagem)
          {
               Console.Write(mensagem);
               decimal valor = Convert.ToDecimal(Console.ReadLine());
               return valor;
          }
          public void GerarTriangulo()
          {
               if ((x + y < z) || (x + z < y) || (y + z < x))
               {
                    Console.WriteLine("\nTriângulo não pode ser criado!");
                    Console.ReadLine();
               }
               else if ((x == y) && (y == z))
               {
                    Console.WriteLine("\nTriângulo equilátero criado!");
                    Console.ReadLine();
               }
               else if ((x == z) || (z == y) || (x == y))
               {
                    Console.WriteLine("\nTriângulo isósceles criado!");
                    Console.ReadLine();
               }
               else
               {
                    Console.WriteLine("\nTriângulo escaleno criado!");
                    Console.ReadLine();
               }                          
          }
     }
}
