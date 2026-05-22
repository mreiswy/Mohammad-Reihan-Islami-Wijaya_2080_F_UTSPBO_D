using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    internal class PaketPrasmanan : PesananMakanan
    {
        public int hargaPerPorsi { get; set; }
        public decimal biayaService { get; set; }
    public override void tampilInfo()
        {
            base.tampilInfo();
            Console.WriteLine("Harga per Porsi: " + hargaPerPorsi);
            Console.WriteLine("Biaya Service: " + biayaService);
        }
        public override void hitungTotalBill()
        {
            decimal totalBill = jumlahPorsi * hargaPerPorsi + biayaService;
            Console.WriteLine("Total Bill: " + totalBill);
        }
    } 
}
