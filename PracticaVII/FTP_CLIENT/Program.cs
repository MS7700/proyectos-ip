using System;

namespace FTP_CLIENT
{
    class Program
    {
        static void Main(string[] args)
        {
            ftp cliente = new ftp(@"ftp://127.0.0.1/", "eduardo", "12345");
            cliente.upload("klk.txt", @"C:\Users\hanie\Desktop\klk.txt");
        }
    }
}
