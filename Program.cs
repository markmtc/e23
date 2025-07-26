


using e23;
using System.Data;


Helper.cargamapa();



byte[,] Tablero = new byte[32, 32];

for (int i = 0; i < 32; i++)
{
    for (int j = 0; j < 32; j++)
    {
        if (i + j < 15) 
            Tablero[i, j] = (byte)255;
        if (j - i > 16 && j-i > 0)
            Tablero[i, j] = (byte)255;

    }
}




Tablero = Tablero;