using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class ImportTablero
    {
        public static string[] LeerContenidoDesdeArchivo(string url)
        {
            return File.ReadAllLines(url);
        }
    }
}
