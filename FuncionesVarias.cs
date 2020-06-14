using System;
using System.Collections.Generic;
using System.Text;

namespace parcial2
{
    class FuncionesVarias
    {
        private static int opcion;
        
        
        public static int convertirNumero(int desde, int hasta)
        {
            int intentos = 0;
            bool esNumero = false;     
            opcion = 0;
            do
            {
                if (intentos > 0)
                    Console.WriteLine("Opcion no valida introduzcala nuevamente");
                esNumero = int.TryParse(Console.ReadLine(), out opcion);                
                intentos++;
            } while ((opcion < desde || opcion > hasta )|| esNumero == false);
            Console.Clear();
            return opcion;
        }

    }
}
