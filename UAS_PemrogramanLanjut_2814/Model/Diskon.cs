using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UAS_PemrogramanLanjut_2814.Model
{
    public class Diskon
    {
        public string diskon { get; set; }
        public double potongan { get; set; }

        public Diskon(string diskon, double potongan)
        {
            this.diskon = diskon;
            this.potongan = potongan;  
        }

    }
}