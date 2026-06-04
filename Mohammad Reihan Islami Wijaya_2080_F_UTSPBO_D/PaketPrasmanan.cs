using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    public class PaketPrasmanan : PesananMakanan
    {
        public int jumlahPorsi { get; set; }
        public double hargaPerPorsi { get; set; }
        public double biayaService { get; set; }

        public PaketPrasmanan(string nama, string meja, string menu, int porsi, double harga, double service)
            : base(nama, meja, menu)
        {
            this.jumlahPorsi = porsi;
            this.hargaPerPorsi = harga;
            this.biayaService = service;
        }

        public override double hitungTotalBill()
        {
            return (jumlahPorsi * hargaPerPorsi) + biayaService;
        }

        public override void tampilInfo()
        {
            Console.WriteLine($"Pemesan: {NamaPemesan} | Meja: {NomorMeja} | Menu: {MenuUtama}");
            Console.WriteLine($"Total Bill: Rp {hitungTotalBill()}");
        }
    }
}