using System;

namespace ClassAndObject.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int TahunTerbit { get; set; }

        public Buku(string judul, string penulis, int tahunterbit)
        {
            Judul = judul;
            Penulis = penulis;
            TahunTerbit = tahunterbit;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
        }
    }
}