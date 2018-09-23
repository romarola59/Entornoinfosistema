using System;
using System.Diagnostics;

namespace Entornoinfosistema
{
    public class Program
    {
        public static void Main()
        {
            string avanceLinea = Environment.NewLine;
            Console.WriteLine("Directorio Actual;{0}", Environment.CurrentDirectory);
            Console.WriteLine("Nombre de la maquina: {0}",Environment.MachineName);
            Console.WriteLine("Nombre de usuario {0}", Environment.UserName);
            Console.WriteLine("Dominio {0}", Environment.UserDomainName);
            Console.WriteLine("Salida del codigo anterior: {0}", Environment.ExitCode);
            Console.WriteLine("Linea de comandos {0}", Environment.CommandLine);
            Console.WriteLine("version del SO:{0}", System.Convert.ToString(Environment.OSVersion));
            Console.WriteLine("version de . net: {0}", Environment.Version.ToString());
            string[] discos = Environment.GetLogicalDrives();
            Console.WriteLine("unidades logicas: {0}", String.Join(".", discos));
            Console.WriteLine("Carpeta de sistema {0}", Environment.GetFolderPath(Environment.SpecialFolder.System));
            Console.ReadKey();
            
        }
    }
}
