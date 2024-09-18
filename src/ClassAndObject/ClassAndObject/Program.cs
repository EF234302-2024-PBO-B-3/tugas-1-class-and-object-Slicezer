using System;
using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Buku buku = new Buku("Belajar C#", "John Doe", 2020);
            buku.TampilkanInfo();

            Mobil mobil = new Mobil("Toyota", "Fortuner", 2021);
            mobil.TampilkanSpesifikasi();

            Laptop laptop = new Laptop("ASUS", "ZenBook", 16, 512);
            laptop.TampilkanSpesifikasi();

            Sepeda sepeda = new Sepeda("Polygon", "Xtrada", 12.7);
            sepeda.TampilkanInformasi();

            Kalkulator kalkulator = new Kalkulator();

            double penjumlahan = kalkulator.Tambah(3.5, 3.47);
            double pengurangan = kalkulator.Kurang(3.5, 3.47);
            double perkalian = kalkulator.Kali(3.5, 3.47);
            double pembagian = kalkulator.Bagi(3.5, 3.47);

            Console.WriteLine("Hasil Penjumlahan: " + penjumlahan);
            Console.WriteLine("Hasil Pengurangan: " + pengurangan);
            Console.WriteLine("Hasil Perkalian: " + perkalian);
            Console.WriteLine("Hasil Pembagian: " + pembagian);

            try
            {
                double hasilBagiNol = kalkulator.Bagi(3.5, 0);
                Console.WriteLine("Hasil pembagian dengan nol: " + hasilBagiNol);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Kesalahan: " + e.Message);
            }
        }
    }
}