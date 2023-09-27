using System;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool[,] CrearTableroDesdeContenido(string[] contenido)
        {
            int width = contenido[0].Length;
            int height = contenido.Length;
            bool[,] board = new bool[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (contenido[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }
            return board;
        }
    }
}
