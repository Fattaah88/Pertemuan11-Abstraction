using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_11
{
    public abstract class Hewan
    {
        public string NamaHewan { get; set; }
        public int JumlahKaki { get; set; }
        public abstract void Bersuara();
    }
}
