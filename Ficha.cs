using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace e23
{
    [StructLayout(LayoutKind.Explicit)]
    internal class Ficha
    {
        [FieldOffset(0)]
        public int Numero; 
        [FieldOffset(1)]
        public UInt32 posicion1;
        [FieldOffset(5)]
        public UInt32 posicion2;
        [FieldOffset(9)]
        public UInt32 posicion3;
        [FieldOffset(13)]
        public UInt32 posicion4;
        [FieldOffset(1)]
        public byte Pos1Arriba;
        [FieldOffset(2)]
        public byte Pos1Derecha;
        [FieldOffset(3)]
        public byte Pos1bajo;
        [FieldOffset(4)]
        public byte Pos1Izquierda;
        [FieldOffset(5)]
        public byte Pos2Arriba;
        [FieldOffset(6)]
        public byte Pos2Derecha;
        [FieldOffset(7)]
        public byte Pos2bajo;
        [FieldOffset(8)]
        public byte Pos2Izquierda;
        [FieldOffset(9)]
        public byte Pos3Arriba;
        [FieldOffset(10)]
        public byte Pos3Derecha;
        [FieldOffset(11)]
        public byte Pos3bajo;
        [FieldOffset(12)]
        public byte Pos3Izquierda;
        [FieldOffset(13)]
        public byte Pos4Arriba;
        [FieldOffset(14)]
        public byte Pos4Derecha;
        [FieldOffset(15)]
        public byte Pos4bajo;
        [FieldOffset(16)]
        public byte Pos4Izquierda;
    }
}
