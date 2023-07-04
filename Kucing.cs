using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_11
{
    public class Kucing : Hewan
    {
        public Kucing()
        {
            NamaHewan = "Kucing";
            JumlahKaki = 4;
        }

        public override void Bersuara()
        {
            Console.WriteLine("Kucing bersuara meoww");
        }
    }
}
