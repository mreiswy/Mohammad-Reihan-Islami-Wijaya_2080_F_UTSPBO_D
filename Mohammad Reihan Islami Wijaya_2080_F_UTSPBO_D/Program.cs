namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Nama = "Rini";
            string Nomormeja = "M05";
            string MenuUtama = "Ayam Bakar";
            Console.WriteLine("Pemesan:" + Nama + " | " + "Meja:" + Nomormeja + " | " + "Menu:" + MenuUtama);
            Console.WriteLine("Total Bill: " + "Rp " + 19000);
            Console.WriteLine("1. Prasmanan | 5 Porsi | 22-05-2026");
        }
        public void pemesanan(PesananMakanan pesanan)
        {
            pesanan.tampilInfo();
            pesanan.hitungTotalBill();
        }
        public void riwayatPesanan(RiwayatPesanan riwayat)
        {
            riwayat.tampilInfo();
            riwayat.hitungTotalBill(); riwayat.hitungTotalBill();
        }

    }
}