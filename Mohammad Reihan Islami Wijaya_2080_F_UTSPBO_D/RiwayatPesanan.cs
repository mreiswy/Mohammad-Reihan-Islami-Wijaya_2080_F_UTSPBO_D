using System;
using System.Collections.Generic;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    internal class RiwayatPesanan : PesananMakanan
    {
        public string kategoriPaket { get; set; }
        public int jumlahPorsi { get; set; }
        public DateTime tanggalPesanan { get; set; } = DateTime.Now;
    public override void tampilInfo()
        {
            base.tampilInfo();
            Console.WriteLine("Kategori Paket: " + kategoriPaket);
            Console.WriteLine("Jumlah Porsi: " + jumlahPorsi);
            Console.WriteLine("Tanggal Pesanan: " + tanggalPesanan.ToString("dd/MM/yyyy"));
        }
    public override void hitungTotalBill()
        {
            int totalBill = 0;
            if (kategoriPaket == "Paket Hemat")
            {
                totalBill = jumlahPorsi * 50000;
            }
            else if (kategoriPaket == "Paket Prasmanan")
            {
                totalBill = jumlahPorsi * 75000 + 100000;
            }
            Console.WriteLine("Total Bill: " + totalBill);
        }
    }
}
