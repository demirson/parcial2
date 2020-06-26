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
        static string[,] auxiliarMatrizParaOrden = new string[20, 8];
        static string[,] auxiliarMatrizTemporaria = new string[1, 2];
        static int auxiliar = 0;
        static string auxiliarString = "";
        static bool encontreDato;
        static bool noHayEspacio;

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

            
            bibliotecarios[0, 0] = "1"; //idBibliotecario
            bibliotecarios[0, 1] = "Maria"; //nombre bibliotecario
            bibliotecarios[0, 2] = "Suarez";    //apellido bibliotecario

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

            libros[0, 0] = "1"; //idlibro
            libros[0, 1] = "Harry Potter y la Piedra Filosofal"; //titulo
            libros[0, 2] = "J.K Rowling";   //autor
            libros[0, 3] = "Buenas Noche"; // editorial
            libros[0, 4] = "Literatura";    // categoria
            libros[0, 5] = "1996";  //año de publicacion
            libros[0, 6] = "4"; //bibliotecario

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
                libros[i, 5] = "-1";
                libros[i, 6] = "vacio";

            }
        }

        public static void eliminarLibro()
        {
            auxiliar = FuncionesVarias.validarDatoParaBusquedasNumericas("ID", "libro");
            encontreDato = false;
            for (int i = 0; i < libros.GetLongLength(0); i++)
            {
                if (libros[i, 0] == auxiliar.ToString())
                {
                    libros[i, 0] = "-1";
                    libros[i, 1] = "vacio";
                    libros[i, 2] = "vacio";
                    libros[i, 3] = "vacio";
                    libros[i, 4] = "vacio";
                    libros[i, 5] = "-1";
                    libros[i, 6] = "vacio";
                    encontreDato = true;
                    break;
                }
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el Id " + auxiliar);
            else
                Console.WriteLine("Dato guardado exitosamente");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void modificarLibro()
        {
            auxiliar = FuncionesVarias.validarDatoParaBusquedasNumericas("ID","libro");
            encontreDato = false;
            for (int i = 0; i < libros.GetLongLength(0); i++)
            {
                if (libros[i, 0] == auxiliar.ToString())
                {                    
                    Console.WriteLine("Introduzca el nuevo titulo del libro (50 caracteres maximos): ");
                    libros[i, 1] = FuncionesVarias.validarTamañoEntradaString(50);
                    Console.Clear();
                    Console.WriteLine("Introduzca el nuevo nombre del Autor del libro (40 caracteres maximos): ");
                    libros[i, 2] = FuncionesVarias.validarTamañoEntradaString(40);
                    Console.Clear();
                    Console.WriteLine("Introduzca la nueva editorial del libro (20 caracteres maximos): ");
                    libros[i, 3] = FuncionesVarias.validarTamañoEntradaString(20);
                    Console.Clear();
                    Console.WriteLine("Seleccione la nueva categoria para el libro: ");
                    FuncionesVarias.mostrarCategorias();
                    auxiliar = FuncionesVarias.introducirDatoParaMenu(1, 10);
                    auxiliar = auxiliar - 1;
                    libros[i, 4] = categorias[auxiliar];
                    Console.Clear();
                    Console.WriteLine("Introduzca el nuevo año de publicacion del libro (del año 1 al 9999): ");
                    libros[i, 5] = FuncionesVarias.validarTamañoEntradaInt(9999);
                    Console.Clear();
                    Console.WriteLine("Introduzca el nuevo id del bibliotecario que guardara el libro");
                    auxiliar = 0;
                    FuncionesVarias.mostrarHeaderBibliotecarios();
                    for(int j = 0; j < bibliotecarios.GetLongLength(0); j++)
                    {
                        recorrerListaBibliotecarios(j);
                    }
                    libros[i, 6] = FuncionesVarias.validarTamañoEntradaInt(auxiliar);

                    
                    encontreDato = true;
                    break;
                }
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el Id " + auxiliar);
            else
                Console.WriteLine("Dato modificado exitosamente");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void agregarLibro()
        {
            Console.WriteLine("Todos los datos solicitados son obligatorios!!!:");
            noHayEspacio = true;
            for (int i = 0; i < libros.GetLongLength(0); i++)
            {
                if (libros[i, 0] == "-1")
                {

                    libros[i, 0] = (i + 1).ToString();
                    Console.WriteLine("Introduzca el titulo del libro (50 caracteres maximos): ");
                    libros[i, 1] = FuncionesVarias.validarTamañoEntradaString(50);
                    Console.Clear();
                    Console.WriteLine("Introduzca el Autor del libro (40 caracteres maximos): ");
                    libros[i, 2] = FuncionesVarias.validarTamañoEntradaString(40);
                    Console.Clear();
                    Console.WriteLine("Introduzca la editorial del libro (20 caracteres maximos): ");
                    libros[i, 3] = FuncionesVarias.validarTamañoEntradaString(20);
                    Console.Clear();
                    Console.WriteLine("Seleccione una de las categorias para el libro: ");
                    FuncionesVarias.mostrarCategorias();
                    auxiliar = FuncionesVarias.introducirDatoParaMenu(1, 10);
                    auxiliar = auxiliar - 1;
                    libros[i, 4] = categorias[auxiliar];
                    Console.Clear();
                    Console.WriteLine("Introduzca el año de publicacion del libro (del año 1 al 9999): ");
                    libros[i, 5] = FuncionesVarias.validarTamañoEntradaInt(9999);
                    Console.Clear();
                    Console.WriteLine("Introduzca el id del bibliotecario que guardara el libro");
                    auxiliar = 0;
                    FuncionesVarias.mostrarHeaderBibliotecarios();
                    for(int j = 0; j < bibliotecarios.GetLongLength(0); j++)
                    {
                        recorrerListaBibliotecarios(j);
                    }
                    libros[i, 6] = FuncionesVarias.validarTamañoEntradaInt(auxiliar);
                    noHayEspacio = false;
                    Console.WriteLine("Libro guardado exitosamente");
                    break;

                }
            }
            if (noHayEspacio)
                Console.WriteLine("No se pueden cargar mas libros, la base de datos ha llegado a su limite");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

       
        public static void modificarBibliotecario()
        {
            auxiliar = FuncionesVarias.validarDatoParaBusquedasNumericas("ID", "bibliotecario");
            encontreDato = false;
            for (int i = 0; i < bibliotecarios.GetLongLength(0); i++)
            {
                if (bibliotecarios[i, 0] == auxiliar.ToString())
                {                    
                    Console.WriteLine("Introduzca el nuevo nombre del bibliotecario (20 caracteres maximos): ");
                    bibliotecarios[i, 1] = FuncionesVarias.validarTamañoEntradaString(20);
                    Console.Clear();
                    Console.WriteLine("Introduzca el nuevo apellido del bibliotecario (20 caracteres maximos): ");
                    bibliotecarios[i, 2] = FuncionesVarias.validarTamañoEntradaString(20);
                    Console.Clear();
                    Console.WriteLine("Bibliotecario guardado exitosamente");

                    encontreDato = true;
                    break;
                }
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el Id " + auxiliar);
            else
                Console.WriteLine("Dato modificado exitosamente");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void buscarLibroPorId()
        {
            auxiliar = FuncionesVarias.validarDatoParaBusquedasNumericas("ID", "libro");
            FuncionesVarias.mostrarHeaderLibros();
            encontreDato = false;
            for (int i = 0; i< libros.GetLongLength(0); i++)
            {
                if (libros[i, 0] == auxiliar.ToString())
                {
                    recorrerListaLibros(i);
                    encontreDato = true;
                }
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el Id " + auxiliar);

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void buscarLibroPorTitulo()
        {
            Console.WriteLine("Introduzca el titulo del libro o palabra clave por el que desee buscar");
            auxiliarString = FuncionesVarias.validarTamañoEntradaString(40);
            FuncionesVarias.mostrarHeaderLibros();
            encontreDato = false;
            for (int i = 0; i < libros.GetLongLength(0); i++)
            {
                if (libros[i, 0] == "-1")
                    continue;
                else if (libros[i, 1].ToLower().Contains(auxiliarString.ToLower()))
                {
                    recorrerListaLibros(i);
                    encontreDato = true;
                }
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el Titulo " + auxiliarString);

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void buscarLibroPorBibliotecarios()
        { 

            auxiliar = FuncionesVarias.validarDatoParaBusquedasNumericas("ID","bibliotecario");
            FuncionesVarias.mostrarHeaderLibros();
            encontreDato = false;
            for (int i = 0; i < libros.GetLongLength(0); i++)
            {
                if (libros[i, 6] == auxiliar.ToString())
                {
                    recorrerListaLibros(i);
                    encontreDato = true;
                }
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el bibliotecario del ID" + auxiliarString);

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void buscarLibroPorAutor()
        {
            Console.WriteLine("Introduzca el nombre del autor del libro o palabra clave por el que desee buscar");
            auxiliarString = Console.ReadLine();
            FuncionesVarias.mostrarHeaderLibros();
            encontreDato = false;
            for (int i = 0; i < libros.GetLongLength(0); i++)
            {
                if (libros[i, 2].ToLower().Contains(auxiliarString.ToLower()))
                {
                    recorrerListaLibros(i);
                    encontreDato = true;
                }
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el Autor " + auxiliarString);

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void agregarBibliotecario()
        {
            Console.WriteLine("Todos los datos solicitados son obligatorios!!!:");
            noHayEspacio = true;
            for (int i = 0; i < bibliotecarios.GetLongLength(0); i++)
            {
                if (bibliotecarios[i, 0] == "-1")
                {
                    bibliotecarios[i, 0] = (i + 1).ToString();
                    Console.WriteLine("Introduzca el nombre del bibliotecario (20 caracteres maximos): ");
                    bibliotecarios[i, 1] = FuncionesVarias.validarTamañoEntradaString(20);
                    Console.Clear();
                    Console.WriteLine("Introduzca el apellido del bibliotecario (20 caracteres maximos): ");
                    bibliotecarios[i, 2] = FuncionesVarias.validarTamañoEntradaString(20);
                    Console.Clear();
                    Console.WriteLine("Bibliotecario guardado exitosamente");
                    noHayEspacio = false;
                    break;

                }
            }
            if (noHayEspacio)
                Console.WriteLine("No se pueden cargar mas bibliotecarios, la base de datos ha llegado a su limite");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void buscarBibliotecario()
        {
            auxiliar = FuncionesVarias.validarDatoParaBusquedasNumericas("ID", "libro");
            FuncionesVarias.mostrarHeaderBibliotecarios();
            encontreDato = false;
            for (int j = 0; j < bibliotecarios.GetLongLength(0); j++)
            {
                if(bibliotecarios[j,0] == auxiliar.ToString())
                    recorrerListaBibliotecarios(j);
                encontreDato = true;
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por el id " + auxiliar);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void mostrarBibliotecarios()
        {
            FuncionesVarias.mostrarHeaderBibliotecarios();
            for (int j = 0; j < bibliotecarios.GetLongLength(0); j++)
            {
                recorrerListaBibliotecarios(j);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void mostrarLibrosPorCategoria()
        {
            Console.WriteLine("Introduzca el numero de la categoria");
            FuncionesVarias.mostrarCategorias();
            auxiliar = FuncionesVarias.introducirDatoParaMenu(1, 10);
            auxiliar = auxiliar - 1;
            FuncionesVarias.mostrarHeaderLibros();
            encontreDato = false;
            for (int i = 0; i < libros.GetLongLength(0); i++)
            {
                if (libros[i, 0] == "-1" || libros[i, 4] != categorias[auxiliar])
                    continue;
                recorrerListaLibros(i);
                encontreDato = true;
            }
            if (!encontreDato)
                Console.WriteLine("No se encontraron datos por la categoria " + categorias[auxiliar]);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void mostrarTodosLibros()
        {
            Console.Clear();
            FuncionesVarias.mostrarHeaderLibros();
            for(int i = 0; i<libros.GetLongLength(0); i++)
            {
                if (libros[i, 0] == "-1")
                    continue;
                recorrerListaLibros(i);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void ordenarAñoPublicacion()
        {
            auxiliarMatrizParaOrden = libros.Clone() as string[,];
            //auxiliarMatrizParaOrden = libros;
            FuncionesVarias.mostrarHeaderLibros();
            for (int i = 0; i <= libros.GetLongLength(0) -2; i++)
            {
                for (int j = 0; j <= libros.GetLongLength(0) - 2; j++)
                {
                    if (auxiliarMatrizParaOrden[j, 0] == "-1" || auxiliarMatrizParaOrden[j + 1, 0] == "-1") { 
                        continue;
                    } else if (int.Parse(auxiliarMatrizParaOrden[j, 5]) > int.Parse(auxiliarMatrizParaOrden[j + 1, 5]))
                    {
                        auxiliarMatrizTemporaria[0, 0] = auxiliarMatrizParaOrden[j + 1, 0];
                        auxiliarMatrizTemporaria[0, 1] = auxiliarMatrizParaOrden[j + 1, 5];
                        auxiliarMatrizParaOrden[j + 1, 0] = auxiliarMatrizParaOrden[j, 0];
                        auxiliarMatrizParaOrden[j + 1, 5] = auxiliarMatrizParaOrden[j, 5];
                        auxiliarMatrizParaOrden[j, 0] = auxiliarMatrizTemporaria[0, 0];
                        auxiliarMatrizParaOrden[j, 5] = auxiliarMatrizTemporaria[0, 1];
                    }
                        
                }
                
            }
            for(int i = 0; i < auxiliarMatrizParaOrden.GetLongLength(0); i++)
            {
                for (int j = 0; j < auxiliarMatrizParaOrden.GetLongLength(0); j++)
                {
                    if (auxiliarMatrizParaOrden[i, 0] == "-1")
                        continue;
                    if(libros[j,0] == auxiliarMatrizParaOrden[i, 0])
                        recorrerListaLibros(j);
                }
                
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        
        public static void ordenarSistemaDewey()
        {

            FuncionesVarias.mostrarHeaderLibros();
            for (int k = 0; k < categorias.Length; k++)
            {
                for (int j = 0; j < libros.GetLongLength(0); j++)
                {
                    if (categorias[k] == libros[j, 4])
                        recorrerListaLibros(j);
                }
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        public static void recorrerListaLibros(int i)
        {
            Console.Write(FuncionesVarias.obtenerTamañoPedido(libros[i, 0], 2));
            Console.Write(FuncionesVarias.obtenerTamañoPedido(libros[i, 1], 40));
            Console.Write(FuncionesVarias.obtenerTamañoPedido(libros[i, 2], 30));
            Console.Write(FuncionesVarias.obtenerTamañoPedido(libros[i, 3], 15));
            Console.Write(FuncionesVarias.obtenerTamañoPedido(libros[i, 4], 30));
            Console.Write(FuncionesVarias.obtenerTamañoPedido(libros[i, 5], 4));
            Console.WriteLine(FuncionesVarias.obtenerTamañoPedido(bibliotecarios[int.Parse(libros[i,6]) - 1, 1] +" "+ bibliotecarios[int.Parse(libros[i, 6]) - 1, 2], 20));
        }

        public static void recorrerListaBibliotecarios(int i)
        {
           
            if (bibliotecarios[i, 0] != "-1") {
                Console.Write(FuncionesVarias.obtenerTamañoPedido(bibliotecarios[i, 0], 2));
                Console.Write(FuncionesVarias.obtenerTamañoPedido(bibliotecarios[i, 1], 20));
                Console.WriteLine(FuncionesVarias.obtenerTamañoPedido(bibliotecarios[i, 2], 20));
                auxiliar++;
            }
                     
        }
    }
}
