using System;
using System.Collections.Generic;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    public class RiwayatPesanan
    {
        private class DataRiwayat
        {
            public string KategoriPaket { get; set; }
            public int JumlahPorsi { get; set; }
            public string TanggalPesan { get; set; }
        }

        private List<DataRiwayat> daftarRiwayat = new List<DataRiwayat>();

        public void tambahPesanan(string kategori, int porsi, string tanggal)
        {
            daftarRiwayat.Add(new DataRiwayat
            {
                KategoriPaket = kategori,
                JumlahPorsi = porsi,
                TanggalPesan = tanggal
            });
        }

        public void cetakRiwayat()
        {
            int no = 1;
            foreach (var riwayat in daftarRiwayat)
            {
                Console.WriteLine($"{no}. {riwayat.KategoriPaket} | {riwayat.JumlahPorsi} porsi | {riwayat.TanggalPesan}");
                no++;
            }
        }
    }
}