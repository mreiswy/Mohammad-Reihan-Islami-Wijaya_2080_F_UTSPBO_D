using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Mohammad_Reihan_Islami_Wijaya_2080_F_UTSPBO_D
{
    abstract class PesananMakanan
    {
        protected int jumlahPorsi { get; set; }

        private string namaPemesan { get; set; }
        private string nomorMeja { get; set; }
        private string menuUtama { get; set; }
        public void setPesanan(string namaPemesan, string nomorMeja, string menuUtama, int jumlahPorsi)
        {
            this.namaPemesan = namaPemesan;
            this.nomorMeja = nomorMeja;
            this.menuUtama = menuUtama;
            this.jumlahPorsi = jumlahPorsi;
        }
        public virtual void tampilInfo()
        {
                Console.WriteLine("Pemesan: " + namaPemesan);
                Console.WriteLine("Meja: " + nomorMeja);
                Console.WriteLine("Menu: " + menuUtama);
        }
    public abstract void hitungTotalBill();
        PaketHemat paketHemat = new PaketHemat();
        PaketPrasmanan paketPrasmanan = new PaketPrasmanan();
    }
}