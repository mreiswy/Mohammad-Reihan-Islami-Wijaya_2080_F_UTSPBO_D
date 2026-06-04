using Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    class Program
    {
        static void Main(string[] args)
        {
            RiwayatPesanan riwayatSistem = new RiwayatPesanan();

            PaketHemat pesanan1 = new PaketHemat("Andi", "A-12", "Nasi Ayam Goreng", 2, 25000);
            pesanan1.tampilInfo();
            riwayatSistem.tambahPesanan("Paket Hemat", pesanan1.jumlahPorsi, "20-10-2023");

            PaketPrasmanan pesanan2 = new PaketPrasmanan("Budi", "VIP-1", "Buffet Seafood", 15, 75000, 150000);
            pesanan2.tampilInfo();
            riwayatSistem.tambahPesanan("Paket Prasmanan", pesanan2.jumlahPorsi, "20-10-2023");

            riwayatSistem.cetakRiwayat();
        }
    }
}