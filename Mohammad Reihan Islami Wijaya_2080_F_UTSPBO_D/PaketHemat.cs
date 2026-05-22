using System;
using System.Collections.Generic;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    internal class PaketHemat : PesananMakanan
    {
        public int hargaPerPorsi { get; set; }

        PaketHemat(string namaPemesan, string nomorMeja, string menuUtama, int hargaPerPorsi)
        {
            setPesanan(namaPemesan, nomorMeja, menuUtama, 1);
            this.hargaPerPorsi = hargaPerPorsi;
        }
        public override void tampilInfo()
        {
            base.tampilInfo();
            Console.WriteLine("Harga per Porsi: " + hargaPerPorsi);
        }
        public override void hitungTotalBill()
        {
            int totalBill = jumlahPorsi * hargaPerPorsi;
            Console.WriteLine("Total Bill: " + totalBill);
        }
    }

}
