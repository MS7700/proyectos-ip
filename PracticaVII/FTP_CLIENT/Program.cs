using System;
using System.Threading;

namespace FTP_CLIENT
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
            ftp cliente = new ftp(@$"ftp://{ip}/", usuario, password);
            Console.WriteLine("\nEstableciendo conexion con el servidor...");
            Thread.Sleep(2000);
            if (cliente.conectado())
            {
                Console.WriteLine("\nConexion establecida");
                while (x == 1)
                {
                    Console.WriteLine("\nSubiendo archivo...");
                    cliente.upload("prueba.txt", @"C:\Users\hanie\Desktop\prueba.txt");
                    Console.WriteLine("Presione Y para continuar.\n Presione enter para terminar la transferencia.");
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
