using System;
using System.Collections.Generic;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    public class PaketHemat : PesananMakanan
    {
        public int jumlahPorsi { get; set; }
        public double hargaPerPorsi { get; set; }

        public PaketHemat(string nama, string meja, string menu, int porsi, double harga): base(nama, meja, menu)
        {
            this.jumlahPorsi = porsi;
            this.hargaPerPorsi = harga;
        }
        public override double hitungTotalBill()
        {
            return jumlahPorsi * hargaPerPorsi;
        }
        public override void tampilInfo()
        {
            Console.WriteLine($"Pemesan: {NamaPemesan} | Meja: {NomorMeja} | Menu: {MenuUtama} ");
            Console.WriteLine($"Total Bill: Rp {hitungTotalBill()}");
        }
    }
}