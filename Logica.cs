using System;
using System.Collections.Generic;
using System.Text;

namespace parcial2
{
    class Logica
    {
        static string[,] libros = new string[20, 8];
        static string[] categorias = new string[10];
        static string[,] bibliotecarios = new string[8, 3];
        

        public static void llenarDatos()
        {

            categorias[0] = "Generalidades";
            categorias[1] = "Filosofia y Psicologia";
            categorias[2] = "Religion";
            categorias[3] = "Ciencias Sociales";
            categorias[4] = "Lenguas";
            categorias[5] = "Matematicas y Ciencias Naturales";
            categorias[6] = "Tecnologia Y ciencias Aplicadas";
            categorias[7] = "Artes";
            categorias[8] = "Literatura";
            categorias[9] = "Historia Y Geografia";

            
            bibliotecarios[0, 0] = "1";
            bibliotecarios[0, 1] = "Maria";
            bibliotecarios[0, 2] = "Suarez";

            bibliotecarios[1, 0] = "2";
            bibliotecarios[1, 1] = "Maya";
            bibliotecarios[1, 2] = "Perez";
            
            bibliotecarios[2, 0] = "3";
            bibliotecarios[2, 1] = "Juan";
            bibliotecarios[2, 2] = "Mendoza";
            
            bibliotecarios[3, 0] = "4";
            bibliotecarios[3, 1] = "Carlos";
            bibliotecarios[3, 2] = "Jarapo";
            
            bibliotecarios[4, 0] = "5";
            bibliotecarios[4, 1] = "Gabriel";
            bibliotecarios[4, 2] = "Moroso";

            for (int i = 5; i < 8; i++)
            {
                bibliotecarios[i, 0] = "-1";
                bibliotecarios[i, 1] = "vacio";
                bibliotecarios[i, 2] = "vacio";             
            }

            libros[0, 0] = "1";
            libros[0, 1] = "Harry Potter y la Piedra Filosofal";
            libros[0, 2] = "J.K Rowling";
            libros[0, 3] = "Buenas Noche";
            libros[0, 4] = "Literatura";
            libros[0, 5] = "1996";
            libros[0, 6] = "4";

            libros[1, 0] = "2";
            libros[1, 1] = "Hiperespacio";
            libros[1, 2] = "Michio Kaku";
            libros[1, 3] = "booket";
            libros[1, 4] = "Matematicas y Ciencias Naturales";
            libros[1, 5] = "2018";
            libros[1, 6] = "2";

            libros[2, 0] = "3";
            libros[2, 1] = "Frankenstein";
            libros[2, 2] = "Mary Shelley";
            libros[2, 3] = "Centro Editor de Cultura";
            libros[2, 4] = "Literatura";
            libros[2, 5] = "2008";
            libros[2, 6] = "1";

            libros[3, 0] = "4";
            libros[3, 1] = "Battle Royale";
            libros[3, 2] = "Koushun Takami";
            libros[3, 3] = "booket";
            libros[3, 4] = "Literatura";
            libros[3, 5] = "2013";
            libros[3, 6] = "5";

            libros[4, 0] = "5";
            libros[4, 1] = "El Psicoanalista";
            libros[4, 2] = "John Katzenbach";
            libros[4, 3] = "Penguin Random House";
            libros[4, 4] = "Literatura";
            libros[4, 5] = "2017";
            libros[4, 6] = "4";

            libros[5, 0] = "6";
            libros[5, 1] = "Calculo de una Variable";
            libros[5, 2] = "James Stewart";
            libros[5, 3] = "Cengage";
            libros[5, 4] = "Matematicas y Ciencias Naturales";
            libros[5, 5] = "2017";
            libros[5, 6] = "1";

            libros[6, 0] = "7";
            libros[6, 1] = "Calculo Estructural";
            libros[6, 2] = "Roger A. Freedman";
            libros[6, 3] = "Pearson";
            libros[6, 4] = "Tecnologia Y ciencias Aplicadas";
            libros[6, 5] = "2016";
            libros[6, 6] = "3";


            for (int i = 7; i < 20; i++)
            {
                libros[i, 0] = "-1";
                libros[i, 1] = "vacio";
                libros[i, 2] = "vacio";
                libros[i, 3] = "vacio";
                libros[i, 4] = "vacio";
                libros[i, 5] = "vacio";

            }
        }

        public static void eliminarLibro()
        {
            throw new NotImplementedException();
        }

        public static void modificarLibro()
        {
            throw new NotImplementedException();
        }

        public static void agregarLibro()
        {
            throw new NotImplementedException();
        }

        public static void eliminarBibliotecario()
        {
            throw new NotImplementedException();
        }

        public static void modificarBibliotecario()
        {
            throw new NotImplementedException();
        }

        public static void buscarLibroPorId()
        {
            throw new NotImplementedException();
        }

        public static void buscarLibroPorTitulo()
        {
            throw new NotImplementedException();
        }

        public static void buscarLibroPorBibliotecarios()
        {
            throw new NotImplementedException();
        }

        public static void buscarLibroPorAutor()
        {
            throw new NotImplementedException();
        }

        public static void agregarBibliotecario()
        {
            throw new NotImplementedException();
        }

        public static void buscarBibliotecario()
        {
            throw new NotImplementedException();
        }

        public static void mostrarBibliotecarios()
        {
            throw new NotImplementedException();
        }

        public static void mostrarLibrosPorCategoria()
        {
            throw new NotImplementedException();
        }

        public static void mostrarTodosLibros()
        {
            for(int i = 0; i<libros.Length; i++)
            {

            }
        }

        public static void ordenarAñoPublicacion()
        {
            throw new NotImplementedException();
        }

        public static void ordenarAlfabeticamente()
        {
            throw new NotImplementedException();
        }

        public static void ordenarSistemaDewey()
        {
            throw new NotImplementedException();
        }
    }


}
