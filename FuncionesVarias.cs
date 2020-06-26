using System;
using System.Collections.Generic;
using System.Text;

namespace parcial2
{
    class FuncionesVarias
    {
        private static int opcion;
        private static bool auxiliarBool;
        
        public static int introducirDatoParaMenu(int desde, int hasta)
        {
            auxiliarBool = false;
            do
            {
                if(auxiliarBool)
                    Console.WriteLine("Opcion no valida introduzcala nuevamente");
                validarNumero();
                auxiliarBool = true;
            } while (opcion < desde || opcion > hasta );
            Console.Clear();
            return opcion;
        }

        public static int validarNumero()
        {
            auxiliarBool = false;
            bool esNumero;
            opcion = 0;
            do
            {
                if (auxiliarBool)
                    Console.WriteLine("Opcion no valida introduzcala nuevamente");

                
                esNumero = int.TryParse(Console.ReadLine(), out opcion);
                auxiliarBool = true;
            } while (esNumero == false);
            return opcion;
        }

        public static int validarDatoParaBusquedasNumericas(string nombre, string tipo)
        {
            Console.WriteLine("Introduzca el " + nombre +" del "+ tipo +" por favor");
            validarNumero();
            return opcion;           
        }


        public static void mostrarHeaderLibros()
        {
            Console.Write("ID");
            Console.Write(" | ");
            Console.Write("Titulo                                  ");
            Console.Write(" | ");
            Console.Write("Autor                         ");
            Console.Write(" | ");
            Console.Write("Editorial      ");
            Console.Write(" | ");
            Console.Write("Categoria                     ");
            Console.Write(" | ");
            Console.Write("Año ");
            Console.Write(" | ");
            Console.Write("Bibliotecario       ");
            Console.WriteLine(" | ");

        }

        public static void mostrarHeaderBibliotecarios()
        {
            Console.Write("ID");
            Console.Write(" | ");
            Console.Write("Nombre              ");
            Console.Write(" | ");
            Console.Write("Apellido            ");         
            Console.WriteLine(" | ");

        }

        public static void mostrarCategorias()
        {
            Console.WriteLine("1. Generalidades");
            Console.WriteLine("2. Filosofia y Psicologia");
            Console.WriteLine("3. Religion");
            Console.WriteLine("4. Ciencias Sociales");
            Console.WriteLine("5. Lenguas");
            Console.WriteLine("6. Matematicas y Ciencias Naturales");
            Console.WriteLine("7. Tecnologia Y ciencias Aplicadas");
            Console.WriteLine("8. Artes");
            Console.WriteLine("9. Literatura");
            Console.WriteLine("10. Historia Y Geografia");
        }

        public static String obtenerTamañoPedido(String campo, int tamaño)
        {
            
            for(int i = 0; i < tamaño; i++)
            {
                if (campo.Length != tamaño)
                    campo = campo + " ";
                
            }
            if (campo.Length > tamaño)
                campo = campo.Substring(0, tamaño);

                campo = campo + " | ";

            return campo;
        }

        public static String validarTamañoEntradaString(int tamaño)
        {
            auxiliarBool = false;
            string texto = "";
            do
            {
                if (auxiliarBool)
                    Console.WriteLine("El numero de carecteres tiene que ser menor a {0} y mayor a 1",tamaño);
                texto = Console.ReadLine();
                auxiliarBool = true;
            } while (texto.Length > tamaño || texto.Trim().Length < 1);

            return texto;
        }

        public static string validarTamañoEntradaInt(int tamaño)
        {
            auxiliarBool = false;
            int texto;
            do
            {
                if (auxiliarBool)
                    Console.WriteLine("El numero es mayor que el permitido , tiene que ser menor a {0} y mayor a 1",tamaño);
                texto = validarNumero();
                auxiliarBool = true;
            } while (texto > tamaño || texto < 1);

            return texto.ToString();
        }
    }
    
}

