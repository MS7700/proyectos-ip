using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practiva_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            string ip;
            string usuario;
            string password;

            //Ingresar credenciales del servidor.
            Console.WriteLine("Introduzca la IP del servidor:");
            ip = Console.ReadLine();
            Console.WriteLine("\nIntroduzca el nombre de usuario del servidor:");
            usuario = Console.ReadLine();
            Console.WriteLine("\nIntroduzca la contraseña del servidor:");
            password = Console.ReadLine();

            //Comprobar conexion y subir archivo
            ftp cliente = new ftp($@"ftp://{ip}/", usuario, password);
            Console.WriteLine("\nEstableciendo conexion con el servidor...");
            Thread.Sleep(2000);
            if (cliente.conectado())
            {
                Console.WriteLine("\nConexion establecida");
                while (x == 1)
                {
                    Console.WriteLine("\nSubiendo archivo...");
                    cliente.upload("haniel/prueba.txt", @"C:\Users\hanie\Desktop\prueba.txt");
                    Console.WriteLine("Presione Y para continuar.\nPresione enter para terminar la transferencia.");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        x--;
                        Console.WriteLine("Transferencia finalizada.");
                    }
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
