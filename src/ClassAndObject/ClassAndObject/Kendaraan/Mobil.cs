using System;

namespace ClassAndObject.Kendaraan
{
    public class Mobil
    {
        public string Merk { get; set; }
        public string Model { get; set; }
        public int TahunProduksi { get; set; }

        public Mobil(string merk, string model, int tahunproduksi)
        {
            Merk = merk;
            Model = model;
            TahunProduksi = tahunproduksi;
        }

        public void TampilkanSpesifikasi()
        {
            Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
        }
    }
}