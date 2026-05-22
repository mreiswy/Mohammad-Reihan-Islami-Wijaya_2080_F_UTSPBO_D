namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
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