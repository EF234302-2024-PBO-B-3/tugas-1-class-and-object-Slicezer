using System;

namespace ClassAndObject.TokoSepeda
{
    public class Sepeda
    {
        public string Merk { get; set; }
        public string Tipe { get; set; }
        public double Berat { get; set; }

        public Sepeda(string merk, string tipe, double berat)
        {
            Merk = merk;
            Tipe = tipe;
            Berat = berat;
        }

        public void TampilkanInformasi()
            {
             Console.WriteLine($"Merk: {Merk}, Tipe: {Tipe}, Berat: {Berat.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)} kg");
            }
    }
}