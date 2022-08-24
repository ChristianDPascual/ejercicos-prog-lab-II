using System;

namespace ejerciciosprog201
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2;
            string palabra = "6";
            string palabra2 = "amarillo y rojo";
            string respuesta;
            double doble = 16;

            num2 = (int)doble;         //}caso de casteo explicitos
            num1 = int.Parse(palabra); //}

            Console.WriteLine("numero1: {0} numero2: {1}",num1,num2);
            
            Console.WriteLine("Ingrese un numero");//mostar un msj
            respuesta = Console.ReadLine();        //levanto un dato
            Console.WriteLine("el numero ingresado es: {0}", respuesta);//muestro el dato


            foreach (char item in palabra2)//sirve pra recorrer un array o string 
            {                              //se puede poner condiciones adentros por ejemplo
                                           //que reemplaze la letra A

                if (item == 'a') 
                {
                    Console.WriteLine('*');
                }
                else 
                {
                    Console.WriteLine(item);
                }
         
            }

            int[] arrayNumeros = new int[5];//Forma de declarar un vector

            for (int i = 100; i < 105; i++) 
            {
                arrayNumeros[i - 100] = i;
            }

            foreach (int listado in arrayNumeros) 
            {
                Console.WriteLine(listado);
            }
        }
    }
}
