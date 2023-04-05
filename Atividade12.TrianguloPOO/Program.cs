namespace Atividade12.TrianguloPOO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               do
               {
                    Triangulo triangulo = new Triangulo();
                    Console.Clear();
                    triangulo.x = triangulo.PegarValor("Entre com o comprimento de X:\n> ");
                    triangulo.y = triangulo.PegarValor("\nEntre com o comprimento de Y:\n> ");
                    triangulo.z = triangulo.PegarValor("\nEntre com o comprimento de Z:\n> ");
                    triangulo.GerarTriangulo();

               } while(true);
          }
     }
}