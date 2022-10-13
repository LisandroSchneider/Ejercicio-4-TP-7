using System;

namespace Ejercicio_4_tp7
{
    class Program
    {
        static void Main(string[] args)
        {   float n1,n2,resultado;
            int eleccion1 = 1 ,eleccion2;

            Console.Clear();
                
            do{
                Console.WriteLine("¿Desea realizar una convercion?");
                Console.WriteLine("Presione 1 para SI");  
                Console.WriteLine("Presiones 2 para NO"); 
                eleccion1 = Convert.ToInt32(Console.ReadLine());
                
                if(eleccion1 != 1){
                    Console.WriteLine("Por favor reiniciar el programa ");
                    break;
                    
                }

                Console.WriteLine("¿Que conversión desea realizar?");
                Console.WriteLine("Presione 1 de Dolar a Peso");  
                Console.WriteLine("Presiones 2 de Euro a Peso");          
                eleccion2= Convert.ToInt32(Console.ReadLine());

                switch(eleccion2){
                case 1:
                Console.Clear();
                
                Console.WriteLine("Digite la cantidad de Dolares que desea convertir:");
                n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite el valor actual del peso");
                n2 = float.Parse(Console.ReadLine());

                resultado = Conversor(n1,n2);

                Console.WriteLine("El total en Pesos es de :${0}",resultado);
                break;

                case 2:
                Console.Clear();
                
                Console.WriteLine("Digite la cantidad de Euros que desea convertir:");
                n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite el valor actual del peso");
                n2 = float.Parse(Console.ReadLine());

                resultado = Conversor(n1,n2);

                Console.WriteLine("El total en Pesos es de :${0}",resultado);
                break;
                
                default:
                Console.Clear();
                Console.WriteLine("Reiniciar el programa");
                break;

                }
            }while(eleccion1 == 1);
        }

        static float Conversor(float n1,float n2){
            return n1*n2;
        }

    }
}
