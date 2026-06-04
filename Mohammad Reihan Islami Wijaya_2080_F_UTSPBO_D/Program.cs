using System;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    class Program
    {
        static void Main(string[] args)
        {
            RiwayatPesanan riwayatSistem = new RiwayatPesanan();

            PaketPrasmanan pesanan1 = new PaketPrasmanan("Rini", "M05", "Ayam Bakar", 5, 15000, 115000);
            pesanan1.tampilInfo();
            riwayatSistem.tambahPesanan("Prasmanan", pesanan1.jumlahPorsi, "13-10-2025");

            riwayatSistem.cetakRiwayat();
        }
    }
}