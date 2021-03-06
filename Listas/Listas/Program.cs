﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        public static void ImprimirLista(ArrayList Lista)
        {
            for (int i = 0; i < Lista.Count; i++) //Recorrer el Array para imprimir
            {
                Console.WriteLine(Lista[i]);
            }
        }

        public static void TeoriaClase01()
        {
            ArrayList Lista = new ArrayList();

            Console.WriteLine("El número de elementos es " + Lista.Count);
            Lista.Add(2); //Metemos elementos en la lista
            Console.WriteLine("El número de elementos es " + Lista.Count);
            Lista.Add(7); //Metemos elementos en la lista
            Lista.Add(2); //Metemos elementos en la lista
            Console.WriteLine("El número de elementos es " + Lista.Count);
            Console.WriteLine(Lista[2]); //Mostrando un elemento de la lsita indicando su índice
            //Console.WriteLine(Lista[7]); //Intentando aaceder a un valor con un índice que se sale de su rango, hemos puesto un valor superior al count
            Console.WriteLine();
            //Foreach permite recorrer todo el arraylist
            //Foreach tipo_dato nom_variable in nom_array
            //Sort ordena los datos. Lista.Sort();
            Lista.Add(5);
            Lista.Add(6);
            Lista.Add(7);
            Lista.Add(8);
            for (int i = 0; i < Lista.Count; i++) //Recorrer el Array para imprimir
            {
                Console.WriteLine(Lista[i]);
            }
            Console.WriteLine("Los elementos  ordenador son: ");
            Lista.Sort(); //Con este metodo ordenamos la lista, y volvemos a imprimir la lista ordenada. 
            //Si no todos los datos son del mismo tipo, son dará error porque comparamos valores con un tipo de dato distinto
            for (int i = 0; i < Lista.Count; i++) //Recorrer el Array para imprimir
            {
                Console.WriteLine(Lista[i]);
            }

            //Lista.Insert(i, dato);
            //Con este métodos, metemos un elementos en la posición que indiquemos
            //Lista.Insert(2, 20);

            //Lista.Remove(dato); Elimina de la lista el que le pasamos como parametro
            Lista.Remove(2);
            Console.WriteLine();
            ImprimirLista(Lista);

            //Lista.RemoveAt(posicion); Elimina un elemento de una posición concreta
            ArrayList Lista02 = new ArrayList();
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(2);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            //for (int i = 0; i < Lista.Count; i++) //No podriamos borrar todos los 3 de la lista si la lista solo tiene 3
            //Lista02.Remove(3);
            Console.WriteLine();

            int Count = Lista02.Count;
            for (int i = 0; i < Count; i++) //Ahora sí daría, porque el count es constante
            {
                Lista02.Remove(3);
            }

            //Lista02.IndexOf(2); //Devuelve el índice del primer elemento coincidente que encuentra
            //Lista02.LastIndexOf(3); //Devuelve el último índice del valor coincidente

            //Lista02.Contains(2); //Bool que devuelve si el elemento está en la lista o no
            //Lista02.BinarySearch(2); //Devuelve la dirección donde se encuentra el dato, pero si no lo encuentra, devuelve -1
        }
        public static void TeoriaClase02()
        {
            //ImprimirMenu();


            char[] LetraDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            pedir:
            Console.WriteLine("Introduce el DNI: ");
            string DNI = Console.ReadLine();
            char letra = char.ToUpper(DNI[8]); //Sacamos asi letra de dni para hacer la verificacion

            string numero = DNI.Remove(8, 1); //Sacar los numeros del dni

            int j = 0;
            bool es_numero = int.TryParse(numero, out j); //comprobar que es un numero

            if (!LetraDNI.Contains(letra))//comprobar letra, si no, reinicia
            {
                Console.WriteLine("mensaje error");
                goto pedir;
            }
            else if (!es_numero) //comprueba que son numeros,si no, reinciia. Retrocede segun el valor booleano de es_numero
            {
                Console.WriteLine("error");
                goto pedir;
            }
            else if (DNI.Length != 9) //Comprobar que la longitud del dni introducido es el correcto
            {
                Console.WriteLine("Error");
                goto pedir;
            }



            int num = Convert.ToInt32(numero);//Pasamos el numero a int
            int pos = num % 23;
            if (LetraDNI[pos] != letra)
            {
                Console.WriteLine("Error");
                goto pedir;
            }
            else
            {
                DNI = numero + letra;
            }


        }
        public static void ImprimirMenu()
        {
            Console.WriteLine("1.- Introducir un nuevo préstamo.");
            Console.WriteLine("2.- Actualizar préstamo.");
            Console.WriteLine("3.- Cancelar préstamo.");
            Console.WriteLine("4.- Listar todos los préstamos.");
            Console.WriteLine("5.- Listar todos los préstamos según cantidad adeudada, amortizados y cancelados.");
        }
        public static void SumarAlArray(int[] Lista) //Funcion para comprobar que los tipos de datos compuestos se pasan por referencia automáticamente
        {
            Lista[0] += 2;
        }
        public static void PruebaSumarAlArray()
        {
            int[] numero = { 1, 2, 3, 4 };
            SumarAlArray(numero);
        }
        public static void ElegirOpcion()
        {
            Console.WriteLine("Elige una opción");
            string opcion = Console.ReadLine();
            int.TryParse(opcion, out int option_num);
            switch(option_num)
            {
                default:
                    break;
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
        public static bool ComprobarLetra(char[] LetraDNI, char letra)
        {
            if (!LetraDNI.Contains(letra))//comprobar letra, si no, reinicia
            {
                Console.WriteLine("mensaje error");
                return false;
            }
            else
                return true;
        }
        public static bool ComprobarNumero(string numero, out int num_int)
        {
            if (!int.TryParse(numero, out num_int)) //comprueba que son numeros,si no, reinciia. Retrocede segun el valor booleano de es_numero
            {
                Console.WriteLine("error");
                return false;
            }
            else
                return true;
        }
        public static bool ComprobarLongitudDNI(string DNI)
        {
            if (DNI.Length != 9) //Comprobar que la longitud del dni introducido es el correcto
            {
                Console.WriteLine("Error");
                return false;
            }
            else
                return true;
        }
        public static bool ValidarDNI(char[] LetraDNI, int numero_int, char letra)
        {
            int pos = numero_int % 23;
            if (LetraDNI[pos] != letra)
            {
                Console.WriteLine("Error");
                return false;

            }
            else
            {                
                Console.WriteLine("El DNI es correcto.");
                return true;
            }            
        }
        public static bool ComprobarDNI(string DNI)
        {
            char[] LetraDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            bool contiene_letra = true;
            bool es_numero = true; //comprobar que es un numero
            bool es_longitud = true;
            bool es_letradni = true;
            char letra = char.ToUpper(DNI[8]); //Sacamos asi letra de dni para hacer la verificacion
            string numero_string = DNI.Remove(8, 1); //Sacar los numeros del dni
            int numero_int = 1;

            contiene_letra = ComprobarLetra(LetraDNI, letra);
            if (contiene_letra)
                es_numero = ComprobarNumero(numero_string, out numero_int);
            if (es_numero)
                es_longitud = ComprobarLongitudDNI(DNI);
            if (es_longitud)
                es_letradni = ValidarDNI(LetraDNI, numero_int, letra);
            if (es_letradni)
                return true;
            else
                return false;
        }
        public static string LeerDNI()
        {
            string DNI;
            do
            {
                Console.WriteLine("Introduce el DNI: ");
                DNI = Console.ReadLine();
            } while (!ComprobarDNI(DNI));
            return DNI;
        }
        public static int Esta(List<int> Lista, int valor) //Repaso examen
        {
            int contador = 0;
            if (!Lista.Contains(valor))
                return contador; //No está
            else
            {
                while (Lista.Contains(valor))
                {
                    Lista.Remove(valor);
                    contador++;
                }
                return contador; //Está
            }
        }
        public static bool UnoListas(List<int> Lista, int valor, out int contador)
        {
            contador = 0;
            if (!Lista.Contains(valor))
                return false;            
            while (Lista.Contains(valor))
            {
                Lista.Remove(valor);
                contador++;
            }
            return true;                
        }
        public static int UnoListas(List<int> Lista, int valor)
        {
            int contador = 0;
            if (!Lista.Contains(valor))
                return contador;
            while (Lista.Contains(valor))
            {
                Lista.Remove(valor);
                contador++;
            }
            return contador;
        }
        public static int DosListas(List<int> Lista, int num_introducir, int num_sustiuir)
        {
            int contador = 0;
            while(Lista.Contains(num_sustiuir))
            {
                int index = Lista.IndexOf(num_sustiuir);
                Lista[index] = num_introducir;
                contador++;
            }
            return contador;
            
        }
        public static void TresListas(List<int> Lista01, List<int> Lista02)
        {
            Lista01.Sort();
            Lista02.Sort();
            List<int> Lista03 = new List<int>();            
       
            for (int i = 0; i < Lista01.Count; i++)
            {
                Lista03.Add(Lista01[i]);
            }
            for (int i = 0; i < Lista02.Count; i++)
            {                
                Lista03.Add(Lista02[i]);
            }
            Lista03.Sort();
        }
        public static int CuatroListas(ArrayList Lista)
        {
            int resultado = 0;
            string elemento;
            for (int i = 0; i < Lista.Count; i++)
            {
                elemento = Convert.ToString(Lista[i]);
                if (Int32.TryParse(elemento, out int valor))
                    resultado += valor;
            }
            return resultado;
        }
        public static int CincoListas(ArrayList Lista, int contador)
        {
            
            if (contador == Lista.Count)
                return 0;
            string elemento = Convert.ToString(Lista[contador]);
            if (Int32.TryParse(elemento, out int valor))

                return CincoListas(Lista, contador + 1);
            else
                return CincoListas(Lista, contador + 1);
        }
        public static void SeisListas(List<int> Lista)
        {            
            for (int i = Lista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(Lista[i]);
            }
        }
        public static void SieteListas(List<int> Lista)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i] % 2 == 0 && Lista[i] != 0)
                    Lista.RemoveAt(i);
            }
        }
        public static int NueveListas(List<int> Lista)
        {
            Lista.Sort();
            return Lista[(Lista.Count) - 1];
        }
        public static bool OchoListas(List<int> Lista01, List<int> Lista02)
        {
            if (Lista01.Count != Lista02.Count)
                return false;
            
            Lista01.Sort();
            Lista02.Sort();
            for (int i = 0; i < Lista01.Count; i++)
            {
                if (Lista01[i] != Lista02[i])
                    return false;
            }
            return true;            
        }
        public static string[] SieteListas(string mensaje)
        {
            string[] array = mensaje.Split(" ");
            return array;
        }
        static void Main(string[] args)
        {
            //LeerDNI();
            //int[] Array = new int[5];
            //Array[1] = 1;

            List<int> lista01 = new List<int>() {5, 2, 3, 4, 9, 0 };
            List<int> lista02 = new List<int>() { 5, 2, 3, 4, 9, 13, 14, 29, 33, 22 };

            //lista.Sort();
            //int a = lista[(lista.Count) - 1];

            //DosListas(lista, 88, 9);
            //TresListas(lista01, lista02);

            ArrayList ListaArray = new ArrayList() {1, 2, 'h', "ddewsew", "15", "3", '1'};
            //CuatroListas(ListaArray);
            //CincoListas(ListaArray, 0);
            //SeisListas(lista02);
            //SieteListas(lista01);
            //UnoListas(lista01, 24);
            //string frase = "Hola que tal, mi nombre es josemi y el juanfran es cabron";
            
            
            
        }
    }
}
