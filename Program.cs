using e23;
using System.Data;

Helper.cargamapa();

var Mapa = Helper.Mapa;
var fichas = Helper.Fichas;
UInt32[,] Tablero = new UInt32[16, 16];

for (int i = 0; i < 16; i++)
{
    for (int j = 0; j < 16; j++)
    {
        Tablero[i, j] = 0;
    }
}


 Mapa = Helper.Mapa;
 fichas = Helper.Fichas;
