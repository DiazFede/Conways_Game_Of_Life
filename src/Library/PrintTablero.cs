using System;
using System.IO;

namespace PII_Game_Of_Life
{
using System;
using System.Text;

public class PrintTablero
{
    public static void Imprimir(bool[,] board)
    {
        int width = board.GetLength(0);
        int height = board.GetLength(1);

        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (board[x, y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
    }
}
}
