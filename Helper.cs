using e23;

internal class Helper
{
    public static Dictionary<int, Ficha> Fichas { set; get; }
    public static Dictionary<uint, Ficha> Mapa { get; set; }
    internal static void cargamapa()
    {
        Fichas = new Dictionary<int, Ficha>();
        Mapa = new Dictionary<uint, Ficha>();
        var texto = File.ReadAllLines("fichas.txt");
        for (int i = 0; i < texto.Length; i++)
        {
            string? linea = texto[i];
            var partes = linea.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            UInt32 indice;
            var ficha = new Ficha { Numero = i + 1 };
            Fichas[i + 1] = ficha;

            indice = (UInt32.Parse(partes[0]) << 24) | (UInt32.Parse(partes[1]) << 16) | (UInt32.Parse(partes[2]) << 8) | UInt32.Parse(partes[3]);
            ficha.posicion1 = indice;
            Mapa[indice] = ficha;

            indice = UInt32.Parse(partes[1]) * 256 * 256 * 256 + UInt32.Parse(partes[2]) * 256 * 256 + UInt32.Parse(partes[3]) * 256 + UInt32.Parse(partes[0]);
            ficha.posicion2 = indice;
            Mapa[indice] = ficha;

            indice = UInt32.Parse(partes[2]) * 256 * 256 * 256 + UInt32.Parse(partes[3]) * 256 * 256 + UInt32.Parse(partes[0]) * 256 + UInt32.Parse(partes[1]);
            ficha.posicion3 = indice;
            Mapa[indice] = ficha;

            indice = UInt32.Parse(partes[3]) * 256 * 256 * 256 + UInt32.Parse(partes[0]) * 256 * 256 + UInt32.Parse(partes[1]) * 256 + UInt32.Parse(partes[2]);
            ficha.posicion4 = indice;
            Mapa[indice] = ficha;

        }
    }
}