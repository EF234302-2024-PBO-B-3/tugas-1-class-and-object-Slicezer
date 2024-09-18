using System;

namespace ClassAndObject.TokoLaptop
{
    public class Laptop
    {
        public string Merk { get; set; }
        public string Prosesor { get; set; }
        public int RAM { get; set; }
        public int Penyimpanan { get; set; }

        public Laptop(string merk, string prosesor, int Ram, int penyimpanan)
        {
            Merk = merk;
            Prosesor = prosesor;
            RAM = Ram;
            Penyimpanan = penyimpanan;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {RAM} GB, Penyimpanan: {Penyimpanan} GB");
        }
    }
}