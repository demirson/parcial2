﻿using System;
using System.Collections.Generic;
using System.Text;

namespace parcial2
{
    class Menu
    {
        
        private bool salida;        

        public Menu()
        {
            salida = false;     
            Logica.llenarDatos();
        }

        public void iniciar()
        {
            do
            {
                menuPrincipal();
            } while (salida == false);
        }
        public void menuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Introduzca el numero de la opcion que desea realizar:");
            Console.WriteLine("1. Mostrar Libros");  //listo
            Console.WriteLine("2. Buscar Libro");   //listo
            Console.WriteLine("3. Ordenar Libros");  //listo
            Console.WriteLine("4. Agregar Libro");  //listo
            Console.WriteLine("5. Modificar Libro.");  //listo 
            Console.WriteLine("6. Eliminar Libro"); //listo
            Console.WriteLine("7. Bibliotecarios");
            Console.WriteLine("8. Salir");



            switch (FuncionesVarias.introducirDatoParaMenu(1, 8))
            {
                case 1:
                    subMenuMostrarLibros();
                    break;
                case 2:
                    subMenuBuscarLibros();
                    break;
                case 3:
                    subMenuOrdenarLibros();
                    break;
                case 4:
                    Logica.agregarLibro();
                    break;
                case 5:
                    Logica.modificarLibro();
                    break;
                case 6:
                    Logica.eliminarLibro();
                    break;
                case 7:
                    subMenuBibliotecarios();
                    break;
                case 8:
                    salida = true;
                    break;
                default:
                    break;

            }

        }

        public void subMenuMostrarLibros()
        {

            Console.WriteLine("Introduzca el numero de la opcion que desea realizar:");
            Console.WriteLine("1. Mostrar Todos Los Libros.");
            Console.WriteLine("2. Mostrar Libros Por Categoria");
            Console.WriteLine("3. Atras");


            switch (FuncionesVarias.introducirDatoParaMenu(1, 3))
            {
                case 1:
                    Logica.mostrarTodosLibros();                    
                    break;
                case 2:               
                    Logica.mostrarLibrosPorCategoria();
                    break;
                default:
                    Console.Clear();
                    break;
            }

        }

       


        public void subMenuBibliotecarios()
        {

            Console.WriteLine("Introduzca el numero de la opcion que desea realizar:");
            Console.WriteLine("1. Mostrar Bibliotecarios");
            Console.WriteLine("2. Buscar Bibliotecarios");
            Console.WriteLine("3. Agregar Bibliotecarios");
            Console.WriteLine("4. Modificar Bibliotecarios");
            Console.WriteLine("5. Atras");

          

            switch (FuncionesVarias.introducirDatoParaMenu(1, 6))
            {
                case 1:
                    Logica.mostrarBibliotecarios();
                    break;
                case 2:
                    Logica.buscarBibliotecario();
                    break;
                case 3:
                    Logica.agregarBibliotecario();
                    break;
                case 4:
                    Logica.modificarBibliotecario();
                    break;                          
                default:
                    Console.Clear();
                    break;

            }

        }


        public void subMenuBuscarLibros()
        {

            Console.WriteLine("Introduzca el numero de la opcion que desea realizar:");
            Console.WriteLine("1. Buscar Libro Por ID");
            Console.WriteLine("2. Buscar Libro Por Titulo");
            Console.WriteLine("3. Buscar Libros Por Autor");
            Console.WriteLine("4. Buscar Libros Por ID de Bibliotecarios");
            Console.WriteLine("5. Atras");


            switch (FuncionesVarias.introducirDatoParaMenu(1, 5))
            {
                case 1:
                    Logica.buscarLibroPorId();
                    break;
                case 2:
                    Logica.buscarLibroPorTitulo();
                    break;
                case 3:
                    Logica.buscarLibroPorAutor();
                    break;
                case 4:
                    Logica.buscarLibroPorBibliotecarios();
                    break;
                default:
                    Console.Clear();
                    break;

            }


        }

        public void subMenuOrdenarLibros()
        {

            Console.WriteLine("Introduzca el numero de la opcion que desea realizar:");
            Console.WriteLine("1. Ordenar Por Sistemas de Clasificacion Dewey");
            Console.WriteLine("2. Ordenar Por Año de Publicacion");
            Console.WriteLine("3. Atras");

            switch (FuncionesVarias.introducirDatoParaMenu(1, 4))
            {
                case 1:
                    Logica.ordenarSistemaDewey();
                    break;
                case 2:
                    Logica.ordenarAñoPublicacion();
                    break;
                default:
                    Console.Clear();
                    break;

            }
        }
    }
}