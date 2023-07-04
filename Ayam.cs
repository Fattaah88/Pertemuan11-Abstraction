using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_11
{
    public class Ayam : Hewan
    {
        public Ayam()
        {
            NamaHewan = "Ayam";
            JumlahKaki = 2;
        }

        public override void Bersuara()
        {
            Console.WriteLine("Ayam bersuara kukuruyuk");
        }
    }
}
