using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la ruta del archivo del tablero: ");
            string rutaArchivo = Console.ReadLine();

            string[] contenido = ImportTablero.LeerContenidoDesdeArchivo(rutaArchivo);

            Tablero tablero = new Tablero();
            bool[,] board = tablero.CrearTableroDesdeContenido(contenido);

            int width = board.GetLength(0);
            int height = board.GetLength(1);

            LogicaJuego logica = new LogicaJuego();
            PrintTablero print = new PrintTablero();

            while (true)
            {
                Console.Clear();
                PrintTablero.Imprimir(board);
                Thread.Sleep(300);
                board = logica.CalcularSiguienteGeneracion(board);
            }
        }
    }
}
